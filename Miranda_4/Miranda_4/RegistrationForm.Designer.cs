namespace Miranda_4
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrantgroupBox = new System.Windows.Forms.GroupBox();
            this.dobmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.statuscomboBox = new System.Windows.Forms.ComboBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.lastnametextBox = new System.Windows.Forms.TextBox();
            this.firstnametextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.datemaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FilmpictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalpriceamountLabel = new System.Windows.Forms.Label();
            this.priceperclassamountLabel = new System.Windows.Forms.Label();
            this.totalclassesamountLabel = new System.Windows.Forms.Label();
            this.totalpriceLabel = new System.Windows.Forms.Label();
            this.priceperclassLabel = new System.Windows.Forms.Label();
            this.totalclassesLabel = new System.Windows.Forms.Label();
            this.classlistBox = new System.Windows.Forms.ListBox();
            this.classesLabel = new System.Windows.Forms.Label();
            this.classtypeLabel = new System.Windows.Forms.Label();
            this.animationradioButton = new System.Windows.Forms.RadioButton();
            this.liveradioButton = new System.Windows.Forms.RadioButton();
            this.cashradioButton = new System.Windows.Forms.RadioButton();
            this.checkradioButton = new System.Windows.Forms.RadioButton();
            this.emailcheckBox = new System.Windows.Forms.CheckBox();
            this.paymenttypeLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.registrantgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilmpictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripMenuItem,
            this.helpStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(471, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileStripMenuItem
            // 
            this.fileStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveStripMenuItem,
            this.clearStripMenuItem,
            this.exitStripMenuItem});
            this.fileStripMenuItem.Name = "fileStripMenuItem";
            this.fileStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileStripMenuItem.Text = "&File";
            // 
            // saveStripMenuItem
            // 
            this.saveStripMenuItem.Name = "saveStripMenuItem";
            this.saveStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.saveStripMenuItem.Text = "&Save";
            this.saveStripMenuItem.Click += new System.EventHandler(this.saveStripMenuItem_Click);
            // 
            // clearStripMenuItem
            // 
            this.clearStripMenuItem.Name = "clearStripMenuItem";
            this.clearStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.clearStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.clearStripMenuItem.Text = "&Clear";
            this.clearStripMenuItem.Click += new System.EventHandler(this.clearStripMenuItem_Click);
            // 
            // exitStripMenuItem
            // 
            this.exitStripMenuItem.Name = "exitStripMenuItem";
            this.exitStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitStripMenuItem.Text = "&Exit";
            this.exitStripMenuItem.Click += new System.EventHandler(this.exitStripMenuItem_Click);
            // 
            // helpStripMenuItem
            // 
            this.helpStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutStripMenuItem});
            this.helpStripMenuItem.Name = "helpStripMenuItem";
            this.helpStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpStripMenuItem.Text = "&Help";
            // 
            // aboutStripMenuItem
            // 
            this.aboutStripMenuItem.Name = "aboutStripMenuItem";
            this.aboutStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutStripMenuItem.Text = "&About";
            this.aboutStripMenuItem.Click += new System.EventHandler(this.aboutStripMenuItem_Click);
            // 
            // registrantgroupBox
            // 
            this.registrantgroupBox.Controls.Add(this.dobmaskedTextBox);
            this.registrantgroupBox.Controls.Add(this.statuscomboBox);
            this.registrantgroupBox.Controls.Add(this.emailtextBox);
            this.registrantgroupBox.Controls.Add(this.lastnametextBox);
            this.registrantgroupBox.Controls.Add(this.firstnametextBox);
            this.registrantgroupBox.Controls.Add(this.statusLabel);
            this.registrantgroupBox.Controls.Add(this.dobLabel);
            this.registrantgroupBox.Controls.Add(this.emailLabel);
            this.registrantgroupBox.Controls.Add(this.lastnameLabel);
            this.registrantgroupBox.Controls.Add(this.firstnameLabel);
            this.registrantgroupBox.Location = new System.Drawing.Point(12, 241);
            this.registrantgroupBox.Name = "registrantgroupBox";
            this.registrantgroupBox.Size = new System.Drawing.Size(447, 110);
            this.registrantgroupBox.TabIndex = 10;
            this.registrantgroupBox.TabStop = false;
            this.registrantgroupBox.Text = "Registrant Information";
            // 
            // dobmaskedTextBox
            // 
            this.dobmaskedTextBox.Location = new System.Drawing.Point(76, 74);
            this.dobmaskedTextBox.Mask = "00/00/0000";
            this.dobmaskedTextBox.Name = "dobmaskedTextBox";
            this.dobmaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.dobmaskedTextBox.TabIndex = 7;
            this.dobmaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // statuscomboBox
            // 
            this.statuscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statuscomboBox.FormattingEnabled = true;
            this.statuscomboBox.Location = new System.Drawing.Point(269, 45);
            this.statuscomboBox.Name = "statuscomboBox";
            this.statuscomboBox.Size = new System.Drawing.Size(121, 21);
            this.statuscomboBox.TabIndex = 9;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(269, 16);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(172, 20);
            this.emailtextBox.TabIndex = 8;
            // 
            // lastnametextBox
            // 
            this.lastnametextBox.Location = new System.Drawing.Point(76, 42);
            this.lastnametextBox.Name = "lastnametextBox";
            this.lastnametextBox.Size = new System.Drawing.Size(100, 20);
            this.lastnametextBox.TabIndex = 6;
            // 
            // firstnametextBox
            // 
            this.firstnametextBox.Location = new System.Drawing.Point(76, 16);
            this.firstnametextBox.Name = "firstnametextBox";
            this.firstnametextBox.Size = new System.Drawing.Size(100, 20);
            this.firstnametextBox.TabIndex = 5;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(223, 42);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Status:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(1, 77);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(69, 13);
            this.dobLabel.TabIndex = 3;
            this.dobLabel.Text = "Date of Birth:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(187, 16);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(76, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email Address:";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(9, 45);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastnameLabel.TabIndex = 1;
            this.lastnameLabel.Text = "Last Name:";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(10, 16);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstnameLabel.TabIndex = 0;
            this.firstnameLabel.Text = "First Name:";
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Location = new System.Drawing.Point(22, 206);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(92, 13);
            this.registrationLabel.TabIndex = 9;
            this.registrationLabel.Text = "Registration Date:";
            // 
            // datemaskedTextBox
            // 
            this.datemaskedTextBox.Location = new System.Drawing.Point(120, 206);
            this.datemaskedTextBox.Mask = "00/00/0000";
            this.datemaskedTextBox.Name = "datemaskedTextBox";
            this.datemaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.datemaskedTextBox.TabIndex = 8;
            this.datemaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // FilmpictureBox
            // 
            this.FilmpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FilmpictureBox.Image")));
            this.FilmpictureBox.Location = new System.Drawing.Point(12, 53);
            this.FilmpictureBox.Name = "FilmpictureBox";
            this.FilmpictureBox.Size = new System.Drawing.Size(212, 147);
            this.FilmpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FilmpictureBox.TabIndex = 6;
            this.FilmpictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(240, 39);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(231, 82);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Hopkins Film School";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalpriceamountLabel);
            this.groupBox1.Controls.Add(this.priceperclassamountLabel);
            this.groupBox1.Controls.Add(this.totalclassesamountLabel);
            this.groupBox1.Controls.Add(this.totalpriceLabel);
            this.groupBox1.Controls.Add(this.priceperclassLabel);
            this.groupBox1.Controls.Add(this.totalclassesLabel);
            this.groupBox1.Controls.Add(this.classlistBox);
            this.groupBox1.Controls.Add(this.classesLabel);
            this.groupBox1.Controls.Add(this.classtypeLabel);
            this.groupBox1.Controls.Add(this.animationradioButton);
            this.groupBox1.Controls.Add(this.liveradioButton);
            this.groupBox1.Location = new System.Drawing.Point(16, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 162);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration Information";
            // 
            // totalpriceamountLabel
            // 
            this.totalpriceamountLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.totalpriceamountLabel.Location = new System.Drawing.Point(314, 123);
            this.totalpriceamountLabel.Name = "totalpriceamountLabel";
            this.totalpriceamountLabel.Size = new System.Drawing.Size(81, 23);
            this.totalpriceamountLabel.TabIndex = 10;
            // 
            // priceperclassamountLabel
            // 
            this.priceperclassamountLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.priceperclassamountLabel.Location = new System.Drawing.Point(314, 92);
            this.priceperclassamountLabel.Name = "priceperclassamountLabel";
            this.priceperclassamountLabel.Size = new System.Drawing.Size(72, 23);
            this.priceperclassamountLabel.TabIndex = 8;
            // 
            // totalclassesamountLabel
            // 
            this.totalclassesamountLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.totalclassesamountLabel.Location = new System.Drawing.Point(314, 60);
            this.totalclassesamountLabel.Name = "totalclassesamountLabel";
            this.totalclassesamountLabel.Size = new System.Drawing.Size(53, 20);
            this.totalclassesamountLabel.TabIndex = 6;
            // 
            // totalpriceLabel
            // 
            this.totalpriceLabel.AutoSize = true;
            this.totalpriceLabel.Location = new System.Drawing.Point(219, 123);
            this.totalpriceLabel.Name = "totalpriceLabel";
            this.totalpriceLabel.Size = new System.Drawing.Size(61, 13);
            this.totalpriceLabel.TabIndex = 9;
            this.totalpriceLabel.Text = "Total Price:";
            // 
            // priceperclassLabel
            // 
            this.priceperclassLabel.AutoSize = true;
            this.priceperclassLabel.Location = new System.Drawing.Point(219, 92);
            this.priceperclassLabel.Name = "priceperclassLabel";
            this.priceperclassLabel.Size = new System.Drawing.Size(81, 13);
            this.priceperclassLabel.TabIndex = 7;
            this.priceperclassLabel.Text = "Price Per Class:";
            // 
            // totalclassesLabel
            // 
            this.totalclassesLabel.AutoSize = true;
            this.totalclassesLabel.Location = new System.Drawing.Point(219, 60);
            this.totalclassesLabel.Name = "totalclassesLabel";
            this.totalclassesLabel.Size = new System.Drawing.Size(73, 13);
            this.totalclassesLabel.TabIndex = 5;
            this.totalclassesLabel.Text = "Total Classes:";
            // 
            // classlistBox
            // 
            this.classlistBox.FormattingEnabled = true;
            this.classlistBox.Location = new System.Drawing.Point(8, 60);
            this.classlistBox.Name = "classlistBox";
            this.classlistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.classlistBox.Size = new System.Drawing.Size(133, 95);
            this.classlistBox.Sorted = true;
            this.classlistBox.TabIndex = 4;
            this.classlistBox.SelectedIndexChanged += new System.EventHandler(this.classlistBox_SelectedIndexChanged);
            // 
            // classesLabel
            // 
            this.classesLabel.AutoSize = true;
            this.classesLabel.Location = new System.Drawing.Point(6, 44);
            this.classesLabel.Name = "classesLabel";
            this.classesLabel.Size = new System.Drawing.Size(120, 13);
            this.classesLabel.TabIndex = 3;
            this.classesLabel.Text = "Classes: (Maximum of 4)";
            // 
            // classtypeLabel
            // 
            this.classtypeLabel.AutoSize = true;
            this.classtypeLabel.Location = new System.Drawing.Point(6, 21);
            this.classtypeLabel.Name = "classtypeLabel";
            this.classtypeLabel.Size = new System.Drawing.Size(62, 13);
            this.classtypeLabel.TabIndex = 0;
            this.classtypeLabel.Text = "Class Type:";
            // 
            // animationradioButton
            // 
            this.animationradioButton.AutoSize = true;
            this.animationradioButton.Location = new System.Drawing.Point(156, 21);
            this.animationradioButton.Name = "animationradioButton";
            this.animationradioButton.Size = new System.Drawing.Size(71, 17);
            this.animationradioButton.TabIndex = 2;
            this.animationradioButton.TabStop = true;
            this.animationradioButton.Text = "Animation";
            this.animationradioButton.UseVisualStyleBackColor = true;
            // 
            // liveradioButton
            // 
            this.liveradioButton.AutoSize = true;
            this.liveradioButton.Checked = true;
            this.liveradioButton.Location = new System.Drawing.Point(72, 21);
            this.liveradioButton.Name = "liveradioButton";
            this.liveradioButton.Size = new System.Drawing.Size(78, 17);
            this.liveradioButton.TabIndex = 1;
            this.liveradioButton.TabStop = true;
            this.liveradioButton.Text = "Live Action";
            this.liveradioButton.UseVisualStyleBackColor = true;
            this.liveradioButton.CheckedChanged += new System.EventHandler(this.liveradioButton_CheckedChanged);
            // 
            // cashradioButton
            // 
            this.cashradioButton.AutoSize = true;
            this.cashradioButton.Location = new System.Drawing.Point(169, 535);
            this.cashradioButton.Name = "cashradioButton";
            this.cashradioButton.Size = new System.Drawing.Size(49, 17);
            this.cashradioButton.TabIndex = 1;
            this.cashradioButton.TabStop = true;
            this.cashradioButton.Text = "Cash";
            this.cashradioButton.UseVisualStyleBackColor = true;
            // 
            // checkradioButton
            // 
            this.checkradioButton.AutoSize = true;
            this.checkradioButton.Location = new System.Drawing.Point(238, 535);
            this.checkradioButton.Name = "checkradioButton";
            this.checkradioButton.Size = new System.Drawing.Size(56, 17);
            this.checkradioButton.TabIndex = 2;
            this.checkradioButton.TabStop = true;
            this.checkradioButton.Text = "Check";
            this.checkradioButton.UseVisualStyleBackColor = true;
            // 
            // emailcheckBox
            // 
            this.emailcheckBox.AutoSize = true;
            this.emailcheckBox.Location = new System.Drawing.Point(169, 561);
            this.emailcheckBox.Name = "emailcheckBox";
            this.emailcheckBox.Size = new System.Drawing.Size(134, 17);
            this.emailcheckBox.TabIndex = 3;
            this.emailcheckBox.Text = "Email Receipt Request";
            this.emailcheckBox.UseVisualStyleBackColor = true;
            // 
            // paymenttypeLabel
            // 
            this.paymenttypeLabel.AutoSize = true;
            this.paymenttypeLabel.Location = new System.Drawing.Point(85, 535);
            this.paymenttypeLabel.Name = "paymenttypeLabel";
            this.paymenttypeLabel.Size = new System.Drawing.Size(78, 13);
            this.paymenttypeLabel.TabIndex = 0;
            this.paymenttypeLabel.Text = "Payment Type:";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 590);
            this.Controls.Add(this.paymenttypeLabel);
            this.Controls.Add(this.emailcheckBox);
            this.Controls.Add(this.checkradioButton);
            this.Controls.Add(this.cashradioButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.registrantgroupBox);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.datemaskedTextBox);
            this.Controls.Add(this.FilmpictureBox);
            this.Controls.Add(this.menuStrip);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.RegistrationForm_Load_1);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.registrantgroupBox.ResumeLayout(false);
            this.registrantgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilmpictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutStripMenuItem;
        private System.Windows.Forms.GroupBox registrantgroupBox;
        private System.Windows.Forms.ComboBox statuscomboBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox lastnametextBox;
        private System.Windows.Forms.TextBox firstnametextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.MaskedTextBox datemaskedTextBox;
        private System.Windows.Forms.PictureBox FilmpictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label classesLabel;
        private System.Windows.Forms.Label classtypeLabel;
        private System.Windows.Forms.RadioButton animationradioButton;
        private System.Windows.Forms.RadioButton liveradioButton;
        private System.Windows.Forms.ListBox classlistBox;
        private System.Windows.Forms.ToolStripMenuItem clearStripMenuItem;
        private System.Windows.Forms.RadioButton cashradioButton;
        private System.Windows.Forms.RadioButton checkradioButton;
        private System.Windows.Forms.CheckBox emailcheckBox;
        private System.Windows.Forms.Label totalpriceamountLabel;
        private System.Windows.Forms.Label priceperclassamountLabel;
        private System.Windows.Forms.Label totalclassesamountLabel;
        private System.Windows.Forms.Label totalpriceLabel;
        private System.Windows.Forms.Label priceperclassLabel;
        private System.Windows.Forms.Label totalclassesLabel;
        private System.Windows.Forms.Label paymenttypeLabel;
        private System.Windows.Forms.MaskedTextBox dobmaskedTextBox;
    }
}

