namespace GardenGroupTicketSystem
{
    partial class TransferTicketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBox_TransferTicket_EmployeeId = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.MaximumSize = new System.Drawing.Size(500, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Please select the Id of the employee to whom the ticket will be transferred.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ticket Owner Id:";
            // 
            // cmbBox_TransferTicket_EmployeeId
            // 
            this.cmbBox_TransferTicket_EmployeeId.FormattingEnabled = true;
            this.cmbBox_TransferTicket_EmployeeId.Location = new System.Drawing.Point(12, 52);
            this.cmbBox_TransferTicket_EmployeeId.Name = "cmbBox_TransferTicket_EmployeeId";
            this.cmbBox_TransferTicket_EmployeeId.Size = new System.Drawing.Size(243, 28);
            this.cmbBox_TransferTicket_EmployeeId.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(346, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Transfer Ticket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TransferTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 226);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBox_TransferTicket_EmployeeId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "TransferTicketForm";
            this.Text = "TransferTicketForm";
            this.Load += new System.EventHandler(this.TransferTicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBox_TransferTicket_EmployeeId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}