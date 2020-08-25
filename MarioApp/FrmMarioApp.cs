using System;
using System.Collections.Generic;
using System.Data.OleDb;
using ADODB;
using System.Windows.Forms;
using QRCoder;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Drawing;
using ZXing;

namespace MarioApp
{
    public partial class FrmMarioApp : Form
    {
        // private string dbTB2Locatie = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=\\JOS-HP\\Users\\Jos\\Documents\telebib2.mdb;";

        // private string dbQualifierSQL = "SELECT * FROM A_DE_QUALIFIANT";
        // private string dbDocumentenSQL = "select * from Dokumenten where dnnSyncAlready = False";
        // private string dbUDocumentenSQL = "select * from Dokumenten where dnnSync = False";        
        // private string dbBriefwisselingSQL = "select * from Briefwisseling where dnnSyncAlready = False";
        // private string dbAllerleiSQL = "select * from Allerlei where dnnSyncAlready = False";
        // private string dbTB2SQL = "select * from TB2 where dnnSyncAlready = False";
        // private string dbProductenSQL = "select * from Produkten where dnnSyncAlready = False";

        public string dbJetProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=";
        public string dbmarLocatie = "";

        public string dbKlantenSQLUpdate = "select * from Klanten where dnnSyncAlready = True and dnnSync = False";
        public string dbKlantenSQLNieuw = "select * from Klanten where dnnSyncAlready = False";
        public string dbContractenSQLUpdate = "select * from Polissen where dnnSyncAlready = True and dnnSync = False";
        public string dbContractenSQLnieuw = "select * from Polissen where dnnSyncAlready = False";
        public string dbTelebibContractenSQLnieuw = "select * from TB2 where dnnSyncAlready = False AND (DocType = '01' OR DocType = '02')";
        public string dbTelebibContractenSQLUpdate = "select * from TB2 where (dnnSyncAlready = True AND dnnSync = False) AND (DocType = '01' OR DocType = '02')";
        public string dbCustomerInvoicesSQLUpdate = "select * from Dokumenten where dnnSyncAlready = True and dnnSync = False and v034 like 'K%'";
        public string dbCustomerInvoicesSQLnieuw = "select * from Dokumenten where dnnSyncAlready = False and v034 like 'K%'";

        public string dbRekeningenSQLUpdate = "select * from Rekeningen where dnnSyncAlready = True and dnnSync = False";
        public string dbRekeningenSQLNieuw = "select * from Rekeningen where dnnSyncAlready = False";
        public string dbJournalenSQLUpdate = "select * from Journalen where dnnSyncAlready = True and dnnSync = False";
        public string dbJournalenSQLNieuw = "select * from Journalen where dnnSyncAlready = False";

        public string dbLeveranciersSQLUpdate = "select * from Leveranciers where dnnSyncAlready = True and dnnSync = False";
        public string dbLeveranciersSQLNieuw = "select * from Leveranciers where dnnSyncAlready = False";
        public string dbSupplierInvoicesSQLUpdate = "select * from Dokumenten where dnnSyncAlready = True and dnnSync = False and v034 like 'L%'";
        public string dbSupplierInvoicesSQLnieuw = "select * from Dokumenten where dnnSyncAlready = False and v034 like 'L%'";

        public string dbQualifiersSQL = "select * from A_DE_QUALIFIANT";
        public string dbValeursSQL = "select * from VALEUR";

        public string cnnChosen = "";

        List<VsoftCustomer> customers = new List<VsoftCustomer>();

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        public FrmMarioApp()
        {
            InitializeComponent();
            UpdateBinding();            
        }

        private void UpdateBinding()
        {
            listBoxCustomersFound.DataSource = customers;
            listBoxCustomersFound.DisplayMember = "SelectedInfo";
        }

        private void FrmMarioApp_Load(object sender, EventArgs e)
        {
            try            
            {
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo device in filterInfoCollection)
                    cboCamera.Items.Add(device.Name);
                cboCamera.SelectedIndex = 0;
            }
            catch (Exception)
            {
                // throw;
                btnStartScan.Enabled = false;
                btnStopScan.Enabled = false;
                cboCamera.Items.Add("No webcam detected");
                cboCamera.SelectedIndex = 0;
            }                                 

            Text = "Mario";
            tbMarLocatie.Text = Properties.Settings.Default.MdvSetting;
            tbLocalConnectionstring.Text = Properties.Settings.Default.LocalSQLSetting;
            tbHostedConnectionstring.Text = Properties.Settings.Default.HostedSQLSetting;
            // rbLocal.Checked = true;
        }

        private void BSearchPostalCode_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            customers = db.GetCustomersByA107(tbPostalCodeToSearch.Text, cnnChosen);
            UpdateBinding();
        }

        private void BSearchNumber_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            customers = db.GetCustomersById(tbClientNumberToSearch.Text, cnnChosen);
            UpdateBinding();
        }

        private void BSearchPlace_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            customers = db.GetCustomersByA108(tbPlaceToSearch.Text, cnnChosen);
            UpdateBinding();
        }

        private void BtnAddNewClient_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertCustomer(tbNewA110.Text, tbNewA100.Text, tbNewA107.Text, tbNewA108.Text, cnnChosen);
            tbNewA110.Text = "";
            tbNewA100.Text = "";
            tbNewA107.Text = "";
            tbNewA108.Text = "";
        }

        private void BtnChangeMarNTLocation_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog MarntOpenFileDialog = new OpenFileDialog())
            {
                MarntOpenFileDialog.InitialDirectory = "c:\\";
                MarntOpenFileDialog.Filter = "mdv files (*.mdv)|*.mdv|All files (*.*)|*.*";
                MarntOpenFileDialog.FilterIndex = 1;
                MarntOpenFileDialog.RestoreDirectory = true;

                if (MarntOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // string fileContent; // = string.Empty;
                    string filePath; // = string.Empty;

                    //Get the path of specified file
                    filePath = MarntOpenFileDialog.FileName;
                    tbMarLocatie.Text = dbJetProvider + MarntOpenFileDialog.FileName;
                    btnChangeMarNTLocation.Text = "OK";
                    tbMarLocatie.Enabled = false;
                    _ = MessageBox.Show("File at path: " + filePath);

                    Properties.Settings.Default.MdvSetting = tbMarLocatie.Text;
                }
            }
        }

        private void BtnMarntList_Click(object sender, EventArgs e)
        {
            // Customers
            MessageBox.Show("Start update customers. For every 2000 records moving to hosting account it will take one or more minutes");
            Cursor.Current = Cursors.WaitCursor;

            DataCustomers dbCustomers = new DataCustomers();
            dbCustomers.CustomersInsertAndUpdate(tbMarLocatie.Text, dbKlantenSQLNieuw, dbKlantenSQLUpdate, cnnChosen);

            Cursor.Current = Cursors.Default;
            MessageBox.Show("Update customers finished");

            // Contracts
            MessageBox.Show("Start update contracts For every 2000 records moving to hosting account it will take one or more minutes");
            Cursor.Current = Cursors.WaitCursor;

            DataContracts dbContracts = new DataContracts();
            dbContracts.ContractsInsertAndUpdate(tbMarLocatie.Text, dbContractenSQLnieuw, dbContractenSQLUpdate, cnnChosen);

            Cursor.Current = Cursors.Default;
            MessageBox.Show("Update contracts finished");

            // Customer Invoices
            MessageBox.Show("Start update customer invoices For every 2000 records moving to hosting account it will take one or more minutes");
            Cursor.Current = Cursors.WaitCursor;

            DataCustomerInvoices dbCustomerInvoices = new DataCustomerInvoices();
            dbCustomerInvoices.CustomerInvoicesInsertAndUpdate(tbMarLocatie.Text, dbCustomerInvoicesSQLnieuw, dbCustomerInvoicesSQLUpdate, cnnChosen);


            Cursor.Current = Cursors.Default;
            MessageBox.Show("Update customer invoices finished");

            // Telebib Contracts
            MessageBox.Show("Start update telebibcontracts For every 2000 records moving to hosting account it will take one or more minutes");
            Cursor.Current = Cursors.WaitCursor;

            DataTelebibContracts dbTelebibContracts = new DataTelebibContracts();
            dbTelebibContracts.TelebibContractsInsertAndUpdate(tbMarLocatie.Text, dbTelebibContractenSQLnieuw, dbTelebibContractenSQLUpdate, cnnChosen);

            Cursor.Current = Cursors.Default;
            MessageBox.Show("Update telebibcontracts finished");
        }

        private void BtnResetMarntCCI_Click(object sender, EventArgs e)
        {
            const string message = "marIntegraal ALLE tabellen resetten voor export. Bent U zeker?";
            const string caption = "MarNT Data Export";
            DialogResult result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                try
                {
                    MessageBox.Show("Start reset sync");
                    OleDbConnection cnnMarJet = new OleDbConnection
                    {
                        ConnectionString = tbMarLocatie.Text
                    };
                    Cursor.Current = Cursors.WaitCursor;
                    cnnMarJet.Open();
                    OleDbCommand commandK = new OleDbCommand("UPDATE Klanten SET dnnSyncAlready = False, dnnSync = False", cnnMarJet);
                    _ = commandK.ExecuteNonQuery();

                    OleDbCommand commandP = new OleDbCommand("UPDATE Polissen SET dnnSyncAlready = False, dnnSync = False", cnnMarJet);
                    _ = commandP.ExecuteNonQuery();

                    OleDbCommand commandT = new OleDbCommand("UPDATE TB2 SET dnnSync = False, dnnSyncAlready = False", cnnMarJet);
                    _ = commandT.ExecuteNonQuery();

                    OleDbCommand commandDK = new OleDbCommand("UPDATE Dokumenten SET dnnSync = False, dnnSyncAlready = False where v034 like 'K%'", cnnMarJet);
                    _ = commandDK.ExecuteNonQuery();

                    OleDbCommand commandR = new OleDbCommand("UPDATE Rekeningen SET dnnSyncAlready = False, dnnSync = False", cnnMarJet);
                    _ = commandR.ExecuteNonQuery();

                    OleDbCommand commandJ = new OleDbCommand("UPDATE Journalen SET dnnSyncAlready = False, dnnSync = False", cnnMarJet);
                    _ = commandJ.ExecuteNonQuery();

                    OleDbCommand commandL = new OleDbCommand("UPDATE Leveranciers SET dnnSyncAlready = False, dnnSync = False", cnnMarJet);
                    _ = commandL.ExecuteNonQuery();

                    OleDbCommand commandDL = new OleDbCommand("UPDATE Dokumenten SET dnnSync = False, dnnSyncAlready = False where v034 like 'L%'", cnnMarJet);
                    _ = commandDL.ExecuteNonQuery();


                    cnnMarJet.Close();
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("End reset sync");
                }
                catch (Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    _ = MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnUpdateCheck_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            Recordset rs = new Recordset();

            string cnStr = tbMarLocatie.Text;
            string result = "";

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cn.Open(cnStr, null, null, 0);
                string countRs = "";

                // New clients
                string query = dbKlantenSQLNieuw;
                rs.Open(query, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic, -1);
                countRs = rs.RecordCount.ToString();
                result = result + "Nieuwe klanten: " + countRs + Environment.NewLine;
                rs.Close();

                // Update clients
                query = dbKlantenSQLUpdate;
                rs.Open(query, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic, -1);
                countRs = rs.RecordCount.ToString();
                result = result + "Update klanten: " + countRs + Environment.NewLine + Environment.NewLine;
                rs.Close();

                // New contracts
                query = dbContractenSQLnieuw;
                rs.Open(query, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic, -1);
                countRs = rs.RecordCount.ToString();
                result = result + "Nieuwe contracten: " + countRs + Environment.NewLine;
                rs.Close();

                // Update contracts
                query = dbContractenSQLUpdate;
                rs.Open(query, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic, -1);
                countRs = rs.RecordCount.ToString();
                result = result + "Update contracten: " + countRs + Environment.NewLine + Environment.NewLine;
                rs.Close();

                // New customerinvoices
                query = dbCustomerInvoicesSQLnieuw;
                rs.Open(query, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic, -1);
                countRs = rs.RecordCount.ToString();
                result = result + "Nieuwe klantfacturen: " + countRs + Environment.NewLine;
                rs.Close();

                // New customerinvoices
                query = dbCustomerInvoicesSQLUpdate;
                rs.Open(query, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic, -1);
                countRs = rs.RecordCount.ToString();
                result = result + "Update klantfacturen: " + countRs + Environment.NewLine;
                rs.Close();

                // New telebibcontracts
                query = dbTelebibContractenSQLnieuw;
                rs.Open(query, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic, -1);
                countRs = rs.RecordCount.ToString();
                result = result + "Nieuwe telebibcontracten: " + countRs + Environment.NewLine;
                rs.Close();

                // Update telebibcontracts
                query = dbTelebibContractenSQLUpdate;
                rs.Open(query, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic, -1);
                countRs = rs.RecordCount.ToString();
                result = result + "Update telebibcontracten: " + countRs + Environment.NewLine + Environment.NewLine;
                rs.Close();
                cn.Close();
                Cursor.Current = Cursors.Default;

                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdateAccounts_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            Recordset rs = new Recordset();

            string cnStr = tbMarLocatie.Text;
            string result = "";

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cn.Open(cnStr, null, null, 0);
                string countRs = "";

                // New accounts
                string query = dbRekeningenSQLNieuw;
                rs.Open(query, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic, -1);
                countRs = rs.RecordCount.ToString();
                result = result + "Nieuwe rekeningen: " + countRs + Environment.NewLine;
                rs.Close();

                // Update accounts
                query = dbRekeningenSQLUpdate;
                rs.Open(query, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic, -1);
                countRs = rs.RecordCount.ToString();
                result = result + "Update rekeningen: " + countRs + Environment.NewLine + Environment.NewLine;
                rs.Close();

                // New daybooks
                query = dbJournalenSQLNieuw;
                rs.Open(query, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic, -1);
                countRs = rs.RecordCount.ToString();
                result = result + "Nieuwe journalen: " + countRs + Environment.NewLine;
                rs.Close();

                // Update daybooks
                query = dbJournalenSQLUpdate;
                rs.Open(query, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic, -1);
                countRs = rs.RecordCount.ToString();
                result = result + "Update journalen: " + countRs + Environment.NewLine + Environment.NewLine;
                rs.Close();
                cn.Close();
                Cursor.Current = Cursors.Default;

                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAccountsList_Click(object sender, EventArgs e)
        {
            // Accounts
            MessageBox.Show("Start update accounts. For every 2000 records moving to hosting account it will take one or more minutes");
            Cursor.Current = Cursors.WaitCursor;

            DataLedgerAccounts dbAccounts = new DataLedgerAccounts();
            dbAccounts.LedgerAccountsInsertAndUpdate(tbMarLocatie.Text, dbRekeningenSQLNieuw, dbRekeningenSQLUpdate, cnnChosen);

            Cursor.Current = Cursors.Default;
            MessageBox.Show("Update accounts finished");

            // DayBooks
            MessageBox.Show("Start update daybooks. For every 2000 records moving to hosting account it will take one or more minutes");
            Cursor.Current = Cursors.WaitCursor;

            DataLedgers dbDayBooks = new DataLedgers();
            dbDayBooks.LedgersInsertAndUpdate(tbMarLocatie.Text, dbJournalenSQLNieuw, dbJournalenSQLUpdate, cnnChosen);

            Cursor.Current = Cursors.Default;
            MessageBox.Show("Update daybooks finished");
        }

        private void BtnCheckLocalSqlServer_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LocalSQLSetting = tbLocalConnectionstring.Text;
        }

        private void BtnCheckHostedSqlServer_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HostedSQLSetting = tbHostedConnectionstring.Text;
        }

        private void RbHosted_CheckedChanged(object sender, EventArgs e)
        {
            cnnChosen = tbHostedConnectionstring.Text;
            btnAccountsList.Enabled = true;
            btnMarntList.Enabled = true;
            btnSuppliersList.Enabled = true;
        }

        private void RbLocal_CheckedChanged(object sender, EventArgs e)
        {
            cnnChosen = tbLocalConnectionstring.Text;
            btnAccountsList.Enabled = true;
            btnMarntList.Enabled = true;
            btnSuppliersList.Enabled = true;
        }

        private void BtnCheckSuppliers_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            Recordset rs = new Recordset();

            string cnStr = tbMarLocatie.Text;
            string result = "";

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cn.Open(cnStr, null, null, 0);
                string countRs = "";

                // New suppliers
                string query = dbLeveranciersSQLNieuw;
                rs.Open(query, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic, -1);
                countRs = rs.RecordCount.ToString();
                result = result + "Nieuwe leveranciers: " + countRs + Environment.NewLine;
                rs.Close();

                // Update leveranciers
                query = dbLeveranciersSQLUpdate;
                rs.Open(query, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic, -1);
                countRs = rs.RecordCount.ToString();
                result = result + "Update leveranciers " + countRs + Environment.NewLine + Environment.NewLine;
                rs.Close();

                // New suppliersinvoices
                query = dbSupplierInvoicesSQLnieuw;
                rs.Open(query, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic, -1);
                countRs = rs.RecordCount.ToString();
                result = result + "Nieuwe leveranciersfacturen: " + countRs + Environment.NewLine;
                rs.Close();

                // Update suppliersinvoices
                query = dbSupplierInvoicesSQLUpdate;
                rs.Open(query, cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic, -1);
                countRs = rs.RecordCount.ToString();
                result = result + "Update leveranciersfacturen: " + countRs + Environment.NewLine;
                rs.Close();
                cn.Close();
                Cursor.Current = Cursors.Default;

                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSuppliersList_Click(object sender, EventArgs e)
        {
            // Suppliers
            MessageBox.Show("Start update suppliers. For every 2000 records moving to hosting account it will take one or more minutes");
            Cursor.Current = Cursors.WaitCursor;

            DataSuppliers dbSuppliers = new DataSuppliers();
            dbSuppliers.SuppliersInsertAndUpdate(tbMarLocatie.Text, dbLeveranciersSQLNieuw, dbLeveranciersSQLUpdate, cnnChosen);

            Cursor.Current = Cursors.Default;
            MessageBox.Show("Update suppliers finished");

            // Supplier Invoices
            MessageBox.Show("Start update supplier invoices For every 2000 records moving to hosting account it will take one or more minutes");
            Cursor.Current = Cursors.WaitCursor;

            DataSupplierInvoices dbSupplierInvoices = new DataSupplierInvoices();
            dbSupplierInvoices.SupplierInvoicesInsertAndUpdate(tbMarLocatie.Text, dbSupplierInvoicesSQLnieuw, dbSupplierInvoicesSQLUpdate, cnnChosen);

            Cursor.Current = Cursors.Default;
            MessageBox.Show("Update supplier invoices finished");
        }



        private void BtnSPCreation_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog SPPathFileDialog = new OpenFileDialog())
            {
                SPPathFileDialog.InitialDirectory = "c:\\";
                SPPathFileDialog.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*";
                SPPathFileDialog.Multiselect = true;
                SPPathFileDialog.FilterIndex = 1;
                SPPathFileDialog.RestoreDirectory = true;

                if (SPPathFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // string fileContent = string.Empty;
                    string filePath; // = string.Empty;

                    //Get the path of specified file
                    filePath = SPPathFileDialog.FileName;
                    var arrayFileNames = SPPathFileDialog.FileNames;

                    _ = MessageBox.Show("File at path: " + filePath);

                    // Stored procedure creation loop files
                    int myCounter = 0;
                    while (arrayFileNames.Length > myCounter)
                    {
                        MessageBox.Show("Start creating stored procedure: " + arrayFileNames[myCounter]);
                        Cursor.Current = Cursors.WaitCursor;

                        AddstoredProcedures createSP = new AddstoredProcedures();
                        createSP.AddSP(arrayFileNames[myCounter], cnnChosen);

                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("Creation stored procedure finished");

                        myCounter++;
                    }
                }
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {            
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txtQRCode.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pic.Image = code.GetGraphic(5);
        }

        private void BtnDemoContent_Click(object sender, EventArgs e)
        {
            string serviceTagValue = "BCD\n";
            string versionValue = "001\n";
            string charactersetValue = "1\n";
            string identificationValue = "SCT\n";
            string bicValue = "VDSPBE91\n";
            string nameValue = "Roelandt en Vermoesen bv\n";
            string ibanValue = "BE83891854037015\n";
            string amountValue = "EUR394.99\n";
            string purposeValue = "GDDS\n";
            string referenceValue = "107/0404/08059\n";
            string remittanceValue = "\n";
            string informationValue = "\n";

            string qrTMP = serviceTagValue + versionValue + charactersetValue + identificationValue + bicValue + nameValue + ibanValue + amountValue + purposeValue + referenceValue + remittanceValue + informationValue;
            txtQRCode.Text = qrTMP;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            try
            {                
                var result = reader.Decode(bitmap);
                if (result != null)
                {
                    txtBarcode.Invoke(new MethodInvoker(delegate ()
                    {
                        txtBarcode.Text = result.ToString();
                    }));
                }
                pictureBox.Image = bitmap;                
            }
            catch (Exception ex)
            {
                // throw; 
                txtBarcode.Text = ex.Message;
            }           
        }

        private void FrmMarioApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void BtnStopScan_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }
    }
}
