namespace GardenGroupTicketSystem
{
    using TicketSystemModels;
    partial class TicketSupportForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCreateUser = new System.Windows.Forms.TabPage();
            this.lblCreateUserBack = new System.Windows.Forms.Label();
            this.Login_txt_confirmPassword = new System.Windows.Forms.TextBox();
            this.Login_lbl_confirmPassword = new System.Windows.Forms.Label();
            this.lblCreateUserMain = new System.Windows.Forms.Label();
            this.Login_cb_userType = new System.Windows.Forms.ComboBox();
            this.Login_cb_location = new System.Windows.Forms.ComboBox();
            this.Login_txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.Login_lbl_location = new System.Windows.Forms.Label();
            this.Login_lbl_phoneNumber = new System.Windows.Forms.Label();
            this.Login_txt_userName = new System.Windows.Forms.TextBox();
            this.Login_lbl_userName = new System.Windows.Forms.Label();
            this.Login_txt_email = new System.Windows.Forms.TextBox();
            this.Login_lbl_email = new System.Windows.Forms.Label();
            this.Login_btn_createUser = new System.Windows.Forms.Button();
            this.Login_lbl_userType = new System.Windows.Forms.Label();
            this.Login_lbl_password = new System.Windows.Forms.Label();
            this.Login_lbl_lastName = new System.Windows.Forms.Label();
            this.Login_lbl_fisrtName = new System.Windows.Forms.Label();
            this.Login_txt_password = new System.Windows.Forms.TextBox();
            this.Login_txt_lastName = new System.Windows.Forms.TextBox();
            this.Login_txt_firstName = new System.Windows.Forms.TextBox();
            this.tabCreateReport = new System.Windows.Forms.TabPage();
            this.lbl_CreateReport_DescriptionWarning = new System.Windows.Forms.Label();
            this.btn_CreateReport_Cancel = new System.Windows.Forms.Button();
            this.txtBox_CreateReport_Subject = new System.Windows.Forms.TextBox();
            this.lbl_CreateReport_Subject = new System.Windows.Forms.Label();
            this.lbl_CreateReport_IncidentCategory = new System.Windows.Forms.Label();
            this.cmbBox_CreateReport_IncidentCategory = new System.Windows.Forms.ComboBox();
            this.lbl_CreateReport_Department = new System.Windows.Forms.Label();
            this.cmbBox_CreateReport_Department = new System.Windows.Forms.ComboBox();
            this.lbl_CreateReport_IncidentDuration = new System.Windows.Forms.Label();
            this.txtBox_CreateReport_IncidentDuration = new System.Windows.Forms.TextBox();
            this.lbl_CreateReport_CharactersLeft = new System.Windows.Forms.Label();
            this.lbl_CreateReport_CharCount = new System.Windows.Forms.Label();
            this.btn_CreateReport_SendReport = new System.Windows.Forms.Button();
            this.lbl_CreateReport_IncidentDescription = new System.Windows.Forms.Label();
            this.lbl_CreateReport_TimeOfOccurance = new System.Windows.Forms.Label();
            this.dateTimePicker__CreateReport_TimeOfOccurance = new System.Windows.Forms.DateTimePicker();
            this.lbl_CreateReport_IncidentLocation = new System.Windows.Forms.Label();
            this.txtBox_CreateReport_IncidentLocation = new System.Windows.Forms.TextBox();
            this.richTextBox_CreateReport_IncidentDescription = new System.Windows.Forms.RichTextBox();
            this.lbl_CreateReport_Title = new System.Windows.Forms.Label();
            this.tabCreateTicket = new System.Windows.Forms.TabPage();
            this.lbl_CreateTicket_DescriptionWarning = new System.Windows.Forms.Label();
            this.btn_CreateTicket_Cancel = new System.Windows.Forms.Button();
            this.txtBox_CreateTicket_Subject = new System.Windows.Forms.TextBox();
            this.dtp_CreateTicket_IncidentDeadline = new System.Windows.Forms.DateTimePicker();
            this.lbl_CreateTicket_Priority = new System.Windows.Forms.Label();
            this.cmbBox_CreateTicket_IncidentPriority = new System.Windows.Forms.ComboBox();
            this.lbl_CreateTicket_IncidentDeadline = new System.Windows.Forms.Label();
            this.lbl_CreateTicket_Subject = new System.Windows.Forms.Label();
            this.lbl_CreateTicket_CharCounter = new System.Windows.Forms.Label();
            this.lbl_CreateTicket_CharsLeft = new System.Windows.Forms.Label();
            this.lbl_CreateTicket_IncidentDescription = new System.Windows.Forms.Label();
            this.richTextBox_CreateTicket_IncidentDescription = new System.Windows.Forms.RichTextBox();
            this.lbl_CreateTicket_Department = new System.Windows.Forms.Label();
            this.cmbBox_CreateTicket_Department = new System.Windows.Forms.ComboBox();
            this.lbl_CreateTicket_TimeOfOccurance = new System.Windows.Forms.Label();
            this.dateTimePicker_CreateTicket_TimeOfOccurance = new System.Windows.Forms.DateTimePicker();
            this.lbl_CreateTicket_IncidentDuration = new System.Windows.Forms.Label();
            this.textBox_CreateTicket_IncidentDuration = new System.Windows.Forms.TextBox();
            this.lbl_CreateTicket_IncidentLocation = new System.Windows.Forms.Label();
            this.txtBox_CreateTicket_IncidentLocation = new System.Windows.Forms.TextBox();
            this.grpBox_CreateTicket_IncidentImpact = new System.Windows.Forms.GroupBox();
            this.lbl_CreateTicket_IncidentImpact = new System.Windows.Forms.Label();
            this.radioBtn_CreateTicket_ImpactCrit = new System.Windows.Forms.RadioButton();
            this.radioBtn_CreateTicket_ImpactHigh = new System.Windows.Forms.RadioButton();
            this.radioBtn_CreateTicket_ImpactMedium = new System.Windows.Forms.RadioButton();
            this.radioBtn_CreateTicket_ImpactLow = new System.Windows.Forms.RadioButton();
            this.grpBox_CreateTicket_IncidentCategory = new System.Windows.Forms.GroupBox();
            this.lbl_CreateTicket_IncidentUrgency = new System.Windows.Forms.Label();
            this.radioBtn_CreateTicket_UrgencyCrit = new System.Windows.Forms.RadioButton();
            this.radioBtn_CreateTicket_UrgencyHigh = new System.Windows.Forms.RadioButton();
            this.radioBtn_CreateTicket_UrgencyMedium = new System.Windows.Forms.RadioButton();
            this.radioBtn_CreateTicket_UrgencyLow = new System.Windows.Forms.RadioButton();
            this.lbl_CreateTicket_IncidentCategory = new System.Windows.Forms.Label();
            this.cmbBox_CreateTicket_Category = new System.Windows.Forms.ComboBox();
            this.btn_CreateTicket_CreateTicket = new System.Windows.Forms.Button();
            this.lbl_CreateTicket_Title = new System.Windows.Forms.Label();
            this.tabUserDashboard = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboardTicketsRadioBtn = new System.Windows.Forms.RadioButton();
            this.dashboardReportsRadioBtn = new System.Windows.Forms.RadioButton();
            this.userDashboardListView = new System.Windows.Forms.ListView();
            this.dashboardCreated = new System.Windows.Forms.ColumnHeader();
            this.dashboardStatus = new System.Windows.Forms.ColumnHeader();
            this.dashboardPriority = new System.Windows.Forms.ColumnHeader();
            this.dashboardSubject = new System.Windows.Forms.ColumnHeader();
            this.dashboardDescription = new System.Windows.Forms.ColumnHeader();
            this.dashboardOccuranceTime = new System.Windows.Forms.ColumnHeader();
            this.dashboardLocation = new System.Windows.Forms.ColumnHeader();
            this.dashboardDeadline = new System.Windows.Forms.ColumnHeader();
            this.dashboardDepartment = new System.Windows.Forms.ColumnHeader();
            this.userdashboardlbl = new System.Windows.Forms.Label();
            this.tabServiceDashboard = new System.Windows.Forms.TabPage();
            this.btn_ServiceD_UpdateTicket = new System.Windows.Forms.Button();
            this.btn_ServiceD_TransferTicket = new System.Windows.Forms.Button();
            this.btn_ServiceD_CreateUser = new System.Windows.Forms.Button();
            this.lbl_ServiceD_Ticket_Count = new System.Windows.Forms.Label();
            this.btn_ServiceD_CreateBlankTicket = new System.Windows.Forms.Button();
            this.lbl_ServiceD_Report_Count = new System.Windows.Forms.Label();
            this.btn_ServiceD_EscalateTicket = new System.Windows.Forms.Button();
            this.btn_ServiceD_CloseTicket = new System.Windows.Forms.Button();
            this.btn_ServiceD_CreateTicketFromReport = new System.Windows.Forms.Button();
            this.lbl_ServiceD_reportOverview = new System.Windows.Forms.Label();
            this.listview_ServiceD_Reports = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.btn_ServiceD_deleteTicket = new System.Windows.Forms.Button();
            this.btn_ServiceD_archivedTickets = new System.Windows.Forms.Button();
            this.lbl_ServiceD_ticketOverview = new System.Windows.Forms.Label();
            this.listview_ServiceD_Tickets = new System.Windows.Forms.ListView();
            this.colTicketStatus = new System.Windows.Forms.ColumnHeader();
            this.colTicketTitle = new System.Windows.Forms.ColumnHeader();
            this.colTicketUser = new System.Windows.Forms.ColumnHeader();
            this.colTicketDate = new System.Windows.Forms.ColumnHeader();
            this.colTicketPriority = new System.Windows.Forms.ColumnHeader();
            this.tabAnalytics = new System.Windows.Forms.TabPage();
            this.analyticsPercentEscalated = new System.Windows.Forms.Label();
            this.analyticsLbl3 = new System.Windows.Forms.Label();
            this.analyticsPercentOpen = new System.Windows.Forms.Label();
            this.analyticsPercentResolved = new System.Windows.Forms.Label();
            this.analyticsLbl2 = new System.Windows.Forms.Label();
            this.analyticsLbl1 = new System.Windows.Forms.Label();
            this.analyticsDashboardListView = new System.Windows.Forms.ListView();
            this.analyticsCreated = new System.Windows.Forms.ColumnHeader();
            this.analyticsStatus = new System.Windows.Forms.ColumnHeader();
            this.analyticsPriority = new System.Windows.Forms.ColumnHeader();
            this.analyticsUser = new System.Windows.Forms.ColumnHeader();
            this.analyticsSubject = new System.Windows.Forms.ColumnHeader();
            this.analyticsDescripton = new System.Windows.Forms.ColumnHeader();
            this.analyticsLocation = new System.Windows.Forms.ColumnHeader();
            this.analyticsDepartment = new System.Windows.Forms.ColumnHeader();
            this.analyticsDeadline = new System.Windows.Forms.ColumnHeader();
            this.searchLbl = new System.Windows.Forms.Label();
            this.searchAnalyticsTextBox = new System.Windows.Forms.TextBox();
            this.titleAnalyticsLbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl.SuspendLayout();
            this.tabCreateUser.SuspendLayout();
            this.tabCreateReport.SuspendLayout();
            this.tabCreateTicket.SuspendLayout();
            this.grpBox_CreateTicket_IncidentImpact.SuspendLayout();
            this.grpBox_CreateTicket_IncidentCategory.SuspendLayout();
            this.tabUserDashboard.SuspendLayout();
            this.tabServiceDashboard.SuspendLayout();
            this.tabAnalytics.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCreateUser);
            this.tabControl.Controls.Add(this.tabCreateReport);
            this.tabControl.Controls.Add(this.tabCreateTicket);
            this.tabControl.Controls.Add(this.tabUserDashboard);
            this.tabControl.Controls.Add(this.tabServiceDashboard);
            this.tabControl.Controls.Add(this.tabAnalytics);
            this.tabControl.Location = new System.Drawing.Point(1, 1);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1065, 454);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabCreateUser
            // 
            this.tabCreateUser.Controls.Add(this.lblCreateUserBack);
            this.tabCreateUser.Controls.Add(this.Login_txt_confirmPassword);
            this.tabCreateUser.Controls.Add(this.Login_lbl_confirmPassword);
            this.tabCreateUser.Controls.Add(this.lblCreateUserMain);
            this.tabCreateUser.Controls.Add(this.Login_cb_userType);
            this.tabCreateUser.Controls.Add(this.Login_cb_location);
            this.tabCreateUser.Controls.Add(this.Login_txt_phoneNumber);
            this.tabCreateUser.Controls.Add(this.Login_lbl_location);
            this.tabCreateUser.Controls.Add(this.Login_lbl_phoneNumber);
            this.tabCreateUser.Controls.Add(this.Login_txt_userName);
            this.tabCreateUser.Controls.Add(this.Login_lbl_userName);
            this.tabCreateUser.Controls.Add(this.Login_txt_email);
            this.tabCreateUser.Controls.Add(this.Login_lbl_email);
            this.tabCreateUser.Controls.Add(this.Login_btn_createUser);
            this.tabCreateUser.Controls.Add(this.Login_lbl_userType);
            this.tabCreateUser.Controls.Add(this.Login_lbl_password);
            this.tabCreateUser.Controls.Add(this.Login_lbl_lastName);
            this.tabCreateUser.Controls.Add(this.Login_lbl_fisrtName);
            this.tabCreateUser.Controls.Add(this.Login_txt_password);
            this.tabCreateUser.Controls.Add(this.Login_txt_lastName);
            this.tabCreateUser.Controls.Add(this.Login_txt_firstName);
            this.tabCreateUser.Location = new System.Drawing.Point(4, 21);
            this.tabCreateUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCreateUser.Name = "tabCreateUser";
            this.tabCreateUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCreateUser.Size = new System.Drawing.Size(1057, 429);
            this.tabCreateUser.TabIndex = 4;
            this.tabCreateUser.Text = "Create User";
            this.tabCreateUser.UseVisualStyleBackColor = true;
            // 
            // lblCreateUserBack
            // 
            this.lblCreateUserBack.AutoSize = true;
            this.lblCreateUserBack.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreateUserBack.Location = new System.Drawing.Point(50, 34);
            this.lblCreateUserBack.Name = "lblCreateUserBack";
            this.lblCreateUserBack.Size = new System.Drawing.Size(62, 30);
            this.lblCreateUserBack.TabIndex = 1;
            this.lblCreateUserBack.Text = "Back";
            this.lblCreateUserBack.Click += new System.EventHandler(this.lblCreatUserBack_Click);
            // 
            // Login_txt_confirmPassword
            // 
            this.Login_txt_confirmPassword.Location = new System.Drawing.Point(429, 239);
            this.Login_txt_confirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_txt_confirmPassword.Name = "Login_txt_confirmPassword";
            this.Login_txt_confirmPassword.PasswordChar = '*';
            this.Login_txt_confirmPassword.Size = new System.Drawing.Size(199, 21);
            this.Login_txt_confirmPassword.TabIndex = 5;
            // 
            // Login_lbl_confirmPassword
            // 
            this.Login_lbl_confirmPassword.AutoSize = true;
            this.Login_lbl_confirmPassword.Location = new System.Drawing.Point(302, 239);
            this.Login_lbl_confirmPassword.Name = "Login_lbl_confirmPassword";
            this.Login_lbl_confirmPassword.Size = new System.Drawing.Size(84, 12);
            this.Login_lbl_confirmPassword.TabIndex = 35;
            this.Login_lbl_confirmPassword.Text = "Confirm Password";
            // 
            // lblCreateUserMain
            // 
            this.lblCreateUserMain.AutoSize = true;
            this.lblCreateUserMain.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreateUserMain.Location = new System.Drawing.Point(429, 26);
            this.lblCreateUserMain.Name = "lblCreateUserMain";
            this.lblCreateUserMain.Size = new System.Drawing.Size(166, 37);
            this.lblCreateUserMain.TabIndex = 34;
            this.lblCreateUserMain.Text = "Create User";
            // 
            // Login_cb_userType
            // 
            this.Login_cb_userType.FormattingEnabled = true;
            this.Login_cb_userType.Items.AddRange(new object[] {
            "Regular Employee",
            "Service Desk Employee",
            "Manager"});
            this.Login_cb_userType.Location = new System.Drawing.Point(429, 270);
            this.Login_cb_userType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_cb_userType.Name = "Login_cb_userType";
            this.Login_cb_userType.Size = new System.Drawing.Size(175, 20);
            this.Login_cb_userType.TabIndex = 6;
            // 
            // Login_cb_location
            // 
            this.Login_cb_location.FormattingEnabled = true;
            this.Login_cb_location.Items.AddRange(new object[] {
            "Amsterdam",
            "Haarlem",
            "Leiden",
            "The Hague",
            "Rotterdam"});
            this.Login_cb_location.Location = new System.Drawing.Point(429, 330);
            this.Login_cb_location.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_cb_location.Name = "Login_cb_location";
            this.Login_cb_location.Size = new System.Drawing.Size(175, 20);
            this.Login_cb_location.TabIndex = 9;
            // 
            // Login_txt_phoneNumber
            // 
            this.Login_txt_phoneNumber.Location = new System.Drawing.Point(429, 299);
            this.Login_txt_phoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_txt_phoneNumber.Name = "Login_txt_phoneNumber";
            this.Login_txt_phoneNumber.Size = new System.Drawing.Size(175, 21);
            this.Login_txt_phoneNumber.TabIndex = 8;
            // 
            // Login_lbl_location
            // 
            this.Login_lbl_location.AutoSize = true;
            this.Login_lbl_location.Location = new System.Drawing.Point(302, 330);
            this.Login_lbl_location.Name = "Login_lbl_location";
            this.Login_lbl_location.Size = new System.Drawing.Size(43, 12);
            this.Login_lbl_location.TabIndex = 33;
            this.Login_lbl_location.Text = "Location";
            // 
            // Login_lbl_phoneNumber
            // 
            this.Login_lbl_phoneNumber.AutoSize = true;
            this.Login_lbl_phoneNumber.Location = new System.Drawing.Point(302, 299);
            this.Login_lbl_phoneNumber.Name = "Login_lbl_phoneNumber";
            this.Login_lbl_phoneNumber.Size = new System.Drawing.Size(73, 12);
            this.Login_lbl_phoneNumber.TabIndex = 32;
            this.Login_lbl_phoneNumber.Text = "Phone Number";
            // 
            // Login_txt_userName
            // 
            this.Login_txt_userName.Location = new System.Drawing.Point(429, 119);
            this.Login_txt_userName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_txt_userName.Name = "Login_txt_userName";
            this.Login_txt_userName.Size = new System.Drawing.Size(175, 21);
            this.Login_txt_userName.TabIndex = 1;
            // 
            // Login_lbl_userName
            // 
            this.Login_lbl_userName.AutoSize = true;
            this.Login_lbl_userName.Location = new System.Drawing.Point(302, 119);
            this.Login_lbl_userName.Name = "Login_lbl_userName";
            this.Login_lbl_userName.Size = new System.Drawing.Size(49, 12);
            this.Login_lbl_userName.TabIndex = 30;
            this.Login_lbl_userName.Text = "Username";
            // 
            // Login_txt_email
            // 
            this.Login_txt_email.Location = new System.Drawing.Point(429, 90);
            this.Login_txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_txt_email.Name = "Login_txt_email";
            this.Login_txt_email.Size = new System.Drawing.Size(175, 21);
            this.Login_txt_email.TabIndex = 0;
            // 
            // Login_lbl_email
            // 
            this.Login_lbl_email.AutoSize = true;
            this.Login_lbl_email.Location = new System.Drawing.Point(302, 90);
            this.Login_lbl_email.Name = "Login_lbl_email";
            this.Login_lbl_email.Size = new System.Drawing.Size(28, 12);
            this.Login_lbl_email.TabIndex = 28;
            this.Login_lbl_email.Text = "Email";
            // 
            // Login_btn_createUser
            // 
            this.Login_btn_createUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login_btn_createUser.Location = new System.Drawing.Point(429, 390);
            this.Login_btn_createUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_btn_createUser.Name = "Login_btn_createUser";
            this.Login_btn_createUser.Size = new System.Drawing.Size(174, 27);
            this.Login_btn_createUser.TabIndex = 10;
            this.Login_btn_createUser.Text = "Create User";
            this.Login_btn_createUser.UseVisualStyleBackColor = true;
            this.Login_btn_createUser.Click += new System.EventHandler(this.Login_btn_createUser_Click);
            // 
            // Login_lbl_userType
            // 
            this.Login_lbl_userType.AutoSize = true;
            this.Login_lbl_userType.Location = new System.Drawing.Point(302, 270);
            this.Login_lbl_userType.Name = "Login_lbl_userType";
            this.Login_lbl_userType.Size = new System.Drawing.Size(44, 12);
            this.Login_lbl_userType.TabIndex = 25;
            this.Login_lbl_userType.Text = "UserType";
            // 
            // Login_lbl_password
            // 
            this.Login_lbl_password.AutoSize = true;
            this.Login_lbl_password.Location = new System.Drawing.Point(302, 210);
            this.Login_lbl_password.Name = "Login_lbl_password";
            this.Login_lbl_password.Size = new System.Drawing.Size(46, 12);
            this.Login_lbl_password.TabIndex = 22;
            this.Login_lbl_password.Text = "Password";
            // 
            // Login_lbl_lastName
            // 
            this.Login_lbl_lastName.AutoSize = true;
            this.Login_lbl_lastName.Location = new System.Drawing.Point(302, 179);
            this.Login_lbl_lastName.Name = "Login_lbl_lastName";
            this.Login_lbl_lastName.Size = new System.Drawing.Size(51, 12);
            this.Login_lbl_lastName.TabIndex = 21;
            this.Login_lbl_lastName.Text = "Last Name";
            // 
            // Login_lbl_fisrtName
            // 
            this.Login_lbl_fisrtName.AutoSize = true;
            this.Login_lbl_fisrtName.Location = new System.Drawing.Point(302, 150);
            this.Login_lbl_fisrtName.Name = "Login_lbl_fisrtName";
            this.Login_lbl_fisrtName.Size = new System.Drawing.Size(51, 12);
            this.Login_lbl_fisrtName.TabIndex = 20;
            this.Login_lbl_fisrtName.Text = "First Name";
            // 
            // Login_txt_password
            // 
            this.Login_txt_password.Location = new System.Drawing.Point(429, 210);
            this.Login_txt_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_txt_password.Name = "Login_txt_password";
            this.Login_txt_password.PasswordChar = '*';
            this.Login_txt_password.Size = new System.Drawing.Size(199, 21);
            this.Login_txt_password.TabIndex = 4;
            // 
            // Login_txt_lastName
            // 
            this.Login_txt_lastName.Location = new System.Drawing.Point(429, 179);
            this.Login_txt_lastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_txt_lastName.Name = "Login_txt_lastName";
            this.Login_txt_lastName.Size = new System.Drawing.Size(175, 21);
            this.Login_txt_lastName.TabIndex = 3;
            // 
            // Login_txt_firstName
            // 
            this.Login_txt_firstName.Location = new System.Drawing.Point(429, 150);
            this.Login_txt_firstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_txt_firstName.Name = "Login_txt_firstName";
            this.Login_txt_firstName.Size = new System.Drawing.Size(175, 21);
            this.Login_txt_firstName.TabIndex = 2;
            // 
            // tabCreateReport
            // 
            this.tabCreateReport.Controls.Add(this.lbl_CreateReport_DescriptionWarning);
            this.tabCreateReport.Controls.Add(this.btn_CreateReport_Cancel);
            this.tabCreateReport.Controls.Add(this.txtBox_CreateReport_Subject);
            this.tabCreateReport.Controls.Add(this.lbl_CreateReport_Subject);
            this.tabCreateReport.Controls.Add(this.lbl_CreateReport_IncidentCategory);
            this.tabCreateReport.Controls.Add(this.cmbBox_CreateReport_IncidentCategory);
            this.tabCreateReport.Controls.Add(this.lbl_CreateReport_Department);
            this.tabCreateReport.Controls.Add(this.cmbBox_CreateReport_Department);
            this.tabCreateReport.Controls.Add(this.lbl_CreateReport_IncidentDuration);
            this.tabCreateReport.Controls.Add(this.txtBox_CreateReport_IncidentDuration);
            this.tabCreateReport.Controls.Add(this.lbl_CreateReport_CharactersLeft);
            this.tabCreateReport.Controls.Add(this.lbl_CreateReport_CharCount);
            this.tabCreateReport.Controls.Add(this.btn_CreateReport_SendReport);
            this.tabCreateReport.Controls.Add(this.lbl_CreateReport_IncidentDescription);
            this.tabCreateReport.Controls.Add(this.lbl_CreateReport_TimeOfOccurance);
            this.tabCreateReport.Controls.Add(this.dateTimePicker__CreateReport_TimeOfOccurance);
            this.tabCreateReport.Controls.Add(this.lbl_CreateReport_IncidentLocation);
            this.tabCreateReport.Controls.Add(this.txtBox_CreateReport_IncidentLocation);
            this.tabCreateReport.Controls.Add(this.richTextBox_CreateReport_IncidentDescription);
            this.tabCreateReport.Controls.Add(this.lbl_CreateReport_Title);
            this.tabCreateReport.Location = new System.Drawing.Point(4, 21);
            this.tabCreateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCreateReport.Name = "tabCreateReport";
            this.tabCreateReport.Size = new System.Drawing.Size(1057, 429);
            this.tabCreateReport.TabIndex = 5;
            this.tabCreateReport.Text = "Create Report";
            this.tabCreateReport.UseVisualStyleBackColor = true;
            // 
            // lbl_CreateReport_DescriptionWarning
            // 
            this.lbl_CreateReport_DescriptionWarning.AutoSize = true;
            this.lbl_CreateReport_DescriptionWarning.Location = new System.Drawing.Point(681, 142);
            this.lbl_CreateReport_DescriptionWarning.Name = "lbl_CreateReport_DescriptionWarning";
            this.lbl_CreateReport_DescriptionWarning.Size = new System.Drawing.Size(0, 12);
            this.lbl_CreateReport_DescriptionWarning.TabIndex = 44;
            // 
            // btn_CreateReport_Cancel
            // 
            this.btn_CreateReport_Cancel.Location = new System.Drawing.Point(784, 382);
            this.btn_CreateReport_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CreateReport_Cancel.Name = "btn_CreateReport_Cancel";
            this.btn_CreateReport_Cancel.Size = new System.Drawing.Size(93, 26);
            this.btn_CreateReport_Cancel.TabIndex = 43;
            this.btn_CreateReport_Cancel.Text = "Cancel";
            this.btn_CreateReport_Cancel.UseVisualStyleBackColor = true;
            this.btn_CreateReport_Cancel.Click += new System.EventHandler(this.btn_CreateReport_Cancel_Click);
            // 
            // txtBox_CreateReport_Subject
            // 
            this.txtBox_CreateReport_Subject.Location = new System.Drawing.Point(470, 107);
            this.txtBox_CreateReport_Subject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_CreateReport_Subject.Name = "txtBox_CreateReport_Subject";
            this.txtBox_CreateReport_Subject.Size = new System.Drawing.Size(193, 21);
            this.txtBox_CreateReport_Subject.TabIndex = 42;
            this.txtBox_CreateReport_Subject.TextChanged += new System.EventHandler(this.txtBox_CreateReport_Subject_TextChanged);
            // 
            // lbl_CreateReport_Subject
            // 
            this.lbl_CreateReport_Subject.AutoSize = true;
            this.lbl_CreateReport_Subject.Location = new System.Drawing.Point(470, 94);
            this.lbl_CreateReport_Subject.Name = "lbl_CreateReport_Subject";
            this.lbl_CreateReport_Subject.Size = new System.Drawing.Size(37, 12);
            this.lbl_CreateReport_Subject.TabIndex = 41;
            this.lbl_CreateReport_Subject.Text = "Subject";
            // 
            // lbl_CreateReport_IncidentCategory
            // 
            this.lbl_CreateReport_IncidentCategory.AutoSize = true;
            this.lbl_CreateReport_IncidentCategory.Location = new System.Drawing.Point(468, 48);
            this.lbl_CreateReport_IncidentCategory.Name = "lbl_CreateReport_IncidentCategory";
            this.lbl_CreateReport_IncidentCategory.Size = new System.Drawing.Size(83, 12);
            this.lbl_CreateReport_IncidentCategory.TabIndex = 26;
            this.lbl_CreateReport_IncidentCategory.Text = "Incident Category";
            // 
            // cmbBox_CreateReport_IncidentCategory
            // 
            this.cmbBox_CreateReport_IncidentCategory.FormattingEnabled = true;
            this.cmbBox_CreateReport_IncidentCategory.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "Service"});
            this.cmbBox_CreateReport_IncidentCategory.Location = new System.Drawing.Point(470, 62);
            this.cmbBox_CreateReport_IncidentCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBox_CreateReport_IncidentCategory.Name = "cmbBox_CreateReport_IncidentCategory";
            this.cmbBox_CreateReport_IncidentCategory.Size = new System.Drawing.Size(193, 20);
            this.cmbBox_CreateReport_IncidentCategory.TabIndex = 25;
            // 
            // lbl_CreateReport_Department
            // 
            this.lbl_CreateReport_Department.AutoSize = true;
            this.lbl_CreateReport_Department.Location = new System.Drawing.Point(243, 94);
            this.lbl_CreateReport_Department.Name = "lbl_CreateReport_Department";
            this.lbl_CreateReport_Department.Size = new System.Drawing.Size(57, 12);
            this.lbl_CreateReport_Department.TabIndex = 24;
            this.lbl_CreateReport_Department.Text = "Department";
            // 
            // cmbBox_CreateReport_Department
            // 
            this.cmbBox_CreateReport_Department.FormattingEnabled = true;
            this.cmbBox_CreateReport_Department.Items.AddRange(new object[] {
            "Management",
            "Marketing",
            "Operations",
            "Finance",
            "Sales",
            "HR"});
            this.cmbBox_CreateReport_Department.Location = new System.Drawing.Point(243, 107);
            this.cmbBox_CreateReport_Department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBox_CreateReport_Department.Name = "cmbBox_CreateReport_Department";
            this.cmbBox_CreateReport_Department.Size = new System.Drawing.Size(193, 20);
            this.cmbBox_CreateReport_Department.TabIndex = 23;
            this.cmbBox_CreateReport_Department.SelectedIndexChanged += new System.EventHandler(this.cmbBox_CreateReport_Department_SelectedIndexChanged);
            // 
            // lbl_CreateReport_IncidentDuration
            // 
            this.lbl_CreateReport_IncidentDuration.AutoSize = true;
            this.lbl_CreateReport_IncidentDuration.Location = new System.Drawing.Point(243, 48);
            this.lbl_CreateReport_IncidentDuration.Name = "lbl_CreateReport_IncidentDuration";
            this.lbl_CreateReport_IncidentDuration.Size = new System.Drawing.Size(82, 12);
            this.lbl_CreateReport_IncidentDuration.TabIndex = 20;
            this.lbl_CreateReport_IncidentDuration.Text = "Incident Duration";
            // 
            // txtBox_CreateReport_IncidentDuration
            // 
            this.txtBox_CreateReport_IncidentDuration.Location = new System.Drawing.Point(243, 62);
            this.txtBox_CreateReport_IncidentDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_CreateReport_IncidentDuration.Name = "txtBox_CreateReport_IncidentDuration";
            this.txtBox_CreateReport_IncidentDuration.Size = new System.Drawing.Size(193, 21);
            this.txtBox_CreateReport_IncidentDuration.TabIndex = 19;
            this.txtBox_CreateReport_IncidentDuration.TextChanged += new System.EventHandler(this.txtBox_CreateReport_IncidentDuration_TextChanged);
            // 
            // lbl_CreateReport_CharactersLeft
            // 
            this.lbl_CreateReport_CharactersLeft.AutoSize = true;
            this.lbl_CreateReport_CharactersLeft.Location = new System.Drawing.Point(1013, 256);
            this.lbl_CreateReport_CharactersLeft.Name = "lbl_CreateReport_CharactersLeft";
            this.lbl_CreateReport_CharactersLeft.Size = new System.Drawing.Size(20, 12);
            this.lbl_CreateReport_CharactersLeft.TabIndex = 18;
            this.lbl_CreateReport_CharactersLeft.Text = "500";
            // 
            // lbl_CreateReport_CharCount
            // 
            this.lbl_CreateReport_CharCount.AutoSize = true;
            this.lbl_CreateReport_CharCount.Location = new System.Drawing.Point(928, 256);
            this.lbl_CreateReport_CharCount.Name = "lbl_CreateReport_CharCount";
            this.lbl_CreateReport_CharCount.Size = new System.Drawing.Size(68, 12);
            this.lbl_CreateReport_CharCount.TabIndex = 17;
            this.lbl_CreateReport_CharCount.Text = "Characters left:";
            // 
            // btn_CreateReport_SendReport
            // 
            this.btn_CreateReport_SendReport.Location = new System.Drawing.Point(891, 382);
            this.btn_CreateReport_SendReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CreateReport_SendReport.Name = "btn_CreateReport_SendReport";
            this.btn_CreateReport_SendReport.Size = new System.Drawing.Size(147, 26);
            this.btn_CreateReport_SendReport.TabIndex = 10;
            this.btn_CreateReport_SendReport.Text = "Send Report";
            this.btn_CreateReport_SendReport.UseVisualStyleBackColor = true;
            this.btn_CreateReport_SendReport.Click += new System.EventHandler(this.btn_CreateReport_SendReport_Click);
            // 
            // lbl_CreateReport_IncidentDescription
            // 
            this.lbl_CreateReport_IncidentDescription.AutoSize = true;
            this.lbl_CreateReport_IncidentDescription.Location = new System.Drawing.Point(15, 142);
            this.lbl_CreateReport_IncidentDescription.Name = "lbl_CreateReport_IncidentDescription";
            this.lbl_CreateReport_IncidentDescription.Size = new System.Drawing.Size(93, 12);
            this.lbl_CreateReport_IncidentDescription.TabIndex = 9;
            this.lbl_CreateReport_IncidentDescription.Text = "Incident Description";
            // 
            // lbl_CreateReport_TimeOfOccurance
            // 
            this.lbl_CreateReport_TimeOfOccurance.AutoSize = true;
            this.lbl_CreateReport_TimeOfOccurance.Location = new System.Drawing.Point(15, 94);
            this.lbl_CreateReport_TimeOfOccurance.Name = "lbl_CreateReport_TimeOfOccurance";
            this.lbl_CreateReport_TimeOfOccurance.Size = new System.Drawing.Size(89, 12);
            this.lbl_CreateReport_TimeOfOccurance.TabIndex = 8;
            this.lbl_CreateReport_TimeOfOccurance.Text = "Time of Occurance";
            // 
            // dateTimePicker__CreateReport_TimeOfOccurance
            // 
            this.dateTimePicker__CreateReport_TimeOfOccurance.Location = new System.Drawing.Point(15, 107);
            this.dateTimePicker__CreateReport_TimeOfOccurance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker__CreateReport_TimeOfOccurance.Name = "dateTimePicker__CreateReport_TimeOfOccurance";
            this.dateTimePicker__CreateReport_TimeOfOccurance.Size = new System.Drawing.Size(188, 21);
            this.dateTimePicker__CreateReport_TimeOfOccurance.TabIndex = 7;
            // 
            // lbl_CreateReport_IncidentLocation
            // 
            this.lbl_CreateReport_IncidentLocation.AutoSize = true;
            this.lbl_CreateReport_IncidentLocation.Location = new System.Drawing.Point(15, 48);
            this.lbl_CreateReport_IncidentLocation.Name = "lbl_CreateReport_IncidentLocation";
            this.lbl_CreateReport_IncidentLocation.Size = new System.Drawing.Size(82, 12);
            this.lbl_CreateReport_IncidentLocation.TabIndex = 4;
            this.lbl_CreateReport_IncidentLocation.Text = "Incident Location";
            // 
            // txtBox_CreateReport_IncidentLocation
            // 
            this.txtBox_CreateReport_IncidentLocation.Location = new System.Drawing.Point(15, 62);
            this.txtBox_CreateReport_IncidentLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_CreateReport_IncidentLocation.Name = "txtBox_CreateReport_IncidentLocation";
            this.txtBox_CreateReport_IncidentLocation.Size = new System.Drawing.Size(188, 21);
            this.txtBox_CreateReport_IncidentLocation.TabIndex = 3;
            this.txtBox_CreateReport_IncidentLocation.TextChanged += new System.EventHandler(this.txtBox_CreateReport_IncidentLocation_TextChanged);
            // 
            // richTextBox_CreateReport_IncidentDescription
            // 
            this.richTextBox_CreateReport_IncidentDescription.Location = new System.Drawing.Point(15, 156);
            this.richTextBox_CreateReport_IncidentDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox_CreateReport_IncidentDescription.Name = "richTextBox_CreateReport_IncidentDescription";
            this.richTextBox_CreateReport_IncidentDescription.Size = new System.Drawing.Size(1023, 99);
            this.richTextBox_CreateReport_IncidentDescription.TabIndex = 2;
            this.richTextBox_CreateReport_IncidentDescription.Text = "";
            this.richTextBox_CreateReport_IncidentDescription.TextChanged += new System.EventHandler(this.richTextBox_CreateReport_IncidentDescription_TextChanged);
            // 
            // lbl_CreateReport_Title
            // 
            this.lbl_CreateReport_Title.AutoSize = true;
            this.lbl_CreateReport_Title.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CreateReport_Title.Location = new System.Drawing.Point(15, 14);
            this.lbl_CreateReport_Title.Name = "lbl_CreateReport_Title";
            this.lbl_CreateReport_Title.Size = new System.Drawing.Size(136, 25);
            this.lbl_CreateReport_Title.TabIndex = 1;
            this.lbl_CreateReport_Title.Text = "Create Report";
            // 
            // tabCreateTicket
            // 
            this.tabCreateTicket.Controls.Add(this.lbl_CreateTicket_DescriptionWarning);
            this.tabCreateTicket.Controls.Add(this.btn_CreateTicket_Cancel);
            this.tabCreateTicket.Controls.Add(this.txtBox_CreateTicket_Subject);
            this.tabCreateTicket.Controls.Add(this.dtp_CreateTicket_IncidentDeadline);
            this.tabCreateTicket.Controls.Add(this.lbl_CreateTicket_Priority);
            this.tabCreateTicket.Controls.Add(this.cmbBox_CreateTicket_IncidentPriority);
            this.tabCreateTicket.Controls.Add(this.lbl_CreateTicket_IncidentDeadline);
            this.tabCreateTicket.Controls.Add(this.lbl_CreateTicket_Subject);
            this.tabCreateTicket.Controls.Add(this.lbl_CreateTicket_CharCounter);
            this.tabCreateTicket.Controls.Add(this.lbl_CreateTicket_CharsLeft);
            this.tabCreateTicket.Controls.Add(this.lbl_CreateTicket_IncidentDescription);
            this.tabCreateTicket.Controls.Add(this.richTextBox_CreateTicket_IncidentDescription);
            this.tabCreateTicket.Controls.Add(this.lbl_CreateTicket_Department);
            this.tabCreateTicket.Controls.Add(this.cmbBox_CreateTicket_Department);
            this.tabCreateTicket.Controls.Add(this.lbl_CreateTicket_TimeOfOccurance);
            this.tabCreateTicket.Controls.Add(this.dateTimePicker_CreateTicket_TimeOfOccurance);
            this.tabCreateTicket.Controls.Add(this.lbl_CreateTicket_IncidentDuration);
            this.tabCreateTicket.Controls.Add(this.textBox_CreateTicket_IncidentDuration);
            this.tabCreateTicket.Controls.Add(this.lbl_CreateTicket_IncidentLocation);
            this.tabCreateTicket.Controls.Add(this.txtBox_CreateTicket_IncidentLocation);
            this.tabCreateTicket.Controls.Add(this.grpBox_CreateTicket_IncidentImpact);
            this.tabCreateTicket.Controls.Add(this.grpBox_CreateTicket_IncidentCategory);
            this.tabCreateTicket.Controls.Add(this.lbl_CreateTicket_IncidentCategory);
            this.tabCreateTicket.Controls.Add(this.cmbBox_CreateTicket_Category);
            this.tabCreateTicket.Controls.Add(this.btn_CreateTicket_CreateTicket);
            this.tabCreateTicket.Controls.Add(this.lbl_CreateTicket_Title);
            this.tabCreateTicket.Location = new System.Drawing.Point(4, 21);
            this.tabCreateTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCreateTicket.Name = "tabCreateTicket";
            this.tabCreateTicket.Size = new System.Drawing.Size(1057, 429);
            this.tabCreateTicket.TabIndex = 2;
            this.tabCreateTicket.Text = "Create Ticket";
            this.tabCreateTicket.UseVisualStyleBackColor = true;
            // 
            // lbl_CreateTicket_DescriptionWarning
            // 
            this.lbl_CreateTicket_DescriptionWarning.AutoSize = true;
            this.lbl_CreateTicket_DescriptionWarning.Location = new System.Drawing.Point(664, 150);
            this.lbl_CreateTicket_DescriptionWarning.Name = "lbl_CreateTicket_DescriptionWarning";
            this.lbl_CreateTicket_DescriptionWarning.Size = new System.Drawing.Size(0, 12);
            this.lbl_CreateTicket_DescriptionWarning.TabIndex = 42;
            // 
            // btn_CreateTicket_Cancel
            // 
            this.btn_CreateTicket_Cancel.Location = new System.Drawing.Point(788, 381);
            this.btn_CreateTicket_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CreateTicket_Cancel.Name = "btn_CreateTicket_Cancel";
            this.btn_CreateTicket_Cancel.Size = new System.Drawing.Size(93, 26);
            this.btn_CreateTicket_Cancel.TabIndex = 41;
            this.btn_CreateTicket_Cancel.Text = "Cancel";
            this.btn_CreateTicket_Cancel.UseVisualStyleBackColor = true;
            // 
            // txtBox_CreateTicket_Subject
            // 
            this.txtBox_CreateTicket_Subject.Location = new System.Drawing.Point(471, 118);
            this.txtBox_CreateTicket_Subject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_CreateTicket_Subject.Name = "txtBox_CreateTicket_Subject";
            this.txtBox_CreateTicket_Subject.Size = new System.Drawing.Size(193, 21);
            this.txtBox_CreateTicket_Subject.TabIndex = 40;
            // 
            // dtp_CreateTicket_IncidentDeadline
            // 
            this.dtp_CreateTicket_IncidentDeadline.Location = new System.Drawing.Point(15, 343);
            this.dtp_CreateTicket_IncidentDeadline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_CreateTicket_IncidentDeadline.Name = "dtp_CreateTicket_IncidentDeadline";
            this.dtp_CreateTicket_IncidentDeadline.Size = new System.Drawing.Size(224, 21);
            this.dtp_CreateTicket_IncidentDeadline.TabIndex = 39;
            // 
            // lbl_CreateTicket_Priority
            // 
            this.lbl_CreateTicket_Priority.AutoSize = true;
            this.lbl_CreateTicket_Priority.Location = new System.Drawing.Point(15, 372);
            this.lbl_CreateTicket_Priority.Name = "lbl_CreateTicket_Priority";
            this.lbl_CreateTicket_Priority.Size = new System.Drawing.Size(74, 12);
            this.lbl_CreateTicket_Priority.TabIndex = 38;
            this.lbl_CreateTicket_Priority.Text = "Incident Priority";
            // 
            // cmbBox_CreateTicket_IncidentPriority
            // 
            this.cmbBox_CreateTicket_IncidentPriority.FormattingEnabled = true;
            this.cmbBox_CreateTicket_IncidentPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Critical"});
            this.cmbBox_CreateTicket_IncidentPriority.Location = new System.Drawing.Point(17, 386);
            this.cmbBox_CreateTicket_IncidentPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBox_CreateTicket_IncidentPriority.Name = "cmbBox_CreateTicket_IncidentPriority";
            this.cmbBox_CreateTicket_IncidentPriority.Size = new System.Drawing.Size(222, 20);
            this.cmbBox_CreateTicket_IncidentPriority.TabIndex = 37;
            // 
            // lbl_CreateTicket_IncidentDeadline
            // 
            this.lbl_CreateTicket_IncidentDeadline.AutoSize = true;
            this.lbl_CreateTicket_IncidentDeadline.Location = new System.Drawing.Point(15, 330);
            this.lbl_CreateTicket_IncidentDeadline.Name = "lbl_CreateTicket_IncidentDeadline";
            this.lbl_CreateTicket_IncidentDeadline.Size = new System.Drawing.Size(82, 12);
            this.lbl_CreateTicket_IncidentDeadline.TabIndex = 36;
            this.lbl_CreateTicket_IncidentDeadline.Text = "Incident Deadline";
            // 
            // lbl_CreateTicket_Subject
            // 
            this.lbl_CreateTicket_Subject.AutoSize = true;
            this.lbl_CreateTicket_Subject.Location = new System.Drawing.Point(471, 104);
            this.lbl_CreateTicket_Subject.Name = "lbl_CreateTicket_Subject";
            this.lbl_CreateTicket_Subject.Size = new System.Drawing.Size(37, 12);
            this.lbl_CreateTicket_Subject.TabIndex = 34;
            this.lbl_CreateTicket_Subject.Text = "Subject";
            // 
            // lbl_CreateTicket_CharCounter
            // 
            this.lbl_CreateTicket_CharCounter.AutoSize = true;
            this.lbl_CreateTicket_CharCounter.Location = new System.Drawing.Point(1013, 277);
            this.lbl_CreateTicket_CharCounter.Name = "lbl_CreateTicket_CharCounter";
            this.lbl_CreateTicket_CharCounter.Size = new System.Drawing.Size(20, 12);
            this.lbl_CreateTicket_CharCounter.TabIndex = 32;
            this.lbl_CreateTicket_CharCounter.Text = "500";
            // 
            // lbl_CreateTicket_CharsLeft
            // 
            this.lbl_CreateTicket_CharsLeft.AutoSize = true;
            this.lbl_CreateTicket_CharsLeft.Location = new System.Drawing.Point(928, 277);
            this.lbl_CreateTicket_CharsLeft.Name = "lbl_CreateTicket_CharsLeft";
            this.lbl_CreateTicket_CharsLeft.Size = new System.Drawing.Size(68, 12);
            this.lbl_CreateTicket_CharsLeft.TabIndex = 31;
            this.lbl_CreateTicket_CharsLeft.Text = "Characters left:";
            // 
            // lbl_CreateTicket_IncidentDescription
            // 
            this.lbl_CreateTicket_IncidentDescription.AutoSize = true;
            this.lbl_CreateTicket_IncidentDescription.Location = new System.Drawing.Point(15, 152);
            this.lbl_CreateTicket_IncidentDescription.Name = "lbl_CreateTicket_IncidentDescription";
            this.lbl_CreateTicket_IncidentDescription.Size = new System.Drawing.Size(93, 12);
            this.lbl_CreateTicket_IncidentDescription.TabIndex = 30;
            this.lbl_CreateTicket_IncidentDescription.Text = "Incident Description";
            // 
            // richTextBox_CreateTicket_IncidentDescription
            // 
            this.richTextBox_CreateTicket_IncidentDescription.Location = new System.Drawing.Point(15, 164);
            this.richTextBox_CreateTicket_IncidentDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox_CreateTicket_IncidentDescription.Name = "richTextBox_CreateTicket_IncidentDescription";
            this.richTextBox_CreateTicket_IncidentDescription.Size = new System.Drawing.Size(1023, 111);
            this.richTextBox_CreateTicket_IncidentDescription.TabIndex = 29;
            this.richTextBox_CreateTicket_IncidentDescription.Text = "";
            this.richTextBox_CreateTicket_IncidentDescription.TextChanged += new System.EventHandler(this.richTextBox_CreateTicket_IncidentDescription_TextChanged);
            // 
            // lbl_CreateTicket_Department
            // 
            this.lbl_CreateTicket_Department.AutoSize = true;
            this.lbl_CreateTicket_Department.Location = new System.Drawing.Point(471, 54);
            this.lbl_CreateTicket_Department.Name = "lbl_CreateTicket_Department";
            this.lbl_CreateTicket_Department.Size = new System.Drawing.Size(57, 12);
            this.lbl_CreateTicket_Department.TabIndex = 28;
            this.lbl_CreateTicket_Department.Text = "Department";
            // 
            // cmbBox_CreateTicket_Department
            // 
            this.cmbBox_CreateTicket_Department.FormattingEnabled = true;
            this.cmbBox_CreateTicket_Department.Items.AddRange(new object[] {
            "Management",
            "Marketing",
            "Operations",
            "Finance",
            "Sales",
            "HR"});
            this.cmbBox_CreateTicket_Department.Location = new System.Drawing.Point(471, 67);
            this.cmbBox_CreateTicket_Department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBox_CreateTicket_Department.Name = "cmbBox_CreateTicket_Department";
            this.cmbBox_CreateTicket_Department.Size = new System.Drawing.Size(193, 20);
            this.cmbBox_CreateTicket_Department.TabIndex = 27;
            // 
            // lbl_CreateTicket_TimeOfOccurance
            // 
            this.lbl_CreateTicket_TimeOfOccurance.AutoSize = true;
            this.lbl_CreateTicket_TimeOfOccurance.Location = new System.Drawing.Point(243, 54);
            this.lbl_CreateTicket_TimeOfOccurance.Name = "lbl_CreateTicket_TimeOfOccurance";
            this.lbl_CreateTicket_TimeOfOccurance.Size = new System.Drawing.Size(89, 12);
            this.lbl_CreateTicket_TimeOfOccurance.TabIndex = 26;
            this.lbl_CreateTicket_TimeOfOccurance.Text = "Time of Occurance";
            // 
            // dateTimePicker_CreateTicket_TimeOfOccurance
            // 
            this.dateTimePicker_CreateTicket_TimeOfOccurance.Location = new System.Drawing.Point(243, 67);
            this.dateTimePicker_CreateTicket_TimeOfOccurance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_CreateTicket_TimeOfOccurance.Name = "dateTimePicker_CreateTicket_TimeOfOccurance";
            this.dateTimePicker_CreateTicket_TimeOfOccurance.Size = new System.Drawing.Size(188, 21);
            this.dateTimePicker_CreateTicket_TimeOfOccurance.TabIndex = 25;
            // 
            // lbl_CreateTicket_IncidentDuration
            // 
            this.lbl_CreateTicket_IncidentDuration.AutoSize = true;
            this.lbl_CreateTicket_IncidentDuration.Location = new System.Drawing.Point(243, 104);
            this.lbl_CreateTicket_IncidentDuration.Name = "lbl_CreateTicket_IncidentDuration";
            this.lbl_CreateTicket_IncidentDuration.Size = new System.Drawing.Size(82, 12);
            this.lbl_CreateTicket_IncidentDuration.TabIndex = 24;
            this.lbl_CreateTicket_IncidentDuration.Text = "Incident Duration";
            // 
            // textBox_CreateTicket_IncidentDuration
            // 
            this.textBox_CreateTicket_IncidentDuration.Location = new System.Drawing.Point(243, 118);
            this.textBox_CreateTicket_IncidentDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_CreateTicket_IncidentDuration.Name = "textBox_CreateTicket_IncidentDuration";
            this.textBox_CreateTicket_IncidentDuration.Size = new System.Drawing.Size(193, 21);
            this.textBox_CreateTicket_IncidentDuration.TabIndex = 23;
            // 
            // lbl_CreateTicket_IncidentLocation
            // 
            this.lbl_CreateTicket_IncidentLocation.AutoSize = true;
            this.lbl_CreateTicket_IncidentLocation.Location = new System.Drawing.Point(15, 104);
            this.lbl_CreateTicket_IncidentLocation.Name = "lbl_CreateTicket_IncidentLocation";
            this.lbl_CreateTicket_IncidentLocation.Size = new System.Drawing.Size(82, 12);
            this.lbl_CreateTicket_IncidentLocation.TabIndex = 22;
            this.lbl_CreateTicket_IncidentLocation.Text = "Incident Location";
            // 
            // txtBox_CreateTicket_IncidentLocation
            // 
            this.txtBox_CreateTicket_IncidentLocation.Location = new System.Drawing.Point(15, 118);
            this.txtBox_CreateTicket_IncidentLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_CreateTicket_IncidentLocation.Name = "txtBox_CreateTicket_IncidentLocation";
            this.txtBox_CreateTicket_IncidentLocation.Size = new System.Drawing.Size(188, 21);
            this.txtBox_CreateTicket_IncidentLocation.TabIndex = 21;
            // 
            // grpBox_CreateTicket_IncidentImpact
            // 
            this.grpBox_CreateTicket_IncidentImpact.Controls.Add(this.lbl_CreateTicket_IncidentImpact);
            this.grpBox_CreateTicket_IncidentImpact.Controls.Add(this.radioBtn_CreateTicket_ImpactCrit);
            this.grpBox_CreateTicket_IncidentImpact.Controls.Add(this.radioBtn_CreateTicket_ImpactHigh);
            this.grpBox_CreateTicket_IncidentImpact.Controls.Add(this.radioBtn_CreateTicket_ImpactMedium);
            this.grpBox_CreateTicket_IncidentImpact.Controls.Add(this.radioBtn_CreateTicket_ImpactLow);
            this.grpBox_CreateTicket_IncidentImpact.Location = new System.Drawing.Point(912, 38);
            this.grpBox_CreateTicket_IncidentImpact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_CreateTicket_IncidentImpact.Name = "grpBox_CreateTicket_IncidentImpact";
            this.grpBox_CreateTicket_IncidentImpact.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_CreateTicket_IncidentImpact.Size = new System.Drawing.Size(126, 97);
            this.grpBox_CreateTicket_IncidentImpact.TabIndex = 12;
            this.grpBox_CreateTicket_IncidentImpact.TabStop = false;
            this.grpBox_CreateTicket_IncidentImpact.Text = "                             ";
            // 
            // lbl_CreateTicket_IncidentImpact
            // 
            this.lbl_CreateTicket_IncidentImpact.AutoSize = true;
            this.lbl_CreateTicket_IncidentImpact.Location = new System.Drawing.Point(4, 0);
            this.lbl_CreateTicket_IncidentImpact.Name = "lbl_CreateTicket_IncidentImpact";
            this.lbl_CreateTicket_IncidentImpact.Size = new System.Drawing.Size(75, 12);
            this.lbl_CreateTicket_IncidentImpact.TabIndex = 19;
            this.lbl_CreateTicket_IncidentImpact.Text = "Incident Impact";
            // 
            // radioBtn_CreateTicket_ImpactCrit
            // 
            this.radioBtn_CreateTicket_ImpactCrit.AutoSize = true;
            this.radioBtn_CreateTicket_ImpactCrit.Location = new System.Drawing.Point(5, 70);
            this.radioBtn_CreateTicket_ImpactCrit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtn_CreateTicket_ImpactCrit.Name = "radioBtn_CreateTicket_ImpactCrit";
            this.radioBtn_CreateTicket_ImpactCrit.Size = new System.Drawing.Size(51, 16);
            this.radioBtn_CreateTicket_ImpactCrit.TabIndex = 6;
            this.radioBtn_CreateTicket_ImpactCrit.TabStop = true;
            this.radioBtn_CreateTicket_ImpactCrit.Text = "Critical";
            this.radioBtn_CreateTicket_ImpactCrit.UseVisualStyleBackColor = true;
            this.radioBtn_CreateTicket_ImpactCrit.CheckedChanged += new System.EventHandler(this.radioBtn_CreateTicket_ImpactCrit_CheckedChanged);
            // 
            // radioBtn_CreateTicket_ImpactHigh
            // 
            this.radioBtn_CreateTicket_ImpactHigh.AutoSize = true;
            this.radioBtn_CreateTicket_ImpactHigh.Location = new System.Drawing.Point(4, 51);
            this.radioBtn_CreateTicket_ImpactHigh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtn_CreateTicket_ImpactHigh.Name = "radioBtn_CreateTicket_ImpactHigh";
            this.radioBtn_CreateTicket_ImpactHigh.Size = new System.Drawing.Size(44, 16);
            this.radioBtn_CreateTicket_ImpactHigh.TabIndex = 5;
            this.radioBtn_CreateTicket_ImpactHigh.TabStop = true;
            this.radioBtn_CreateTicket_ImpactHigh.Text = "High";
            this.radioBtn_CreateTicket_ImpactHigh.UseVisualStyleBackColor = true;
            this.radioBtn_CreateTicket_ImpactHigh.CheckedChanged += new System.EventHandler(this.radioBtn_CreateTicket_ImpactHigh_CheckedChanged);
            // 
            // radioBtn_CreateTicket_ImpactMedium
            // 
            this.radioBtn_CreateTicket_ImpactMedium.AutoSize = true;
            this.radioBtn_CreateTicket_ImpactMedium.Location = new System.Drawing.Point(4, 34);
            this.radioBtn_CreateTicket_ImpactMedium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtn_CreateTicket_ImpactMedium.Name = "radioBtn_CreateTicket_ImpactMedium";
            this.radioBtn_CreateTicket_ImpactMedium.Size = new System.Drawing.Size(60, 16);
            this.radioBtn_CreateTicket_ImpactMedium.TabIndex = 4;
            this.radioBtn_CreateTicket_ImpactMedium.TabStop = true;
            this.radioBtn_CreateTicket_ImpactMedium.Text = "Medium";
            this.radioBtn_CreateTicket_ImpactMedium.UseVisualStyleBackColor = true;
            this.radioBtn_CreateTicket_ImpactMedium.CheckedChanged += new System.EventHandler(this.radioBtn_CreateTicket_ImpactMedium_CheckedChanged);
            // 
            // radioBtn_CreateTicket_ImpactLow
            // 
            this.radioBtn_CreateTicket_ImpactLow.AutoSize = true;
            this.radioBtn_CreateTicket_ImpactLow.Location = new System.Drawing.Point(4, 16);
            this.radioBtn_CreateTicket_ImpactLow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtn_CreateTicket_ImpactLow.Name = "radioBtn_CreateTicket_ImpactLow";
            this.radioBtn_CreateTicket_ImpactLow.Size = new System.Drawing.Size(41, 16);
            this.radioBtn_CreateTicket_ImpactLow.TabIndex = 3;
            this.radioBtn_CreateTicket_ImpactLow.TabStop = true;
            this.radioBtn_CreateTicket_ImpactLow.Text = "Low";
            this.radioBtn_CreateTicket_ImpactLow.UseVisualStyleBackColor = true;
            this.radioBtn_CreateTicket_ImpactLow.CheckedChanged += new System.EventHandler(this.radioBtn_CreateTicket_ImpactLow_CheckedChanged);
            // 
            // grpBox_CreateTicket_IncidentCategory
            // 
            this.grpBox_CreateTicket_IncidentCategory.Controls.Add(this.lbl_CreateTicket_IncidentUrgency);
            this.grpBox_CreateTicket_IncidentCategory.Controls.Add(this.radioBtn_CreateTicket_UrgencyCrit);
            this.grpBox_CreateTicket_IncidentCategory.Controls.Add(this.radioBtn_CreateTicket_UrgencyHigh);
            this.grpBox_CreateTicket_IncidentCategory.Controls.Add(this.radioBtn_CreateTicket_UrgencyMedium);
            this.grpBox_CreateTicket_IncidentCategory.Controls.Add(this.radioBtn_CreateTicket_UrgencyLow);
            this.grpBox_CreateTicket_IncidentCategory.Location = new System.Drawing.Point(744, 38);
            this.grpBox_CreateTicket_IncidentCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_CreateTicket_IncidentCategory.Name = "grpBox_CreateTicket_IncidentCategory";
            this.grpBox_CreateTicket_IncidentCategory.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_CreateTicket_IncidentCategory.Size = new System.Drawing.Size(126, 97);
            this.grpBox_CreateTicket_IncidentCategory.TabIndex = 11;
            this.grpBox_CreateTicket_IncidentCategory.TabStop = false;
            this.grpBox_CreateTicket_IncidentCategory.Text = "                             ";
            // 
            // lbl_CreateTicket_IncidentUrgency
            // 
            this.lbl_CreateTicket_IncidentUrgency.AutoSize = true;
            this.lbl_CreateTicket_IncidentUrgency.Location = new System.Drawing.Point(4, 0);
            this.lbl_CreateTicket_IncidentUrgency.Name = "lbl_CreateTicket_IncidentUrgency";
            this.lbl_CreateTicket_IncidentUrgency.Size = new System.Drawing.Size(81, 12);
            this.lbl_CreateTicket_IncidentUrgency.TabIndex = 18;
            this.lbl_CreateTicket_IncidentUrgency.Text = "Incident Urgency";
            // 
            // radioBtn_CreateTicket_UrgencyCrit
            // 
            this.radioBtn_CreateTicket_UrgencyCrit.AutoSize = true;
            this.radioBtn_CreateTicket_UrgencyCrit.Location = new System.Drawing.Point(5, 70);
            this.radioBtn_CreateTicket_UrgencyCrit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtn_CreateTicket_UrgencyCrit.Name = "radioBtn_CreateTicket_UrgencyCrit";
            this.radioBtn_CreateTicket_UrgencyCrit.Size = new System.Drawing.Size(51, 16);
            this.radioBtn_CreateTicket_UrgencyCrit.TabIndex = 6;
            this.radioBtn_CreateTicket_UrgencyCrit.TabStop = true;
            this.radioBtn_CreateTicket_UrgencyCrit.Text = "Critical";
            this.radioBtn_CreateTicket_UrgencyCrit.UseVisualStyleBackColor = true;
            this.radioBtn_CreateTicket_UrgencyCrit.CheckedChanged += new System.EventHandler(this.radioBtn_CreateTicket_UrgencyCrit_CheckedChanged);
            // 
            // radioBtn_CreateTicket_UrgencyHigh
            // 
            this.radioBtn_CreateTicket_UrgencyHigh.AutoSize = true;
            this.radioBtn_CreateTicket_UrgencyHigh.Location = new System.Drawing.Point(4, 51);
            this.radioBtn_CreateTicket_UrgencyHigh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtn_CreateTicket_UrgencyHigh.Name = "radioBtn_CreateTicket_UrgencyHigh";
            this.radioBtn_CreateTicket_UrgencyHigh.Size = new System.Drawing.Size(44, 16);
            this.radioBtn_CreateTicket_UrgencyHigh.TabIndex = 5;
            this.radioBtn_CreateTicket_UrgencyHigh.TabStop = true;
            this.radioBtn_CreateTicket_UrgencyHigh.Text = "High";
            this.radioBtn_CreateTicket_UrgencyHigh.UseVisualStyleBackColor = true;
            this.radioBtn_CreateTicket_UrgencyHigh.CheckedChanged += new System.EventHandler(this.radioBtn_CreateTicket_UrgencyHigh_CheckedChanged);
            // 
            // radioBtn_CreateTicket_UrgencyMedium
            // 
            this.radioBtn_CreateTicket_UrgencyMedium.AutoSize = true;
            this.radioBtn_CreateTicket_UrgencyMedium.Location = new System.Drawing.Point(4, 34);
            this.radioBtn_CreateTicket_UrgencyMedium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtn_CreateTicket_UrgencyMedium.Name = "radioBtn_CreateTicket_UrgencyMedium";
            this.radioBtn_CreateTicket_UrgencyMedium.Size = new System.Drawing.Size(60, 16);
            this.radioBtn_CreateTicket_UrgencyMedium.TabIndex = 4;
            this.radioBtn_CreateTicket_UrgencyMedium.TabStop = true;
            this.radioBtn_CreateTicket_UrgencyMedium.Text = "Medium";
            this.radioBtn_CreateTicket_UrgencyMedium.UseVisualStyleBackColor = true;
            this.radioBtn_CreateTicket_UrgencyMedium.CheckedChanged += new System.EventHandler(this.radioBtn_CreateTicket_UrgencyMedium_CheckedChanged);
            // 
            // radioBtn_CreateTicket_UrgencyLow
            // 
            this.radioBtn_CreateTicket_UrgencyLow.AutoSize = true;
            this.radioBtn_CreateTicket_UrgencyLow.Location = new System.Drawing.Point(4, 16);
            this.radioBtn_CreateTicket_UrgencyLow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtn_CreateTicket_UrgencyLow.Name = "radioBtn_CreateTicket_UrgencyLow";
            this.radioBtn_CreateTicket_UrgencyLow.Size = new System.Drawing.Size(41, 16);
            this.radioBtn_CreateTicket_UrgencyLow.TabIndex = 3;
            this.radioBtn_CreateTicket_UrgencyLow.TabStop = true;
            this.radioBtn_CreateTicket_UrgencyLow.Text = "Low";
            this.radioBtn_CreateTicket_UrgencyLow.UseVisualStyleBackColor = true;
            this.radioBtn_CreateTicket_UrgencyLow.CheckedChanged += new System.EventHandler(this.radioBtn_CreateTicket_UrgencyLow_CheckedChanged);
            // 
            // lbl_CreateTicket_IncidentCategory
            // 
            this.lbl_CreateTicket_IncidentCategory.AutoSize = true;
            this.lbl_CreateTicket_IncidentCategory.Location = new System.Drawing.Point(15, 54);
            this.lbl_CreateTicket_IncidentCategory.Name = "lbl_CreateTicket_IncidentCategory";
            this.lbl_CreateTicket_IncidentCategory.Size = new System.Drawing.Size(83, 12);
            this.lbl_CreateTicket_IncidentCategory.TabIndex = 6;
            this.lbl_CreateTicket_IncidentCategory.Text = "Incident Category";
            // 
            // cmbBox_CreateTicket_Category
            // 
            this.cmbBox_CreateTicket_Category.FormattingEnabled = true;
            this.cmbBox_CreateTicket_Category.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "Service"});
            this.cmbBox_CreateTicket_Category.Location = new System.Drawing.Point(17, 67);
            this.cmbBox_CreateTicket_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBox_CreateTicket_Category.Name = "cmbBox_CreateTicket_Category";
            this.cmbBox_CreateTicket_Category.Size = new System.Drawing.Size(193, 20);
            this.cmbBox_CreateTicket_Category.TabIndex = 5;
            this.cmbBox_CreateTicket_Category.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_CreateTicket_CreateTicket
            // 
            this.btn_CreateTicket_CreateTicket.Location = new System.Drawing.Point(895, 381);
            this.btn_CreateTicket_CreateTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CreateTicket_CreateTicket.Name = "btn_CreateTicket_CreateTicket";
            this.btn_CreateTicket_CreateTicket.Size = new System.Drawing.Size(143, 26);
            this.btn_CreateTicket_CreateTicket.TabIndex = 1;
            this.btn_CreateTicket_CreateTicket.Text = "Create Ticket";
            this.btn_CreateTicket_CreateTicket.UseVisualStyleBackColor = true;
            this.btn_CreateTicket_CreateTicket.Click += new System.EventHandler(this.btn_CreateTicket_CreateTicket_Click);
            // 
            // lbl_CreateTicket_Title
            // 
            this.lbl_CreateTicket_Title.AutoSize = true;
            this.lbl_CreateTicket_Title.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CreateTicket_Title.Location = new System.Drawing.Point(15, 13);
            this.lbl_CreateTicket_Title.Name = "lbl_CreateTicket_Title";
            this.lbl_CreateTicket_Title.Size = new System.Drawing.Size(127, 25);
            this.lbl_CreateTicket_Title.TabIndex = 0;
            this.lbl_CreateTicket_Title.Text = "Create Ticket";
            // 
            // tabUserDashboard
            // 
            this.tabUserDashboard.Controls.Add(this.label1);
            this.tabUserDashboard.Controls.Add(this.dashboardTicketsRadioBtn);
            this.tabUserDashboard.Controls.Add(this.dashboardReportsRadioBtn);
            this.tabUserDashboard.Controls.Add(this.userDashboardListView);
            this.tabUserDashboard.Controls.Add(this.userdashboardlbl);
            this.tabUserDashboard.Location = new System.Drawing.Point(4, 24);
            this.tabUserDashboard.Name = "tabUserDashboard";
            this.tabUserDashboard.Size = new System.Drawing.Size(1057, 429);
            this.tabUserDashboard.TabIndex = 3;
            this.tabUserDashboard.Text = "Regular User Dashboard";
            this.tabUserDashboard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "View";
            // 
            // dashboardTicketsRadioBtn
            // 
            this.dashboardTicketsRadioBtn.AutoSize = true;
            this.dashboardTicketsRadioBtn.Location = new System.Drawing.Point(538, 73);
            this.dashboardTicketsRadioBtn.Name = "dashboardTicketsRadioBtn";
            this.dashboardTicketsRadioBtn.Size = new System.Drawing.Size(61, 19);
            this.dashboardTicketsRadioBtn.TabIndex = 3;
            this.dashboardTicketsRadioBtn.TabStop = true;
            this.dashboardTicketsRadioBtn.Text = "Tickets";
            this.dashboardTicketsRadioBtn.UseVisualStyleBackColor = true;
            this.dashboardTicketsRadioBtn.CheckedChanged += new System.EventHandler(this.dashboardTicketsRadioBtn_CheckedChanged);
            // 
            // dashboardReportsRadioBtn
            // 
            this.dashboardReportsRadioBtn.AutoSize = true;
            this.dashboardReportsRadioBtn.Location = new System.Drawing.Point(605, 73);
            this.dashboardReportsRadioBtn.Name = "dashboardReportsRadioBtn";
            this.dashboardReportsRadioBtn.Size = new System.Drawing.Size(65, 19);
            this.dashboardReportsRadioBtn.TabIndex = 2;
            this.dashboardReportsRadioBtn.TabStop = true;
            this.dashboardReportsRadioBtn.Text = "Reports";
            this.dashboardReportsRadioBtn.UseVisualStyleBackColor = true;
            this.dashboardReportsRadioBtn.CheckedChanged += new System.EventHandler(this.dashboardReportsRadioBtn_CheckedChanged);
            // 
            // userDashboardListView
            // 
            this.userDashboardListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dashboardCreated,
            this.dashboardStatus,
            this.dashboardPriority,
            this.dashboardSubject,
            this.dashboardDescription,
            this.dashboardOccuranceTime,
            this.dashboardLocation,
            this.dashboardDeadline,
            this.dashboardDepartment});
            this.userDashboardListView.HideSelection = false;
            this.userDashboardListView.Location = new System.Drawing.Point(4, 106);
            this.userDashboardListView.Name = "userDashboardListView";
            this.userDashboardListView.Size = new System.Drawing.Size(1226, 429);
            this.userDashboardListView.TabIndex = 1;
            this.userDashboardListView.UseCompatibleStateImageBehavior = false;
            this.userDashboardListView.View = System.Windows.Forms.View.Details;
            // 
            // dashboardCreated
            // 
            this.dashboardCreated.Text = "Date created";
            this.dashboardCreated.Width = 102;
            // 
            // dashboardStatus
            // 
            this.dashboardStatus.Text = "Status";
            this.dashboardStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dashboardStatus.Width = 100;
            // 
            // dashboardPriority
            // 
            this.dashboardPriority.Text = "Priority";
            this.dashboardPriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dashboardPriority.Width = 100;
            // 
            // dashboardSubject
            // 
            this.dashboardSubject.Text = "Subject";
            this.dashboardSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dashboardSubject.Width = 200;
            // 
            // dashboardDescription
            // 
            this.dashboardDescription.Text = "Description";
            this.dashboardDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dashboardDescription.Width = 300;
            // 
            // dashboardOccuranceTime
            // 
            this.dashboardOccuranceTime.Text = "Time of occurrance";
            this.dashboardOccuranceTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dashboardOccuranceTime.Width = 115;
            // 
            // dashboardLocation
            // 
            this.dashboardLocation.Text = "Location";
            this.dashboardLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dashboardLocation.Width = 100;
            // 
            // dashboardDeadline
            // 
            this.dashboardDeadline.Text = "Deadline";
            this.dashboardDeadline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dashboardDeadline.Width = 102;
            // 
            // dashboardDepartment
            // 
            this.dashboardDepartment.Text = "Department";
            this.dashboardDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dashboardDepartment.Width = 102;
            // 
            // userdashboardlbl
            // 
            this.userdashboardlbl.AutoSize = true;
            this.userdashboardlbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userdashboardlbl.Location = new System.Drawing.Point(462, 13);
            this.userdashboardlbl.Name = "userdashboardlbl";
            this.userdashboardlbl.Size = new System.Drawing.Size(302, 32);
            this.userdashboardlbl.TabIndex = 0;
            this.userdashboardlbl.Text = "Personal Incident Overview";
            // 
            // tabServiceDashboard
            // 
            this.tabServiceDashboard.Controls.Add(this.btn_ServiceD_UpdateTicket);
            this.tabServiceDashboard.Controls.Add(this.btn_ServiceD_TransferTicket);
            this.tabServiceDashboard.Controls.Add(this.btn_ServiceD_CreateUser);
            this.tabServiceDashboard.Controls.Add(this.lbl_ServiceD_Ticket_Count);
            this.tabServiceDashboard.Controls.Add(this.btn_ServiceD_CreateBlankTicket);
            this.tabServiceDashboard.Controls.Add(this.lbl_ServiceD_Report_Count);
            this.tabServiceDashboard.Controls.Add(this.btn_ServiceD_EscalateTicket);
            this.tabServiceDashboard.Controls.Add(this.btn_ServiceD_CloseTicket);
            this.tabServiceDashboard.Controls.Add(this.btn_ServiceD_CreateTicketFromReport);
            this.tabServiceDashboard.Controls.Add(this.lbl_ServiceD_reportOverview);
            this.tabServiceDashboard.Controls.Add(this.listview_ServiceD_Reports);
            this.tabServiceDashboard.Controls.Add(this.btn_ServiceD_deleteTicket);
            this.tabServiceDashboard.Controls.Add(this.btn_ServiceD_archivedTickets);
            this.tabServiceDashboard.Controls.Add(this.lbl_ServiceD_ticketOverview);
            this.tabServiceDashboard.Controls.Add(this.listview_ServiceD_Tickets);
            this.tabServiceDashboard.Location = new System.Drawing.Point(4, 21);
            this.tabServiceDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabServiceDashboard.Name = "tabServiceDashboard";
            this.tabServiceDashboard.Size = new System.Drawing.Size(1057, 429);
            this.tabServiceDashboard.TabIndex = 6;
            this.tabServiceDashboard.Text = "Service Dashboard";
            this.tabServiceDashboard.UseVisualStyleBackColor = true;
            // 
            // btn_ServiceD_UpdateTicket
            // 
            this.btn_ServiceD_UpdateTicket.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_ServiceD_UpdateTicket.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ServiceD_UpdateTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ServiceD_UpdateTicket.Location = new System.Drawing.Point(671, 312);
            this.btn_ServiceD_UpdateTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ServiceD_UpdateTicket.Name = "btn_ServiceD_UpdateTicket";
            this.btn_ServiceD_UpdateTicket.Size = new System.Drawing.Size(122, 26);
            this.btn_ServiceD_UpdateTicket.TabIndex = 16;
            this.btn_ServiceD_UpdateTicket.Text = "Update Ticket";
            this.btn_ServiceD_UpdateTicket.UseVisualStyleBackColor = false;
            this.btn_ServiceD_UpdateTicket.Click += new System.EventHandler(this.btn_ServiceD_UpdateTicket_Click);
            // 
            // btn_ServiceD_TransferTicket
            // 
            this.btn_ServiceD_TransferTicket.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ServiceD_TransferTicket.Location = new System.Drawing.Point(663, 487);
            this.btn_ServiceD_TransferTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ServiceD_TransferTicket.Name = "btn_ServiceD_TransferTicket";
            this.btn_ServiceD_TransferTicket.Size = new System.Drawing.Size(111, 26);
            this.btn_ServiceD_TransferTicket.TabIndex = 15;
            this.btn_ServiceD_TransferTicket.Text = "Transfer Ticket";
            this.btn_ServiceD_TransferTicket.UseVisualStyleBackColor = true;
            this.btn_ServiceD_TransferTicket.Click += new System.EventHandler(this.btn_ServiceD_TransferTicket_Click);
            // 
            // btn_ServiceD_CreateUser
            // 
            this.btn_ServiceD_CreateUser.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_ServiceD_CreateUser.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ServiceD_CreateUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ServiceD_CreateUser.Location = new System.Drawing.Point(188, 370);
            this.btn_ServiceD_CreateUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ServiceD_CreateUser.Name = "btn_ServiceD_CreateUser";
            this.btn_ServiceD_CreateUser.Size = new System.Drawing.Size(149, 27);
            this.btn_ServiceD_CreateUser.TabIndex = 14;
            this.btn_ServiceD_CreateUser.Text = "Create New User";
            this.btn_ServiceD_CreateUser.UseVisualStyleBackColor = false;
            this.btn_ServiceD_CreateUser.Click += new System.EventHandler(this.btn_ServiceD_CreateUser_Click);
            // 
            // lbl_ServiceD_Ticket_Count
            // 
            this.lbl_ServiceD_Ticket_Count.AccessibleName = "";
            this.lbl_ServiceD_Ticket_Count.AutoSize = true;
            this.lbl_ServiceD_Ticket_Count.Location = new System.Drawing.Point(939, 31);
            this.lbl_ServiceD_Ticket_Count.Name = "lbl_ServiceD_Ticket_Count";
            this.lbl_ServiceD_Ticket_Count.Size = new System.Drawing.Size(65, 12);
            this.lbl_ServiceD_Ticket_Count.TabIndex = 12;
            this.lbl_ServiceD_Ticket_Count.Text = "Ticket Count: ";
            // 
            // btn_ServiceD_CreateBlankTicket
            // 
            this.btn_ServiceD_CreateBlankTicket.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_ServiceD_CreateBlankTicket.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ServiceD_CreateBlankTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ServiceD_CreateBlankTicket.Location = new System.Drawing.Point(188, 312);
            this.btn_ServiceD_CreateBlankTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ServiceD_CreateBlankTicket.Name = "btn_ServiceD_CreateBlankTicket";
            this.btn_ServiceD_CreateBlankTicket.Size = new System.Drawing.Size(149, 43);
            this.btn_ServiceD_CreateBlankTicket.TabIndex = 11;
            this.btn_ServiceD_CreateBlankTicket.Text = "Create Blank Ticket";
            this.btn_ServiceD_CreateBlankTicket.UseVisualStyleBackColor = false;
            this.btn_ServiceD_CreateBlankTicket.Click += new System.EventHandler(this.btn_ServiceD_CreateBlankTicket_Click);
            // 
            // lbl_ServiceD_Report_Count
            // 
            this.lbl_ServiceD_Report_Count.AccessibleName = "";
            this.lbl_ServiceD_Report_Count.AutoSize = true;
            this.lbl_ServiceD_Report_Count.Location = new System.Drawing.Point(429, 31);
            this.lbl_ServiceD_Report_Count.Name = "lbl_ServiceD_Report_Count";
            this.lbl_ServiceD_Report_Count.Size = new System.Drawing.Size(69, 12);
            this.lbl_ServiceD_Report_Count.TabIndex = 10;
            this.lbl_ServiceD_Report_Count.Text = "Report Count: ";
            // 
            // btn_ServiceD_EscalateTicket
            // 
            this.btn_ServiceD_EscalateTicket.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_ServiceD_EscalateTicket.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ServiceD_EscalateTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ServiceD_EscalateTicket.Location = new System.Drawing.Point(537, 312);
            this.btn_ServiceD_EscalateTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ServiceD_EscalateTicket.Name = "btn_ServiceD_EscalateTicket";
            this.btn_ServiceD_EscalateTicket.Size = new System.Drawing.Size(128, 26);
            this.btn_ServiceD_EscalateTicket.TabIndex = 9;
            this.btn_ServiceD_EscalateTicket.Text = "Escalate Ticket";
            this.btn_ServiceD_EscalateTicket.UseVisualStyleBackColor = false;
            this.btn_ServiceD_EscalateTicket.Click += new System.EventHandler(this.btn_ServiceD_EscalateTicket_Click);
            // 
            // btn_ServiceD_CloseTicket
            // 
            this.btn_ServiceD_CloseTicket.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_ServiceD_CloseTicket.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ServiceD_CloseTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ServiceD_CloseTicket.Location = new System.Drawing.Point(915, 312);
            this.btn_ServiceD_CloseTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ServiceD_CloseTicket.Name = "btn_ServiceD_CloseTicket";
            this.btn_ServiceD_CloseTicket.Size = new System.Drawing.Size(113, 26);
            this.btn_ServiceD_CloseTicket.TabIndex = 8;
            this.btn_ServiceD_CloseTicket.Text = "Close Ticket";
            this.btn_ServiceD_CloseTicket.UseVisualStyleBackColor = false;
            this.btn_ServiceD_CloseTicket.Click += new System.EventHandler(this.btn_ServiceD_CloseTicket_Click);
            // 
            // btn_ServiceD_CreateTicketFromReport
            // 
            this.btn_ServiceD_CreateTicketFromReport.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_ServiceD_CreateTicketFromReport.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ServiceD_CreateTicketFromReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ServiceD_CreateTicketFromReport.Location = new System.Drawing.Point(342, 312);
            this.btn_ServiceD_CreateTicketFromReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ServiceD_CreateTicketFromReport.Name = "btn_ServiceD_CreateTicketFromReport";
            this.btn_ServiceD_CreateTicketFromReport.Size = new System.Drawing.Size(176, 43);
            this.btn_ServiceD_CreateTicketFromReport.TabIndex = 7;
            this.btn_ServiceD_CreateTicketFromReport.Text = "Create Ticket From Report";
            this.btn_ServiceD_CreateTicketFromReport.UseVisualStyleBackColor = false;
            this.btn_ServiceD_CreateTicketFromReport.Click += new System.EventHandler(this.btn_ServiceD_CreateTicketFromReport_Click);
            // 
            // lbl_ServiceD_reportOverview
            // 
            this.lbl_ServiceD_reportOverview.AutoSize = true;
            this.lbl_ServiceD_reportOverview.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ServiceD_reportOverview.Location = new System.Drawing.Point(27, 29);
            this.lbl_ServiceD_reportOverview.Name = "lbl_ServiceD_reportOverview";
            this.lbl_ServiceD_reportOverview.Size = new System.Drawing.Size(143, 18);
            this.lbl_ServiceD_reportOverview.TabIndex = 6;
            this.lbl_ServiceD_reportOverview.Text = "Report Overview";
            // 
            // listview_ServiceD_Reports
            // 
            this.listview_ServiceD_Reports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listview_ServiceD_Reports.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listview_ServiceD_Reports.FullRowSelect = true;
            this.listview_ServiceD_Reports.HideSelection = false;
            this.listview_ServiceD_Reports.Location = new System.Drawing.Point(27, 56);
            this.listview_ServiceD_Reports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listview_ServiceD_Reports.Name = "listview_ServiceD_Reports";
            this.listview_ServiceD_Reports.Size = new System.Drawing.Size(491, 246);
            this.listview_ServiceD_Reports.TabIndex = 5;
            this.listview_ServiceD_Reports.UseCompatibleStateImageBehavior = false;
            this.listview_ServiceD_Reports.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Report Title";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "User";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Date";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Department";
            this.columnHeader8.Width = 170;
            // 
            // btn_ServiceD_deleteTicket
            // 
            this.btn_ServiceD_deleteTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ServiceD_deleteTicket.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ServiceD_deleteTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ServiceD_deleteTicket.Location = new System.Drawing.Point(799, 312);
            this.btn_ServiceD_deleteTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ServiceD_deleteTicket.Name = "btn_ServiceD_deleteTicket";
            this.btn_ServiceD_deleteTicket.Size = new System.Drawing.Size(111, 26);
            this.btn_ServiceD_deleteTicket.TabIndex = 4;
            this.btn_ServiceD_deleteTicket.Text = "Delete Ticket";
            this.btn_ServiceD_deleteTicket.UseVisualStyleBackColor = false;
            this.btn_ServiceD_deleteTicket.Click += new System.EventHandler(this.btn_ServiceD_deleteTicket_Click);
            // 
            // btn_ServiceD_archivedTickets
            // 
            this.btn_ServiceD_archivedTickets.BackColor = System.Drawing.Color.Gray;
            this.btn_ServiceD_archivedTickets.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ServiceD_archivedTickets.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ServiceD_archivedTickets.Location = new System.Drawing.Point(799, 369);
            this.btn_ServiceD_archivedTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ServiceD_archivedTickets.Name = "btn_ServiceD_archivedTickets";
            this.btn_ServiceD_archivedTickets.Size = new System.Drawing.Size(229, 28);
            this.btn_ServiceD_archivedTickets.TabIndex = 2;
            this.btn_ServiceD_archivedTickets.Text = "Archive Tickets";
            this.btn_ServiceD_archivedTickets.UseVisualStyleBackColor = false;
            this.btn_ServiceD_archivedTickets.Click += new System.EventHandler(this.btn_ServiceD_archivedTickets_Click);
            // 
            // lbl_ServiceD_ticketOverview
            // 
            this.lbl_ServiceD_ticketOverview.AutoSize = true;
            this.lbl_ServiceD_ticketOverview.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ServiceD_ticketOverview.Location = new System.Drawing.Point(537, 29);
            this.lbl_ServiceD_ticketOverview.Name = "lbl_ServiceD_ticketOverview";
            this.lbl_ServiceD_ticketOverview.Size = new System.Drawing.Size(138, 18);
            this.lbl_ServiceD_ticketOverview.TabIndex = 1;
            this.lbl_ServiceD_ticketOverview.Text = "Ticket Overview";
            // 
            // listview_ServiceD_Tickets
            // 
            this.listview_ServiceD_Tickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTicketStatus,
            this.colTicketTitle,
            this.colTicketUser,
            this.colTicketDate,
            this.colTicketPriority});
            this.listview_ServiceD_Tickets.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listview_ServiceD_Tickets.FullRowSelect = true;
            this.listview_ServiceD_Tickets.HideSelection = false;
            this.listview_ServiceD_Tickets.Location = new System.Drawing.Point(537, 56);
            this.listview_ServiceD_Tickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listview_ServiceD_Tickets.Name = "listview_ServiceD_Tickets";
            this.listview_ServiceD_Tickets.Size = new System.Drawing.Size(491, 246);
            this.listview_ServiceD_Tickets.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listview_ServiceD_Tickets.TabIndex = 0;
            this.listview_ServiceD_Tickets.UseCompatibleStateImageBehavior = false;
            this.listview_ServiceD_Tickets.View = System.Windows.Forms.View.Details;
            // 
            // colTicketStatus
            // 
            this.colTicketStatus.Text = "Status";
            this.colTicketStatus.Width = 110;
            // 
            // colTicketTitle
            // 
            this.colTicketTitle.Text = "Title";
            this.colTicketTitle.Width = 140;
            // 
            // colTicketUser
            // 
            this.colTicketUser.Text = "User";
            this.colTicketUser.Width = 100;
            // 
            // colTicketDate
            // 
            this.colTicketDate.Text = "Date";
            this.colTicketDate.Width = 150;
            // 
            // colTicketPriority
            // 
            this.colTicketPriority.Text = "Priority";
            this.colTicketPriority.Width = 120;
            // 
            // tabAnalytics
            // 
            this.tabAnalytics.Controls.Add(this.analyticsPercentEscalated);
            this.tabAnalytics.Controls.Add(this.analyticsLbl3);
            this.tabAnalytics.Controls.Add(this.analyticsPercentOpen);
            this.tabAnalytics.Controls.Add(this.analyticsPercentResolved);
            this.tabAnalytics.Controls.Add(this.analyticsLbl2);
            this.tabAnalytics.Controls.Add(this.analyticsLbl1);
            this.tabAnalytics.Controls.Add(this.analyticsDashboardListView);
            this.tabAnalytics.Controls.Add(this.searchLbl);
            this.tabAnalytics.Controls.Add(this.searchAnalyticsTextBox);
            this.tabAnalytics.Controls.Add(this.titleAnalyticsLbl);
            this.tabAnalytics.Location = new System.Drawing.Point(4, 24);

            this.tabAnalytics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAnalytics.Name = "tabAnalytics";
            this.tabAnalytics.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAnalytics.Size = new System.Drawing.Size(1057, 429);
            this.tabAnalytics.TabIndex = 7;
            this.tabAnalytics.Text = "Incident Analytics";
            this.tabAnalytics.UseVisualStyleBackColor = true;
            // 
            // analyticsPercentEscalated
            // 
            this.analyticsPercentEscalated.AccessibleName = "";
            this.analyticsPercentEscalated.AutoSize = true;
            this.analyticsPercentEscalated.Location = new System.Drawing.Point(292, 32);
            this.analyticsPercentEscalated.Name = "analyticsPercentEscalated";
            this.analyticsPercentEscalated.Size = new System.Drawing.Size(0, 15);
            this.analyticsPercentEscalated.TabIndex = 9;
            // 
            // analyticsLbl3
            // 
            this.analyticsLbl3.AutoSize = true;
            this.analyticsLbl3.Location = new System.Drawing.Point(227, 32);
            this.analyticsLbl3.Name = "analyticsLbl3";
            this.analyticsLbl3.Size = new System.Drawing.Size(62, 15);
            this.analyticsLbl3.TabIndex = 8;
            this.analyticsLbl3.Text = "Escalated: ";
            // 
            // analyticsPercentOpen
            // 
            this.analyticsPercentOpen.AutoSize = true;
            this.analyticsPercentOpen.Location = new System.Drawing.Point(292, 63);
            this.analyticsPercentOpen.Name = "analyticsPercentOpen";
            this.analyticsPercentOpen.Size = new System.Drawing.Size(0, 15);
            this.analyticsPercentOpen.TabIndex = 7;
            // 
            // analyticsPercentResolved
            // 
            this.analyticsPercentResolved.AutoSize = true;
            this.analyticsPercentResolved.Location = new System.Drawing.Point(292, 48);
            this.analyticsPercentResolved.Name = "analyticsPercentResolved";
            this.analyticsPercentResolved.Size = new System.Drawing.Size(0, 15);
            this.analyticsPercentResolved.TabIndex = 6;
            // 
            // analyticsLbl2
            // 
            this.analyticsLbl2.AutoSize = true;
            this.analyticsLbl2.Location = new System.Drawing.Point(227, 48);
            this.analyticsLbl2.Name = "analyticsLbl2";
            this.analyticsLbl2.Size = new System.Drawing.Size(60, 15);
            this.analyticsLbl2.TabIndex = 5;
            this.analyticsLbl2.Text = "Resolved: ";
            // 
            // analyticsLbl1
            // 
            this.analyticsLbl1.AutoSize = true;
            this.analyticsLbl1.Location = new System.Drawing.Point(227, 63);
            this.analyticsLbl1.Name = "analyticsLbl1";
            this.analyticsLbl1.Size = new System.Drawing.Size(42, 15);
            this.analyticsLbl1.TabIndex = 4;
            this.analyticsLbl1.Text = "Open: ";
            // 
            // analyticsDashboardListView
            // 
            this.analyticsDashboardListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.analyticsCreated,
            this.analyticsStatus,
            this.analyticsPriority,
            this.analyticsUser,
            this.analyticsSubject,
            this.analyticsDescripton,
            this.analyticsLocation,
            this.analyticsDepartment,
            this.analyticsDeadline});
            this.analyticsDashboardListView.HideSelection = false;
            this.analyticsDashboardListView.Location = new System.Drawing.Point(3, 110);
            this.analyticsDashboardListView.Name = "analyticsDashboardListView";
            this.analyticsDashboardListView.Size = new System.Drawing.Size(1229, 427);
            this.analyticsDashboardListView.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.analyticsDashboardListView.TabIndex = 3;
            this.analyticsDashboardListView.UseCompatibleStateImageBehavior = false;
            this.analyticsDashboardListView.View = System.Windows.Forms.View.Details;
            // 
            // analyticsCreated
            // 
            this.analyticsCreated.Text = "Date created";
            this.analyticsCreated.Width = 102;
            // 
            // analyticsStatus
            // 
            this.analyticsStatus.Text = "Status";
            this.analyticsStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.analyticsStatus.Width = 100;
            // 
            // analyticsPriority
            // 
            this.analyticsPriority.Text = "Priority";
            this.analyticsPriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.analyticsPriority.Width = 100;
            // 
            // analyticsUser
            // 
            this.analyticsUser.Text = "Assigned to";
            this.analyticsUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.analyticsUser.Width = 120;
            // 
            // analyticsSubject
            // 
            this.analyticsSubject.Text = "Subject";
            this.analyticsSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.analyticsSubject.Width = 200;
            // 
            // analyticsDescripton
            // 
            this.analyticsDescripton.Text = "Description";
            this.analyticsDescripton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.analyticsDescripton.Width = 300;
            // 
            // analyticsLocation
            // 
            this.analyticsLocation.Text = "Location";
            this.analyticsLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.analyticsLocation.Width = 100;
            // 
            // analyticsDepartment
            // 
            this.analyticsDepartment.Text = "Department";
            this.analyticsDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.analyticsDepartment.Width = 100;
            // 
            // analyticsDeadline
            // 
            this.analyticsDeadline.Text = "Deadline";
            this.analyticsDeadline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.analyticsDeadline.Width = 102;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(609, 63);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(42, 15);
            this.searchLbl.TabIndex = 2;
            this.searchLbl.Text = "Search";
            // 
            // searchAnalyticsTextBox
            // 
            this.searchAnalyticsTextBox.Location = new System.Drawing.Point(527, 81);
            this.searchAnalyticsTextBox.Name = "searchAnalyticsTextBox";
            this.searchAnalyticsTextBox.Size = new System.Drawing.Size(214, 23);
            this.searchAnalyticsTextBox.TabIndex = 1;
            this.searchAnalyticsTextBox.TextChanged += new System.EventHandler(this.searchAnalyticsTextBox_TextChanged);
            // 
            // titleAnalyticsLbl
            // 
            this.titleAnalyticsLbl.AutoSize = true;
            this.titleAnalyticsLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleAnalyticsLbl.Location = new System.Drawing.Point(527, 18);
            this.titleAnalyticsLbl.Name = "titleAnalyticsLbl";
            this.titleAnalyticsLbl.Size = new System.Drawing.Size(214, 32);
            this.titleAnalyticsLbl.TabIndex = 0;
            this.titleAnalyticsLbl.Text = "Analytics Overview";
            // 
            // TicketSupportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 458);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TicketSupportForm";
            this.Text = "Garden Group IT Support";
            this.Load += new System.EventHandler(this.TicketSupportForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabCreateUser.ResumeLayout(false);
            this.tabCreateUser.PerformLayout();
            this.tabCreateReport.ResumeLayout(false);
            this.tabCreateReport.PerformLayout();
            this.tabCreateTicket.ResumeLayout(false);
            this.tabCreateTicket.PerformLayout();
            this.grpBox_CreateTicket_IncidentImpact.ResumeLayout(false);
            this.grpBox_CreateTicket_IncidentImpact.PerformLayout();
            this.grpBox_CreateTicket_IncidentCategory.ResumeLayout(false);
            this.grpBox_CreateTicket_IncidentCategory.PerformLayout();
            this.tabUserDashboard.ResumeLayout(false);
            this.tabUserDashboard.PerformLayout();
            this.tabServiceDashboard.ResumeLayout(false);
            this.tabServiceDashboard.PerformLayout();
            this.tabAnalytics.ResumeLayout(false);
            this.tabAnalytics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCreateTicket;
        private System.Windows.Forms.TabPage tabUserDashboard;
        private System.Windows.Forms.TabPage tabCreateUser;
        private System.Windows.Forms.TabPage tabCreateReport;
        private System.Windows.Forms.TabPage tabServiceDashboard;
        private System.Windows.Forms.Label lbl_CreateTicket_IncidentCategory;
        private System.Windows.Forms.Label lblCreateUserBack;
        private System.Windows.Forms.ComboBox cmbBox_CreateTicket_Category;
        private System.Windows.Forms.RadioButton radioBtn_CreateTicket_UrgencyLow;
        private System.Windows.Forms.Button btn_CreateTicket_CreateTicket;
        private System.Windows.Forms.Label lbl_CreateTicket_Title;
        private System.Windows.Forms.GroupBox grpBox_CreateTicket_IncidentImpact;
        private System.Windows.Forms.RadioButton radioBtn_CreateTicket_ImpactCrit;
        private System.Windows.Forms.RadioButton radioBtn_CreateTicket_ImpactHigh;
        private System.Windows.Forms.RadioButton radioBtn_CreateTicket_ImpactMedium;
        private System.Windows.Forms.RadioButton radioBtn_CreateTicket_ImpactLow;
        private System.Windows.Forms.GroupBox grpBox_CreateTicket_IncidentCategory;
        private System.Windows.Forms.RadioButton radioBtn_CreateTicket_UrgencyCrit;
        private System.Windows.Forms.RadioButton radioBtn_CreateTicket_UrgencyHigh;
        private System.Windows.Forms.RadioButton radioBtn_CreateTicket_UrgencyMedium;
        private System.Windows.Forms.Label lbl_CreateTicket_IncidentUrgency;
        private System.Windows.Forms.Label lbl_CreateTicket_IncidentImpact;
        private System.Windows.Forms.Label lbl_CreateReport_IncidentDescription;
        private System.Windows.Forms.Label lbl_CreateReport_TimeOfOccurance;
        private System.Windows.Forms.DateTimePicker dateTimePicker__CreateReport_TimeOfOccurance;
        private System.Windows.Forms.Label lbl_CreateReport_IncidentLocation;
        private System.Windows.Forms.TextBox txtBox_CreateReport_IncidentLocation;
        private System.Windows.Forms.RichTextBox richTextBox_CreateReport_IncidentDescription;
        private System.Windows.Forms.Label lbl_CreateReport_Title;
        private System.Windows.Forms.Button btn_CreateReport_SendReport;
        private System.Windows.Forms.Label lbl_CreateReport_CharactersLeft;
        private System.Windows.Forms.Label lbl_CreateReport_CharCount;
        private System.Windows.Forms.Label lbl_CreateReport_Department;
        private System.Windows.Forms.ComboBox cmbBox_CreateReport_Department;
        private System.Windows.Forms.Label lbl_CreateReport_IncidentDuration;
        private System.Windows.Forms.TextBox txtBox_CreateReport_IncidentDuration;
        private System.Windows.Forms.Label lbl_CreateReport_IncidentCategory;
        private System.Windows.Forms.ComboBox cmbBox_CreateReport_IncidentCategory;
        private System.Windows.Forms.Label lbl_CreateTicket_Priority;
        private System.Windows.Forms.ComboBox cmbBox_CreateTicket_IncidentPriority;
        private System.Windows.Forms.Label lbl_CreateTicket_IncidentDeadline;
        private System.Windows.Forms.Label lbl_CreateTicket_Subject;
        private System.Windows.Forms.Label lbl_CreateTicket_CharCounter;
        private System.Windows.Forms.Label lbl_CreateTicket_CharsLeft;
        private System.Windows.Forms.Label lbl_CreateTicket_IncidentDescription;
        private System.Windows.Forms.RichTextBox richTextBox_CreateTicket_IncidentDescription;
        private System.Windows.Forms.Label lbl_CreateTicket_Department;
        private System.Windows.Forms.ComboBox cmbBox_CreateTicket_Department;
        private System.Windows.Forms.Label lbl_CreateTicket_TimeOfOccurance;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CreateTicket_TimeOfOccurance;
        private System.Windows.Forms.Label lbl_CreateTicket_IncidentDuration;
        private System.Windows.Forms.TextBox textBox_CreateTicket_IncidentDuration;
        private System.Windows.Forms.Label lbl_CreateTicket_IncidentLocation;
        private System.Windows.Forms.TextBox txtBox_CreateTicket_IncidentLocation;
        private System.Windows.Forms.DateTimePicker dtp_CreateTicket_IncidentDeadline;
        private System.Windows.Forms.TextBox txtBox_CreateTicket_Subject;
        private System.Windows.Forms.TextBox txtBox_CreateReport_Subject;
        private System.Windows.Forms.Label lbl_CreateReport_Subject;
        private System.Windows.Forms.ListView listview_ServiceD_Tickets;
        private System.Windows.Forms.Label lbl_ServiceD_ticketOverview;
        private System.Windows.Forms.Button btn_ServiceD_archivedTickets;
        private System.Windows.Forms.Button btn_ServiceD_deleteTicket;
        private System.Windows.Forms.Label lbl_ServiceD_reportOverview;
        private System.Windows.Forms.ListView listview_ServiceD_Reports;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btn_ServiceD_CreateTicketFromReport;
        private System.Windows.Forms.Button btn_ServiceD_CloseTicket;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Login_lbl_userType;
        private System.Windows.Forms.Label Login_lbl_password;
        private System.Windows.Forms.Label Login_lbl_lastName;
        private System.Windows.Forms.Label Login_lbl_fisrtName;
        private System.Windows.Forms.TextBox Login_txt_password;
        private System.Windows.Forms.TextBox Login_txt_lastName;
        private System.Windows.Forms.TextBox Login_txt_firstName;
        private System.Windows.Forms.Button Login_btn_createUser;
        private System.Windows.Forms.TabPage tabAnalytics;
        private System.Windows.Forms.Button btn_ServiceD_EscalateTicket;
        private System.Windows.Forms.Label lbl_ServiceD_Report_Count;
        private System.Windows.Forms.Button btn_ServiceD_CreateBlankTicket;
        private System.Windows.Forms.TextBox Login_txt_email;
        private System.Windows.Forms.Label Login_lbl_email;
        private System.Windows.Forms.TextBox Login_txt_userName;
        private System.Windows.Forms.Label Login_lbl_userName;
        private System.Windows.Forms.Label lbl_ServiceD_Ticket_Count;
        private System.Windows.Forms.Button btn_ServiceD_CreateUser;
        private System.Windows.Forms.ComboBox Login_cb_location;
        private System.Windows.Forms.TextBox Login_txt_phoneNumber;
        private System.Windows.Forms.Label Login_lbl_location;
        private System.Windows.Forms.Label Login_lbl_phoneNumber;
        private System.Windows.Forms.ComboBox Login_cb_userType;
        private System.Windows.Forms.Label lblCreateUserMain;
        private System.Windows.Forms.TextBox Login_txt_confirmPassword;
        private System.Windows.Forms.Label Login_lbl_confirmPassword;
        private System.Windows.Forms.Button btn_ServiceD_TransferTicket;
        private System.Windows.Forms.ColumnHeader colTicketStatus;
        private System.Windows.Forms.ColumnHeader colTicketTitle;
        private System.Windows.Forms.ColumnHeader colTicketUser;
        private System.Windows.Forms.ColumnHeader colTicketDate;
        private System.Windows.Forms.ColumnHeader colTicketPriority;
        private System.Windows.Forms.Button btn_CreateTicket_Cancel;
        private System.Windows.Forms.Button btn_CreateReport_Cancel;
        private System.Windows.Forms.Label lbl_CreateReport_DescriptionWarning;
        private System.Windows.Forms.Button btn_ServiceD_UpdateTicket;
        private System.Windows.Forms.Label userdashboardlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton dashboardTicketsRadioBtn;
        private System.Windows.Forms.RadioButton dashboardReportsRadioBtn;
        private System.Windows.Forms.ListView userDashboardListView;
        private System.Windows.Forms.ColumnHeader dashboardCreated;
        private System.Windows.Forms.ColumnHeader dashboardStatus;
        private System.Windows.Forms.ColumnHeader dashboardPriority;
        private System.Windows.Forms.ColumnHeader dashboardSubject;
        private System.Windows.Forms.ColumnHeader dashboardDescription;
        private System.Windows.Forms.ColumnHeader dashboardOccuranceTime;
        private System.Windows.Forms.ColumnHeader dashboardLocation;
        private System.Windows.Forms.ColumnHeader dashboardDeadline;
        private System.Windows.Forms.ColumnHeader dashboardDepartment;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.TextBox searchAnalyticsTextBox;
        private System.Windows.Forms.Label titleAnalyticsLbl;
        private System.Windows.Forms.ListView analyticsDashboardListView;
        private System.Windows.Forms.ColumnHeader analyticsCreated;
        private System.Windows.Forms.ColumnHeader analyticsStatus;
        private System.Windows.Forms.ColumnHeader analyticsPriority;
        private System.Windows.Forms.ColumnHeader analyticsUser;
        private System.Windows.Forms.ColumnHeader analyticsSubject;
        private System.Windows.Forms.ColumnHeader analyticsDescripton;
        private System.Windows.Forms.ColumnHeader analyticsLocation;
        private System.Windows.Forms.ColumnHeader analyticsDepartment;
        private System.Windows.Forms.ColumnHeader analyticsDeadline;
        private System.Windows.Forms.Label analyticsPercentOpen;
        private System.Windows.Forms.Label analyticsPercentResolved;
        private System.Windows.Forms.Label analyticsLbl2;
        private System.Windows.Forms.Label analyticsLbl1;
        private System.Windows.Forms.Label analyticsLbl3;
        private System.Windows.Forms.Label analyticsPercentEscalated;
        private System.Windows.Forms.Label lbl_CreateTicket_DescriptionWarning;
    }
}
