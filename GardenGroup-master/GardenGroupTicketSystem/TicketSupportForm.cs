using MongoDB.Bson;
using System;
using System.Drawing;
using TicketSystemServices;
using System.Windows.Forms;
using TicketSystemModels;
using System.Security.Cryptography;
using System.Collections.Generic;
using Color = System.Drawing.Color;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Linq;

namespace GardenGroupTicketSystem
{
    public partial class TicketSupportForm : Form
    {
        //Service layer
        TicketService ticketService;
        ReportService reportService;
        UserService userService;

        //Global variables
        User currentUser;
        Ticket selectedTicket;
        Report selectedReport;
        TicketViewType viewType;
        ListView OriginalDataListView = new ListView();

        #region Form
        public TicketSupportForm(User loggedInUser)
        {
            //Store logged in user
            currentUser = loggedInUser;

            //Instantiate services
            ticketService = new TicketService();
            reportService = new ReportService();
            userService = new UserService();

            //Initialise the form

            InitializeComponent();
        }

        private void TicketSupportForm_Load(object sender, EventArgs e)
        {
            //Hide tabcontrol for the user
            

            //Load dashboard based on usertype
            if (currentUser.UserType == (int)UserType.RegularUser)
            { 
                tabControl.SelectedTab = tabUserDashboard;
                tabControl.Controls.Remove(tabCreateUser);
                tabControl.Controls.Remove(tabCreateTicket);
                tabControl.Controls.Remove(tabServiceDashboard);
            }
            else
            {
                tabControl.SelectedTab = tabServiceDashboard;
                tabControl.Appearance = TabAppearance.FlatButtons;
                tabControl.ItemSize = new Size(0, 1);
                tabControl.SizeMode = TabSizeMode.Fixed;
            }
        }
        #endregion

        #region Navigation

        #endregion

        #region Create User
        //CREATE USER
        //====================================================================================================================================================
        private void btn_ServiceD_CreateUser_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabCreateUser;
        }

        private void NewUser(User user)
        {
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();

            user.UserId = new ObjectId();
            user.Email = Login_txt_email.Text;
            user.UserName = Login_txt_userName.Text;
            Name name = new Name();
            name.First = Login_txt_firstName.Text;
            name.Second = Login_txt_lastName.Text;
            BsonDocument nameDocument = name.ToBsonDocument();
            user.Name = nameDocument;
            int n = Login_cb_userType.SelectedIndex;
            user.UserType = (UserType)n;

            user.PhoneNumber = Login_txt_phoneNumber.Text;
            user.Location = Login_cb_location.Text;

            Password password = new Password();
            HashWithSaltResult hashPassword = pwHasher.HashWithSalt(Login_txt_password.Text, 64, SHA256.Create());
            password.Salt = hashPassword.Salt;
            password.HashedPassword = hashPassword.Digest;
            user.Password = password.ToBsonDocument();
        }
        private void Login_btn_createUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (userService.ValidateUserName(Login_txt_userName.Text))
                {
                    if (CheckUserInput)
                    {
                        User user = new User();
                        NewUser(user);
                        userService.InsertUser(userService.CreateUsertoDatabase(user.Email, user.UserName, user.Name, user.Password, user.UserType, user.PhoneNumber, user.Location));

                        CleanTextFieldForCreateUser();
                        MessageBox.Show("User is successfully registerd to the Database!");
                        userService.SendConfirmationEmail(user.Email, user.UserName);
                    }
                }
                else
                {
                    MessageBox.Show("The username is already registered to the database\nplease choose another username");
                }

            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Please write right form of email address");
            }
        }
        private void CleanTextFieldForCreateUser()
        {
            Login_txt_email.Clear();
            Login_txt_userName.Clear();
            Login_txt_firstName.Clear();
            Login_txt_lastName.Clear();
            Login_txt_password.Clear();
            Login_txt_confirmPassword.Clear();
            Login_txt_phoneNumber.Clear();
        }
        private bool CheckUserInput
        {
            get
            {
                if (Login_txt_email.Text == "")
                {
                    MessageBox.Show("Please fill out email");
                    return false;
                }
                else if (Login_txt_userName.Text == "")
                {
                    MessageBox.Show("Please fill out username");
                    return false;
                }
                else if (Login_txt_firstName.Text == "")
                {
                    MessageBox.Show("Please fill out first name");
                    return false;
                }
                else if (Login_txt_lastName.Text == "")
                {
                    MessageBox.Show("Please fill out last name");
                    return false;
                }
                else if (Login_txt_password.Text == "")
                {
                    MessageBox.Show("Please fill out password");
                    return false;
                }
                else if (Login_txt_confirmPassword.Text == "")
                {
                    MessageBox.Show("Please fill out confirm password");
                    return false;
                }
                else if (Login_txt_phoneNumber.Text == "")
                {
                    MessageBox.Show("Please fill out phone number");
                    return false;
                }
                else if (Login_cb_location.Text == "")
                {
                    MessageBox.Show("Please choose the location");
                    return false;
                }
                else if (Login_cb_userType.Text == "")
                {
                    MessageBox.Show("Please choose the usertype");
                    return false;
                }
                else if (Login_txt_password.Text != Login_txt_confirmPassword.Text)
                {
                    MessageBox.Show("Please check password and confirm password. They are not same");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        private void lblCreatUserBack_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabServiceDashboard;
            CleanTextFieldForCreateUser();
        }
        #endregion

        #region Regular User Dashboard + analytics
        //REGULAR USER DASHBOARD
        //====================================================================================================================================================
        private void LoadUserDashboard()
        {
            dashboardTicketsRadioBtn.Checked = false;
            dashboardTicketsRadioBtn.Checked = true;
        }
        private void dashboardTicketsRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dashboardTicketsRadioBtn.Checked)
            {
                userDashboardListView.Items.Clear();
                dashboardDeadline.Text = "Deadline";
                dashboardStatus.Text = "Status";
                dashboardPriority.Text = "Priority";
                dashboardPriority.Width = 100;
                List<Ticket> Tickets = ticketService.GetAllTickets();
                Tickets.RemoveAll(t => t.UserId != currentUser.UserId);
                foreach (Ticket ticket in Tickets)
                {
                    ListViewItem item = new ListViewItem(ticket.TicketOpenDate.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(ticket.TicketStatus.ToString());
                    switch (ticket.TicketPriority)
                    {
                        case 1:
                            item.SubItems.Add("Low");
                            break;
                        case 2:
                            item.SubItems.Add("Medium");
                            break;
                        case 3:
                            item.SubItems.Add("High");
                            break;
                        case 4:
                            item.SubItems.Add("Critical");
                            break;
                        default:
                            item.SubItems.Add("N/A");
                            break;
                    }
                    item.SubItems.Add(ticket.TicketSubject);
                    item.SubItems.Add(ticket.TicketDescription);
                    item.SubItems.Add(ticket.TimeOfOccurance.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(ticket.TicketLocation);
                    item.SubItems.Add(ticket.Deadline.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(ticket.Department);
                    if (ticket.TicketStatus == TicketStatus.Closed)
                    {
                        item.BackColor = Color.Red;
                        item.ForeColor = Color.White;
                    }  
                    userDashboardListView.Items.Add(item);
                }
            }
        }

        private void dashboardReportsRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dashboardReportsRadioBtn.Checked)
            {
                userDashboardListView.Items.Clear();
                dashboardDeadline.Text = "Incident duration";
                dashboardStatus.Text = "Category";
                dashboardPriority.Text = "";
                dashboardPriority.Width = 0;
                List<Report> Reports = reportService.GetAllReports();
                Reports.RemoveAll(r => r.UserId != currentUser.UserId);
                foreach (Report report in Reports)
                {
                    ListViewItem item = new ListViewItem(report.ReportCreationDate.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(report.Category.ToString());
                    item.SubItems.Add("");
                    item.SubItems.Add(report.Subject);
                    item.SubItems.Add(report.ReportDescription);
                    item.SubItems.Add(report.IncidentDate.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(report.IncidentLocation);
                    string dayOrDays = report.IncidentDuration < 2 ? " day" : " days";
                    item.SubItems.Add(report.IncidentDuration.ToString() + dayOrDays);
                    item.SubItems.Add(report.Department);
                    userDashboardListView.Items.Add(item);
                }
            }
        }
        private void LoadAnalyticsDashboard()
        {
            
            analyticsDashboardListView.Items.Clear();
            List<Ticket> Tickets = ticketService.GetAllTickets().OrderBy(t => t.TicketOpenDate).ToList(); 
            foreach (Ticket ticket in Tickets)
            {
                ListViewItem item = new ListViewItem(ticket.TicketOpenDate.ToString("dd/MM/yyyy"));
                item.SubItems.Add(ticket.TicketStatus.ToString());
                item.SubItems.Add(ticket.TicketPriority.ToString());
                item.SubItems.Add(userService.GetUserNameByID(ticket.UserId).ToString());
                item.SubItems.Add(ticket.TicketSubject);
                item.SubItems.Add(ticket.TicketDescription);
                item.SubItems.Add(ticket.TicketLocation);
                item.SubItems.Add(ticket.Department);
                item.SubItems.Add(ticket.Deadline.ToString("dd/MM/yyyy"));
                OriginalDataListView.Items.Add(item);
            }
            UpdateListView();
            int percentResolved = (int)Math.Round((double)(100 * (Tickets.Count(t => t.TicketStatus == TicketStatus.Closed)) / Tickets.Count));
            int percentOpen = (int)Math.Round((double)(100 * (Tickets.Count(t => t.TicketStatus == TicketStatus.Open)) / Tickets.Count));
            int percentEscalated = (int)Math.Round((double)(100 * (Tickets.Count(t => t.TicketStatus == TicketStatus.Escalated)) / Tickets.Count));
            analyticsPercentResolved.Text = percentResolved + "%";
            analyticsPercentOpen.Text = percentOpen + "%";
            analyticsPercentEscalated.Text = percentEscalated + "%";
        }

        public void UpdateListView()
        {
            analyticsDashboardListView.Items.Clear();
            foreach (ListViewItem item in OriginalDataListView.Items)
            {
                analyticsDashboardListView.Items.Add((ListViewItem)item.Clone());
            }
        }
        private void searchAnalyticsTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateListView();
           
                foreach (ListViewItem listItem in analyticsDashboardListView.Items)
                {
                    if (!listItem.SubItems[4].Text.ToLower().Contains(searchAnalyticsTextBox.Text.ToLower()) && !listItem.SubItems[5].Text.ToLower().Contains(searchAnalyticsTextBox.Text.ToLower()))
                    {
                        analyticsDashboardListView.Items.Remove(listItem);
                    }
                }
            
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabUserDashboard)
                LoadUserDashboard();
            else if (tabControl.SelectedTab == tabServiceDashboard)
                LoadServiceDashboard();
            else if (tabControl.SelectedTab == tabAnalytics)
            {
                searchAnalyticsTextBox.Text = "";
                LoadAnalyticsDashboard();
            }
               
        }
        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabCreateReport;
        }
        #endregion

        #region Servicedesk Dashboard

        //SERVICE DASHBOARD TAB 
        //====================================================================================================================================================

        private void LoadServiceDashboard()
        {
            
            //Manager shouldn't see escalation button
            if (currentUser.UserType == UserType.Manager) 
            {
                btn_ServiceD_EscalateTicket.Size = new Size(0, 1);
            }

            //Load data into service dashboard
            DisplayTickets();
            DisplayReports();
        }

        public void DisplayTickets()
        {
            try
            {
                listview_ServiceD_Tickets.Items.Clear();
                List<Ticket> tickets = ticketService.GetAllTickets();
                if (tickets.Count <= 0)
                {
                    return;
                }

                //Based on which user, either open or escalated tickets are shown
                TicketStatus statusToShow;
                if (currentUser.UserType == UserType.ServiceDeskEmployee)
                    statusToShow = TicketStatus.Open;
                else if (currentUser.UserType == UserType.Manager)
                    statusToShow = TicketStatus.Escalated;
                else
                {
                    MessageBox.Show("Unauthorised user detected!");
                    Application.Exit();
                    //Needs a return, otherwise throws error that statusToShow is undefined
                    return;
                }

                //Load tickets filtered with the user-defined ticket status  
                foreach (Ticket ticket in tickets)
                {
                    if (ticket.TicketStatus == statusToShow || ticket.TicketStatus == TicketStatus.Closed)
                    {
                        ListViewItem lvItem = new ListViewItem(ticket.TicketStatus.ToString());
                        lvItem.SubItems.Add(ticket.TicketSubject.ToString());
                        lvItem.SubItems.Add(userService.GetUserNameByID(ticket.UserId).ToString());
                        lvItem.SubItems.Add(ticket.TicketOpenDate.ToString("dd//MM//yyyy"));
                        if (ticket.TicketPriority == 1)
                        {
                            lvItem.SubItems.Add("Low");
                        }
                        else if (ticket.TicketPriority == 2)
                        {
                            lvItem.SubItems.Add("Medium");
                        }
                        else if (ticket.TicketPriority == 3)
                        {
                            lvItem.SubItems.Add("High");
                        }
                        else if (ticket.TicketPriority == 4)
                        {
                            lvItem.SubItems.Add("Critical");
                            //lvItem.BackColor = Color.Red;
                        }
                        lvItem.SubItems.Add(ticket.TicketPriority.ToString());
                        listview_ServiceD_Tickets.Items.Add(lvItem);
                        lvItem.Tag = ticket;
                        ChangeColorOfRows(listview_ServiceD_Tickets, lvItem);
                    }
                    lbl_ServiceD_Ticket_Count.Text = $"Ticket Count: {listview_ServiceD_Tickets.Items.Count}";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void DisplayReports()
        {
            try
            {
                listview_ServiceD_Reports.Items.Clear();
                List<Report> reports = reportService.GetAllReports();
                if (reports.Count <= 0)
                {
                    return;
                }

                lbl_ServiceD_Report_Count.Text = $"Report Count: {reports.Count}";

                foreach (Report report in reports)
                {
                    ListViewItem lvItem = new ListViewItem(report.Subject);
                    lvItem.SubItems.Add(userService.GetUserNameByID(report.UserId).ToString());
                    lvItem.SubItems.Add(report.ReportCreationDate.ToString("dd//MM//yyyy"));
                    lvItem.SubItems.Add(report.Department);
                    listview_ServiceD_Reports.Items.Add(lvItem);
                    lvItem.Tag = report;

                    ChangeColorOfRows(listview_ServiceD_Reports, lvItem);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void ChangeColorOfRows(ListView listview, ListViewItem lvItem)
        {
            if (listview.Items.IndexOf(lvItem) % 2 == 0)
            {
                lvItem.BackColor = Color.FromArgb(224, 234, 255);
            }
        }

        private void btn_ServiceD_CreateTicketFromReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (listview_ServiceD_Reports.SelectedItems.Count == 0)
                    throw new Exception("No report selected!");
                
                //Fetching the selected report
                selectedReport = reportService.GetAllReports()[listview_ServiceD_Reports.SelectedIndices[0]];

                //Switch to create ticket tab
                viewType = TicketViewType.CreateTicketView;
                LoadViewTicketTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ServiceD_CreateBlankTicket_Click(object sender, EventArgs e)
        {
            //Clear the form
            cmbBox_CreateTicket_Category.SelectedItem = default;
            cmbBox_CreateTicket_Department.SelectedItem = default;
            dateTimePicker_CreateTicket_TimeOfOccurance.Value = DateTime.Now;
            richTextBox_CreateTicket_IncidentDescription.Text = "";
            txtBox_CreateTicket_IncidentLocation.Text = "";
            textBox_CreateTicket_IncidentDuration.Text = "";
            txtBox_CreateTicket_Subject.Text = "";

            //Switch to create ticket tab with no report data
            viewType = TicketViewType.CreateTicketView;
            LoadViewTicketTab();
        }

        private void btn_ServiceD_deleteTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (listview_ServiceD_Tickets.SelectedItems.Count == 0)
                {
                    throw new Exception("Ticket is not selected!");
                }
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this ticket?", "Delete Ticket", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Ticket ticket = (Ticket)listview_ServiceD_Tickets.SelectedItems[0].Tag;
                    ticketService.DeleteOneDocumentFromTicketDatabase(ticket);
                    listview_ServiceD_Tickets.Items.Remove(listview_ServiceD_Tickets.SelectedItems[0]);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btn_ServiceD_CloseTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (listview_ServiceD_Tickets.SelectedItems.Count == 0)
                {
                    throw new Exception("Ticket is not selected!");
                }
                
                Ticket ticket = (Ticket)listview_ServiceD_Tickets.SelectedItems[0].Tag;

                if (ticket.TicketStatus == TicketStatus.Closed)
                {
                    return;
                }

                ticketService.UpdateTicketStatus(ticket, TicketStatus.Closed);
                DisplayTickets();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btn_ServiceD_UpdateTicket_Click(object sender, EventArgs e)
        {
            try
            {
                //Exception if no ticket is selected
                if (listview_ServiceD_Tickets.SelectedItems.Count == 0)
                    throw new Exception("No ticket selected.");

                selectedTicket = (Ticket)listview_ServiceD_Tickets.SelectedItems[0].Tag;

                //Exception if selected ticket is already closed
                if (selectedTicket.TicketStatus == TicketStatus.Closed)
                {
                    selectedTicket = null;
                    throw new Exception("Closed tickets cannot be updated.");
                }

                viewType = TicketViewType.UpdateTicketView;
                LoadViewTicketTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ServiceD_EscalateTicket_Click(object sender, EventArgs e)
        {
            try
            {
                //Exception if no ticket is selected
                if (listview_ServiceD_Tickets.SelectedItems.Count == 0)
                    throw new Exception("No ticket selected.");

                Ticket ticket = (Ticket)listview_ServiceD_Tickets.SelectedItems[0].Tag;

                //Exception if selected ticket is already closed or escalated
                if (ticket.TicketStatus == TicketStatus.Closed || ticket.TicketStatus == TicketStatus.Escalated)
                    throw new Exception("Closed tickets cannot be escalated.");

                //Confirmation from user
                DialogResult confirmation = MessageBox.Show("Are you sure you want to escalate this ticket to management?", "Confirm Escalation", MessageBoxButtons.YesNo);

                if (confirmation == DialogResult.Yes)
                    ticketService.UpdateTicketStatus(ticket, TicketStatus.Escalated);
                
                DisplayTickets();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ServiceD_archivedTickets_Click(object sender, EventArgs e)
        {
            try
            {
                ticketService.AddClosedTicketToArchiveCollection();
                LoadServiceDashboard();
                MessageBox.Show("Tickets older than 2 years are archived");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btn_ServiceD_TransferTicket_Click(object sender, EventArgs e)
        {
            TransferTicketForm transferTicketForm = new TransferTicketForm(ticketService.GetByDescription(listview_ServiceD_Tickets.SelectedItems[0].SubItems[3].Text), this);
            transferTicketForm.ShowDialog();
        }

        
        #endregion

        #region Create / Update Ticket 

        //CREATE / UPDATE TICKET TAB
        //====================================================================================================================================================

        private void LoadViewTicketTab()
        {
            tabControl.SelectedTab = tabCreateTicket;

            if (selectedTicket == null && selectedReport == null)//There is no ticket or report to load data from
            {
                //Load UI elements
                lbl_CreateTicket_Title.Text = "Create Ticket";
                btn_CreateTicket_CreateTicket.Text = "Create Ticket";

                //Clear all
                dateTimePicker_CreateTicket_TimeOfOccurance.Value = DateTime.Now;
                cmbBox_CreateTicket_Department.SelectedIndex = default;
                txtBox_CreateTicket_IncidentLocation.Text = "";
                textBox_CreateTicket_IncidentDuration.Text = "";
                txtBox_CreateTicket_Subject.Text = "";
                richTextBox_CreateTicket_IncidentDescription.Text = "";
            }
            else if (selectedTicket != null && selectedReport == null)//There is a selected ticket to load data from
            {
                //Load UI elements
                lbl_CreateTicket_Title.Text = "Update Ticket";
                btn_CreateTicket_CreateTicket.Text = "Update Ticket";

                //Load ticket data into UI
                dateTimePicker_CreateTicket_TimeOfOccurance.Value = selectedTicket.TimeOfOccurance;
                txtBox_CreateTicket_IncidentLocation.Text = selectedTicket.TicketLocation;
                cmbBox_CreateTicket_Department.SelectedIndex = GetDepartmentIndex(selectedTicket.Department.ToLower());
                textBox_CreateTicket_IncidentDuration.Text = selectedTicket.IncidentDuration.ToString();
                txtBox_CreateTicket_Subject.Text = selectedTicket.TicketSubject;
                richTextBox_CreateTicket_IncidentDescription.Text = selectedTicket.TicketDescription;
                cmbBox_CreateTicket_IncidentPriority.SelectedIndex = (selectedTicket.TicketPriority - 1);
            }
            else if (selectedReport != null && selectedTicket == null) //There is a selected report to load data from
            {
                //Load UI elements
                lbl_CreateTicket_Title.Text = "Create Ticket";
                btn_CreateTicket_CreateTicket.Text = "Create Ticket";

                //Load report data into create ticket tab UI
                cmbBox_CreateTicket_Category.SelectedIndex = (int)selectedReport.Category;
                dateTimePicker_CreateTicket_TimeOfOccurance.Value = selectedReport.IncidentDate;
                txtBox_CreateTicket_IncidentLocation.Text = selectedReport.IncidentLocation;
                cmbBox_CreateTicket_Department.SelectedIndex = GetDepartmentIndex(selectedReport.Department.ToLower());
                textBox_CreateTicket_IncidentDuration.Text = selectedReport.IncidentDuration.ToString();
                txtBox_CreateTicket_Subject.Text = selectedReport.Subject;
                richTextBox_CreateTicket_IncidentDescription.Text = selectedReport.ReportDescription;
            }
            else //If both selectedReport and selectedTicket are not null, something went wrong and the objects will be nullified.
            {
                selectedReport = null;
                selectedTicket = null;
                MessageBox.Show("There has been an error. You will be redirected to the Service Desk Dashboard.");
                tabControl.SelectedTab = tabServiceDashboard;
            }
        }

        private int GetDepartmentIndex(string department)
        {
            int departmentIndex = 0;

            switch (department.ToLower())
            {
                case "management":
                    departmentIndex = 0;
                    break;
                case "marketing":
                    departmentIndex = 1;
                    break;
                case "operations":
                    departmentIndex = 2;
                    break;
                case "finance":
                    departmentIndex = 3;
                    break;
                case "sales":
                    departmentIndex = 4;
                    break;
                case "hr":
                    departmentIndex = 5;
                    break;
            }
            return departmentIndex;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbBox_CreateTicket_Category.Text))
            {
                lbl_CreateTicket_IncidentCategory.Text = "Incident Category";
                lbl_CreateTicket_IncidentCategory.ForeColor = Color.Black;
            }
        }
        private void SelectPriority()
        {
            int impact = Tools.IndexOfSelectedRadioButton(radioBtn_CreateTicket_ImpactLow, radioBtn_CreateTicket_ImpactMedium, radioBtn_CreateTicket_ImpactHigh, radioBtn_CreateTicket_ImpactCrit) + 1;
            int urgency = Tools.IndexOfSelectedRadioButton(radioBtn_CreateTicket_UrgencyLow, radioBtn_CreateTicket_UrgencyMedium, radioBtn_CreateTicket_UrgencyHigh, radioBtn_CreateTicket_UrgencyCrit) + 1;
            int priority = 0;

            if (impact != 0 && urgency != 0)
            {
                switch (impact + urgency)
                {
                    case 2:
                        priority = 1;
                        break;
                    case 3:
                        priority = 1;
                        break;
                    case 4:
                        priority = 2;
                        break;
                    case 5:
                        priority = 2;
                        break;
                    case 6:
                        priority = 3;
                        break;
                    case 7:
                        priority = 4;
                        break;
                    case 8:
                        priority = 4;
                        break;
                }
            }
            cmbBox_CreateTicket_IncidentPriority.SelectedIndex = priority - 1;
        }

        private void radioBtn_CreateTicket_UrgencyLow_CheckedChanged(object sender, EventArgs e)
        {
            SelectPriority();
            lbl_CreateTicket_IncidentUrgency.Text = "Incident Urgency";
            lbl_CreateTicket_IncidentUrgency.ForeColor = Color.Black;
        }

        private void radioBtn_CreateTicket_UrgencyMedium_CheckedChanged(object sender, EventArgs e)
        {
            SelectPriority();
            lbl_CreateTicket_IncidentUrgency.Text = "Incident Urgency";
            lbl_CreateTicket_IncidentUrgency.ForeColor = Color.Black;
        }

        private void radioBtn_CreateTicket_UrgencyHigh_CheckedChanged(object sender, EventArgs e)
        {
            SelectPriority();
            lbl_CreateTicket_IncidentUrgency.Text = "Incident Urgency";
            lbl_CreateTicket_IncidentUrgency.ForeColor = Color.Black;
        }

        private void radioBtn_CreateTicket_UrgencyCrit_CheckedChanged(object sender, EventArgs e)
        {
            SelectPriority();
            lbl_CreateTicket_IncidentUrgency.Text = "Incident Urgency";
            lbl_CreateTicket_IncidentUrgency.ForeColor = Color.Black;
        }

        private void radioBtn_CreateTicket_ImpactLow_CheckedChanged(object sender, EventArgs e)
        {
            SelectPriority();
            lbl_CreateTicket_IncidentImpact.Text = "Incident Impact";
            lbl_CreateTicket_IncidentImpact.ForeColor = Color.Black;
        }

        private void radioBtn_CreateTicket_ImpactMedium_CheckedChanged(object sender, EventArgs e)
        {
            SelectPriority();
            lbl_CreateTicket_IncidentImpact.Text = "Incident Impact";
            lbl_CreateTicket_IncidentImpact.ForeColor = Color.Black;
        }

        private void radioBtn_CreateTicket_ImpactHigh_CheckedChanged(object sender, EventArgs e)
        {
            SelectPriority();
            lbl_CreateTicket_IncidentImpact.Text = "Incident Impact";
            lbl_CreateTicket_IncidentImpact.ForeColor = Color.Black;
        }

        private void radioBtn_CreateTicket_ImpactCrit_CheckedChanged(object sender, EventArgs e)
        {
            SelectPriority();
            lbl_CreateTicket_IncidentImpact.Text = "Incident Impact";
            lbl_CreateTicket_IncidentImpact.ForeColor = Color.Black;
        }

        private void btn_CreateTicket_CreateTicket_Click(object sender, EventArgs e)
        {
            if (validateCreateTicketForm()) 
            {
                if (viewType == TicketViewType.CreateTicketView)
                {
                    ticketService.InsertTicket(new Ticket(currentUser.UserId, DateTime.Now, DateTime.Now, richTextBox_CreateTicket_IncidentDescription.Text, TicketStatus.Open, txtBox_CreateTicket_Subject.Text, txtBox_CreateTicket_IncidentLocation.Text, int.Parse(textBox_CreateTicket_IncidentDuration.Text), cmbBox_CreateTicket_IncidentPriority.SelectedIndex + 1, cmbBox_CreateTicket_Department.Text, dtp_CreateTicket_IncidentDeadline.Value.Date, dateTimePicker_CreateTicket_TimeOfOccurance.Value.Date));
                    if (selectedReport != null) 
                    {
                        reportService.DeleteReport(selectedReport);
                    }
                }
                else if (viewType == TicketViewType.UpdateTicketView)
                {
                    //Update the selected ticket with new info fetched from UI
                    selectedTicket.TicketSubject = txtBox_CreateTicket_Subject.Text;
                    selectedTicket.TicketDescription = richTextBox_CreateTicket_IncidentDescription.Text;
                    selectedTicket.Department = cmbBox_CreateTicket_Department.Text;
                    selectedTicket.TicketLocation = txtBox_CreateTicket_IncidentLocation.Text;
                    selectedTicket.IncidentDuration = int.Parse(textBox_CreateTicket_IncidentDuration.Text);
                    selectedTicket.TicketPriority = cmbBox_CreateTicket_IncidentPriority.SelectedIndex + 1;
                    selectedTicket.Deadline = dtp_CreateTicket_IncidentDeadline.Value.Date;
                    selectedTicket.TimeOfOccurance = dateTimePicker_CreateTicket_TimeOfOccurance.Value.Date;

                    ticketService.UpdateTicketInformation(selectedTicket);
                }

                //Nullify global variables after they are no longer needed
                selectedTicket = null;
                selectedReport = null;

                //Back to service dashboard tab
                LoadServiceDashboard();
            }
        }
        public bool validateCreateTicketForm()
        {
            int errorCount = 0;

            if (string.IsNullOrEmpty(richTextBox_CreateTicket_IncidentDescription.Text) || string.IsNullOrWhiteSpace(richTextBox_CreateTicket_IncidentDescription.Text) || richTextBox_CreateTicket_IncidentDescription.Text.Length < 50)
            {
                lbl_CreateTicket_IncidentDescription.ForeColor = Color.Red;
                lbl_CreateTicket_IncidentDescription.Text = "Incident Description*";
                lbl_CreateTicket_DescriptionWarning.ForeColor = Color.Red;
                lbl_CreateTicket_DescriptionWarning.Text = "Please make sure the description is at least 50 characters long*";
                errorCount++;
            }
            if (string.IsNullOrEmpty(txtBox_CreateTicket_IncidentLocation.Text) || string.IsNullOrWhiteSpace(txtBox_CreateTicket_IncidentLocation.Text))
            {
                lbl_CreateTicket_IncidentLocation.ForeColor = Color.Red;
                lbl_CreateTicket_IncidentLocation.Text = "Incident Location*";
                errorCount++;
            }
            if (!textBox_CreateTicket_IncidentDuration.Text.All(x => char.IsDigit(x)) || string.IsNullOrEmpty(textBox_CreateTicket_IncidentDuration.Text) || string.IsNullOrWhiteSpace(textBox_CreateTicket_IncidentDuration.Text))
            {
                lbl_CreateTicket_IncidentDuration.ForeColor = Color.Red;
                lbl_CreateTicket_IncidentDuration.Text = "Incident Duration*";
                errorCount++;
            }
            if (string.IsNullOrEmpty(txtBox_CreateTicket_Subject.Text) || string.IsNullOrWhiteSpace(txtBox_CreateTicket_Subject.Text))
            {
                lbl_CreateTicket_Subject.ForeColor = Color.Red;
                lbl_CreateTicket_Subject.Text = "Subject*";
                errorCount++;
            }
            /*if (cmbBox_CreateTicket_Department.SelectedIndex != -1)
            {
                lbl_CreateTicket_Department.ForeColor = Color.Red;
                lbl_CreateTicket_Department.Text = "Department*";
                errorCount++;
            }*/
            if(Tools.IndexOfSelectedRadioButton(radioBtn_CreateTicket_UrgencyLow, radioBtn_CreateTicket_UrgencyMedium, radioBtn_CreateTicket_UrgencyHigh, radioBtn_CreateTicket_UrgencyCrit) == -1)
            {
                lbl_CreateTicket_IncidentUrgency.Text = "Incident Urgency*";
                lbl_CreateTicket_IncidentUrgency.ForeColor = Color.Red;
                errorCount++;
            }
            if (Tools.IndexOfSelectedRadioButton(radioBtn_CreateTicket_ImpactLow, radioBtn_CreateTicket_ImpactMedium, radioBtn_CreateTicket_ImpactHigh, radioBtn_CreateTicket_ImpactCrit) == -1)
            {
                lbl_CreateTicket_IncidentImpact.Text = "Incident Impact*";
                lbl_CreateTicket_IncidentImpact.ForeColor = Color.Red;
                errorCount++;
            }

            if (errorCount > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtBox_CreateTicket_IncidentLocation_TextChanged(object sender, EventArgs e)
        {
            lbl_CreateTicket_IncidentLocation.ForeColor = Color.Black;
            lbl_CreateTicket_IncidentLocation.Text = "Incident Location";
        }
        private void textBox_CreateTicket_IncidentDuration_TextChanged(object sender, EventArgs e)
        {
            lbl_CreateTicket_IncidentDuration.ForeColor = Color.Black;
            lbl_CreateTicket_IncidentDuration.Text = "Incident Duration";
        }
        private void cmbBox_CreateTicket_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_CreateTicket_Department.ForeColor = Color.Black;
            lbl_CreateTicket_Department.Text = "Department";
        }
        private void txtBox_CreateTicket_Subject_TextChanged(object sender, EventArgs e)
        {
            lbl_CreateTicket_Subject.ForeColor = Color.Black;
            lbl_CreateTicket_Subject.Text = "Subject";
        }
        private void richTextBox_CreateTicket_IncidentDescription_TextChanged(object sender, EventArgs e)
        {
            lbl_CreateTicket_CharCounter.Text = (500 - richTextBox_CreateTicket_IncidentDescription.Text.Length).ToString();
            lbl_CreateTicket_IncidentDescription.ForeColor = Color.Black;
            lbl_CreateTicket_IncidentDescription.Text = "Incident Description";
            lbl_CreateTicket_DescriptionWarning.ForeColor = Color.Black;
            lbl_CreateTicket_DescriptionWarning.Text = "";
        }

        private void btn_CreateTicket_Cancel_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabServiceDashboard;
        }
        #endregion

        #region Create Report
        //CREATE REPORT TAB
        //====================================================================================================================================================
        private void btn_CreateReport_SendReport_Click(object sender, EventArgs e)
        {
            if (validateCreateReportForm()) 
            {
                reportService.InsertReport(new Report(currentUser.UserId, DateTime.Now, dateTimePicker__CreateReport_TimeOfOccurance.Value.Date,
                    richTextBox_CreateReport_IncidentDescription.Text, int.Parse(txtBox_CreateReport_IncidentDuration.Text),
                    txtBox_CreateReport_IncidentLocation.Text, cmbBox_CreateReport_Department.Text, txtBox_CreateReport_Subject.Text));

                tabControl.SelectedTab = tabUserDashboard;
            }
        }
        private bool validateCreateReportForm() 
        {
            int errorCount = 0;
            if (string.IsNullOrEmpty(richTextBox_CreateReport_IncidentDescription.Text) || string.IsNullOrWhiteSpace(richTextBox_CreateReport_IncidentDescription.Text) || richTextBox_CreateReport_IncidentDescription.Text.Length < 50)
            {
                lbl_CreateReport_IncidentDescription.ForeColor = Color.Red;
                lbl_CreateReport_IncidentDescription.Text = "Incident Description*";
                lbl_CreateReport_DescriptionWarning.ForeColor = Color.Red;
                lbl_CreateReport_DescriptionWarning.Text = "Please make sure the description is at least 50 characters long*";
                errorCount++;
            }
            if (string.IsNullOrEmpty(txtBox_CreateReport_IncidentLocation.Text) || string.IsNullOrWhiteSpace(txtBox_CreateReport_IncidentLocation.Text)) 
            {
                lbl_CreateReport_IncidentLocation.ForeColor = Color.Red;
                lbl_CreateReport_IncidentLocation.Text = "Incident Location*";
                errorCount++;
            }
            if (string.IsNullOrEmpty(txtBox_CreateReport_IncidentDuration.Text) || string.IsNullOrWhiteSpace(txtBox_CreateReport_IncidentDuration.Text))
            {
                lbl_CreateReport_IncidentDuration.ForeColor = Color.Red;
                lbl_CreateReport_IncidentDuration.Text = "Incident Duration*";
                errorCount++;
            }
            if (string.IsNullOrEmpty(txtBox_CreateReport_Subject.Text) || string.IsNullOrWhiteSpace(txtBox_CreateReport_Subject.Text))
            {   
                lbl_CreateReport_Subject.ForeColor = Color.Red;
                lbl_CreateReport_Subject.Text = "Subject*";
                errorCount++;
            }

            //if (cmbBox_CreateReport_Department.SelectedIndex == -1)
            //{
                //lbl_CreateReport_Department.ForeColor = Color.Red;
                //lbl_CreateReport_Department.Text = "Department*";
                //errorCount++;
            //}

            if (errorCount > 0) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void txtBox_CreateReport_IncidentLocation_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox_CreateReport_IncidentLocation.Text))
            {
                lbl_CreateReport_IncidentLocation.ForeColor = Color.Black;
                lbl_CreateReport_IncidentLocation.Text = "Incident Location";
            }
        }
        private void txtBox_CreateReport_IncidentDuration_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox_CreateReport_IncidentDuration.Text))
            {
                lbl_CreateReport_IncidentDuration.ForeColor = Color.Black;
                lbl_CreateReport_IncidentDuration.Text = "Incident Duration";
            }
        }
        private void cmbBox_CreateReport_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_CreateReport_Department.ForeColor = Color.Black;
            lbl_CreateReport_Department.Text = "Department";
        }
        private void txtBox_CreateReport_Subject_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox_CreateReport_Subject.Text))
            {
                lbl_CreateReport_Subject.ForeColor = Color.Black;
                lbl_CreateReport_Subject.Text = "Subject";
            }
        }
        private void richTextBox_CreateReport_IncidentDescription_TextChanged(object sender, EventArgs e)
        {
            lbl_CreateReport_CharactersLeft.Text = (500 - richTextBox_CreateReport_IncidentDescription.Text.Length).ToString();
            if (!string.IsNullOrEmpty(richTextBox_CreateReport_IncidentDescription.Text) && richTextBox_CreateReport_IncidentDescription.Text.Length >= 50)
            {
                lbl_CreateReport_IncidentDescription.ForeColor = Color.Black;
                lbl_CreateReport_IncidentDescription.Text = "Incident Description";
                lbl_CreateReport_DescriptionWarning.ForeColor = Color.Black;
                lbl_CreateReport_DescriptionWarning.Text = "";
            }
        }

        private void btn_CreateReport_Cancel_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabUserDashboard;
        }
        #endregion

        
    }
}
