namespace Front_End.PAL
{
    partial class TUpdateData
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
            this.btnupdate = new System.Windows.Forms.Button();
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
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(293, 463);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(128, 40);
            this.btnupdate.TabIndex = 66;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // cmbsub
            // 
            this.cmbsub.FormattingEnabled = true;
            this.cmbsub.Location = new System.Drawing.Point(546, 135);
            this.cmbsub.Name = "cmbsub";
            this.cmbsub.Size = new System.Drawing.Size(121, 28);
            this.cmbsub.TabIndex = 65;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(446, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 20);
            this.label13.TabIndex = 64;
            this.label13.Text = "Subject";
            // 
            // txtgmark
            // 
            this.txtgmark.Location = new System.Drawing.Point(269, 344);
            this.txtgmark.Name = "txtgmark";
            this.txtgmark.Size = new System.Drawing.Size(100, 26);
            this.txtgmark.TabIndex = 60;
            this.txtgmark.TextChanged += new System.EventHandler(this.txtgmark_TextChanged);
            // 
            // txtrno
            // 
            this.txtrno.Location = new System.Drawing.Point(269, 273);
            this.txtrno.Name = "txtrno";
            this.txtrno.Size = new System.Drawing.Size(100, 26);
            this.txtrno.TabIndex = 59;
            // 
            // txtsname
            // 
            this.txtsname.Location = new System.Drawing.Point(269, 229);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(100, 26);
            this.txtsname.TabIndex = 58;
            this.txtsname.TextChanged += new System.EventHandler(this.txtsname_TextChanged);
            // 
            // cmbtest
            // 
            this.cmbtest.FormattingEnabled = true;
            this.cmbtest.Location = new System.Drawing.Point(269, 185);
            this.cmbtest.Name = "cmbtest";
            this.cmbtest.Size = new System.Drawing.Size(121, 28);
            this.cmbtest.TabIndex = 56;
            // 
            // cmbsec
            // 
            this.cmbsec.FormattingEnabled = true;
            this.cmbsec.Location = new System.Drawing.Point(269, 135);
            this.cmbsec.Name = "cmbsec";
            this.cmbsec.Size = new System.Drawing.Size(121, 28);
            this.cmbsec.TabIndex = 55;
            // 
            // cmbclass
            // 
            this.cmbclass.FormattingEnabled = true;
            this.cmbclass.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12"});
            this.cmbclass.Location = new System.Drawing.Point(269, 92);
            this.cmbclass.Name = "cmbclass";
            this.cmbclass.Size = new System.Drawing.Size(121, 28);
            this.cmbclass.TabIndex = 54;
            this.cmbclass.SelectedIndexChanged += new System.EventHandler(this.cmbclass_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Percentage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "Gain Marks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Total Marks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Registration No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Data Entry";
            // 
            // lbltname
            // 
            this.lbltname.AutoSize = true;
            this.lbltname.Location = new System.Drawing.Point(387, 45);
            this.lbltname.Name = "lbltname";
            this.lbltname.Size = new System.Drawing.Size(113, 20);
            this.lbltname.TabIndex = 57;
            this.lbltname.Text = "Teacher Name";
            // 
            // txtmark
            // 
            this.txtmark.Location = new System.Drawing.Point(269, 313);
            this.txtmark.Name = "txtmark";
            this.txtmark.Size = new System.Drawing.Size(100, 26);
            this.txtmark.TabIndex = 60;
            // 
            // txtper
            // 
            this.txtper.Location = new System.Drawing.Point(269, 388);
            this.txtper.Name = "txtper";
            this.txtper.Size = new System.Drawing.Size(100, 26);
            this.txtper.TabIndex = 60;
            // 
            // TUpdateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.cmbsub);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtmark);
            this.Controls.Add(this.txtper);
            this.Controls.Add(this.txtgmark);
            this.Controls.Add(this.txtrno);
            this.Controls.Add(this.txtsname);
            this.Controls.Add(this.lbltname);
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
            this.Name = "TUpdateData";
            this.Text = "TUpdateData";
            this.Load += new System.EventHandler(this.TUpdateData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
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