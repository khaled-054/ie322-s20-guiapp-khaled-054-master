﻿namespace project_2
{
    partial class Frmcheck
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
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.ChkCoffee = new System.Windows.Forms.CheckBox();
            this.ChkDount = new System.Windows.Forms.CheckBox();
            this.ChkBrownie = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(167, 331);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(93, 47);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(431, 331);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(103, 47);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // ChkCoffee
            // 
            this.ChkCoffee.AutoSize = true;
            this.ChkCoffee.Location = new System.Drawing.Point(21, 34);
            this.ChkCoffee.Name = "ChkCoffee";
            this.ChkCoffee.Size = new System.Drawing.Size(71, 21);
            this.ChkCoffee.TabIndex = 2;
            this.ChkCoffee.Text = "Coffee";
            this.ChkCoffee.UseVisualStyleBackColor = true;
            // 
            // ChkDount
            // 
            this.ChkDount.AutoSize = true;
            this.ChkDount.Location = new System.Drawing.Point(21, 81);
            this.ChkDount.Name = "ChkDount";
            this.ChkDount.Size = new System.Drawing.Size(68, 21);
            this.ChkDount.TabIndex = 3;
            this.ChkDount.Text = "Dount";
            this.ChkDount.UseVisualStyleBackColor = true;
            // 
            // ChkBrownie
            // 
            this.ChkBrownie.AutoSize = true;
            this.ChkBrownie.Location = new System.Drawing.Point(21, 124);
            this.ChkBrownie.Name = "ChkBrownie";
            this.ChkBrownie.Size = new System.Drawing.Size(80, 21);
            this.ChkBrownie.TabIndex = 4;
            this.ChkBrownie.Text = "Brownie";
            this.ChkBrownie.UseVisualStyleBackColor = true;
            this.ChkBrownie.CheckedChanged += new System.EventHandler(this.ChkBrownie_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkCoffee);
            this.groupBox1.Controls.Add(this.ChkBrownie);
            this.groupBox1.Controls.Add(this.ChkDount);
            this.groupBox1.Location = new System.Drawing.Point(167, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 185);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Frmcheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnShow);
            this.Name = "Frmcheck";
            this.Text = "Form Check";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.CheckBox ChkCoffee;
        private System.Windows.Forms.CheckBox ChkDount;
        private System.Windows.Forms.CheckBox ChkBrownie;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}