namespace VisualProgramming.ExamProblems
{
    partial class MainExam
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
            this.lbExamss = new System.Windows.Forms.ListBox();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.btnDeleteExam = new System.Windows.Forms.Button();
            this.tbDesc1 = new System.Windows.Forms.RichTextBox();
            this.tbDesc2 = new System.Windows.Forms.RichTextBox();
            this.nudPoints1 = new System.Windows.Forms.NumericUpDown();
            this.nudPoints2 = new System.Windows.Forms.NumericUpDown();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbExamss
            // 
            this.lbExamss.FormattingEnabled = true;
            this.lbExamss.Location = new System.Drawing.Point(13, 26);
            this.lbExamss.Name = "lbExamss";
            this.lbExamss.Size = new System.Drawing.Size(258, 277);
            this.lbExamss.TabIndex = 0;
            this.lbExamss.SelectedIndexChanged += new System.EventHandler(this.lbExamss_SelectedIndexChanged);
            // 
            // btnAddExam
            // 
            this.btnAddExam.Location = new System.Drawing.Point(8, 305);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(258, 23);
            this.btnAddExam.TabIndex = 1;
            this.btnAddExam.Text = "Додади испит";
            this.btnAddExam.UseVisualStyleBackColor = true;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // btnDeleteExam
            // 
            this.btnDeleteExam.Location = new System.Drawing.Point(8, 339);
            this.btnDeleteExam.Name = "btnDeleteExam";
            this.btnDeleteExam.Size = new System.Drawing.Size(258, 23);
            this.btnDeleteExam.TabIndex = 2;
            this.btnDeleteExam.Text = "Избриши испит";
            this.btnDeleteExam.UseVisualStyleBackColor = true;
            this.btnDeleteExam.Click += new System.EventHandler(this.btnDeleteExam_Click);
            // 
            // tbDesc1
            // 
            this.tbDesc1.Location = new System.Drawing.Point(19, 36);
            this.tbDesc1.Name = "tbDesc1";
            this.tbDesc1.Size = new System.Drawing.Size(255, 88);
            this.tbDesc1.TabIndex = 4;
            this.tbDesc1.Text = "";
            // 
            // tbDesc2
            // 
            this.tbDesc2.Location = new System.Drawing.Point(18, 41);
            this.tbDesc2.Name = "tbDesc2";
            this.tbDesc2.Size = new System.Drawing.Size(255, 88);
            this.tbDesc2.TabIndex = 5;
            this.tbDesc2.Text = "";
            // 
            // nudPoints1
            // 
            this.nudPoints1.Location = new System.Drawing.Point(308, 149);
            this.nudPoints1.Name = "nudPoints1";
            this.nudPoints1.Size = new System.Drawing.Size(120, 20);
            this.nudPoints1.TabIndex = 6;
            // 
            // nudPoints2
            // 
            this.nudPoints2.Location = new System.Drawing.Point(16, 151);
            this.nudPoints2.Name = "nudPoints2";
            this.nudPoints2.Size = new System.Drawing.Size(120, 20);
            this.nudPoints2.TabIndex = 7;
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(162, 145);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(109, 23);
            this.btnSave1.TabIndex = 8;
            this.btnSave1.Text = "Зачувај";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(162, 151);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(109, 23);
            this.btnSave2.TabIndex = 9;
            this.btnSave2.Text = "Зачувај";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddExam);
            this.groupBox1.Controls.Add(this.btnDeleteExam);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 379);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Испити";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbDesc1);
            this.groupBox2.Controls.Add(this.btnSave1);
            this.groupBox2.Location = new System.Drawing.Point(292, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 190);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задача 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnSave2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbDesc2);
            this.groupBox3.Controls.Add(this.nudPoints2);
            this.groupBox3.Location = new System.Drawing.Point(292, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 191);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Задача 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Опис";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Опис";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Поени";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Поени";
            // 
            // MainExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 391);
            this.Controls.Add(this.nudPoints1);
            this.Controls.Add(this.lbExamss);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "MainExam";
            this.Text = "MainExam";
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbExamss;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.Button btnDeleteExam;
        private System.Windows.Forms.RichTextBox tbDesc1;
        private System.Windows.Forms.RichTextBox tbDesc2;
        private System.Windows.Forms.NumericUpDown nudPoints1;
        private System.Windows.Forms.NumericUpDown nudPoints2;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}