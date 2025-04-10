namespace VisualProgramming.F1Race
{
    partial class MainF1
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
            this.lbDrivers = new System.Windows.Forms.ListBox();
            this.lbCircles = new System.Windows.Forms.ListBox();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.btnRemoveDriver = new System.Windows.Forms.Button();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.btnAddCircle = new System.Windows.Forms.Button();
            this.tbBestCircle = new System.Windows.Forms.TextBox();
            this.nudTIme = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTIme)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDrivers
            // 
            this.lbDrivers.FormattingEnabled = true;
            this.lbDrivers.Location = new System.Drawing.Point(13, 28);
            this.lbDrivers.Name = "lbDrivers";
            this.lbDrivers.Size = new System.Drawing.Size(238, 290);
            this.lbDrivers.TabIndex = 0;
            this.lbDrivers.SelectedIndexChanged += new System.EventHandler(this.lbDrivers_SelectedIndexChanged);
            // 
            // lbCircles
            // 
            this.lbCircles.FormattingEnabled = true;
            this.lbCircles.Location = new System.Drawing.Point(275, 28);
            this.lbCircles.Name = "lbCircles";
            this.lbCircles.Size = new System.Drawing.Size(307, 238);
            this.lbCircles.TabIndex = 1;
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(13, 325);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(238, 23);
            this.btnAddDriver.TabIndex = 2;
            this.btnAddDriver.Text = "Додади возач";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // btnRemoveDriver
            // 
            this.btnRemoveDriver.Location = new System.Drawing.Point(13, 354);
            this.btnRemoveDriver.Name = "btnRemoveDriver";
            this.btnRemoveDriver.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRemoveDriver.Size = new System.Drawing.Size(238, 23);
            this.btnRemoveDriver.TabIndex = 3;
            this.btnRemoveDriver.Text = "Избриѓи возач";
            this.btnRemoveDriver.UseVisualStyleBackColor = true;
            this.btnRemoveDriver.Click += new System.EventHandler(this.btnRemoveDriver_Click);
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(275, 288);
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(101, 20);
            this.nudMinutes.TabIndex = 4;
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(399, 288);
            this.nudSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(89, 20);
            this.nudSeconds.TabIndex = 5;
            this.nudSeconds.ValueChanged += new System.EventHandler(this.nudSeconds_ValueChanged);
            // 
            // btnAddCircle
            // 
            this.btnAddCircle.Location = new System.Drawing.Point(503, 284);
            this.btnAddCircle.Name = "btnAddCircle";
            this.btnAddCircle.Size = new System.Drawing.Size(79, 23);
            this.btnAddCircle.TabIndex = 6;
            this.btnAddCircle.Text = "Додади круг";
            this.btnAddCircle.UseVisualStyleBackColor = true;
            this.btnAddCircle.Click += new System.EventHandler(this.btnAddCircle_Click);
            // 
            // tbBestCircle
            // 
            this.tbBestCircle.Enabled = false;
            this.tbBestCircle.Location = new System.Drawing.Point(275, 328);
            this.tbBestCircle.Name = "tbBestCircle";
            this.tbBestCircle.Size = new System.Drawing.Size(307, 20);
            this.tbBestCircle.TabIndex = 7;
            // 
            // nudTIme
            // 
            this.nudTIme.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTIme.Location = new System.Drawing.Point(325, 357);
            this.nudTIme.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudTIme.Name = "nudTIme";
            this.nudTIme.Size = new System.Drawing.Size(120, 20);
            this.nudTIme.TabIndex = 8;
            this.nudTIme.ValueChanged += new System.EventHandler(this.nudTIme_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 374);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Возачи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Минути";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Секунди";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Најдобар круг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Време";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(265, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(329, 374);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кругови";
            // 
            // MainF1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 398);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudTIme);
            this.Controls.Add(this.tbBestCircle);
            this.Controls.Add(this.btnAddCircle);
            this.Controls.Add(this.nudSeconds);
            this.Controls.Add(this.nudMinutes);
            this.Controls.Add(this.btnRemoveDriver);
            this.Controls.Add(this.btnAddDriver);
            this.Controls.Add(this.lbCircles);
            this.Controls.Add(this.lbDrivers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainF1";
            this.Text = "MainF1";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTIme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDrivers;
        private System.Windows.Forms.ListBox lbCircles;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Button btnRemoveDriver;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.Button btnAddCircle;
        private System.Windows.Forms.TextBox tbBestCircle;
        private System.Windows.Forms.NumericUpDown nudTIme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}