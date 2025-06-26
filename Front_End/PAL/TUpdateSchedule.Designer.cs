namespace Front_End.PAL
{
    partial class TUpdateSchedule
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
            this.txtpmark = new System.Windows.Forms.TextBox();
            this.txttmark = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cmbusubject = new System.Windows.Forms.ComboBox();
            this.cmbutest = new System.Windows.Forms.ComboBox();
            this.cmbusec = new System.Windows.Forms.ComboBox();
            this.cmbuclass = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnupdate.BackColor = System.Drawing.Color.Navy;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(233, 576);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(217, 60);
            this.btnupdate.TabIndex = 36;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtpmark
            // 
            this.txtpmark.Location = new System.Drawing.Point(212, 449);
            this.txtpmark.Name = "txtpmark";
            this.txtpmark.Size = new System.Drawing.Size(282, 26);
            this.txtpmark.TabIndex = 35;
            // 
            // txttmark
            // 
            this.txttmark.Location = new System.Drawing.Point(212, 382);
            this.txttmark.Name = "txttmark";
            this.txttmark.Size = new System.Drawing.Size(282, 26);
            this.txttmark.TabIndex = 34;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(212, 520);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(282, 26);
            this.dtp.TabIndex = 33;
            // 
            // cmbusubject
            // 
            this.cmbusubject.FormattingEnabled = true;
            this.cmbusubject.Location = new System.Drawing.Point(212, 312);
            this.cmbusubject.Name = "cmbusubject";
            this.cmbusubject.Size = new System.Drawing.Size(282, 28);
            this.cmbusubject.TabIndex = 29;
            // 
            // cmbutest
            // 
            this.cmbutest.FormattingEnabled = true;
            this.cmbutest.Location = new System.Drawing.Point(212, 243);
            this.cmbutest.Name = "cmbutest";
            this.cmbutest.Size = new System.Drawing.Size(282, 28);
            this.cmbutest.TabIndex = 30;
            // 
            // cmbusec
            // 
            this.cmbusec.FormattingEnabled = true;
            this.cmbusec.Location = new System.Drawing.Point(212, 181);
            this.cmbusec.Name = "cmbusec";
            this.cmbusec.Size = new System.Drawing.Size(282, 28);
            this.cmbusec.TabIndex = 31;
            this.cmbusec.SelectedIndexChanged += new System.EventHandler(this.cmbusec_SelectedIndexChanged);
            // 
            // cmbuclass
            // 
            this.cmbuclass.FormattingEnabled = true;
            this.cmbuclass.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12"});
            this.cmbuclass.Location = new System.Drawing.Point(212, 117);
            this.cmbuclass.Name = "cmbuclass";
            this.cmbuclass.Size = new System.Drawing.Size(282, 28);
            this.cmbuclass.TabIndex = 32;
            this.cmbuclass.SelectedIndexChanged += new System.EventHandler(this.cmbuclass_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Passing Marks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Total Marks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Section";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Class";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(201, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 64);
            this.label9.TabIndex = 37;
            this.label9.Text = "Schedule";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(471, 650);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 70);
            this.button2.TabIndex = 61;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cmbuclass);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtp);
            this.panel1.Controls.Add(this.txtpmark);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txttmark);
            this.panel1.Controls.Add(this.cmbusec);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbusubject);
            this.panel1.Controls.Add(this.cmbutest);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(164, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 723);
            this.panel1.TabIndex = 62;
            // 
            // TUpdateSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 724);
            this.Controls.Add(this.panel1);
            this.Name = "TUpdateSchedule";
            this.Text = "TUpdateSchedule";
            this.Load += new System.EventHandler(this.TUpdateSchedule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtpmark;
        private System.Windows.Forms.TextBox txttmark;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ComboBox cmbusubject;
        private System.Windows.Forms.ComboBox cmbutest;
        private System.Windows.Forms.ComboBox cmbusec;
        private System.Windows.Forms.ComboBox cmbuclass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}