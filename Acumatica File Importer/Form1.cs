using Acumatica;
using Acumatica_File_Importer.Acumatica;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using File = System.IO.File;

namespace Acumatica_File_Importer
{
    public partial class Form1 : Form
    {
        bool isValidStockItem = true;
        string baseURL = "";
        string user = "";
        string password = "";
        string company = "";
        string branch = "";
        string entity = "StockItem";
        bool isImageFile = false;
        List<string> files = new List<string>();

        ///Image uploaded from folder named inventoryCD
        List<string> iifiles = new List<string>();
        ///Image uploaded files name
        List<string> iiInventoryCD = new List<string>();

        ///Image uploaded from folder named inventoryCD
        List<string> reffiles = new List<string>();
        List<string> reffilesPath = new List<string>();
        ///Image uploaded files name
        string vendorReference = "";

        int fileCount = 0;

        AcConfiguration configuration = null;

        //Configuration completed
        bool isConfigured = false;


        private delegate void SetControlPropertyThreadSafeDelegate(
    Control control,
    string propertyName,
    object propertyValue);

        ServiceCollection serviceCollection = null;
        ServiceProvider serviceProvider = null;
        private string csvLocation;

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private string csvfilename;

        public static void SetControlPropertyThreadSafe(
    Control control,
    string propertyName,
    object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlPropertyThreadSafeDelegate
                (SetControlPropertyThreadSafe),
                new object[] { control, propertyName, propertyValue });
            }
            else
            {
                control.GetType().InvokeMember(
                    propertyName,
                    BindingFlags.SetProperty,
                    null,
                    control,
                    new object[] { propertyValue });
            }
        }
        public Form1()
        {
            InitializeComponent();

            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            serviceCollection = new ServiceCollection();
            //ConfigureServices(serviceCollection);

            serviceProvider = serviceCollection.BuildServiceProvider();
            Log.Write("Acumatica File Import Init", "");

            // Folder Path panel
            //panel2.Hide();
            //panel1.BringToFront();

            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height + 10);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            lblbulkIIfileurl.Text = "";
            lblErrorRef.Text = "";
            //manualConfire();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            //progressBar1.Value = ((fileCount / files.Count) * 100);
            // progressBar1.Increment(((fileCount / files.Count) * 100));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imageimport.Checked = true;
            ImagePanel.Show();
            PDFPanel.Hide();
        }

        /// <summary>
        /// Oraganizes upload images
        /// </summary>
        private void ConfigureBIIUploads()
        {
            try
            {
                files.Clear();
                if (!isConfigured)
                {
                    MessageBox.Show(Globals.EMPTYCONFIGURATION);
                    return;
                }

                csvLocation = lblbulkIIfileurl.Text;

                if (!Directory.Exists(csvLocation))
                {
                    MessageBox.Show(Globals.FOLDERNOTEXISTS);
                    return;
                };

                string[] filenames = Directory.GetFiles(csvLocation, ".", SearchOption.AllDirectories);

                foreach (var item in filenames)
                {
                    fileCount = fileCount + 1;
                    files.Add(item);
                }

                if (fileCount == 0)
                {
                    MessageBox.Show(Globals.NOREADBLEFILE);
                    return;
                }

            }
            catch (Exception ex)
            {

                Log.Write(ex.Message, "");
            }
        }

        private void ConfigureIIUploads()
        {
            try
            {
                fileCount = 0;

                if (!isConfigured)
                {
                    MessageBox.Show(Globals.EMPTYCONFIGURATION);
                    return;
                }

                var folderlocation = IIfileurl.Text;
                iifiles.Clear();
                iiInventoryCD.Clear();

                if (!Directory.Exists(folderlocation))
                {
                    MessageBox.Show(Globals.FOLDERNOTEXISTS);
                    return;
                };

                string[] filenames = Directory.GetFiles(folderlocation, ".", SearchOption.AllDirectories);

                foreach (var item in filenames)
                {
                    fileCount = fileCount + 1;
                    var filename = item.Substring(item.LastIndexOf('\\') + 1);
                    iiInventoryCD.Add(filename.Substring(0, filename.LastIndexOf('.')));
                    iifiles.Add(item);
                }

                if (fileCount == 0)
                {
                    MessageBox.Show(Globals.NOREADBLEFILE);
                    return;
                }
            }
            catch (Exception ex)
            {

                Log.Write(ex.Message, "");
            }
        }

        private void ConfigureVendorRefUploads()
        {
            try
            {
                fileCount = 0;

                if (!isConfigured)
                {
                    MessageBox.Show(Globals.EMPTYCONFIGURATION);
                    return;
                }

                var folderlocation = lblErrorRef.Text;
                reffiles.Clear();
                reffilesPath.Clear();

                if (!Directory.Exists(folderlocation))
                {
                    MessageBox.Show(Globals.FOLDERNOTEXISTS);
                    return;
                };

                vendorReference = folderlocation.Substring(folderlocation.LastIndexOf('\\') + 1);

                string[] filenames = Directory.GetFiles(folderlocation, ".", SearchOption.AllDirectories);

                foreach (var item in filenames)
                {
                    fileCount = fileCount + 1;
                    var filename = item.Substring(item.LastIndexOf('\\') + 1);
                    reffiles.Add(filename);
                    reffilesPath.Add(item);
                }

                if (fileCount == 0)
                {
                    MessageBox.Show(Globals.NOREADBLEFILE);
                    return;
                }
            }
            catch (Exception ex)
            {

                Log.Write(ex.Message, "");
            }
        }

        private string CreateCSV(string csvLocation)
        {
            if (string.IsNullOrEmpty(csvLocation)) return "";

            fileCount = 0;
            var csvFileName = "";

            //Folder name as document type
            var orderType = csvLocation.Substring(csvLocation.LastIndexOf("\\") + 1);

            if (!Directory.Exists(csvLocation))
            {
                MessageBox.Show(Globals.FOLDERNOTEXISTS);
                return "";
            };

            string[] filenames = Directory.GetFiles(csvLocation, ".", SearchOption.AllDirectories);


            foreach (var item in filenames)
            {
                if (item.EndsWith(".pdf"))
                {
                    fileCount = fileCount + 1;
                }
            }


            //checks pdf file found 
            if (fileCount == 0)
            {
                MessageBox.Show(Globals.NOREADBLEFILE);
                return "";
            }

            ////Writing CSV File
            //csvFileName = WriteCSV(filenames, Doctype, csvLocation);

            foreach (var item in filenames)
            {
                if (item.EndsWith(".pdf"))
                {
                    string refNumber = item.Substring(item.LastIndexOf("\\") + 1);
                    refNumber = refNumber.Split('.')[0];

                    var key1 = GetRecordType(orderType);

                    var key2 = refNumber;

                    //remove CRM from DocType
                    if (orderType.Contains("CRM") || orderType.Contains("crm"))
                    {
                        key2 = "CRM";
                    }


                }
            }

            files.Clear();

            foreach (string item in Directory.GetFiles(csvLocation))
            {
                if (!item.Contains(".csv"))
                    files.Add(item);
            }


            if (!File.Exists(csvFileName))
            {
                MessageBox.Show(Globals.FAILDETOGENERATECSV);
                return "";
            }

            return csvFileName;

        }

        //private static void ConfigureServices(IServiceCollection services)
        //{
        //    services
        //         .AddTransient<FileImporter>()
        //         .AddTransient<AcumaticaWorker>()
        //         .AddTransient<CsvWorker>();
        //}

        /// <summary>
        /// It write a csv file with keys and file path 
        /// </summary>
        /// <param name="filenames"></param>
        /// <param name="Doctype"></param>
        /// <param name="folderpath"></param>
        /// <returns></returns>
        private string WriteCSV(string[] filenames, string Doctype, string folderpath)
        {

            var csvFileName = folderpath + "\\" + "RecordFile.csv";

            var csv = new StringBuilder();
            foreach (var item in filenames)
            {
                if (!item.EndsWith(".csv") && item.EndsWith(".pdf"))
                {
                    string refNumber = item.Substring(item.LastIndexOf("\\") + 1);
                    refNumber = refNumber.Split('.')[0];


                    var first = Doctype;

                    var second = item;
                    var third = "";

                    var fourth = GetRecordType(Doctype);

                    var fifth = refNumber;
                    var sixth = "";
                    var seventh = "";
                    var eighth = "";
                    var nine = "";

                    //remove CRM from DocType
                    if (first.Contains("CRM") || first.Contains("crm"))
                    {
                        first = first.Replace("CRM", "");
                    }

                    var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}", first, second, third, fourth, fifth, sixth, seventh, eighth, nine);

                    csv.AppendLine(newLine);

                }
            }

            if (!File.Exists(csvFileName))
            {
                File.WriteAllText(csvFileName, csv.ToString());
            }
            else
            {
                File.Delete(csvFileName);
                File.WriteAllText(csvFileName, csv.ToString());
            }
            csv.Clear();

            return csvFileName;
        }

        private string GetEntityType(string Doctype)
        {
            string entityType = "";

            switch (Doctype.ToLower())
            {
                case "salesorder":
                    entityType = ConfigurationManager.AppSettings["ESO"].ToString();
                    break;
                case "arinvoice":
                    entityType = ConfigurationManager.AppSettings["EINV"].ToString();
                    break;
                case "creditmemo":
                    entityType = ConfigurationManager.AppSettings["ECRM"].ToString();
                    break;
                case "apinvoice":
                    entityType = ConfigurationManager.AppSettings["EINV"].ToString();
                    break;
                case "arpayment":
                    entityType = ConfigurationManager.AppSettings["EPAYMENT"].ToString();
                    break;
                case "appayment":
                    entityType = ConfigurationManager.AppSettings["EPAYMENT"].ToString();
                    break;
                case "purchaseorder":
                    entityType = ConfigurationManager.AppSettings["EPO"].ToString();
                    break;

                default:
                    break;
            }

            //  recordType = ConfigurationManager.AppSettings["RecordType"].ToString();

            return entityType;

        }
        private string GetRecordType(string Doctype)
        {
            string recordType = "";

            switch (Doctype.ToLower())
            {
                case "salesorder":
                    recordType = ConfigurationManager.AppSettings["SalesOrder"].ToString();
                    break;
                case "arinvoice":
                    recordType = ConfigurationManager.AppSettings["ARInvoice"].ToString();
                    break;
                case "creditmemo":
                    recordType = ConfigurationManager.AppSettings["CreditMemo"].ToString();
                    break;
                case "apinvoice":
                    recordType = ConfigurationManager.AppSettings["APInvoice"].ToString();
                    break;
                case "arpayment":
                    recordType = ConfigurationManager.AppSettings["ARPayment"].ToString();
                    break;
                case "appayment":
                    recordType = ConfigurationManager.AppSettings["APPayment"].ToString();
                    break;
                case "purchaseorder":
                    recordType = ConfigurationManager.AppSettings["PurchaseOrder"].ToString();
                    break;

                default:
                    break;
            }

            //  recordType = ConfigurationManager.AppSettings["RecordType"].ToString();

            return recordType;

        }
        private string GetUrl()
        {
            string url;
            Uri uri;
            while (true)
            {
                url = configuration.baseURL.ToString();
                if (Uri.TryCreate(url, UriKind.RelativeOrAbsolute, out uri))
                {
                    return url;
                }
                this.baseURL = url;
                Console.WriteLine($"Url {url} is not valid");
            }
        }
        //private Credentials GetCredentials()
        //{
        //    string userName = configuration.user;
        //    string password = configuration.pwd;
        //    string company = configuration.company;

        //    return new Credentials(userName, password, company);
        //}


        public void updateInitIIProgressBar()
        {
            var updated = (decimal)((decimal)fileCount / iifiles.Count * 100);
            IIProgressBar.Increment((int)updated);
        }

        public void updateProgressBar()
        {
            var updated = (decimal)((decimal)fileCount / files.Count * 100);
            BIIProgressBar.Increment((int)updated);
        }

        public void updatePDFProgressBar()
        {
            var updated = (decimal)((decimal)fileCount / files.Count * 100);
            PDFProgressBar.Increment((int)updated);
        }

        public void updateIIProgressBar()
        {
            var updated = (decimal)((decimal)fileCount / files.Count * 100);
            BIIProgressBar.Increment((int)updated);
        }

        public void updateRefProgressBar()
        {
            var updated = (decimal)((decimal)fileCount / reffiles.Count * 100);
            progressBarRef.Increment((int)updated);
        }


        public void updatePDFBar()
        {
            fileCount++;
            BIIProgressBar.Increment((int)((decimal)(fileCount / 3 * 100)));
        }

        /// <summary>
        /// Reset form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset_Click(object sender, EventArgs e)
        {
            //panel1.BringToFront();
            //panel1.Show();
            //panel2.Hide();
            BIIProgressBar.Value = 0;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        void manualConfire()
        {
            configuration = new AcConfiguration()
            {
                baseURL = "http://localhost/AcumaticaDBv(21.115.0017)1/",
                pwd = "admin",
                branch = "",
                company = "company",
                user = "admin",
            };

            isConfigured = true;
        }

        private void ConfigurationButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(acumaticaurl.Text.ToString()) && string.IsNullOrEmpty(uid.Text.ToString())
                && string.IsNullOrEmpty(pwd.Text.ToString()) && string.IsNullOrEmpty(cmpny.Text.ToString()))
                return;

            configuration = new AcConfiguration()
            {
                baseURL = acumaticaurl.Text,
                pwd = pwd.Text,
                branch = branch,
                company = cmpny.Text,
                user = uid.Text,
            };

            var service = new RestService(configuration.baseURL, configuration.user, configuration.pwd, configuration.company, configuration.branch, entity);
            try
            {
                var x = service.LoginAsync(configuration.baseURL, configuration.user, configuration.pwd, configuration.company, configuration.branch);

                if (x.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    configurationPanel.Enabled = false;
                    lblError.Text = String.Empty;
                    isConfigured = true;
                    MessageBox.Show(service.errorMessage);
                    service.Logout();
                }
                else
                {
                    configurationPanel.Enabled = true;
                    lblError.Text = x.Content.ReadAsStringAsync().Result;
                    isConfigured = false;
                    MessageBox.Show(service.errorMessage);
                }

            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "");
                MessageBox.Show(service.errorMessage);
            }
        }

        private void bulkFolderPathButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isConfigured)
                {
                    MessageBox.Show(Globals.EMPTYCONFIGURATION);
                    lblError.Visible = true;
                    BIIUploadButton.Enabled = bulkFolderPathButton.Enabled = false;
                    lblError.Text = Globals.EMPTYCONFIGURATION;
                    return;
                }
                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = true;
                // Show the FolderBrowserDialog.  
                DialogResult result = folderDlg.ShowDialog();

                if (result == DialogResult.OK)
                {
                    lblbulkIIfileurl.Text = folderDlg.SelectedPath;
                    Environment.SpecialFolder root = folderDlg.RootFolder;

                    ConfigureBIIUploads();
                }
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "");
                throw;
            }
        }


        private void BIIUploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                BIIProgressBar.Visible = true;

                if (isConfigured)
                {
                    var service = new RestService(configuration.baseURL, configuration.user, configuration.pwd, configuration.company, configuration.branch, entity);
                    fileCount = 0;

                    foreach (var file in files)
                    {
                        var x = service.LoginAsync(configuration.baseURL, configuration.user, configuration.pwd, configuration.company, configuration.branch);

                        // To get progressBar incremental value
                        fileCount++;

                        if (x.StatusCode == System.Net.HttpStatusCode.NoContent)
                        {
                            string filename = file;
                            var inventoryCD = InventoryCD.Text;

                            using (StreamReader sr = new StreamReader(filename))
                            {
                                var response = service.PutFile(inventoryCD, filename.Substring(filename.LastIndexOf("\\") + 1), sr.BaseStream);

                                if (response.Length == 0)
                                {
                                    if (BIIProgressBar.InvokeRequired)
                                    {
                                        Invoke(new MethodInvoker(updateProgressBar));
                                    }
                                    else
                                    {
                                        // updating progressbar
                                        updateProgressBar();
                                    }

                                    if (fileCount == files.Count)
                                    {
                                        MessageBox.Show(Globals.ALLFILEUPDATED);
                                        lblbulkIIfileurl.Text = string.Empty;
                                        BIIProgressBar.Visible = false;
                                    }
                                }
                            }
                        }
                        else if (x.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                        {
                            MessageBox.Show("401 Unauthorized access.");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Configuration is empty");
                    tabControl1.TabPages[3].Focus();
                    BIIProgressBar.Visible = false;
                }
                BIIProgressBar.Visible = false;
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "");
                MessageBox.Show(Globals.FAILEDTOUPLOADFILES);
                BIIProgressBar.Visible = false;
                throw;
            }
        }

        private void configurationResetButton_Click(object sender, EventArgs e)
        {
            try
            {
                acumaticaurl.Text = pwd.Text = uid.Text = cmpny.Text = String.Empty;
                isConfigured = false;
                configurationPanel.Enabled = true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Check valid stock item
        /// </summary>
        /// <param name="InventoryCD">inventory item key</param>
        /// <returns></returns>
        private bool validStockItem(string InventoryCD)
        {
            var isValid = false;

            try
            {

                if (isConfigured)
                {
                    var service = new RestService(configuration.baseURL, configuration.user, configuration.pwd, configuration.company, configuration.branch, entity);
                    var x = service.LoginAsync(configuration.baseURL, configuration.user, configuration.pwd, configuration.company, configuration.branch);

                    if (x.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        var json = service.fetchInventory(InventoryCD);

                        if (json.Contains("No entity satisfies the condition."))
                        {
                            isValid = false;
                        }
                        else if (json != "")
                        {

                            InventoryItem inventory = Newtonsoft.Json.JsonConvert.DeserializeObject<InventoryItem>(json);
                            if (inventory != null)
                            {
                                isValid = true;
                            }
                            else
                                isValid = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(service.errorMessage);
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "");
                throw;
            }
            return isValid;
        }

        private void InventoryCD_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (InventoryCD.Text.Trim().Length == 0)
                {
                    lblError.Visible = false;
                    lblError.Text = "";
                    return;
                }

                isValidStockItem = validStockItem(InventoryCD.Text);

                if (isValidStockItem)
                {
                    lblError.Visible = false;
                    lblError.Text = "";
                    BIIUploadButton.Enabled = bulkFolderPathButton.Enabled = true;
                }
                else if (InventoryCD.Text.Length > 0 && !isValidStockItem && isConfigured)
                {
                    lblError.Visible = true;
                    lblError.Text = "Invalid Stockitem.";
                    BIIUploadButton.Enabled = bulkFolderPathButton.Enabled = false;
                }
                else
                {
                    lblError.Visible = true;
                    BIIUploadButton.Enabled = bulkFolderPathButton.Enabled = false;
                    lblError.Text = Globals.EMPTYCONFIGURATION;
                }
            }
            catch (Exception ex)
            {

            }
        }


        private void ImageFolderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isConfigured)
                {
                    MessageBox.Show(Globals.EMPTYCONFIGURATION);
                    return;
                }

                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = false;
                // Show the FolderBrowserDialog.  
                DialogResult result = folderDlg.ShowDialog();

                if (result == DialogResult.OK)
                {
                    IIfileurl.Text = folderDlg.SelectedPath;
                    Environment.SpecialFolder root = folderDlg.RootFolder;

                    ConfigureIIUploads();

                    if (iifiles.Count == 0)
                    {
                        ImageUploadButton.Enabled = false;
                    }
                    else
                    {
                        ImageUploadButton.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "");
                throw;
            }
        }

        private void ImageUploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                IIProgressBar.Visible = true;
                entity = "StockItem";

                if (isConfigured)
                {
                    var service = new RestService(configuration.baseURL, configuration.user, configuration.pwd, configuration.company, configuration.branch, entity);
                    fileCount = 0;

                    foreach (var file in iifiles)
                    {
                        var x = service.LoginAsync(configuration.baseURL, configuration.user, configuration.pwd, configuration.company, configuration.branch);
                        fileCount++;
                        // To get progressBar incremental value


                        if (x.StatusCode == System.Net.HttpStatusCode.NoContent)
                        {
                            string filename = file;
                            var inventoryCD = iiInventoryCD[fileCount - 1];

                            using (StreamReader sr = new StreamReader(filename))
                            {
                                var response = service.PutFile(inventoryCD, filename.Substring(filename.LastIndexOf("\\") + 1), sr.BaseStream);

                                if (response.Length == 0)
                                {
                                    if (IIProgressBar.InvokeRequired)
                                    {
                                        Invoke(new MethodInvoker(updateIIProgressBar));
                                    }
                                    else
                                    {
                                        // updating progressbar
                                        updateInitIIProgressBar();
                                    }

                                    if (fileCount == iifiles.Count)
                                    {
                                        MessageBox.Show(Globals.ALLFILEUPDATED);
                                        IIfileurl.Text = string.Empty;
                                        IIProgressBar.Visible = false;
                                        ImageUploadButton.Enabled = false;
                                    }
                                }
                            }

                        }
                        else if (x.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                        {
                            MessageBox.Show(Globals.UNAUTHORIZEDACCESS);
                        }
                    }

                }
                else
                {
                    MessageBox.Show(Globals.EMPTYCONFIGURATION);
                    tabControl1.TabPages[3].Focus();
                    BIIProgressBar.Visible = false;
                }
                IIProgressBar.Visible = false;
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "");
                MessageBox.Show(Globals.FAILEDTOUPLOADFILES);
                throw;
            }
        }

        private void bulkPDFFolderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isConfigured)
                {
                    MessageBox.Show(Globals.EMPTYCONFIGURATION);
                    return;
                }

                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = false;
                // Show the FolderBrowserDialog.  
                DialogResult result = folderDlg.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PDFIfileurl.Text = folderDlg.SelectedPath;
                    Environment.SpecialFolder root = folderDlg.RootFolder;
                }

                if (PDFIfileurl.Text.Length > 0)
                {
                    PDFButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "");
                throw;
            }
        }

        private void PDFButton_Click(object sender, EventArgs e)
        {
            try
            {
                var key1 = new List<string>();
                var key2 = new List<string>();

                if (!isConfigured)
                {
                    MessageBox.Show(Globals.EMPTYCONFIGURATION);
                    return;
                }

                files.Clear();
                PDFProgressBar.Visible = true;

                //Folder name as document type
                var orderType = PDFIfileurl.Text.Substring(PDFIfileurl.Text.LastIndexOf("\\") + 1);
                entity = GetEntityType(orderType);
                var service = new RestService(configuration.baseURL, configuration.user, configuration.pwd, configuration.company, configuration.branch, entity);


                if (!Directory.Exists(PDFIfileurl.Text))
                {
                    MessageBox.Show(Globals.FOLDERNOTEXISTS);
                    return;
                };

                string[] filenames = Directory.GetFiles(PDFIfileurl.Text, ".", SearchOption.AllDirectories);

                foreach (var item in filenames)
                {
                    if (item.EndsWith(".pdf"))
                    {
                        files.Add(item);
                        fileCount = fileCount + 1;
                        string refNumber = item.Substring(item.LastIndexOf("\\") + 1);
                        refNumber = refNumber.Split('.')[0];

                        key1.Add(GetRecordType(orderType));
                        key2.Add(refNumber);
                    }
                }

                //checks pdf file found 
                if (fileCount == 0)
                {
                    MessageBox.Show(Globals.NOREADBLEFILE);
                    return;
                }
                fileCount = 0;

                foreach (var item in files)
                {

                    var x = service.LoginAsync(configuration.baseURL, configuration.user, configuration.pwd, configuration.company, configuration.branch);

                    // To get progressBar incremental value

                    if (x.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        string filename = item;

                        using (StreamReader sr = new StreamReader(filename))
                        {
                            var response = service.PutFile(key1[fileCount] + "/" + key2[fileCount], filename.Substring(filename.LastIndexOf("\\") + 1), sr.BaseStream);

                            if (response.Length == 0)
                            {
                                fileCount++;
                                if (PDFProgressBar.InvokeRequired)
                                {
                                    Invoke(new MethodInvoker(updatePDFProgressBar));
                                }
                                else
                                {
                                    updatePDFProgressBar();
                                }

                                if (fileCount == files.Count)
                                {
                                    MessageBox.Show(Globals.ALLFILEUPDATED);
                                    PDFIfileurl.Text = string.Empty;
                                    PDFProgressBar.Visible = false;
                                    PDFButton.Enabled = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show(service.errorMessage);
                                PDFIfileurl.Text = string.Empty;
                                PDFProgressBar.Visible = false;
                                PDFButton.Enabled = false;
                            }
                        }
                    }
                    else if (x.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        MessageBox.Show("401 Unauthorized access.");
                        PDFProgressBar.Visible = false;
                    }
                }


            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "");
                MessageBox.Show(Globals.FAILEDTOUPLOADFILES);
                PDFProgressBar.Visible = false;
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TabControl tabControl = (TabControl)sender;
                IIfileurl.Text = lblbulkIIfileurl.Text = PDFIfileurl.Text = string.Empty;
                ImageUploadButton.Enabled = PDFButton.Enabled = false;
                fileCount = 0;
                iifiles.Clear();
                files.Clear();

            }
            catch (Exception ex)
            {

                throw;
            }
        }





        private void lblbulkIIfileurl_Enter(object sender, EventArgs e)
        {

        }

        private void lblbulkIIfileurl_MouseHover(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(lblbulkIIfileurl, lbl.Text);
        }

        private void IIfileurl_MouseHover(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(IIfileurl, lbl.Text);
        }

        private void PDFIfileurl_MouseHover(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(PDFIfileurl, lbl.Text);
        }

        private void imageimport_CheckedChanged(object sender, EventArgs e)
        {
            ImagePanel.Show();
            PDFPanel.Hide();
        }

        private void pdfimport_CheckedChanged(object sender, EventArgs e)
        {

            ImagePanel.Hide();
            PDFPanel.Show();
        }



        private void browseFolderPathRef_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isConfigured)
                {
                    MessageBox.Show(Globals.EMPTYCONFIGURATION);
                    return;
                }

                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = false;
                // Show the FolderBrowserDialog.  
                DialogResult result = folderDlg.ShowDialog();

                if (result == DialogResult.OK)
                {
                    lblErrorRef.Text = folderDlg.SelectedPath;
                    Environment.SpecialFolder root = folderDlg.RootFolder;

                    ConfigureVendorRefUploads();

                    if (reffiles.Count == 0)
                    {
                        btnUploadRef.Enabled = false;
                    }
                    else
                    {
                        btnUploadRef.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "");
                throw;
            }
        }

        private void btnUploadRef_Click(object sender, EventArgs e)
        {
            try
            {
                progressBarRef.Visible = true;
                entity = "bill";


                if (isConfigured)
                {
                    var service = new RestService(configuration.baseURL, configuration.user, configuration.pwd, configuration.company, configuration.branch, entity);
                    fileCount = 0;

                    foreach (var file in reffilesPath)
                    {
                        var x = service.LoginAsync(configuration.baseURL, configuration.user, configuration.pwd, configuration.company, configuration.branch);
                        fileCount++;
                        // To get progressBar incremental value


                        if (x.StatusCode == System.Net.HttpStatusCode.NoContent)
                        {
                            string filename = file;
                            var filen = reffiles[fileCount - 1];

                            using (StreamReader sr = new StreamReader(filename))
                            {
                                var response = service.PutFileByVendorReference(entity, vendorReference, filen.Substring(0, filen.LastIndexOf('.')), filen, sr.BaseStream);

                                //if (response.Length == 0)
                                //{
                                if (progressBarRef.InvokeRequired)
                                {
                                    Invoke(new MethodInvoker(updateRefProgressBar));
                                }
                                else
                                {
                                    // updating progressbar
                                    updateRefProgressBar();
                                }

                                if (fileCount == reffiles.Count)
                                {
                                    MessageBox.Show(Globals.ALLFILEUPDATED);
                                    lblErrorRef.Text = string.Empty;
                                    progressBarRef.Visible = false;
                                    btnUploadRef.Enabled = false;
                                }
                                //}
                            }

                        }
                        else if (x.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                        {
                            MessageBox.Show(Globals.UNAUTHORIZEDACCESS);
                        }
                    }

                }
                else
                {
                    MessageBox.Show(Globals.EMPTYCONFIGURATION);
                    tabControl1.TabPages[3].Focus();
                    progressBarRef.Visible = false;
                }
                progressBarRef.Visible = false;
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "");
                MessageBox.Show(Globals.FAILEDTOUPLOADFILES);
                throw;
            }
        }

        //private void InventoryCD_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == '32') return;
        //}
    }



    public static class FormExtension
    {
        /// <summary>
        /// Executes the Action asynchronously on the UI thread, does not block execution on the calling thread.
        /// </summary>
        /// <param name="control"></param>
        /// <param name="code"></param>
        public static void UIThread(this Control @this, Action code)
        {
            if (@this.InvokeRequired)
            {
                @this.BeginInvoke(code);
            }
            else
            {
                code.Invoke();
            }
        }
    }

}
