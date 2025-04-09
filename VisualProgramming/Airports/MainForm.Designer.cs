namespace VisualProgramming
{
    partial class MainForm
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
            this.lbAirports = new System.Windows.Forms.ListBox();
            this.lbDestinations = new System.Windows.Forms.ListBox();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.btnRemoveAirport = new System.Windows.Forms.Button();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.tbExpensive = new System.Windows.Forms.TextBox();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lbAirports
            // 
            this.lbAirports.FormattingEnabled = true;
            this.lbAirports.Location = new System.Drawing.Point(12, 26);
            this.lbAirports.Name = "lbAirports";
            this.lbAirports.Size = new System.Drawing.Size(362, 303);
            this.lbAirports.TabIndex = 0;
            this.lbAirports.SelectedIndexChanged += new System.EventHandler(this.lbAirports_SelectedIndexChanged);
            // 
            // lbDestinations
            // 
            this.lbDestinations.FormattingEnabled = true;
            this.lbDestinations.Location = new System.Drawing.Point(388, 26);
            this.lbDestinations.Name = "lbDestinations";
            this.lbDestinations.Size = new System.Drawing.Size(362, 303);
            this.lbDestinations.TabIndex = 1;
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.Location = new System.Drawing.Point(12, 348);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(362, 23);
            this.btnAddAirport.TabIndex = 2;
            this.btnAddAirport.Text = "Додади Аеродром";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // btnRemoveAirport
            // 
            this.btnRemoveAirport.Location = new System.Drawing.Point(12, 382);
            this.btnRemoveAirport.Name = "btnRemoveAirport";
            this.btnRemoveAirport.Size = new System.Drawing.Size(362, 23);
            this.btnRemoveAirport.TabIndex = 3;
            this.btnRemoveAirport.Text = "Избриши Аеродром";
            this.btnRemoveAirport.UseVisualStyleBackColor = true;
            this.btnRemoveAirport.Click += new System.EventHandler(this.btnRemoveAirport_Click);
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(12, 416);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(362, 23);
            this.btnAddDestination.TabIndex = 4;
            this.btnAddDestination.Text = "Додади Дестинација";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // tbExpensive
            // 
            this.tbExpensive.Enabled = false;
            this.tbExpensive.Location = new System.Drawing.Point(407, 369);
            this.tbExpensive.Name = "tbExpensive";
            this.tbExpensive.Size = new System.Drawing.Size(325, 20);
            this.tbExpensive.TabIndex = 5;
            // 
            // tbAverage
            // 
            this.tbAverage.Enabled = false;
            this.tbAverage.Location = new System.Drawing.Point(407, 417);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(325, 20);
            this.tbAverage.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Аеродроми";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Дестинации";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Најскапа дестинација";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Просечна должина на дестинациите";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(388, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 120);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дестинации";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 456);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAverage);
            this.Controls.Add(this.tbExpensive);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.btnRemoveAirport);
            this.Controls.Add(this.btnAddAirport);
            this.Controls.Add(this.lbDestinations);
            this.Controls.Add(this.lbAirports);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAirports;
        private System.Windows.Forms.ListBox lbDestinations;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnRemoveAirport;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.TextBox tbExpensive;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

