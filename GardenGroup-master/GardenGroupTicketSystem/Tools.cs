using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace GardenGroupTicketSystem
{
    internal static class Tools
    {
        public static int IndexOfSelectedRadioButton(RadioButton button1, RadioButton button2, RadioButton button3, RadioButton button4) 
        {
            List<RadioButton> buttons = new List<RadioButton>();
            int index = -1;

            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);

            foreach (RadioButton radioButton in buttons)
            {
                if (radioButton.Checked)
                {
                    index = buttons.IndexOf(radioButton);
                }
            }
            return index;
        }
    }
}
