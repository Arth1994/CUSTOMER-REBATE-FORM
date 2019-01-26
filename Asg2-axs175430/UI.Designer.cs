namespace Asg2_axs175430
{
    partial class RebateForm
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
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textFName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.Label();
            this.MiddleInitial = new System.Windows.Forms.Label();
            this.textBoxMI = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.textBoxLN = new System.Windows.Forms.TextBox();
            this.Address1 = new System.Windows.Forms.Label();
            this.textAddress1 = new System.Windows.Forms.TextBox();
            this.Address2 = new System.Windows.Forms.Label();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.ZipCode = new System.Windows.Forms.Label();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.EmailAddress = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.ProofOfPurchase = new System.Windows.Forms.Label();
            this.comboBoxProof = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(285, 686);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 16;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(407, 686);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textFName
            // 
            this.textFName.Location = new System.Drawing.Point(173, 35);
            this.textFName.MaxLength = 20;
            this.textFName.Name = "textFName";
            this.textFName.Size = new System.Drawing.Size(110, 20);
            this.textFName.TabIndex = 2;
            this.textFName.TextChanged += new System.EventHandler(this.textFName_TextChanged);
            this.textFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFName__KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(173, 686);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(96, 35);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(61, 13);
            this.FirstName.TabIndex = 18;
            this.FirstName.Text = "First Name*";
            // 
            // MiddleInitial
            // 
            this.MiddleInitial.AutoSize = true;
            this.MiddleInitial.Location = new System.Drawing.Point(92, 84);
            this.MiddleInitial.Name = "MiddleInitial";
            this.MiddleInitial.Size = new System.Drawing.Size(65, 13);
            this.MiddleInitial.TabIndex = 19;
            this.MiddleInitial.Text = "Middle Initial";
            // 
            // textBoxMI
            // 
            this.textBoxMI.Location = new System.Drawing.Point(173, 77);
            this.textBoxMI.MaxLength = 1;
            this.textBoxMI.Name = "textBoxMI";
            this.textBoxMI.Size = new System.Drawing.Size(20, 20);
            this.textBoxMI.TabIndex = 3;
            this.textBoxMI.TextChanged += new System.EventHandler(this.textBoxMI_TextChanged);
            this.textBoxMI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMI_KeyPress);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(92, 124);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(65, 13);
            this.LastName.TabIndex = 20;
            this.LastName.Text = "Last Name* ";
            // 
            // textBoxLN
            // 
            this.textBoxLN.Location = new System.Drawing.Point(173, 121);
            this.textBoxLN.MaxLength = 20;
            this.textBoxLN.Name = "textBoxLN";
            this.textBoxLN.Size = new System.Drawing.Size(110, 20);
            this.textBoxLN.TabIndex = 4;
            this.textBoxLN.TextChanged += new System.EventHandler(this.textBoxLN_TextChanged);
            this.textBoxLN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLN_KeyPress);
            // 
            // Address1
            // 
            this.Address1.AutoSize = true;
            this.Address1.Location = new System.Drawing.Point(73, 181);
            this.Address1.Name = "Address1";
            this.Address1.Size = new System.Drawing.Size(84, 13);
            this.Address1.TabIndex = 21;
            this.Address1.Text = "Address Line 1* ";
            // 
            // textAddress1
            // 
            this.textAddress1.Location = new System.Drawing.Point(173, 178);
            this.textAddress1.MaxLength = 35;
            this.textAddress1.Name = "textAddress1";
            this.textAddress1.Size = new System.Drawing.Size(252, 20);
            this.textAddress1.TabIndex = 5;
            this.textAddress1.TextChanged += new System.EventHandler(this.textAddress1_TextChanged);
            this.textAddress1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAddress1_KeyPress);
            // 
            // Address2
            // 
            this.Address2.AutoSize = true;
            this.Address2.Location = new System.Drawing.Point(74, 225);
            this.Address2.Name = "Address2";
            this.Address2.Size = new System.Drawing.Size(83, 13);
            this.Address2.TabIndex = 22;
            this.Address2.Text = "Address Label 2";
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Location = new System.Drawing.Point(173, 222);
            this.textBoxAddress2.MaxLength = 35;
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(252, 20);
            this.textBoxAddress2.TabIndex = 6;
            this.textBoxAddress2.TextChanged += new System.EventHandler(this.textBoxAddress2_TextChanged);
            this.textBoxAddress2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddress2_KeyPress);
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(129, 283);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(28, 13);
            this.City.TabIndex = 23;
            this.City.Text = "City*";
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Location = new System.Drawing.Point(121, 342);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(36, 13);
            this.State.TabIndex = 24;
            this.State.Text = "State*";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(173, 280);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(154, 20);
            this.textBoxCity.TabIndex = 7;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
            this.textBoxCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCity__KeyPress);
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(173, 335);
            this.textBoxState.MaxLength = 2;
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(35, 20);
            this.textBoxState.TabIndex = 8;
            this.textBoxState.TextChanged += new System.EventHandler(this.textBoxState_TextChanged);
            this.textBoxState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxState_KeyPress);
            // 
            // ZipCode
            // 
            this.ZipCode.AutoSize = true;
            this.ZipCode.Location = new System.Drawing.Point(100, 400);
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.Size = new System.Drawing.Size(57, 13);
            this.ZipCode.TabIndex = 26;
            this.ZipCode.Text = "Zip Code* ";
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(173, 393);
            this.textBoxZipCode.MaxLength = 9;
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(89, 20);
            this.textBoxZipCode.TabIndex = 9;
            this.textBoxZipCode.TextChanged += new System.EventHandler(this.textBoxZipCode_TextChanged);
            this.textBoxZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxZipCode_KeyPress);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(111, 456);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(46, 13);
            this.Gender.TabIndex = 28;
            this.Gender.Text = "Gender*";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(72, 504);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(85, 13);
            this.PhoneNumber.TabIndex = 31;
            this.PhoneNumber.Text = "Phone Number* ";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownWidth = 100;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(173, 448);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(89, 21);
            this.comboBoxGender.TabIndex = 10;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(173, 497);
            this.textBoxPhone.MaxLength = 21;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(121, 20);
            this.textBoxPhone.TabIndex = 11;
            this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // EmailAddress
            // 
            this.EmailAddress.AutoSize = true;
            this.EmailAddress.Location = new System.Drawing.Point(80, 546);
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(77, 13);
            this.EmailAddress.TabIndex = 34;
            this.EmailAddress.Text = "Email Address*";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(173, 543);
            this.textBoxEmail.MaxLength = 60;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(309, 20);
            this.textBoxEmail.TabIndex = 12;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            this.textBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxemail_KeyPress);
            // 
            // ProofOfPurchase
            // 
            this.ProofOfPurchase.AutoSize = true;
            this.ProofOfPurchase.Location = new System.Drawing.Point(13, 590);
            this.ProofOfPurchase.Name = "ProofOfPurchase";
            this.ProofOfPurchase.Size = new System.Drawing.Size(148, 13);
            this.ProofOfPurchase.TabIndex = 36;
            this.ProofOfPurchase.Text = "Proof of Purchase Attached?*";
            // 
            // comboBoxProof
            // 
            this.comboBoxProof.FormattingEnabled = true;
            this.comboBoxProof.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxProof.Location = new System.Drawing.Point(173, 582);
            this.comboBoxProof.Name = "comboBoxProof";
            this.comboBoxProof.Size = new System.Drawing.Size(64, 21);
            this.comboBoxProof.TabIndex = 13;
            this.comboBoxProof.SelectedIndexChanged += new System.EventHandler(this.comboBoxProof_SelectedIndexChanged);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(71, 640);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(86, 13);
            this.Date.TabIndex = 38;
            this.Date.Text = "Date Received* ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 634);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFullName,
            this.columnPhoneNumber});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(533, 35);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(370, 711);
            this.listView1.TabIndex = 40;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.VirtualListSize = 10000;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnFullName
            // 
            this.columnFullName.Text = "Full Name";
            this.columnFullName.Width = 191;
            // 
            // columnPhoneNumber
            // 
            this.columnPhoneNumber.Text = "Phone Number";
            this.columnPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPhoneNumber.Width = 172;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 721);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(309, 25);
            this.textBox2.TabIndex = 41;
            this.textBox2.Text = "Messages for you";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 776);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(919, 22);
            this.statusStrip1.TabIndex = 42;
            this.statusStrip1.Text = "statusDisplay";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel1.Text = "Status Messages";
            // 
            // RebateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(919, 798);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.comboBoxProof);
            this.Controls.Add(this.ProofOfPurchase);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.EmailAddress);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.textBoxZipCode);
            this.Controls.Add(this.ZipCode);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.State);
            this.Controls.Add(this.City);
            this.Controls.Add(this.textBoxAddress2);
            this.Controls.Add(this.Address2);
            this.Controls.Add(this.textAddress1);
            this.Controls.Add(this.Address1);
            this.Controls.Add(this.textBoxLN);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.textBoxMI);
            this.Controls.Add(this.MiddleInitial);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textFName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Name = "RebateForm";
            this.Text = "Rebate Form";
            this.Load += new System.EventHandler(this.RebateForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textFName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label MiddleInitial;
        private System.Windows.Forms.TextBox textBoxMI;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox textBoxLN;
        private System.Windows.Forms.Label Address1;
        private System.Windows.Forms.TextBox textAddress1;
        private System.Windows.Forms.Label Address2;
        private System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Label ZipCode;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label EmailAddress;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label ProofOfPurchase;
        private System.Windows.Forms.ComboBox comboBoxProof;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnFullName;
        private System.Windows.Forms.ColumnHeader columnPhoneNumber;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

