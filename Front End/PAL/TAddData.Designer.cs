namespace Front_End.PAL
{
    partial class TAddData
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
            this.btnadd = new System.Windows.Forms.Button();
            this.cmbsub = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtgmark = new System.Windows.Forms.TextBox();
            this.txtrno = new System.Windows.Forms.TextBox();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.cmbtest = new System.Windows.Forms.ComboBox();
            this.cmbsec = new System.Windows.Forms.ComboBox();
            this.cmbclass = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltname = new System.Windows.Forms.Label();
            this.txtmark = new System.Windows.Forms.TextBox();
            this.txtper = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(311, 457);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(128, 40);
            this.btnadd.TabIndex = 44;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cmbsub
            // 
            this.cmbsub.FormattingEnabled = true;
            this.cmbsub.Location = new System.Drawing.Point(564, 129);
            this.cmbsub.Name = "cmbsub";
            this.cmbsub.Size = new System.Drawing.Size(121, 28);
            this.cmbsub.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(464, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "Subject";
            // 
            // txtgmark
            // 
            this.txtgmark.Location = new System.Drawing.Point(287, 354);
            this.txtgmark.Name = "txtgmark";
            this.txtgmark.Size = new System.Drawing.Size(100, 26);
            this.txtgmark.TabIndex = 38;
            this.txtgmark.TextChanged += new System.EventHandler(this.txtgmark_TextChanged);
            // 
            // txtrno
            // 
            this.txtrno.Location = new System.Drawing.Point(287, 273);
            this.txtrno.Name = "txtrno";
            this.txtrno.Size = new System.Drawing.Size(121, 26);
            this.txtrno.TabIndex = 37;
            // 
            // txtsname
            // 
            this.txtsname.Location = new System.Drawing.Point(287, 226);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(121, 26);
            this.txtsname.TabIndex = 36;
            // 
            // cmbtest
            // 
            this.cmbtest.FormattingEnabled = true;
            this.cmbtest.Location = new System.Drawing.Point(287, 179);
            this.cmbtest.Name = "cmbtest";
            this.cmbtest.Size = new System.Drawing.Size(121, 28);
            this.cmbtest.TabIndex = 34;
            // 
            // cmbsec
            // 
            this.cmbsec.FormattingEnabled = true;
            this.cmbsec.Location = new System.Drawing.Point(287, 129);
            this.cmbsec.Name = "cmbsec";
            this.cmbsec.Size = new System.Drawing.Size(121, 28);
            this.cmbsec.TabIndex = 33;
            // 
            // cmbclass
            // 
            this.cmbclass.FormattingEnabled = true;
            this.cmbclass.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12"});
            this.cmbclass.Location = new System.Drawing.Point(287, 86);
            this.cmbclass.Name = "cmbclass";
            this.cmbclass.Size = new System.Drawing.Size(121, 28);
            this.cmbclass.TabIndex = 32;
            this.cmbclass.SelectedIndexChanged += new System.EventHandler(this.cmbclass_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Percentage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Gain Marks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Total Marks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Registration No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Data Entry";
            // 
            // lbltname
            // 
            this.lbltname.AutoSize = true;
            this.lbltname.Location = new System.Drawing.Point(550, 33);
            this.lbltname.Name = "lbltname";
            this.lbltname.Size = new System.Drawing.Size(113, 20);
            this.lbltname.TabIndex = 58;
            this.lbltname.Text = "Teacher Name";
            // 
            // txtmark
            // 
            this.txtmark.Location = new System.Drawing.Point(287, 313);
            this.txtmark.Name = "txtmark";
            this.txtmark.Size = new System.Drawing.Size(100, 26);
            this.txtmark.TabIndex = 38;
            // 
            // txtper
            // 
            this.txtper.Location = new System.Drawing.Point(287, 396);
            this.txtper.Name = "txtper";
            this.txtper.Size = new System.Drawing.Size(100, 26);
            this.txtper.TabIndex = 38;
            // 
            // TAddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 535);
            this.Controls.Add(this.lbltname);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cmbsub);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtmark);
            this.Controls.Add(this.txtper);
            this.Controls.Add(this.txtgmark);
            this.Controls.Add(this.txtrno);
            this.Controls.Add(this.txtsname);
            this.Controls.Add(this.cmbtest);
            this.Controls.Add(this.cmbsec);
            this.Controls.Add(this.cmbclass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TAddData";
            this.Text = "TAddData";
            this.Load += new System.EventHandler(this.TAddData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox cmbsub;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtgmark;
        private System.Windows.Forms.TextBox txtrno;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.ComboBox cmbtest;
        private System.Windows.Forms.ComboBox cmbsec;
        private System.Windows.Forms.ComboBox cmbclass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltname;
        private System.Windows.Forms.TextBox txtmark;
        private System.Windows.Forms.TextBox txtper;
    }
}