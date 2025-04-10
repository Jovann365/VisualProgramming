﻿namespace VisualProgramming.ConferencePapers
{
    partial class MainPapers
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
            this.lbConferences = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Конференции = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lbConferences
            // 
            this.lbConferences.FormattingEnabled = true;
            this.lbConferences.Location = new System.Drawing.Point(13, 24);
            this.lbConferences.Name = "lbConferences";
            this.lbConferences.Size = new System.Drawing.Size(235, 277);
            this.lbConferences.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 354);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(235, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Додади конференција";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 383);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(235, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Избриши конференција";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "-1"});
            this.cbYear.Location = new System.Drawing.Point(13, 327);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(234, 21);
            this.cbYear.TabIndex = 3;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Година";
            // 
            // Конференции
            // 
            this.Конференции.Location = new System.Drawing.Point(3, 6);
            this.Конференции.Name = "Конференции";
            this.Конференции.Size = new System.Drawing.Size(255, 412);
            this.Конференции.TabIndex = 5;
            this.Конференции.TabStop = false;
            this.Конференции.Text = "Конференции";
            // 
            // MainPapers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbConferences);
            this.Controls.Add(this.Конференции);
            this.Name = "MainPapers";
            this.Text = "MainPapers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbConferences;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Конференции;
    }
}