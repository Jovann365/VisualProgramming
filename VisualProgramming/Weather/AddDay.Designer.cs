namespace VisualProgramming.Weather
{
    partial class AddDay
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
            this.dudDay = new System.Windows.Forms.DomainUpDown();
            this.dudMonth = new System.Windows.Forms.DomainUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ден";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Месец";
            // 
            // dudDay
            // 
            this.dudDay.Items.Add("1");
            this.dudDay.Items.Add("2");
            this.dudDay.Items.Add("3");
            this.dudDay.Items.Add("4");
            this.dudDay.Items.Add("5");
            this.dudDay.Items.Add("6");
            this.dudDay.Items.Add("7");
            this.dudDay.Items.Add("8");
            this.dudDay.Items.Add("9");
            this.dudDay.Items.Add("10");
            this.dudDay.Items.Add("11");
            this.dudDay.Items.Add("12");
            this.dudDay.Items.Add("13");
            this.dudDay.Items.Add("14");
            this.dudDay.Items.Add("15");
            this.dudDay.Items.Add("16");
            this.dudDay.Items.Add("17");
            this.dudDay.Items.Add("18");
            this.dudDay.Items.Add("19");
            this.dudDay.Items.Add("20");
            this.dudDay.Items.Add("21");
            this.dudDay.Items.Add("22");
            this.dudDay.Items.Add("23");
            this.dudDay.Items.Add("24");
            this.dudDay.Items.Add("25");
            this.dudDay.Items.Add("26");
            this.dudDay.Items.Add("27");
            this.dudDay.Items.Add("28");
            this.dudDay.Items.Add("29");
            this.dudDay.Items.Add("30");
            this.dudDay.Items.Add("31");
            this.dudDay.Location = new System.Drawing.Point(12, 25);
            this.dudDay.Name = "dudDay";
            this.dudDay.Size = new System.Drawing.Size(98, 20);
            this.dudDay.TabIndex = 2;
            this.dudDay.Text = "ден";
            // 
            // dudMonth
            // 
            this.dudMonth.Items.Add("Јануари");
            this.dudMonth.Items.Add("Февруари");
            this.dudMonth.Items.Add("Март");
            this.dudMonth.Items.Add("Април");
            this.dudMonth.Items.Add("Мај");
            this.dudMonth.Items.Add("Јуни");
            this.dudMonth.Items.Add("Јули");
            this.dudMonth.Items.Add("Август");
            this.dudMonth.Items.Add("Септември");
            this.dudMonth.Items.Add("Октомври");
            this.dudMonth.Items.Add("Ноември");
            this.dudMonth.Items.Add("Декември");
            this.dudMonth.Location = new System.Drawing.Point(124, 25);
            this.dudMonth.Name = "dudMonth";
            this.dudMonth.Size = new System.Drawing.Size(98, 20);
            this.dudMonth.TabIndex = 3;
            this.dudMonth.Text = "месец";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Додади";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(124, 51);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddDay
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(236, 78);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dudMonth);
            this.Controls.Add(this.dudDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddDay";
            this.Text = "Ден";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown dudDay;
        private System.Windows.Forms.DomainUpDown dudMonth;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}