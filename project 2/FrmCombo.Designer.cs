﻿namespace project_2
{
    partial class FrmCombo
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
            this.BtnM1 = new System.Windows.Forms.Button();
            this.BtnM2 = new System.Windows.Forms.Button();
            this.BtnRl = new System.Windows.Forms.Button();
            this.BtnR2 = new System.Windows.Forms.Button();
            this.BtnRi = new System.Windows.Forms.Button();
            this.BtnRn = new System.Windows.Forms.Button();
            this.BtnBackk = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnM1
            // 
            this.BtnM1.Location = new System.Drawing.Point(62, 52);
            this.BtnM1.Name = "BtnM1";
            this.BtnM1.Size = new System.Drawing.Size(138, 50);
            this.BtnM1.TabIndex = 0;
            this.BtnM1.Text = "Show Selected Method1";
            this.BtnM1.UseVisualStyleBackColor = true;
            this.BtnM1.Click += new System.EventHandler(this.BtnM1_Click);
            // 
            // BtnM2
            // 
            this.BtnM2.Location = new System.Drawing.Point(224, 52);
            this.BtnM2.Name = "BtnM2";
            this.BtnM2.Size = new System.Drawing.Size(138, 50);
            this.BtnM2.TabIndex = 1;
            this.BtnM2.Text = "Show Selected Method2";
            this.BtnM2.UseVisualStyleBackColor = true;
            this.BtnM2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnRl
            // 
            this.BtnRl.Location = new System.Drawing.Point(663, 52);
            this.BtnRl.Name = "BtnRl";
            this.BtnRl.Size = new System.Drawing.Size(96, 50);
            this.BtnRl.TabIndex = 2;
            this.BtnRl.Text = "Remove last item";
            this.BtnRl.UseVisualStyleBackColor = true;
            // 
            // BtnR2
            // 
            this.BtnR2.Location = new System.Drawing.Point(663, 161);
            this.BtnR2.Name = "BtnR2";
            this.BtnR2.Size = new System.Drawing.Size(96, 50);
            this.BtnR2.TabIndex = 3;
            this.BtnR2.Text = "Remove 2nd last item";
            this.BtnR2.UseVisualStyleBackColor = true;
            // 
            // BtnRi
            // 
            this.BtnRi.Location = new System.Drawing.Point(62, 319);
            this.BtnRi.Name = "BtnRi";
            this.BtnRi.Size = new System.Drawing.Size(96, 50);
            this.BtnRi.TabIndex = 4;
            this.BtnRi.Text = "Remove by index";
            this.BtnRi.UseVisualStyleBackColor = true;
            this.BtnRi.Click += new System.EventHandler(this.BtnRi_Click);
            // 
            // BtnRn
            // 
            this.BtnRn.Location = new System.Drawing.Point(209, 319);
            this.BtnRn.Name = "BtnRn";
            this.BtnRn.Size = new System.Drawing.Size(96, 50);
            this.BtnRn.TabIndex = 5;
            this.BtnRn.Text = "Remove by Name";
            this.BtnRn.UseVisualStyleBackColor = true;
            this.BtnRn.Click += new System.EventHandler(this.button6_Click);
            // 
            // BtnBackk
            // 
            this.BtnBackk.Location = new System.Drawing.Point(663, 374);
            this.BtnBackk.Name = "BtnBackk";
            this.BtnBackk.Size = new System.Drawing.Size(96, 50);
            this.BtnBackk.TabIndex = 6;
            this.BtnBackk.Text = "Back";
            this.BtnBackk.UseVisualStyleBackColor = true;
            this.BtnBackk.Click += new System.EventHandler(this.BtnBackk_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(62, 159);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(300, 24);
            this.CmbDays.TabIndex = 7;
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.BtnBackk);
            this.Controls.Add(this.BtnRn);
            this.Controls.Add(this.BtnRi);
            this.Controls.Add(this.BtnR2);
            this.Controls.Add(this.BtnRl);
            this.Controls.Add(this.BtnM2);
            this.Controls.Add(this.BtnM1);
            this.Name = "FrmCombo";
            this.Text = "Form Combo";
            this.Load += new System.EventHandler(this.FrmCombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnM1;
        private System.Windows.Forms.Button BtnM2;
        private System.Windows.Forms.Button BtnRl;
        private System.Windows.Forms.Button BtnR2;
        private System.Windows.Forms.Button BtnRi;
        private System.Windows.Forms.Button BtnRn;
        private System.Windows.Forms.Button BtnBackk;
        private System.Windows.Forms.ComboBox CmbDays;
    }
}