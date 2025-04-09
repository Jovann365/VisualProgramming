namespace VisualProgramming.Weather
{
    partial class MainWeather
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
            System.Windows.Forms.Button btnAddDay;
            this.lbDays = new System.Windows.Forms.ListBox();
            this.btnDeleteDay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSelected = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.max = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.min = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            btnAddDay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddDay
            // 
            btnAddDay.Location = new System.Drawing.Point(12, 398);
            btnAddDay.Name = "btnAddDay";
            btnAddDay.Size = new System.Drawing.Size(156, 23);
            btnAddDay.TabIndex = 1;
            btnAddDay.Text = "Додади ден";
            btnAddDay.UseVisualStyleBackColor = true;
            btnAddDay.Click += new System.EventHandler(this.btnAddDay_Click);
            // 
            // lbDays
            // 
            this.lbDays.FormattingEnabled = true;
            this.lbDays.Location = new System.Drawing.Point(13, 24);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(331, 368);
            this.lbDays.TabIndex = 0;
            this.lbDays.SelectedIndexChanged += new System.EventHandler(this.lbDays_SelectedIndexChanged);
            // 
            // btnDeleteDay
            // 
            this.btnDeleteDay.Location = new System.Drawing.Point(186, 398);
            this.btnDeleteDay.Name = "btnDeleteDay";
            this.btnDeleteDay.Size = new System.Drawing.Size(158, 23);
            this.btnDeleteDay.TabIndex = 2;
            this.btnDeleteDay.Text = "Избриши ден";
            this.btnDeleteDay.UseVisualStyleBackColor = true;
            this.btnDeleteDay.Click += new System.EventHandler(this.btnDeleteDay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSelected);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.day);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(351, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 145);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детали";
            // 
            // lbSelected
            // 
            this.lbSelected.AutoSize = true;
            this.lbSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelected.Location = new System.Drawing.Point(118, 16);
            this.lbSelected.Name = "lbSelected";
            this.lbSelected.Size = new System.Drawing.Size(0, 25);
            this.lbSelected.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(7, 112);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(242, 20);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Минимална температура";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(7, 68);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(242, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Максимална температура";
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.Location = new System.Drawing.Point(92, 16);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(0, 25);
            this.day.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Датум:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.max);
            this.groupBox2.Location = new System.Drawing.Point(351, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 81);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ден со најголема максимална температура";
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max.Location = new System.Drawing.Point(10, 31);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(90, 29);
            this.max.TabIndex = 0;
            this.max.Text = "4 June";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.min);
            this.groupBox3.Location = new System.Drawing.Point(350, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 81);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ден со најмала минимална температура";
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.Location = new System.Drawing.Point(11, 34);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(90, 29);
            this.min.TabIndex = 1;
            this.min.Text = "4 June";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Прогноза";
            // 
            // MainWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 430);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteDay);
            this.Controls.Add(btnAddDay);
            this.Controls.Add(this.lbDays);
            this.Name = "MainWeather";
            this.Text = "Временска прогноза";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDays;
        private System.Windows.Forms.Button btnDeleteDay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label lbSelected;
        private System.Windows.Forms.Label label4;
    }
}