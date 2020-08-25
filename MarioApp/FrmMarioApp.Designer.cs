namespace MarioApp
{
    partial class FrmMarioApp
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
            this.tbPlaceToSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bSearchPlace = new System.Windows.Forms.Button();
            this.tbClientNumberToSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bSearchNumber = new System.Windows.Forms.Button();
            this.listBoxCustomersFound = new System.Windows.Forms.ListBox();
            this.tbPostalCodeToSearch = new System.Windows.Forms.TextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.bSearchPostalCode = new System.Windows.Forms.Button();
            this.tbNewA107 = new System.Windows.Forms.TextBox();
            this.lblNewPostalcode = new System.Windows.Forms.Label();
            this.tbNewA100 = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.tbNewA110 = new System.Windows.Forms.TextBox();
            this.lblNewID = new System.Windows.Forms.Label();
            this.tbNewA108 = new System.Windows.Forms.TextBox();
            this.lblNewPlace = new System.Windows.Forms.Label();
            this.btnAddNewClient = new System.Windows.Forms.Button();
            this.btnMarntList = new System.Windows.Forms.Button();
            this.lblMarDataLocatie = new System.Windows.Forms.Label();
            this.btnChangeMarNTLocation = new System.Windows.Forms.Button();
            this.tbMarLocatie = new System.Windows.Forms.TextBox();
            this.btnResetMarntCCI = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheckLocalSqlServer = new System.Windows.Forms.Button();
            this.tbLocalConnectionstring = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCheckHostedSqlServer = new System.Windows.Forms.Button();
            this.tbHostedConnectionstring = new System.Windows.Forms.TextBox();
            this.btnUpdateCheck = new System.Windows.Forms.Button();
            this.btnUpdateAccounts = new System.Windows.Forms.Button();
            this.btnAccountsList = new System.Windows.Forms.Button();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.rbHosted = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabQR = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSPCreation = new System.Windows.Forms.Button();
            this.btnSuppliersList = new System.Windows.Forms.Button();
            this.btnCheckSuppliers = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDemoContent = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnStopScan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabQR.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPlaceToSearch
            // 
            this.tbPlaceToSearch.Location = new System.Drawing.Point(163, 67);
            this.tbPlaceToSearch.Name = "tbPlaceToSearch";
            this.tbPlaceToSearch.Size = new System.Drawing.Size(208, 20);
            this.tbPlaceToSearch.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Place (A108)";
            // 
            // bSearchPlace
            // 
            this.bSearchPlace.Location = new System.Drawing.Point(440, 65);
            this.bSearchPlace.Name = "bSearchPlace";
            this.bSearchPlace.Size = new System.Drawing.Size(158, 23);
            this.bSearchPlace.TabIndex = 25;
            this.bSearchPlace.Text = "Search on Place";
            this.bSearchPlace.UseVisualStyleBackColor = true;
            this.bSearchPlace.Click += new System.EventHandler(this.BSearchPlace_Click);
            // 
            // tbClientNumberToSearch
            // 
            this.tbClientNumberToSearch.Location = new System.Drawing.Point(163, 38);
            this.tbClientNumberToSearch.Name = "tbClientNumberToSearch";
            this.tbClientNumberToSearch.Size = new System.Drawing.Size(208, 20);
            this.tbClientNumberToSearch.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Client Id (A110)";
            // 
            // bSearchNumber
            // 
            this.bSearchNumber.Location = new System.Drawing.Point(440, 36);
            this.bSearchNumber.Name = "bSearchNumber";
            this.bSearchNumber.Size = new System.Drawing.Size(158, 23);
            this.bSearchNumber.TabIndex = 22;
            this.bSearchNumber.Text = "Search on Client Number";
            this.bSearchNumber.UseVisualStyleBackColor = true;
            this.bSearchNumber.Click += new System.EventHandler(this.BSearchNumber_Click);
            // 
            // listBoxCustomersFound
            // 
            this.listBoxCustomersFound.FormattingEnabled = true;
            this.listBoxCustomersFound.Location = new System.Drawing.Point(24, 93);
            this.listBoxCustomersFound.Name = "listBoxCustomersFound";
            this.listBoxCustomersFound.Size = new System.Drawing.Size(574, 108);
            this.listBoxCustomersFound.TabIndex = 21;
            // 
            // tbPostalCodeToSearch
            // 
            this.tbPostalCodeToSearch.Location = new System.Drawing.Point(163, 8);
            this.tbPostalCodeToSearch.Name = "tbPostalCodeToSearch";
            this.tbPostalCodeToSearch.Size = new System.Drawing.Size(208, 20);
            this.tbPostalCodeToSearch.TabIndex = 20;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(28, 11);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(98, 13);
            this.labelPlace.TabIndex = 19;
            this.labelPlace.Text = "Postal Code (A107)";
            // 
            // bSearchPostalCode
            // 
            this.bSearchPostalCode.Location = new System.Drawing.Point(440, 6);
            this.bSearchPostalCode.Name = "bSearchPostalCode";
            this.bSearchPostalCode.Size = new System.Drawing.Size(158, 23);
            this.bSearchPostalCode.TabIndex = 18;
            this.bSearchPostalCode.Text = "Search on Postal Code";
            this.bSearchPostalCode.UseVisualStyleBackColor = true;
            this.bSearchPostalCode.Click += new System.EventHandler(this.BSearchPostalCode_Click);
            // 
            // tbNewA107
            // 
            this.tbNewA107.Enabled = false;
            this.tbNewA107.Location = new System.Drawing.Point(240, 301);
            this.tbNewA107.Name = "tbNewA107";
            this.tbNewA107.Size = new System.Drawing.Size(208, 20);
            this.tbNewA107.TabIndex = 33;
            // 
            // lblNewPostalcode
            // 
            this.lblNewPostalcode.AutoSize = true;
            this.lblNewPostalcode.Enabled = false;
            this.lblNewPostalcode.Location = new System.Drawing.Point(237, 285);
            this.lblNewPostalcode.Name = "lblNewPostalcode";
            this.lblNewPostalcode.Size = new System.Drawing.Size(98, 13);
            this.lblNewPostalcode.TabIndex = 32;
            this.lblNewPostalcode.Text = "Postal Code (A107)";
            // 
            // tbNewA100
            // 
            this.tbNewA100.Enabled = false;
            this.tbNewA100.Location = new System.Drawing.Point(240, 262);
            this.tbNewA100.Name = "tbNewA100";
            this.tbNewA100.Size = new System.Drawing.Size(208, 20);
            this.tbNewA100.TabIndex = 31;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Enabled = false;
            this.lblNewName.Location = new System.Drawing.Point(237, 246);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(98, 13);
            this.lblNewName.TabIndex = 30;
            this.lblNewName.Text = "Client Name (A100)";
            // 
            // tbNewA110
            // 
            this.tbNewA110.Enabled = false;
            this.tbNewA110.Location = new System.Drawing.Point(240, 223);
            this.tbNewA110.Name = "tbNewA110";
            this.tbNewA110.Size = new System.Drawing.Size(208, 20);
            this.tbNewA110.TabIndex = 29;
            // 
            // lblNewID
            // 
            this.lblNewID.AutoSize = true;
            this.lblNewID.Enabled = false;
            this.lblNewID.Location = new System.Drawing.Point(237, 207);
            this.lblNewID.Name = "lblNewID";
            this.lblNewID.Size = new System.Drawing.Size(50, 13);
            this.lblNewID.TabIndex = 28;
            this.lblNewID.Text = "Id (A110)";
            // 
            // tbNewA108
            // 
            this.tbNewA108.Enabled = false;
            this.tbNewA108.Location = new System.Drawing.Point(239, 342);
            this.tbNewA108.Name = "tbNewA108";
            this.tbNewA108.Size = new System.Drawing.Size(208, 20);
            this.tbNewA108.TabIndex = 35;
            // 
            // lblNewPlace
            // 
            this.lblNewPlace.AutoSize = true;
            this.lblNewPlace.Enabled = false;
            this.lblNewPlace.Location = new System.Drawing.Point(237, 324);
            this.lblNewPlace.Name = "lblNewPlace";
            this.lblNewPlace.Size = new System.Drawing.Size(68, 13);
            this.lblNewPlace.TabIndex = 34;
            this.lblNewPlace.Text = "Place (A108)";
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.Enabled = false;
            this.btnAddNewClient.Location = new System.Drawing.Point(24, 207);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Size = new System.Drawing.Size(207, 30);
            this.btnAddNewClient.TabIndex = 36;
            this.btnAddNewClient.Text = "Add New Client";
            this.btnAddNewClient.UseVisualStyleBackColor = true;
            this.btnAddNewClient.Click += new System.EventHandler(this.BtnAddNewClient_Click);
            // 
            // btnMarntList
            // 
            this.btnMarntList.Enabled = false;
            this.btnMarntList.Location = new System.Drawing.Point(241, 210);
            this.btnMarntList.Name = "btnMarntList";
            this.btnMarntList.Size = new System.Drawing.Size(125, 50);
            this.btnMarntList.TabIndex = 37;
            this.btnMarntList.Text = "Update Customers, Contracts and Invoices";
            this.btnMarntList.UseVisualStyleBackColor = true;
            this.btnMarntList.Click += new System.EventHandler(this.BtnMarntList_Click);
            // 
            // lblMarDataLocatie
            // 
            this.lblMarDataLocatie.AutoSize = true;
            this.lblMarDataLocatie.Location = new System.Drawing.Point(9, 10);
            this.lblMarDataLocatie.Name = "lblMarDataLocatie";
            this.lblMarDataLocatie.Size = new System.Drawing.Size(65, 13);
            this.lblMarDataLocatie.TabIndex = 74;
            this.lblMarDataLocatie.Text = "? marnt.mdv";
            this.lblMarDataLocatie.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnChangeMarNTLocation
            // 
            this.btnChangeMarNTLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeMarNTLocation.Location = new System.Drawing.Point(76, 9);
            this.btnChangeMarNTLocation.Name = "btnChangeMarNTLocation";
            this.btnChangeMarNTLocation.Size = new System.Drawing.Size(41, 22);
            this.btnChangeMarNTLocation.TabIndex = 73;
            this.btnChangeMarNTLocation.Text = "...";
            this.btnChangeMarNTLocation.UseVisualStyleBackColor = true;
            this.btnChangeMarNTLocation.Click += new System.EventHandler(this.BtnChangeMarNTLocation_Click);
            // 
            // tbMarLocatie
            // 
            this.tbMarLocatie.Location = new System.Drawing.Point(123, 6);
            this.tbMarLocatie.Multiline = true;
            this.tbMarLocatie.Name = "tbMarLocatie";
            this.tbMarLocatie.Size = new System.Drawing.Size(505, 30);
            this.tbMarLocatie.TabIndex = 72;
            // 
            // btnResetMarntCCI
            // 
            this.btnResetMarntCCI.Location = new System.Drawing.Point(12, 168);
            this.btnResetMarntCCI.Name = "btnResetMarntCCI";
            this.btnResetMarntCCI.Size = new System.Drawing.Size(105, 32);
            this.btnResetMarntCCI.TabIndex = 75;
            this.btnResetMarntCCI.Text = "Reset marnt sync";
            this.btnResetMarntCCI.UseVisualStyleBackColor = true;
            this.btnResetMarntCCI.Click += new System.EventHandler(this.BtnResetMarntCCI_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "? local sqlserver";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCheckLocalSqlServer
            // 
            this.btnCheckLocalSqlServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckLocalSqlServer.Location = new System.Drawing.Point(41, 70);
            this.btnCheckLocalSqlServer.Name = "btnCheckLocalSqlServer";
            this.btnCheckLocalSqlServer.Size = new System.Drawing.Size(76, 22);
            this.btnCheckLocalSqlServer.TabIndex = 77;
            this.btnCheckLocalSqlServer.Text = "Remember";
            this.btnCheckLocalSqlServer.UseVisualStyleBackColor = true;
            this.btnCheckLocalSqlServer.Click += new System.EventHandler(this.BtnCheckLocalSqlServer_Click);
            // 
            // tbLocalConnectionstring
            // 
            this.tbLocalConnectionstring.Location = new System.Drawing.Point(123, 42);
            this.tbLocalConnectionstring.Multiline = true;
            this.tbLocalConnectionstring.Name = "tbLocalConnectionstring";
            this.tbLocalConnectionstring.Size = new System.Drawing.Size(505, 50);
            this.tbLocalConnectionstring.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "? hosted sqlserver";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCheckHostedSqlServer
            // 
            this.btnCheckHostedSqlServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckHostedSqlServer.Location = new System.Drawing.Point(41, 140);
            this.btnCheckHostedSqlServer.Name = "btnCheckHostedSqlServer";
            this.btnCheckHostedSqlServer.Size = new System.Drawing.Size(76, 22);
            this.btnCheckHostedSqlServer.TabIndex = 80;
            this.btnCheckHostedSqlServer.Text = "Remember";
            this.btnCheckHostedSqlServer.UseVisualStyleBackColor = true;
            this.btnCheckHostedSqlServer.Click += new System.EventHandler(this.BtnCheckHostedSqlServer_Click);
            // 
            // tbHostedConnectionstring
            // 
            this.tbHostedConnectionstring.Location = new System.Drawing.Point(123, 100);
            this.tbHostedConnectionstring.Multiline = true;
            this.tbHostedConnectionstring.Name = "tbHostedConnectionstring";
            this.tbHostedConnectionstring.Size = new System.Drawing.Size(505, 62);
            this.tbHostedConnectionstring.TabIndex = 79;
            // 
            // btnUpdateCheck
            // 
            this.btnUpdateCheck.Location = new System.Drawing.Point(241, 168);
            this.btnUpdateCheck.Name = "btnUpdateCheck";
            this.btnUpdateCheck.Size = new System.Drawing.Size(125, 32);
            this.btnUpdateCheck.TabIndex = 82;
            this.btnUpdateCheck.Text = "Check Customers";
            this.btnUpdateCheck.UseVisualStyleBackColor = true;
            this.btnUpdateCheck.Click += new System.EventHandler(this.BtnUpdateCheck_Click);
            // 
            // btnUpdateAccounts
            // 
            this.btnUpdateAccounts.Location = new System.Drawing.Point(372, 168);
            this.btnUpdateAccounts.Name = "btnUpdateAccounts";
            this.btnUpdateAccounts.Size = new System.Drawing.Size(125, 32);
            this.btnUpdateAccounts.TabIndex = 83;
            this.btnUpdateAccounts.Text = "Check Jounal";
            this.btnUpdateAccounts.UseVisualStyleBackColor = true;
            this.btnUpdateAccounts.Click += new System.EventHandler(this.BtnUpdateAccounts_Click);
            // 
            // btnAccountsList
            // 
            this.btnAccountsList.Enabled = false;
            this.btnAccountsList.Location = new System.Drawing.Point(372, 210);
            this.btnAccountsList.Name = "btnAccountsList";
            this.btnAccountsList.Size = new System.Drawing.Size(125, 50);
            this.btnAccountsList.TabIndex = 84;
            this.btnAccountsList.Text = "Update Accounts and Daybook";
            this.btnAccountsList.UseVisualStyleBackColor = true;
            this.btnAccountsList.Click += new System.EventHandler(this.BtnAccountsList_Click);
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Location = new System.Drawing.Point(17, 21);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(73, 17);
            this.rbLocal.TabIndex = 85;
            this.rbLocal.Text = "Use Local";
            this.rbLocal.UseVisualStyleBackColor = true;
            this.rbLocal.CheckedChanged += new System.EventHandler(this.RbLocal_CheckedChanged);
            // 
            // rbHosted
            // 
            this.rbHosted.AutoSize = true;
            this.rbHosted.Location = new System.Drawing.Point(96, 21);
            this.rbHosted.Name = "rbHosted";
            this.rbHosted.Size = new System.Drawing.Size(81, 17);
            this.rbHosted.TabIndex = 86;
            this.rbHosted.Text = "Use Hosted";
            this.rbHosted.UseVisualStyleBackColor = true;
            this.rbHosted.CheckedChanged += new System.EventHandler(this.RbHosted_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLocal);
            this.groupBox1.Controls.Add(this.rbHosted);
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 52);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Server";
            // 
            // tabQR
            // 
            this.tabQR.Controls.Add(this.tabPage1);
            this.tabQR.Controls.Add(this.tabPage3);
            this.tabQR.Controls.Add(this.tabPage4);
            this.tabQR.Controls.Add(this.tabPage2);
            this.tabQR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabQR.Location = new System.Drawing.Point(0, 0);
            this.tabQR.Name = "tabQR";
            this.tabQR.SelectedIndex = 0;
            this.tabQR.Size = new System.Drawing.Size(652, 419);
            this.tabQR.TabIndex = 88;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSPCreation);
            this.tabPage1.Controls.Add(this.btnSuppliersList);
            this.tabPage1.Controls.Add(this.btnCheckSuppliers);
            this.tabPage1.Controls.Add(this.tbHostedConnectionstring);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnMarntList);
            this.tabPage1.Controls.Add(this.btnAccountsList);
            this.tabPage1.Controls.Add(this.tbMarLocatie);
            this.tabPage1.Controls.Add(this.btnUpdateAccounts);
            this.tabPage1.Controls.Add(this.btnChangeMarNTLocation);
            this.tabPage1.Controls.Add(this.btnUpdateCheck);
            this.tabPage1.Controls.Add(this.lblMarDataLocatie);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnResetMarntCCI);
            this.tabPage1.Controls.Add(this.btnCheckHostedSqlServer);
            this.tabPage1.Controls.Add(this.tbLocalConnectionstring);
            this.tabPage1.Controls.Add(this.btnCheckLocalSqlServer);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(644, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSPCreation
            // 
            this.btnSPCreation.Location = new System.Drawing.Point(123, 168);
            this.btnSPCreation.Name = "btnSPCreation";
            this.btnSPCreation.Size = new System.Drawing.Size(105, 32);
            this.btnSPCreation.TabIndex = 93;
            this.btnSPCreation.Text = "StoredProcedures";
            this.btnSPCreation.UseVisualStyleBackColor = true;
            this.btnSPCreation.Click += new System.EventHandler(this.BtnSPCreation_Click);
            // 
            // btnSuppliersList
            // 
            this.btnSuppliersList.Enabled = false;
            this.btnSuppliersList.Location = new System.Drawing.Point(503, 210);
            this.btnSuppliersList.Name = "btnSuppliersList";
            this.btnSuppliersList.Size = new System.Drawing.Size(125, 50);
            this.btnSuppliersList.TabIndex = 89;
            this.btnSuppliersList.Text = "Update Suppliers and Invoices";
            this.btnSuppliersList.UseVisualStyleBackColor = true;
            this.btnSuppliersList.Click += new System.EventHandler(this.BtnSuppliersList_Click);
            // 
            // btnCheckSuppliers
            // 
            this.btnCheckSuppliers.Location = new System.Drawing.Point(503, 168);
            this.btnCheckSuppliers.Name = "btnCheckSuppliers";
            this.btnCheckSuppliers.Size = new System.Drawing.Size(125, 32);
            this.btnCheckSuppliers.TabIndex = 88;
            this.btnCheckSuppliers.Text = "Check Suppliers";
            this.btnCheckSuppliers.UseVisualStyleBackColor = true;
            this.btnCheckSuppliers.Click += new System.EventHandler(this.BtnCheckSuppliers_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDemoContent);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtQRCode);
            this.tabPage3.Controls.Add(this.pic);
            this.tabPage3.Controls.Add(this.btnGenerate);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(644, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "QR Code Generator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDemoContent
            // 
            this.btnDemoContent.Location = new System.Drawing.Point(8, 328);
            this.btnDemoContent.Name = "btnDemoContent";
            this.btnDemoContent.Size = new System.Drawing.Size(93, 23);
            this.btnDemoContent.TabIndex = 5;
            this.btnDemoContent.Text = "Demo Content";
            this.btnDemoContent.UseVisualStyleBackColor = true;
            this.btnDemoContent.Click += new System.EventHandler(this.BtnDemoContent_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Text Content";
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(8, 41);
            this.txtQRCode.Multiline = true;
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Size = new System.Drawing.Size(280, 281);
            this.txtQRCode.TabIndex = 3;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Location = new System.Drawing.Point(294, 41);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(342, 281);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(213, 328);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "QR Code";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnStopScan);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.cboCamera);
            this.tabPage4.Controls.Add(this.pictureBox);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.txtBarcode);
            this.tabPage4.Controls.Add(this.btnStartScan);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(644, 393);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Barcode Reader";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Camera:";
            // 
            // cboCamera
            // 
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(75, 29);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(375, 21);
            this.cboCamera.TabIndex = 4;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(11, 56);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(439, 282);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Barcode:";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(64, 344);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(295, 20);
            this.txtBarcode.TabIndex = 1;
            // 
            // btnStartScan
            // 
            this.btnStartScan.Location = new System.Drawing.Point(375, 344);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(75, 23);
            this.btnStartScan.TabIndex = 0;
            this.btnStartScan.Text = "Start";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxCustomersFound);
            this.tabPage2.Controls.Add(this.bSearchPostalCode);
            this.tabPage2.Controls.Add(this.btnAddNewClient);
            this.tabPage2.Controls.Add(this.labelPlace);
            this.tabPage2.Controls.Add(this.tbNewA108);
            this.tabPage2.Controls.Add(this.tbPostalCodeToSearch);
            this.tabPage2.Controls.Add(this.lblNewPlace);
            this.tabPage2.Controls.Add(this.bSearchNumber);
            this.tabPage2.Controls.Add(this.tbNewA107);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblNewPostalcode);
            this.tabPage2.Controls.Add(this.tbClientNumberToSearch);
            this.tabPage2.Controls.Add(this.tbNewA100);
            this.tabPage2.Controls.Add(this.bSearchPlace);
            this.tabPage2.Controls.Add(this.lblNewName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbNewA110);
            this.tabPage2.Controls.Add(this.tbPlaceToSearch);
            this.tabPage2.Controls.Add(this.lblNewID);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(644, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SQL Test";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnStopScan
            // 
            this.btnStopScan.Location = new System.Drawing.Point(456, 344);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(75, 23);
            this.btnStopScan.TabIndex = 6;
            this.btnStopScan.Text = "Stop";
            this.btnStopScan.UseVisualStyleBackColor = true;
            this.btnStopScan.Click += new System.EventHandler(this.BtnStopScan_Click);
            // 
            // FrmMarioApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 419);
            this.Controls.Add(this.tabQR);
            this.Name = "FrmMarioApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMarioApp_FormClosing);
            this.Load += new System.EventHandler(this.FrmMarioApp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabQR.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlaceToSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSearchPlace;
        private System.Windows.Forms.TextBox tbClientNumberToSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSearchNumber;
        private System.Windows.Forms.ListBox listBoxCustomersFound;
        private System.Windows.Forms.TextBox tbPostalCodeToSearch;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button bSearchPostalCode;
        private System.Windows.Forms.TextBox tbNewA107;
        private System.Windows.Forms.Label lblNewPostalcode;
        private System.Windows.Forms.TextBox tbNewA100;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.TextBox tbNewA110;
        private System.Windows.Forms.Label lblNewID;
        private System.Windows.Forms.TextBox tbNewA108;
        private System.Windows.Forms.Label lblNewPlace;
        private System.Windows.Forms.Button btnAddNewClient;
        private System.Windows.Forms.Button btnMarntList;
        internal System.Windows.Forms.Label lblMarDataLocatie;
        internal System.Windows.Forms.Button btnChangeMarNTLocation;
        internal System.Windows.Forms.TextBox tbMarLocatie;
        private System.Windows.Forms.Button btnResetMarntCCI;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button btnCheckLocalSqlServer;
        internal System.Windows.Forms.TextBox tbLocalConnectionstring;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnCheckHostedSqlServer;
        internal System.Windows.Forms.TextBox tbHostedConnectionstring;
        private System.Windows.Forms.Button btnUpdateCheck;
        private System.Windows.Forms.Button btnUpdateAccounts;
        private System.Windows.Forms.Button btnAccountsList;
        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.RadioButton rbHosted;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabQR;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCheckSuppliers;
        private System.Windows.Forms.Button btnSuppliersList;
        private System.Windows.Forms.Button btnSPCreation;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDemoContent;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Button btnStopScan;
    }
}

