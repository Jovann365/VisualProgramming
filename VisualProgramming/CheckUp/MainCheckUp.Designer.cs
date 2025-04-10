namespace VisualProgramming.CheckUp
{
    partial class MainCheckUp
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
            this.lbPatients = new System.Windows.Forms.ListBox();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnRemovePatient = new System.Windows.Forms.Button();
            this.cbMesName = new System.Windows.Forms.ComboBox();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.btnAddMesurement = new System.Windows.Forms.Button();
            this.lbMesurements = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPatients
            // 
            this.lbPatients.FormattingEnabled = true;
            this.lbPatients.Location = new System.Drawing.Point(13, 29);
            this.lbPatients.Name = "lbPatients";
            this.lbPatients.Size = new System.Drawing.Size(166, 290);
            this.lbPatients.TabIndex = 0;
            this.lbPatients.SelectedIndexChanged += new System.EventHandler(this.lbPatients_SelectedIndexChanged);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(13, 326);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(166, 23);
            this.btnAddPatient.TabIndex = 1;
            this.btnAddPatient.Text = "Додади пациент";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnRemovePatient
            // 
            this.btnRemovePatient.Location = new System.Drawing.Point(13, 355);
            this.btnRemovePatient.Name = "btnRemovePatient";
            this.btnRemovePatient.Size = new System.Drawing.Size(166, 23);
            this.btnRemovePatient.TabIndex = 2;
            this.btnRemovePatient.Text = "Избриши пациент";
            this.btnRemovePatient.UseVisualStyleBackColor = true;
            this.btnRemovePatient.Click += new System.EventHandler(this.btnRemovePatient_Click);
            // 
            // cbMesName
            // 
            this.cbMesName.FormattingEnabled = true;
            this.cbMesName.Items.AddRange(new object[] {
            "Леукоцити: 2000 - 16000",
            "Еритроцити: 4 - 7"});
            this.cbMesName.Location = new System.Drawing.Point(18, 34);
            this.cbMesName.Name = "cbMesName";
            this.cbMesName.Size = new System.Drawing.Size(211, 21);
            this.cbMesName.TabIndex = 3;
            // 
            // nudValue
            // 
            this.nudValue.Location = new System.Drawing.Point(18, 82);
            this.nudValue.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(211, 20);
            this.nudValue.TabIndex = 4;
            // 
            // btnAddMesurement
            // 
            this.btnAddMesurement.Location = new System.Drawing.Point(123, 108);
            this.btnAddMesurement.Name = "btnAddMesurement";
            this.btnAddMesurement.Size = new System.Drawing.Size(106, 23);
            this.btnAddMesurement.TabIndex = 5;
            this.btnAddMesurement.Text = "Додади мерење";
            this.btnAddMesurement.UseVisualStyleBackColor = true;
            this.btnAddMesurement.Click += new System.EventHandler(this.btnAddMesurement_Click);
            // 
            // lbMesurements
            // 
            this.lbMesurements.FormattingEnabled = true;
            this.lbMesurements.Location = new System.Drawing.Point(197, 202);
            this.lbMesurements.Name = "lbMesurements";
            this.lbMesurements.Size = new System.Drawing.Size(246, 147);
            this.lbMesurements.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Пациенти";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddMesurement);
            this.groupBox1.Controls.Add(this.nudValue);
            this.groupBox1.Controls.Add(this.cbMesName);
            this.groupBox1.Location = new System.Drawing.Point(197, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 137);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Доади мерење";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вид на мерење:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вредност:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Мерења";
            // 
            // MainCheckUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 392);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMesurements);
            this.Controls.Add(this.btnRemovePatient);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.lbPatients);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainCheckUp";
            this.Text = "MainCheckUp";
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPatients;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnRemovePatient;
        private System.Windows.Forms.ComboBox cbMesName;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Button btnAddMesurement;
        private System.Windows.Forms.ListBox lbMesurements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}