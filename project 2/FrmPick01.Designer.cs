﻿namespace project_2
{
    partial class FrmPick01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPick01));
            this.BtnLoad1 = new System.Windows.Forms.Button();
            this.BtnRe = new System.Windows.Forms.Button();
            this.BtnLoad2 = new System.Windows.Forms.Button();
            this.Pictry = new System.Windows.Forms.PictureBox();
            this.Pictry2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pictry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pictry2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoad1
            // 
            this.BtnLoad1.BackColor = System.Drawing.SystemColors.Info;
            this.BtnLoad1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoad1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLoad1.Location = new System.Drawing.Point(68, 71);
            this.BtnLoad1.Name = "BtnLoad1";
            this.BtnLoad1.Size = new System.Drawing.Size(100, 59);
            this.BtnLoad1.TabIndex = 0;
            this.BtnLoad1.Text = "Load Image from file";
            this.BtnLoad1.UseVisualStyleBackColor = false;
            this.BtnLoad1.Click += new System.EventHandler(this.BtnLoad1_Click);
            // 
            // BtnRe
            // 
            this.BtnRe.BackColor = System.Drawing.SystemColors.Info;
            this.BtnRe.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRe.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnRe.Location = new System.Drawing.Point(609, 487);
            this.BtnRe.Name = "BtnRe";
            this.BtnRe.Size = new System.Drawing.Size(102, 52);
            this.BtnRe.TabIndex = 1;
            this.BtnRe.Text = "Back";
            this.BtnRe.UseVisualStyleBackColor = false;
            this.BtnRe.Click += new System.EventHandler(this.BtnRe_Click);
            // 
            // BtnLoad2
            // 
            this.BtnLoad2.BackColor = System.Drawing.SystemColors.Info;
            this.BtnLoad2.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoad2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLoad2.Location = new System.Drawing.Point(68, 387);
            this.BtnLoad2.Name = "BtnLoad2";
            this.BtnLoad2.Size = new System.Drawing.Size(100, 68);
            this.BtnLoad2.TabIndex = 3;
            this.BtnLoad2.Text = "Load Image from resource";
            this.BtnLoad2.UseVisualStyleBackColor = false;
            this.BtnLoad2.Click += new System.EventHandler(this.BtnLoad2_Click);
            // 
            // Pictry
            // 
            this.Pictry.Location = new System.Drawing.Point(274, 93);
            this.Pictry.Name = "Pictry";
            this.Pictry.Size = new System.Drawing.Size(316, 362);
            this.Pictry.TabIndex = 4;
            this.Pictry.TabStop = false;
            // 
            // Pictry2
            // 
            this.Pictry2.Location = new System.Drawing.Point(722, 93);
            this.Pictry2.Name = "Pictry2";
            this.Pictry2.Size = new System.Drawing.Size(316, 362);
            this.Pictry2.TabIndex = 5;
            this.Pictry2.TabStop = false;
            // 
            // FrmPick01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1146, 551);
            this.Controls.Add(this.Pictry2);
            this.Controls.Add(this.Pictry);
            this.Controls.Add(this.BtnLoad2);
            this.Controls.Add(this.BtnRe);
            this.Controls.Add(this.BtnLoad1);
            this.Name = "FrmPick01";
            this.Text = "FrmPick01";
            this.Load += new System.EventHandler(this.FrmPick01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pictry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pictry2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLoad1;
        private System.Windows.Forms.Button BtnRe;
        private System.Windows.Forms.Button BtnLoad2;
        private System.Windows.Forms.PictureBox Pictry;
        private System.Windows.Forms.PictureBox Pictry2;
    }
}