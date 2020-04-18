namespace project_2
{
    partial class FrmRandomCombo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRandomCombo));
            this.CmbRand = new System.Windows.Forms.ComboBox();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbRand
            // 
            this.CmbRand.FormattingEnabled = true;
            this.CmbRand.Location = new System.Drawing.Point(91, 194);
            this.CmbRand.Name = "CmbRand";
            this.CmbRand.Size = new System.Drawing.Size(284, 24);
            this.CmbRand.TabIndex = 0;
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.BackColor = System.Drawing.SystemColors.Info;
            this.BtnGenerate.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnGenerate.Location = new System.Drawing.Point(567, 81);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(161, 76);
            this.BtnGenerate.TabIndex = 1;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(567, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 76);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.CmbRand);
            this.Name = "FrmRandomCombo";
            this.Text = "FrmRandomCombo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbRand;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Button button2;
    }
}