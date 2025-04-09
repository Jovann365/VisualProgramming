namespace VisualProgramming.CashAccount
{
    partial class MainCash
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
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddToBill = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.nudTax = new System.Windows.Forms.NumericUpDown();
            this.tbFull = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.Location = new System.Drawing.Point(12, 25);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(197, 264);
            this.lbProducts.TabIndex = 0;
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(239, 25);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(235, 238);
            this.lbItems.TabIndex = 1;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(239, 270);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(235, 23);
            this.btnDeleteItem.TabIndex = 2;
            this.btnDeleteItem.Text = "Избриши ставка";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(132, 295);
            this.nudCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(77, 20);
            this.nudCount.TabIndex = 3;
            this.nudCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddToBill
            // 
            this.btnAddToBill.Location = new System.Drawing.Point(12, 321);
            this.btnAddToBill.Name = "btnAddToBill";
            this.btnAddToBill.Size = new System.Drawing.Size(199, 23);
            this.btnAddToBill.TabIndex = 4;
            this.btnAddToBill.Text = "Додади во сметка";
            this.btnAddToBill.UseVisualStyleBackColor = true;
            this.btnAddToBill.Click += new System.EventHandler(this.btnAddToBill_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(12, 349);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(199, 23);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "Додади нов";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(344, 300);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(130, 20);
            this.tbTotal.TabIndex = 6;
            // 
            // nudTax
            // 
            this.nudTax.Location = new System.Drawing.Point(344, 326);
            this.nudTax.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudTax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTax.Name = "nudTax";
            this.nudTax.Size = new System.Drawing.Size(130, 20);
            this.nudTax.TabIndex = 7;
            this.nudTax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTax.ValueChanged += new System.EventHandler(this.nudTax_ValueChanged);
            // 
            // tbFull
            // 
            this.tbFull.Enabled = false;
            this.tbFull.Location = new System.Drawing.Point(344, 353);
            this.tbFull.Name = "tbFull";
            this.tbFull.Size = new System.Drawing.Size(130, 20);
            this.tbFull.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Вкупно:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Данок (%):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "За плаќање:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 378);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Продукти";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(228, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 378);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сметка";
            // 
            // MainCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 387);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFull);
            this.Controls.Add(this.nudTax);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnAddToBill);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainCash";
            this.Text = "MainCash";
            this.Load += new System.EventHandler(this.MainCash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Button btnAddToBill;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.NumericUpDown nudTax;
        private System.Windows.Forms.TextBox tbFull;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}