namespace VisualProgramming.TVProgram
{
    partial class MainTV
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
            this.components = new System.ComponentModel.Container();
            this.cbTV = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddTV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.programName = new System.Windows.Forms.Label();
            this.lbPrograms = new System.Windows.Forms.ListBox();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTV
            // 
            this.cbTV.FormattingEnabled = true;
            this.cbTV.Location = new System.Drawing.Point(22, 33);
            this.cbTV.Name = "cbTV";
            this.cbTV.Size = new System.Drawing.Size(237, 21);
            this.cbTV.TabIndex = 0;
            this.cbTV.SelectedIndexChanged += new System.EventHandler(this.cbTV_SelectedIndexChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(22, 69);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(237, 20);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // nudTime
            // 
            this.nudTime.Location = new System.Drawing.Point(22, 107);
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(120, 20);
            this.nudTime.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Додади програма";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(149, 149);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Избриши програма";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddTV
            // 
            this.btnAddTV.Location = new System.Drawing.Point(22, 229);
            this.btnAddTV.Name = "btnAddTV";
            this.btnAddTV.Size = new System.Drawing.Size(110, 23);
            this.btnAddTV.TabIndex = 5;
            this.btnAddTV.Text = "Додади ТВ";
            this.btnAddTV.UseVisualStyleBackColor = true;
            this.btnAddTV.Click += new System.EventHandler(this.btnAddTV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Телевизија:";
            // 
            // programName
            // 
            this.programName.AutoSize = true;
            this.programName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programName.Location = new System.Drawing.Point(106, 16);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(0, 31);
            this.programName.TabIndex = 7;
            // 
            // lbPrograms
            // 
            this.lbPrograms.FormattingEnabled = true;
            this.lbPrograms.Location = new System.Drawing.Point(301, 55);
            this.lbPrograms.Name = "lbPrograms";
            this.lbPrograms.Size = new System.Drawing.Size(208, 160);
            this.lbPrograms.TabIndex = 8;
            // 
            // tbAverage
            // 
            this.tbAverage.Location = new System.Drawing.Point(301, 232);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(208, 20);
            this.tbAverage.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Име:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Времетрање (мин):";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 174);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нова програма";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.programName);
            this.groupBox2.Location = new System.Drawing.Point(284, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 252);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Програми на ТВ:";
            // 
            // MainTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 266);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAverage);
            this.Controls.Add(this.lbPrograms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddTV);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudTime);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cbTV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainTV";
            this.Text = "ТВ програма";
            this.Load += new System.EventHandler(this.MainTV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTV;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddTV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label programName;
        private System.Windows.Forms.ListBox lbPrograms;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}