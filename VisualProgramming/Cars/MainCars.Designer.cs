namespace VisualProgramming.Cars
{
    partial class MainCars
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
            this.lbCars = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbExpensive = new System.Windows.Forms.TextBox();
            this.tbEconomic = new System.Windows.Forms.TextBox();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.ddBrand = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.nudSpending = new System.Windows.Forms.NumericUpDown();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.lbModels = new System.Windows.Forms.ListBox();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCars
            // 
            this.lbCars.FormattingEnabled = true;
            this.lbCars.Location = new System.Drawing.Point(14, 19);
            this.lbCars.Name = "lbCars";
            this.lbCars.Size = new System.Drawing.Size(280, 303);
            this.lbCars.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbCars);
            this.groupBox1.Controls.Add(this.tbExpensive);
            this.groupBox1.Controls.Add(this.tbEconomic);
            this.groupBox1.Controls.Add(this.tbAverage);
            this.groupBox1.Location = new System.Drawing.Point(271, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 468);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Листа на автомобили";
            // 
            // tbExpensive
            // 
            this.tbExpensive.Enabled = false;
            this.tbExpensive.Location = new System.Drawing.Point(9, 432);
            this.tbExpensive.Name = "tbExpensive";
            this.tbExpensive.Size = new System.Drawing.Size(280, 20);
            this.tbExpensive.TabIndex = 2;
            // 
            // tbEconomic
            // 
            this.tbEconomic.Enabled = false;
            this.tbEconomic.Location = new System.Drawing.Point(9, 387);
            this.tbEconomic.Name = "tbEconomic";
            this.tbEconomic.Size = new System.Drawing.Size(280, 20);
            this.tbEconomic.TabIndex = 1;
            // 
            // tbAverage
            // 
            this.tbAverage.Enabled = false;
            this.tbAverage.Location = new System.Drawing.Point(189, 343);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(100, 20);
            this.tbAverage.TabIndex = 0;
            // 
            // ddBrand
            // 
            this.ddBrand.FormattingEnabled = true;
            this.ddBrand.Location = new System.Drawing.Point(9, 34);
            this.ddBrand.Name = "ddBrand";
            this.ddBrand.Size = new System.Drawing.Size(243, 21);
            this.ddBrand.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(13, 81);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(242, 20);
            this.tbName.TabIndex = 3;
            // 
            // nudSpending
            // 
            this.nudSpending.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSpending.Location = new System.Drawing.Point(13, 129);
            this.nudSpending.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudSpending.Name = "nudSpending";
            this.nudSpending.Size = new System.Drawing.Size(120, 20);
            this.nudSpending.TabIndex = 4;
            // 
            // nudPrice
            // 
            this.nudPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrice.Location = new System.Drawing.Point(13, 176);
            this.nudPrice.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 20);
            this.nudPrice.TabIndex = 5;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(10, 211);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(105, 23);
            this.btnAddCar.TabIndex = 6;
            this.btnAddCar.Text = "Додади";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(147, 211);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(105, 23);
            this.btnDeleteCar.TabIndex = 7;
            this.btnDeleteCar.Text = "Избриши";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // lbModels
            // 
            this.lbModels.FormattingEnabled = true;
            this.lbModels.Location = new System.Drawing.Point(10, 26);
            this.lbModels.Name = "lbModels";
            this.lbModels.Size = new System.Drawing.Size(242, 160);
            this.lbModels.TabIndex = 8;
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Location = new System.Drawing.Point(137, 192);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(115, 23);
            this.btnAddBrand.TabIndex = 9;
            this.btnAddBrand.Text = "Додади марка";
            this.btnAddBrand.UseVisualStyleBackColor = true;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ddBrand);
            this.groupBox2.Controls.Add(this.btnAddCar);
            this.groupBox2.Controls.Add(this.btnDeleteCar);
            this.groupBox2.Location = new System.Drawing.Point(3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 240);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Нов Автомобил";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbModels);
            this.groupBox3.Controls.Add(this.btnAddBrand);
            this.groupBox3.Location = new System.Drawing.Point(3, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 221);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Марки на автомобили:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Модел";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Потрошувачка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Просечна потрошувачка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Најекономичен";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Најскап";
            // 
            // MainCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 482);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.nudSpending);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "MainCars";
            this.Text = "MainCars";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCars;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbExpensive;
        private System.Windows.Forms.TextBox tbEconomic;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.ComboBox ddBrand;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.NumericUpDown nudSpending;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.ListBox lbModels;
        private System.Windows.Forms.Button btnAddBrand;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}