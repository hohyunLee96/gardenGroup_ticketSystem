﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace TicketSystemModels
{
    public class PasswordWithSaltHasher
    {
        //hashing password with length of salt as input
        public HashWithSaltResult HashWithSalt(string password, int saltLength, HashAlgorithm hashAlgo)
        {
            RNG rng = new RNG();          
            byte[] saltBytes = rng.GenerateRandomCryptographicBytes(saltLength);
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            return new HashWithSaltResult(Convert.ToBase64String(saltBytes), Convert.ToBase64String(digestBytes));
        }

        //hashing password with known salt as input
        public HashWithSaltResult HashWithKnownSalt(string password, string salt, HashAlgorithm hashAlgo)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            return new HashWithSaltResult(Convert.ToBase64String(saltBytes), Convert.ToBase64String(digestBytes));
        }

        //password validation
        public bool PasswordValidation(string enteredPassword, string hashedPassword, string salt)
        {
            HashWithSaltResult hashedEnteredPassword = HashWithKnownSalt(enteredPassword, salt, SHA256.Create());
            return (hashedEnteredPassword.Digest == hashedPassword);
        }
    }
}
