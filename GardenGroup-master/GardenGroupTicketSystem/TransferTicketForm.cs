using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TicketSystemServices;
using TicketSystemModels;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace GardenGroupTicketSystem
{
    public partial class TransferTicketForm : Form
    {
        UserService userService;
        TicketService ticketService;
        TicketSupportForm ticketSupportForm;
        Ticket ticket;
        List<User> users;

        public TransferTicketForm(Ticket ticket, TicketSupportForm ticketSupportForm)
        {
            userService = new UserService();
            ticketService = new TicketService();
            this.ticket = ticket;
            this.ticketSupportForm = ticketSupportForm;
            InitializeComponent();
            Start();
        }
        private void Start() 
        {
            users = userService.GetAllUsers();

            foreach (User user in users) 
            {
                cmbBox_TransferTicket_EmployeeId.Items.Add(BsonSerializer.Deserialize<Name>(user.Name).First);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int employeeId = cmbBox_TransferTicket_EmployeeId.SelectedIndex;

            ticketService.UpdateTicketEmployee(ticket, users[cmbBox_TransferTicket_EmployeeId.SelectedIndex].UserId);
            ticketSupportForm.DisplayTickets();
        }

        private void TransferTicketForm_Load(object sender, EventArgs e)
        {

        }
    }
}
