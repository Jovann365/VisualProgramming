namespace VisualProgramming.Busses
{
    partial class MainBusses
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
            this.lbLines = new System.Windows.Forms.ListBox();
            this.lbBuses = new System.Windows.Forms.ListBox();
            this.btnAddBus = new System.Windows.Forms.Button();
            this.btnDeleteBus = new System.Windows.Forms.Button();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.tbExpensive = new System.Windows.Forms.TextBox();
            this.tbAveragePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLines
            // 
            this.lbLines.FormattingEnabled = true;
            this.lbLines.Location = new System.Drawing.Point(286, 23);
            this.lbLines.Name = "lbLines";
            this.lbLines.Size = new System.Drawing.Size(247, 277);
            this.lbLines.TabIndex = 0;
            // 
            // lbBuses
            // 
            this.lbBuses.FormattingEnabled = true;
            this.lbBuses.Location = new System.Drawing.Point(12, 23);
            this.lbBuses.Name = "lbBuses";
            this.lbBuses.Size = new System.Drawing.Size(256, 277);
            this.lbBuses.TabIndex = 1;
            this.lbBuses.SelectedIndexChanged += new System.EventHandler(this.lbBuses_SelectedIndexChanged);
            // 
            // btnAddBus
            // 
            this.btnAddBus.Location = new System.Drawing.Point(12, 306);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(256, 23);
            this.btnAddBus.TabIndex = 2;
            this.btnAddBus.Text = "Додади автобус";
            this.btnAddBus.UseVisualStyleBackColor = true;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // btnDeleteBus
            // 
            this.btnDeleteBus.Location = new System.Drawing.Point(12, 335);
            this.btnDeleteBus.Name = "btnDeleteBus";
            this.btnDeleteBus.Size = new System.Drawing.Size(256, 23);
            this.btnDeleteBus.TabIndex = 3;
            this.btnDeleteBus.Text = "Избриши автобус";
            this.btnDeleteBus.UseVisualStyleBackColor = true;
            this.btnDeleteBus.Click += new System.EventHandler(this.btnDeleteBus_Click);
            // 
            // btnAddLine
            // 
            this.btnAddLine.Location = new System.Drawing.Point(12, 364);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(256, 23);
            this.btnAddLine.TabIndex = 4;
            this.btnAddLine.Text = "Додади линија";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // tbExpensive
            // 
            this.tbExpensive.Enabled = false;
            this.tbExpensive.Location = new System.Drawing.Point(286, 321);
            this.tbExpensive.Name = "tbExpensive";
            this.tbExpensive.Size = new System.Drawing.Size(247, 20);
            this.tbExpensive.TabIndex = 5;
            // 
            // tbAveragePrice
            // 
            this.tbAveragePrice.Enabled = false;
            this.tbAveragePrice.Location = new System.Drawing.Point(286, 364);
            this.tbAveragePrice.Name = "tbAveragePrice";
            this.tbAveragePrice.Size = new System.Drawing.Size(247, 20);
            this.tbAveragePrice.TabIndex = 6;
            this.tbAveragePrice.TextChanged += new System.EventHandler(this.tbAveragePrice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Автобуси";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Линии";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Најкапа линија";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Просечна цена";
            // 
            // MainBusses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 402);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAveragePrice);
            this.Controls.Add(this.tbExpensive);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.btnDeleteBus);
            this.Controls.Add(this.btnAddBus);
            this.Controls.Add(this.lbBuses);
            this.Controls.Add(this.lbLines);
            this.Name = "MainBusses";
            this.Text = "MainBusses";
            this.Load += new System.EventHandler(this.MainBusses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLines;
        private System.Windows.Forms.ListBox lbBuses;
        private System.Windows.Forms.Button btnAddBus;
        private System.Windows.Forms.Button btnDeleteBus;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.TextBox tbExpensive;
        private System.Windows.Forms.TextBox tbAveragePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}