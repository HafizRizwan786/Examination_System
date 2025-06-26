namespace Front_End.PAL
{
    partial class TAddSchedule
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbclass = new System.Windows.Forms.ComboBox();
            this.cmbSec = new System.Windows.Forms.ComboBox();
            this.cmbTest = new System.Windows.Forms.ComboBox();
            this.cmbSub = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Passing Marks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Marks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Section";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Class";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 59);
            this.label1.TabIndex = 8;
            this.label1.Text = "Schedule";
            // 
            // cmbclass
            // 
            this.cmbclass.FormattingEnabled = true;
            this.cmbclass.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12"});
            this.cmbclass.Location = new System.Drawing.Point(183, 127);
            this.cmbclass.Name = "cmbclass";
            this.cmbclass.Size = new System.Drawing.Size(295, 28);
            this.cmbclass.TabIndex = 16;
            this.cmbclass.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbSec
            // 
            this.cmbSec.FormattingEnabled = true;
            this.cmbSec.Location = new System.Drawing.Point(186, 191);
            this.cmbSec.Name = "cmbSec";
            this.cmbSec.Size = new System.Drawing.Size(292, 28);
            this.cmbSec.TabIndex = 16;
            this.cmbSec.SelectedIndexChanged += new System.EventHandler(this.cmbSec_SelectedIndexChanged);
            // 
            // cmbTest
            // 
            this.cmbTest.FormattingEnabled = true;
            this.cmbTest.Location = new System.Drawing.Point(186, 248);
            this.cmbTest.Name = "cmbTest";
            this.cmbTest.Size = new System.Drawing.Size(292, 28);
            this.cmbTest.TabIndex = 16;
            // 
            // cmbSub
            // 
            this.cmbSub.FormattingEnabled = true;
            this.cmbSub.Location = new System.Drawing.Point(183, 310);
            this.cmbSub.Name = "cmbSub";
            this.cmbSub.Size = new System.Drawing.Size(295, 28);
            this.cmbSub.TabIndex = 16;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(183, 504);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(292, 26);
            this.dtp.TabIndex = 17;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(186, 374);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(292, 26);
            this.txtTotal.TabIndex = 18;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(186, 440);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(292, 26);
            this.txtPass.TabIndex = 19;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Navy;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(199, 568);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(205, 62);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(432, 653);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 63);
            this.button5.TabIndex = 24;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.cmbclass);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtp);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.cmbSec);
            this.panel1.Controls.Add(this.cmbTest);
            this.panel1.Controls.Add(this.cmbSub);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(172, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 729);
            this.panel1.TabIndex = 25;
            // 
            // TAddSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 731);
            this.Controls.Add(this.panel1);
            this.Name = "TAddSchedule";
            this.Text = "TAddSchedule";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbclass;
        private System.Windows.Forms.ComboBox cmbSec;
        private System.Windows.Forms.ComboBox cmbTest;
        private System.Windows.Forms.ComboBox cmbSub;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
    }
}