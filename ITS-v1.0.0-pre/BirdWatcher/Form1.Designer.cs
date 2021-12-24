namespace BirdWatcher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllBirdsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ieškotiPagalAutoriųToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.įeitiĮKatalogąToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBirdName = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblBehavior = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.gbxImage = new System.Windows.Forms.GroupBox();
            this.btnSetImage = new System.Windows.Forms.Button();
            this.picBird = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveBird = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFindBird = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNavBack = new System.Windows.Forms.ToolStripButton();
            this.tsbNavForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.cboWorld = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLit = new System.Windows.Forms.ComboBox();
            this.linkBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbxImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.įeitiĮKatalogąToolStripMenuItem,
            this.apieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1240, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openStripMenuItem2,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Failas";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "Naujas";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openStripMenuItem2
            // 
            this.openStripMenuItem2.Name = "openStripMenuItem2";
            this.openStripMenuItem2.Size = new System.Drawing.Size(146, 22);
            this.openStripMenuItem2.Text = "Atidaryti";
            this.openStripMenuItem2.Click += new System.EventHandler(this.openStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Išsaugoti";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Išsaugoti kaip";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Išeiti";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAllBirdsToolStripMenuItem,
            this.ieškotiPagalAutoriųToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "Ieška";
            // 
            // listAllBirdsToolStripMenuItem
            // 
            this.listAllBirdsToolStripMenuItem.Name = "listAllBirdsToolStripMenuItem";
            this.listAllBirdsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.listAllBirdsToolStripMenuItem.Text = "Rodyti visą katalogą - BETA";
            this.listAllBirdsToolStripMenuItem.Click += new System.EventHandler(this.listAllBirdsToolStripMenuItem_Click);
            // 
            // ieškotiPagalAutoriųToolStripMenuItem
            // 
            this.ieškotiPagalAutoriųToolStripMenuItem.Name = "ieškotiPagalAutoriųToolStripMenuItem";
            this.ieškotiPagalAutoriųToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.ieškotiPagalAutoriųToolStripMenuItem.Text = "Ieškoti pagal autorių - BETA";
            this.ieškotiPagalAutoriųToolStripMenuItem.Click += new System.EventHandler(this.ieškotiPagalAutoriųToolStripMenuItem_Click);
            // 
            // įeitiĮKatalogąToolStripMenuItem
            // 
            this.įeitiĮKatalogąToolStripMenuItem.Name = "įeitiĮKatalogąToolStripMenuItem";
            this.įeitiĮKatalogąToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.įeitiĮKatalogąToolStripMenuItem.Text = "Įeiti į katalogą";
            this.įeitiĮKatalogąToolStripMenuItem.ToolTipText = "Katalogas iš turimos duomenų bazės";
            this.įeitiĮKatalogąToolStripMenuItem.Click += new System.EventHandler(this.įeitiĮKatalogąToolStripMenuItem_Click);
            // 
            // apieToolStripMenuItem
            // 
            this.apieToolStripMenuItem.Name = "apieToolStripMenuItem";
            this.apieToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.apieToolStripMenuItem.Text = "Apie";
            this.apieToolStripMenuItem.Click += new System.EventHandler(this.apieToolStripMenuItem_Click);
            // 
            // lblBirdName
            // 
            this.lblBirdName.AutoSize = true;
            this.lblBirdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirdName.Location = new System.Drawing.Point(29, 68);
            this.lblBirdName.Name = "lblBirdName";
            this.lblBirdName.Size = new System.Drawing.Size(84, 24);
            this.lblBirdName.TabIndex = 1;
            this.lblBirdName.Text = "Autorius:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(189, 68);
            this.txtAuthor.MaxLength = 100;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(534, 26);
            this.txtAuthor.TabIndex = 0;
            this.txtAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirdName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategorija";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboGender
            // 
            this.cboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Pasaulio istorija",
            "Lietuvos istorija",
            "Enciklopedija",
            "Atsiminimai"});
            this.cboGender.Location = new System.Drawing.Point(188, 189);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(535, 28);
            this.cboGender.TabIndex = 1;
            this.cboGender.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboGender_MouseClick);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(29, 241);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(138, 24);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "Pasaulio istorija";
            // 
            // lblBehavior
            // 
            this.lblBehavior.AutoSize = true;
            this.lblBehavior.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBehavior.Location = new System.Drawing.Point(29, 283);
            this.lblBehavior.Name = "lblBehavior";
            this.lblBehavior.Size = new System.Drawing.Size(136, 24);
            this.lblBehavior.TabIndex = 7;
            this.lblBehavior.Text = "Lietuvos istorija";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(189, 366);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(134, 26);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.CloseUp += new System.EventHandler(this.dtpDate_CloseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Įrašo data";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(29, 409);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(67, 24);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "Laikas:";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "hh:mm";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(189, 413);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(134, 26);
            this.dtpTime.TabIndex = 5;
            this.dtpTime.CloseUp += new System.EventHandler(this.dtpTime_CloseUp);
            // 
            // gbxImage
            // 
            this.gbxImage.Controls.Add(this.btnSetImage);
            this.gbxImage.Controls.Add(this.picBird);
            this.gbxImage.Location = new System.Drawing.Point(807, 52);
            this.gbxImage.Name = "gbxImage";
            this.gbxImage.Size = new System.Drawing.Size(421, 555);
            this.gbxImage.TabIndex = 13;
            this.gbxImage.TabStop = false;
            this.gbxImage.Text = "Viršelio nuotrauka";
            // 
            // btnSetImage
            // 
            this.btnSetImage.Location = new System.Drawing.Point(174, 532);
            this.btnSetImage.Name = "btnSetImage";
            this.btnSetImage.Size = new System.Drawing.Size(75, 23);
            this.btnSetImage.TabIndex = 0;
            this.btnSetImage.Text = "Įkelti";
            this.btnSetImage.UseVisualStyleBackColor = true;
            this.btnSetImage.Click += new System.EventHandler(this.btnSetImage_Click);
            // 
            // picBird
            // 
            this.picBird.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBird.Location = new System.Drawing.Point(6, 19);
            this.picBird.Name = "picBird";
            this.picBird.Size = new System.Drawing.Size(409, 508);
            this.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBird.TabIndex = 0;
            this.picBird.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbRemoveBird,
            this.toolStripSeparator2,
            this.tsbFindBird,
            this.toolStripSeparator5,
            this.tsbSave,
            this.toolStripButton1,
            this.toolStripSeparator4,
            this.tsbNavBack,
            this.tsbNavForward,
            this.toolStripSeparator3,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1240, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "Pridėti naują knygą";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbRemoveBird
            // 
            this.tsbRemoveBird.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveBird.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveBird.Image")));
            this.tsbRemoveBird.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveBird.Name = "tsbRemoveBird";
            this.tsbRemoveBird.Size = new System.Drawing.Size(23, 22);
            this.tsbRemoveBird.Text = "Ištrinti šią knygą iš katalogo";
            this.tsbRemoveBird.Click += new System.EventHandler(this.tsbRemoveBird_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbFindBird
            // 
            this.tsbFindBird.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFindBird.Image = ((System.Drawing.Image)(resources.GetObject("tsbFindBird.Image")));
            this.tsbFindBird.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFindBird.Name = "tsbFindBird";
            this.tsbFindBird.Size = new System.Drawing.Size(23, 22);
            this.tsbFindBird.Text = "Surasti knygą pagal pavadinimą";
            this.tsbFindBird.Click += new System.EventHandler(this.tsbFindBird_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "Išsaugoti į katalogą";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Atidaryti";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbNavBack
            // 
            this.tsbNavBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNavBack.Image = ((System.Drawing.Image)(resources.GetObject("tsbNavBack.Image")));
            this.tsbNavBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNavBack.Name = "tsbNavBack";
            this.tsbNavBack.Size = new System.Drawing.Size(23, 22);
            this.tsbNavBack.Text = "Grįžti atgal prie ankstesnės knygos";
            this.tsbNavBack.Click += new System.EventHandler(this.tsbNavBack_Click);
            // 
            // tsbNavForward
            // 
            this.tsbNavForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNavForward.Image = ((System.Drawing.Image)(resources.GetObject("tsbNavForward.Image")));
            this.tsbNavForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNavForward.Name = "tsbNavForward";
            this.tsbNavForward.Size = new System.Drawing.Size(23, 22);
            this.tsbNavForward.Text = "Eiti prie kitos knygos";
            this.tsbNavForward.Click += new System.EventHandler(this.tsbNavForward_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExit
            // 
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(23, 22);
            this.tsbExit.Text = "Išeiti";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // cboWorld
            // 
            this.cboWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWorld.FormattingEnabled = true;
            this.cboWorld.Items.AddRange(new object[] {
            "Senovės istorija 3500 m. pr. Kr. - 476 m.",
            "Viduramžiai 500-1500m. :",
            "Ankstyvieji viduramžiai V-X a. ~500-1500 m.",
            "Brandieji viduramžiai XI - XIII a. ",
            "Vėlyvieji viduramžiai XIV - XV a.",
            "Naujieji laikai XVI - XVIII a.",
            "Naujausieji laikai XIX - XX a. vid. (1800-1945)",
            "Šiuolaikinė istorija (po 1945 m. )",
            "Nėra duomenų",
            "Nesusiję"});
            this.cboWorld.Location = new System.Drawing.Point(188, 237);
            this.cboWorld.Name = "cboWorld";
            this.cboWorld.Size = new System.Drawing.Size(535, 28);
            this.cboWorld.TabIndex = 15;
            this.cboWorld.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboWorld_MouseClick);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(189, 109);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(534, 26);
            this.txtName.TabIndex = 16;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pavadinimas";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(188, 150);
            this.txtYear.MaxLength = 100;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(535, 26);
            this.txtYear.TabIndex = 18;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Išleidimo metai";
            // 
            // cboLit
            // 
            this.cboLit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLit.FormattingEnabled = true;
            this.cboLit.Items.AddRange(new object[] {
            "Nesusiję",
            "Nėra informacijos",
            "Bronzos (žalvario), geležies amžiai 2000-500 m. pr. Kr.",
            "Baltų genčių formavimosi laikotarpis (lietuviai, latviai, prūsai) 500 m. pr. Kr. " +
                "- 500 m. po Kr.",
            "Žemių konfederacijų formavimasis V-XI a.",
            "Ankstyvasis Lietuvos valstybės formavimosi laikotarpis XI- XIII a. pr.",
            "Lietuvos valstybė (LDK) XIII a. Vid. - XIV a. II pus. (1236 m. (1240 m.) 1569 m.)" +
                "",
            "1236-1385 m. Ankstyvasis LDK feodalinis laikotarpis",
            "1385-1569 m. LDK didvalstybė luominės monarchijos laikotarpiu.",
            "LDK ATR sudėtyje. 1569-1795 m.",
            "Lietuva Rusijos imperijos sudėtyje. 1795-1915 m.",
            "Lietuvos teritorijos administracinis ir teisinis integravimas į Rusijos imperiją " +
                "1795-1840 m.",
            "Lietuvių tautinis sąjūdis. XIX a. I pus. - XIX a. II pus.",
            "Lietuviškos spaudos draudimo laikotarpis 1864-1904 m.",
            "Lietuvių tautinis atgimimas 1883-1918 m.",
            "Lietuvos kultūrinis - ekonominis klestėjimas Rusijos imperijoje. 1883-1915 m.",
            "Lietuva kaizerinės Vokietijos okupacijos laikotarpyje. 1915-1918 m.",
            "Nepriklausoma (tarpukario) Lietuvos respublika. 1918-1940 m.",
            "Lietuvos valstybės kūrimas. 1918-02-16 - 1922 lapkritis",
            "Prezidentinis (seiminis) LR laikotarpis. 1920-1926",
            "Prezidentinis (autoritarinis) LR laikotarpis. 1927-1940",
            "Lietuva I-osios sovietinės okupacijos laikotarpiu. 1940.06.15 - 1941.06.23",
            "Lietuva nacistinės (hitlerinės) okupacijos laikotarpiu 1941.06.23 - 1944 liepa",
            "Lietuva II-osios sovietinės okupacijos laikotarpiu 1944 liepa - 1990 kovo 11",
            "II - asis LR laikotarpis (po 1990 03 11)"});
            this.cboLit.Location = new System.Drawing.Point(188, 279);
            this.cboLit.Name = "cboLit";
            this.cboLit.Size = new System.Drawing.Size(535, 28);
            this.cboLit.TabIndex = 20;
            this.cboLit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboLit_MouseClick);
            // 
            // linkBox
            // 
            this.linkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBox.Location = new System.Drawing.Point(188, 324);
            this.linkBox.MaxLength = 100;
            this.linkBox.Name = "linkBox";
            this.linkBox.Size = new System.Drawing.Size(534, 26);
            this.linkBox.TabIndex = 21;
            this.linkBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.linkBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Viršelio nuoroda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 621);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkBox);
            this.Controls.Add(this.cboLit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cboWorld);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbxImage);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblBehavior);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblBirdName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Istorijos šaltinių archyvas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblBirdName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblBehavior;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.GroupBox gbxImage;
        private System.Windows.Forms.PictureBox picBird;
        private System.Windows.Forms.Button btnSetImage;
        private System.Windows.Forms.ToolStripMenuItem openStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbRemoveBird;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbNavBack;
        private System.Windows.Forms.ToolStripButton tsbNavForward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripButton tsbFindBird;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllBirdsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ComboBox cboWorld;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLit;
        private System.Windows.Forms.ToolStripMenuItem ieškotiPagalAutoriųToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem įeitiĮKatalogąToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox linkBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem apieToolStripMenuItem;
    }
}

