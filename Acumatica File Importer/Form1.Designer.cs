namespace Acumatica_File_Importer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.configurationPanel = new System.Windows.Forms.Panel();
            this.cmpny = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.acumaticaurl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblError = new System.Windows.Forms.Label();
            this.lblbulkIIfileurl = new System.Windows.Forms.Label();
            this.BIIProgressBar = new System.Windows.Forms.ProgressBar();
            this.BIIUploadButton = new System.Windows.Forms.Button();
            this.bulkFolderPathButton = new System.Windows.Forms.Button();
            this.InventoryCD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.IIProgressBar = new System.Windows.Forms.ProgressBar();
            this.IIfileurl = new System.Windows.Forms.Label();
            this.ImageProgressBar = new System.Windows.Forms.ProgressBar();
            this.ImageUploadButton = new System.Windows.Forms.Button();
            this.ImageFolderButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.progressBarPDF = new System.Windows.Forms.ProgressBar();
            this.PDFButton = new System.Windows.Forms.Button();
            this.PDFIfileurl = new System.Windows.Forms.Label();
            this.PDFProgressBar = new System.Windows.Forms.ProgressBar();
            this.bulkPDFFolderButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.configurationResetButton = new System.Windows.Forms.Button();
            this.ConfigurationButton = new System.Windows.Forms.Button();
            this.configurationPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // configurationPanel
            // 
            this.configurationPanel.Controls.Add(this.cmpny);
            this.configurationPanel.Controls.Add(this.label4);
            this.configurationPanel.Controls.Add(this.pwd);
            this.configurationPanel.Controls.Add(this.label3);
            this.configurationPanel.Controls.Add(this.uid);
            this.configurationPanel.Controls.Add(this.label2);
            this.configurationPanel.Controls.Add(this.acumaticaurl);
            this.configurationPanel.Controls.Add(this.label1);
            this.configurationPanel.Location = new System.Drawing.Point(-6, 0);
            this.configurationPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.configurationPanel.Name = "configurationPanel";
            this.configurationPanel.Size = new System.Drawing.Size(522, 183);
            this.configurationPanel.TabIndex = 6;
            // 
            // cmpny
            // 
            this.cmpny.Location = new System.Drawing.Point(165, 142);
            this.cmpny.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmpny.Name = "cmpny";
            this.cmpny.Size = new System.Drawing.Size(325, 26);
            this.cmpny.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(68, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Company";
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(165, 100);
            this.pwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(325, 26);
            this.pwd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(64, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // uid
            // 
            this.uid.Location = new System.Drawing.Point(165, 55);
            this.uid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(325, 26);
            this.uid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(60, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // acumaticaurl
            // 
            this.acumaticaurl.Location = new System.Drawing.Point(165, 15);
            this.acumaticaurl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acumaticaurl.Name = "acumaticaurl";
            this.acumaticaurl.Size = new System.Drawing.Size(325, 26);
            this.acumaticaurl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instance URL";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ItemSize = new System.Drawing.Size(90, 19);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 305);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleDescription = "sdfdsfsdf";
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.lblError);
            this.tabPage1.Controls.Add(this.lblbulkIIfileurl);
            this.tabPage1.Controls.Add(this.BIIProgressBar);
            this.tabPage1.Controls.Add(this.BIIUploadButton);
            this.tabPage1.Controls.Add(this.bulkFolderPathButton);
            this.tabPage1.Controls.Add(this.InventoryCD);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(524, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bulk Import ";
            this.tabPage1.ToolTipText = "Upload images by inventoryCD wise";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(167, 48);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(102, 23);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "Inventory CD";
            this.lblError.UseCompatibleTextRendering = true;
            this.lblError.Visible = false;
            // 
            // lblbulkIIfileurl
            // 
            this.lblbulkIIfileurl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbulkIIfileurl.Location = new System.Drawing.Point(39, 138);
            this.lblbulkIIfileurl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbulkIIfileurl.Name = "lblbulkIIfileurl";
            this.lblbulkIIfileurl.Size = new System.Drawing.Size(438, 37);
            this.lblbulkIIfileurl.TabIndex = 11;
            this.lblbulkIIfileurl.Text = "lbl";
            this.lblbulkIIfileurl.MouseHover += new System.EventHandler(this.lblbulkIIfileurl_MouseHover);
            // 
            // BIIProgressBar
            // 
            this.BIIProgressBar.Location = new System.Drawing.Point(39, 235);
            this.BIIProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BIIProgressBar.Name = "BIIProgressBar";
            this.BIIProgressBar.Size = new System.Drawing.Size(440, 15);
            this.BIIProgressBar.TabIndex = 10;
            this.BIIProgressBar.Visible = false;
            // 
            // BIIUploadButton
            // 
            this.BIIUploadButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.BIIUploadButton.Enabled = false;
            this.BIIUploadButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BIIUploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIIUploadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BIIUploadButton.Location = new System.Drawing.Point(39, 180);
            this.BIIUploadButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BIIUploadButton.Name = "BIIUploadButton";
            this.BIIUploadButton.Size = new System.Drawing.Size(440, 38);
            this.BIIUploadButton.TabIndex = 6;
            this.BIIUploadButton.Text = "Upload";
            this.BIIUploadButton.UseVisualStyleBackColor = false;
            this.BIIUploadButton.Click += new System.EventHandler(this.BIIUploadButton_Click);
            // 
            // bulkFolderPathButton
            // 
            this.bulkFolderPathButton.BackColor = System.Drawing.Color.White;
            this.bulkFolderPathButton.Enabled = false;
            this.bulkFolderPathButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bulkFolderPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulkFolderPathButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bulkFolderPathButton.Location = new System.Drawing.Point(39, 82);
            this.bulkFolderPathButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bulkFolderPathButton.Name = "bulkFolderPathButton";
            this.bulkFolderPathButton.Size = new System.Drawing.Size(440, 46);
            this.bulkFolderPathButton.TabIndex = 4;
            this.bulkFolderPathButton.Text = "Browse Folder Path";
            this.bulkFolderPathButton.UseVisualStyleBackColor = false;
            this.bulkFolderPathButton.Click += new System.EventHandler(this.bulkFolderPathButton_Click);
            // 
            // InventoryCD
            // 
            this.InventoryCD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InventoryCD.Location = new System.Drawing.Point(165, 14);
            this.InventoryCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InventoryCD.Name = "InventoryCD";
            this.InventoryCD.Size = new System.Drawing.Size(312, 28);
            this.InventoryCD.TabIndex = 3;
            this.InventoryCD.TextChanged += new System.EventHandler(this.InventoryCD_TextChanged);
            this.InventoryCD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InventoryCD_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(39, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Inventory CD";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.IIProgressBar);
            this.tabPage2.Controls.Add(this.IIfileurl);
            this.tabPage2.Controls.Add(this.ImageProgressBar);
            this.tabPage2.Controls.Add(this.ImageUploadButton);
            this.tabPage2.Controls.Add(this.ImageFolderButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(524, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Image Import";
            this.tabPage2.ToolTipText = "Upload images named with inventoryCD from folder ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // IIProgressBar
            // 
            this.IIProgressBar.Location = new System.Drawing.Point(39, 235);
            this.IIProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IIProgressBar.Name = "IIProgressBar";
            this.IIProgressBar.Size = new System.Drawing.Size(440, 15);
            this.IIProgressBar.TabIndex = 18;
            this.IIProgressBar.Visible = false;
            // 
            // IIfileurl
            // 
            this.IIfileurl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IIfileurl.Location = new System.Drawing.Point(39, 111);
            this.IIfileurl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IIfileurl.Name = "IIfileurl";
            this.IIfileurl.Size = new System.Drawing.Size(438, 26);
            this.IIfileurl.TabIndex = 17;
            this.IIfileurl.MouseHover += new System.EventHandler(this.IIfileurl_MouseHover);
            // 
            // ImageProgressBar
            // 
            this.ImageProgressBar.Location = new System.Drawing.Point(28, 291);
            this.ImageProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImageProgressBar.Name = "ImageProgressBar";
            this.ImageProgressBar.Size = new System.Drawing.Size(405, 28);
            this.ImageProgressBar.TabIndex = 16;
            this.ImageProgressBar.Visible = false;
            // 
            // ImageUploadButton
            // 
            this.ImageUploadButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ImageUploadButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ImageUploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageUploadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ImageUploadButton.Location = new System.Drawing.Point(39, 180);
            this.ImageUploadButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImageUploadButton.Name = "ImageUploadButton";
            this.ImageUploadButton.Size = new System.Drawing.Size(440, 38);
            this.ImageUploadButton.TabIndex = 15;
            this.ImageUploadButton.Text = "Upload";
            this.ImageUploadButton.UseVisualStyleBackColor = false;
            this.ImageUploadButton.Click += new System.EventHandler(this.ImageUploadButton_Click);
            // 
            // ImageFolderButton
            // 
            this.ImageFolderButton.BackColor = System.Drawing.Color.White;
            this.ImageFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ImageFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ImageFolderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ImageFolderButton.Location = new System.Drawing.Point(39, 46);
            this.ImageFolderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImageFolderButton.Name = "ImageFolderButton";
            this.ImageFolderButton.Size = new System.Drawing.Size(438, 46);
            this.ImageFolderButton.TabIndex = 14;
            this.ImageFolderButton.Text = "Browse Image Folder Path";
            this.ImageFolderButton.UseVisualStyleBackColor = false;
            this.ImageFolderButton.Click += new System.EventHandler(this.ImageFolderButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.progressBarPDF);
            this.tabPage3.Controls.Add(this.PDFButton);
            this.tabPage3.Controls.Add(this.PDFIfileurl);
            this.tabPage3.Controls.Add(this.PDFProgressBar);
            this.tabPage3.Controls.Add(this.bulkPDFFolderButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(524, 278);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PDF Import";
            this.tabPage3.ToolTipText = "Upload bulk pdf by entity wise";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // progressBarPDF
            // 
            this.progressBarPDF.Location = new System.Drawing.Point(39, 235);
            this.progressBarPDF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBarPDF.Name = "progressBarPDF";
            this.progressBarPDF.Size = new System.Drawing.Size(440, 15);
            this.progressBarPDF.TabIndex = 20;
            this.progressBarPDF.Visible = false;
            // 
            // PDFButton
            // 
            this.PDFButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.PDFButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PDFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDFButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PDFButton.Location = new System.Drawing.Point(39, 180);
            this.PDFButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PDFButton.Name = "PDFButton";
            this.PDFButton.Size = new System.Drawing.Size(440, 38);
            this.PDFButton.TabIndex = 19;
            this.PDFButton.Text = "Upload";
            this.PDFButton.UseVisualStyleBackColor = false;
            this.PDFButton.Click += new System.EventHandler(this.PDFButton_Click);
            // 
            // PDFIfileurl
            // 
            this.PDFIfileurl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDFIfileurl.Location = new System.Drawing.Point(39, 111);
            this.PDFIfileurl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PDFIfileurl.Name = "PDFIfileurl";
            this.PDFIfileurl.Size = new System.Drawing.Size(438, 40);
            this.PDFIfileurl.TabIndex = 17;
            this.PDFIfileurl.MouseHover += new System.EventHandler(this.PDFIfileurl_MouseHover);
            // 
            // PDFProgressBar
            // 
            this.PDFProgressBar.Location = new System.Drawing.Point(28, 291);
            this.PDFProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PDFProgressBar.Name = "PDFProgressBar";
            this.PDFProgressBar.Size = new System.Drawing.Size(405, 28);
            this.PDFProgressBar.TabIndex = 16;
            this.PDFProgressBar.Visible = false;
            // 
            // bulkPDFFolderButton
            // 
            this.bulkPDFFolderButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.bulkPDFFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bulkPDFFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bulkPDFFolderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bulkPDFFolderButton.Location = new System.Drawing.Point(39, 46);
            this.bulkPDFFolderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bulkPDFFolderButton.Name = "bulkPDFFolderButton";
            this.bulkPDFFolderButton.Size = new System.Drawing.Size(438, 46);
            this.bulkPDFFolderButton.TabIndex = 14;
            this.bulkPDFFolderButton.Text = "Browse PDF Folder Path";
            this.bulkPDFFolderButton.UseVisualStyleBackColor = false;
            this.bulkPDFFolderButton.Click += new System.EventHandler(this.bulkPDFFolderButton_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.configurationResetButton);
            this.tabPage4.Controls.Add(this.ConfigurationButton);
            this.tabPage4.Controls.Add(this.configurationPanel);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Size = new System.Drawing.Size(524, 278);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Configuration";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // configurationResetButton
            // 
            this.configurationResetButton.BackColor = System.Drawing.Color.White;
            this.configurationResetButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.configurationResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configurationResetButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.configurationResetButton.Location = new System.Drawing.Point(66, 192);
            this.configurationResetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.configurationResetButton.Name = "configurationResetButton";
            this.configurationResetButton.Size = new System.Drawing.Size(166, 43);
            this.configurationResetButton.TabIndex = 6;
            this.configurationResetButton.Text = "Reset";
            this.configurationResetButton.UseVisualStyleBackColor = false;
            this.configurationResetButton.Click += new System.EventHandler(this.configurationResetButton_Click);
            // 
            // ConfigurationButton
            // 
            this.ConfigurationButton.BackColor = System.Drawing.Color.White;
            this.ConfigurationButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ConfigurationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigurationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConfigurationButton.Location = new System.Drawing.Point(320, 192);
            this.ConfigurationButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConfigurationButton.Name = "ConfigurationButton";
            this.ConfigurationButton.Size = new System.Drawing.Size(166, 43);
            this.ConfigurationButton.TabIndex = 5;
            this.ConfigurationButton.Text = "Configure";
            this.ConfigurationButton.UseVisualStyleBackColor = false;
            this.ConfigurationButton.Click += new System.EventHandler(this.ConfigurationButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 295);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Acumatica File Import";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.configurationPanel.ResumeLayout(false);
            this.configurationPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        //private System.Windows.Forms.Button CreateCSV;
        private System.Windows.Forms.Panel configurationPanel;
        private System.Windows.Forms.TextBox uid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox acumaticaurl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cmpny;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ProgressBar BIIProgressBar;
        private System.Windows.Forms.Button BIIUploadButton;
        private System.Windows.Forms.Button bulkFolderPathButton;
        private System.Windows.Forms.TextBox InventoryCD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar PDFProgressBar;
        private System.Windows.Forms.Button bulkPDFFolderButton;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ProgressBar ImageProgressBar;
        private System.Windows.Forms.Button ImageUploadButton;
        private System.Windows.Forms.Button ImageFolderButton;
        private System.Windows.Forms.Label lblbulkIIfileurl;
        private System.Windows.Forms.Label IIfileurl;
        private System.Windows.Forms.Label PDFIfileurl;
        private System.Windows.Forms.Button configurationResetButton;
        private System.Windows.Forms.Button ConfigurationButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ProgressBar IIProgressBar;
        private System.Windows.Forms.ProgressBar progressBarPDF;
        private System.Windows.Forms.Button PDFButton;
    }
}

