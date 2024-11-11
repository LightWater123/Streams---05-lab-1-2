namespace Streams_1
{
    partial class frmRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.studentNoTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.prog_cb = new System.Windows.Forms.ComboBox();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.middleNameTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gender_cb = new System.Windows.Forms.ComboBox();
            this.contactNumTxt = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birthday";
            // 
            // studentNoTxt
            // 
            this.studentNoTxt.Location = new System.Drawing.Point(96, 122);
            this.studentNoTxt.Name = "studentNoTxt";
            this.studentNoTxt.Size = new System.Drawing.Size(200, 20);
            this.studentNoTxt.TabIndex = 5;
            this.studentNoTxt.TextChanged += new System.EventHandler(this.studentNo_TextChanged);
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(96, 164);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(200, 20);
            this.lastNameTxt.TabIndex = 6;
            this.lastNameTxt.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // ageTxt
            // 
            this.ageTxt.Location = new System.Drawing.Point(96, 212);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(100, 20);
            this.ageTxt.TabIndex = 7;
            this.ageTxt.TextChanged += new System.EventHandler(this.ageTxt_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 252);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Program";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "First Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Contact No.";
            // 
            // prog_cb
            // 
            this.prog_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prog_cb.FormattingEnabled = true;
            this.prog_cb.Items.AddRange(new object[] {
            "BS Information Technology",
            "BS Computer Engineering",
            "BS Business Administration",
            "BS Hotel Management"});
            this.prog_cb.Location = new System.Drawing.Point(477, 121);
            this.prog_cb.Name = "prog_cb";
            this.prog_cb.Size = new System.Drawing.Size(311, 21);
            this.prog_cb.TabIndex = 13;
            this.prog_cb.SelectedIndexChanged += new System.EventHandler(this.prog_cb_SelectedIndexChanged);
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(477, 160);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(198, 20);
            this.firstNameTxt.TabIndex = 14;
            this.firstNameTxt.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // middleNameTxt
            // 
            this.middleNameTxt.Location = new System.Drawing.Point(720, 160);
            this.middleNameTxt.Name = "middleNameTxt";
            this.middleNameTxt.Size = new System.Drawing.Size(68, 20);
            this.middleNameTxt.TabIndex = 15;
            this.middleNameTxt.TextChanged += new System.EventHandler(this.middleName_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(689, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "M.I.";
            // 
            // gender_cb
            // 
            this.gender_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_cb.FormattingEnabled = true;
            this.gender_cb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_cb.Location = new System.Drawing.Point(477, 204);
            this.gender_cb.Name = "gender_cb";
            this.gender_cb.Size = new System.Drawing.Size(121, 21);
            this.gender_cb.TabIndex = 17;
            // 
            // contactNumTxt
            // 
            this.contactNumTxt.Location = new System.Drawing.Point(477, 252);
            this.contactNumTxt.Name = "contactNumTxt";
            this.contactNumTxt.Size = new System.Drawing.Size(311, 20);
            this.contactNumTxt.TabIndex = 18;
            this.contactNumTxt.TextChanged += new System.EventHandler(this.contactNum_TextChanged);
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(362, 312);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(75, 23);
            this.register_btn.TabIndex = 19;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Records";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.contactNumTxt);
            this.Controls.Add(this.gender_cb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.middleNameTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.prog_cb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ageTxt);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.studentNoTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox studentNoTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox prog_cb;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.TextBox middleNameTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox gender_cb;
        private System.Windows.Forms.TextBox contactNumTxt;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Button button1;
    }
}