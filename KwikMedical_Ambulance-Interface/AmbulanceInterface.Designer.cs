namespace KwikMedical_Ambulance_Interface
{
    partial class AmbulanceInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmbulanceInterface));
            this.grp_patientDetails = new System.Windows.Forms.GroupBox();
            this.date_dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.panel_gender = new System.Windows.Forms.Panel();
            this.radio_female = new System.Windows.Forms.RadioButton();
            this.radio_male = new System.Windows.Forms.RadioButton();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_patientNo = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.tb_patientNo = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.tb_houseNo = new System.Windows.Forms.TextBox();
            this.tb_streetName = new System.Windows.Forms.TextBox();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.tb_postcode = new System.Windows.Forms.TextBox();
            this.tb_telephone = new System.Windows.Forms.TextBox();
            this.tb_callDetails = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_postcode = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_streetName = new System.Windows.Forms.Label();
            this.lbl_houseNo = new System.Windows.Forms.Label();
            this.menu_main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.group_contactInfo = new System.Windows.Forms.GroupBox();
            this.lbl_telephone = new System.Windows.Forms.Label();
            this.group_callDetails = new System.Windows.Forms.GroupBox();
            this.lbl_callTime = new System.Windows.Forms.Label();
            this.tb_callTime = new System.Windows.Forms.TextBox();
            this.btn_logCall = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grp_patientDetails.SuspendLayout();
            this.panel_gender.SuspendLayout();
            this.menu_main.SuspendLayout();
            this.group_contactInfo.SuspendLayout();
            this.group_callDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_patientDetails
            // 
            this.grp_patientDetails.Controls.Add(this.date_dateOfBirth);
            this.grp_patientDetails.Controls.Add(this.panel_gender);
            this.grp_patientDetails.Controls.Add(this.lbl_gender);
            this.grp_patientDetails.Controls.Add(this.lbl_dob);
            this.grp_patientDetails.Controls.Add(this.lbl_patientNo);
            this.grp_patientDetails.Controls.Add(this.lbl_lastName);
            this.grp_patientDetails.Controls.Add(this.lbl_firstName);
            this.grp_patientDetails.Controls.Add(this.tb_patientNo);
            this.grp_patientDetails.Controls.Add(this.tb_lastName);
            this.grp_patientDetails.Controls.Add(this.tb_firstName);
            this.grp_patientDetails.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_patientDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(94)))), ((int)(((byte)(119)))));
            this.grp_patientDetails.Location = new System.Drawing.Point(24, 63);
            this.grp_patientDetails.Name = "grp_patientDetails";
            this.grp_patientDetails.Size = new System.Drawing.Size(349, 196);
            this.grp_patientDetails.TabIndex = 4;
            this.grp_patientDetails.TabStop = false;
            this.grp_patientDetails.Text = "Patient Details";
            // 
            // date_dateOfBirth
            // 
            this.date_dateOfBirth.CustomFormat = "yyyy-MM-dd";
            this.date_dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_dateOfBirth.Location = new System.Drawing.Point(124, 118);
            this.date_dateOfBirth.Name = "date_dateOfBirth";
            this.date_dateOfBirth.Size = new System.Drawing.Size(200, 25);
            this.date_dateOfBirth.TabIndex = 20;
            // 
            // panel_gender
            // 
            this.panel_gender.Controls.Add(this.radio_female);
            this.panel_gender.Controls.Add(this.radio_male);
            this.panel_gender.Location = new System.Drawing.Point(124, 144);
            this.panel_gender.Name = "panel_gender";
            this.panel_gender.Size = new System.Drawing.Size(182, 29);
            this.panel_gender.TabIndex = 6;
            // 
            // radio_female
            // 
            this.radio_female.AutoSize = true;
            this.radio_female.Location = new System.Drawing.Point(85, 3);
            this.radio_female.Name = "radio_female";
            this.radio_female.Size = new System.Drawing.Size(78, 21);
            this.radio_female.TabIndex = 21;
            this.radio_female.TabStop = true;
            this.radio_female.Text = "Female";
            this.radio_female.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            this.radio_male.AutoSize = true;
            this.radio_male.Location = new System.Drawing.Point(4, 3);
            this.radio_male.Name = "radio_male";
            this.radio_male.Size = new System.Drawing.Size(59, 21);
            this.radio_male.TabIndex = 20;
            this.radio_male.TabStop = true;
            this.radio_male.Text = "Male";
            this.radio_male.UseVisualStyleBackColor = true;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(25, 147);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(56, 17);
            this.lbl_gender.TabIndex = 19;
            this.lbl_gender.Text = "Gender";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Location = new System.Drawing.Point(25, 122);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(49, 17);
            this.lbl_dob.TabIndex = 15;
            this.lbl_dob.Text = "D.O.B";
            // 
            // lbl_patientNo
            // 
            this.lbl_patientNo.AutoSize = true;
            this.lbl_patientNo.Location = new System.Drawing.Point(25, 94);
            this.lbl_patientNo.Name = "lbl_patientNo";
            this.lbl_patientNo.Size = new System.Drawing.Size(73, 17);
            this.lbl_patientNo.TabIndex = 5;
            this.lbl_patientNo.Text = "NHS Reg.";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Location = new System.Drawing.Point(25, 67);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(79, 17);
            this.lbl_lastName.TabIndex = 4;
            this.lbl_lastName.Text = "Last Name";
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Location = new System.Drawing.Point(25, 40);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(80, 17);
            this.lbl_firstName.TabIndex = 3;
            this.lbl_firstName.Text = "First Name";
            // 
            // tb_patientNo
            // 
            this.tb_patientNo.Location = new System.Drawing.Point(124, 92);
            this.tb_patientNo.Name = "tb_patientNo";
            this.tb_patientNo.Size = new System.Drawing.Size(182, 25);
            this.tb_patientNo.TabIndex = 0;
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(124, 66);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(182, 25);
            this.tb_lastName.TabIndex = 2;
            // 
            // tb_firstName
            // 
            this.tb_firstName.Location = new System.Drawing.Point(124, 40);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(139, 25);
            this.tb_firstName.TabIndex = 1;
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.btn_enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_enter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(84)))), ((int)(((byte)(118)))));
            this.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(94)))), ((int)(((byte)(119)))));
            this.btn_enter.Location = new System.Drawing.Point(754, 313);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(122, 36);
            this.btn_enter.TabIndex = 3;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // tb_houseNo
            // 
            this.tb_houseNo.Location = new System.Drawing.Point(116, 37);
            this.tb_houseNo.Name = "tb_houseNo";
            this.tb_houseNo.Size = new System.Drawing.Size(115, 25);
            this.tb_houseNo.TabIndex = 7;
            // 
            // tb_streetName
            // 
            this.tb_streetName.Location = new System.Drawing.Point(116, 63);
            this.tb_streetName.Name = "tb_streetName";
            this.tb_streetName.Size = new System.Drawing.Size(232, 25);
            this.tb_streetName.TabIndex = 6;
            // 
            // tb_city
            // 
            this.tb_city.Location = new System.Drawing.Point(116, 89);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(143, 25);
            this.tb_city.TabIndex = 8;
            // 
            // tb_postcode
            // 
            this.tb_postcode.Location = new System.Drawing.Point(116, 116);
            this.tb_postcode.Name = "tb_postcode";
            this.tb_postcode.Size = new System.Drawing.Size(115, 25);
            this.tb_postcode.TabIndex = 9;
            // 
            // tb_telephone
            // 
            this.tb_telephone.Location = new System.Drawing.Point(116, 144);
            this.tb_telephone.Name = "tb_telephone";
            this.tb_telephone.Size = new System.Drawing.Size(143, 25);
            this.tb_telephone.TabIndex = 14;
            // 
            // tb_callDetails
            // 
            this.tb_callDetails.Location = new System.Drawing.Point(23, 30);
            this.tb_callDetails.Multiline = true;
            this.tb_callDetails.Name = "tb_callDetails";
            this.tb_callDetails.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_callDetails.Size = new System.Drawing.Size(424, 146);
            this.tb_callDetails.TabIndex = 20;
            this.tb_callDetails.Text = "Please give details of the call...";
            this.tb_callDetails.Click += new System.EventHandler(this.tb_callDetails_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(84)))), ((int)(((byte)(118)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(94)))), ((int)(((byte)(119)))));
            this.btn_clear.Location = new System.Drawing.Point(754, 361);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(122, 36);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_postcode
            // 
            this.lbl_postcode.AutoSize = true;
            this.lbl_postcode.Location = new System.Drawing.Point(25, 119);
            this.lbl_postcode.Name = "lbl_postcode";
            this.lbl_postcode.Size = new System.Drawing.Size(70, 17);
            this.lbl_postcode.TabIndex = 13;
            this.lbl_postcode.Text = "Postcode";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(25, 92);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(33, 17);
            this.lbl_city.TabIndex = 12;
            this.lbl_city.Text = "City";
            // 
            // lbl_streetName
            // 
            this.lbl_streetName.AutoSize = true;
            this.lbl_streetName.Location = new System.Drawing.Point(25, 66);
            this.lbl_streetName.Name = "lbl_streetName";
            this.lbl_streetName.Size = new System.Drawing.Size(90, 17);
            this.lbl_streetName.TabIndex = 11;
            this.lbl_streetName.Text = "Street Name";
            // 
            // lbl_houseNo
            // 
            this.lbl_houseNo.AutoSize = true;
            this.lbl_houseNo.Location = new System.Drawing.Point(25, 40);
            this.lbl_houseNo.Name = "lbl_houseNo";
            this.lbl_houseNo.Size = new System.Drawing.Size(76, 17);
            this.lbl_houseNo.TabIndex = 10;
            this.lbl_houseNo.Text = "House No.";
            // 
            // menu_main
            // 
            this.menu_main.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menu_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu_main.Location = new System.Drawing.Point(0, 0);
            this.menu_main.Name = "menu_main";
            this.menu_main.Size = new System.Drawing.Size(972, 28);
            this.menu_main.TabIndex = 5;
            this.menu_main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // group_contactInfo
            // 
            this.group_contactInfo.Controls.Add(this.lbl_telephone);
            this.group_contactInfo.Controls.Add(this.tb_telephone);
            this.group_contactInfo.Controls.Add(this.lbl_houseNo);
            this.group_contactInfo.Controls.Add(this.lbl_city);
            this.group_contactInfo.Controls.Add(this.lbl_postcode);
            this.group_contactInfo.Controls.Add(this.lbl_streetName);
            this.group_contactInfo.Controls.Add(this.tb_streetName);
            this.group_contactInfo.Controls.Add(this.tb_postcode);
            this.group_contactInfo.Controls.Add(this.tb_houseNo);
            this.group_contactInfo.Controls.Add(this.tb_city);
            this.group_contactInfo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_contactInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(94)))), ((int)(((byte)(119)))));
            this.group_contactInfo.Location = new System.Drawing.Point(388, 63);
            this.group_contactInfo.Name = "group_contactInfo";
            this.group_contactInfo.Size = new System.Drawing.Size(373, 196);
            this.group_contactInfo.TabIndex = 15;
            this.group_contactInfo.TabStop = false;
            this.group_contactInfo.Text = "Contact Info.";
            // 
            // lbl_telephone
            // 
            this.lbl_telephone.AutoSize = true;
            this.lbl_telephone.Location = new System.Drawing.Point(25, 147);
            this.lbl_telephone.Name = "lbl_telephone";
            this.lbl_telephone.Size = new System.Drawing.Size(30, 17);
            this.lbl_telephone.TabIndex = 15;
            this.lbl_telephone.Text = "Tel:";
            // 
            // group_callDetails
            // 
            this.group_callDetails.Controls.Add(this.lbl_callTime);
            this.group_callDetails.Controls.Add(this.tb_callTime);
            this.group_callDetails.Controls.Add(this.btn_logCall);
            this.group_callDetails.Controls.Add(this.tb_callDetails);
            this.group_callDetails.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_callDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(94)))), ((int)(((byte)(119)))));
            this.group_callDetails.Location = new System.Drawing.Point(24, 275);
            this.group_callDetails.Name = "group_callDetails";
            this.group_callDetails.Size = new System.Drawing.Size(635, 194);
            this.group_callDetails.TabIndex = 16;
            this.group_callDetails.TabStop = false;
            this.group_callDetails.Text = "Emergency Call Details";
            // 
            // lbl_callTime
            // 
            this.lbl_callTime.AutoSize = true;
            this.lbl_callTime.Location = new System.Drawing.Point(453, 40);
            this.lbl_callTime.Name = "lbl_callTime";
            this.lbl_callTime.Size = new System.Drawing.Size(172, 17);
            this.lbl_callTime.TabIndex = 22;
            this.lbl_callTime.Text = "Time spent on call (mins)";
            // 
            // tb_callTime
            // 
            this.tb_callTime.Location = new System.Drawing.Point(477, 60);
            this.tb_callTime.Name = "tb_callTime";
            this.tb_callTime.Size = new System.Drawing.Size(122, 25);
            this.tb_callTime.TabIndex = 21;
            // 
            // btn_logCall
            // 
            this.btn_logCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.btn_logCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_logCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logCall.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logCall.Location = new System.Drawing.Point(477, 113);
            this.btn_logCall.Name = "btn_logCall";
            this.btn_logCall.Size = new System.Drawing.Size(122, 36);
            this.btn_logCall.TabIndex = 18;
            this.btn_logCall.Text = "Log Call";
            this.btn_logCall.UseVisualStyleBackColor = false;
            this.btn_logCall.Click += new System.EventHandler(this.btn_logCall_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(84)))), ((int)(((byte)(118)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(94)))), ((int)(((byte)(119)))));
            this.btn_update.Location = new System.Drawing.Point(754, 409);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(122, 36);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(767, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AmbulanceInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(972, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.group_callDetails);
            this.Controls.Add(this.group_contactInfo);
            this.Controls.Add(this.grp_patientDetails);
            this.Controls.Add(this.menu_main);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_enter);
            this.MainMenuStrip = this.menu_main;
            this.Name = "AmbulanceInterface";
            this.Text = "KwikMedical";
            this.grp_patientDetails.ResumeLayout(false);
            this.grp_patientDetails.PerformLayout();
            this.panel_gender.ResumeLayout(false);
            this.panel_gender.PerformLayout();
            this.menu_main.ResumeLayout(false);
            this.menu_main.PerformLayout();
            this.group_contactInfo.ResumeLayout(false);
            this.group_contactInfo.PerformLayout();
            this.group_callDetails.ResumeLayout(false);
            this.group_callDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.TextBox tb_patientNo;
        private System.Windows.Forms.DateTimePicker date_dateOfBirth;
        private System.Windows.Forms.Panel panel_gender;
        private System.Windows.Forms.RadioButton radio_male;
        private System.Windows.Forms.RadioButton radio_female;
        private System.Windows.Forms.TextBox tb_houseNo;
        private System.Windows.Forms.TextBox tb_streetName;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.TextBox tb_postcode;
        private System.Windows.Forms.TextBox tb_telephone;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.GroupBox grp_patientDetails;
        private System.Windows.Forms.Label lbl_patientNo;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_houseNo;
        private System.Windows.Forms.Label lbl_postcode;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_streetName;
        private System.Windows.Forms.MenuStrip menu_main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.GroupBox group_contactInfo;
        private System.Windows.Forms.Label lbl_telephone;
        private System.Windows.Forms.GroupBox group_callDetails;
        private System.Windows.Forms.TextBox tb_callDetails;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button btn_logCall;
        private System.Windows.Forms.Label lbl_callTime;
        private System.Windows.Forms.TextBox tb_callTime;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

