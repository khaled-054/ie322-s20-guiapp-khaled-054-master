using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2
{
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            RdoYellow.ForeColor = Color.FromName("Black");
            RdoBlue.ForeColor = Color.FromName("Black");
            RdoGreen.ForeColor = Color.FromName("Black");
            RdoRed.ForeColor = Color.FromName("Black");
            RdoYellow2.ForeColor = Color.FromName("Black");
            RdoBlue2.ForeColor = Color.FromName("Black");
            RdoGreen2.ForeColor = Color.FromName("Black");
            RdoRed2.ForeColor = Color.FromName("Black");


        }

        private void RdoRed_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoRed.Checked == true)
                RdoRed.ForeColor = Color.FromName("Red");
            else
                RdoRed.ForeColor = Color.FromName("Black");
        }

        private void RdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoGreen.Checked == true)
                RdoGreen.ForeColor = Color.FromName("Green");
            else
                RdoGreen.ForeColor = Color.FromName("Black");
        }

        private void RdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBlue.Checked == true)
                RdoBlue.ForeColor = Color.FromName("Blue");
            else
                RdoBlue.ForeColor = Color.FromName("Black");
        }

        private void RdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoYellow.Checked == true)
                RdoYellow.ForeColor = Color.FromName("Yellow");
            else
                RdoYellow.ForeColor = Color.FromName("Black");
        }

        private void RdoRed2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoRed2.Checked == true)

            {
                RdoRed2.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else
                RdoRed2.ForeColor = Color.FromArgb(0, 0, 0);

        }

        private void RdoGreen2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoGreen2.Checked == true)

            {
                RdoGreen2.ForeColor = Color.FromName("green");
            }
            else
                RdoGreen2.ForeColor = Color.FromName("black");

        }

        private void RdoBlue2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBlue2.Checked == true)
                RdoBlue2.ForeColor = Color.FromName("Blue");
            else
                RdoBlue2.ForeColor = Color.FromName("Black");

        }

        private void RdoYellow2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoYellow2.Checked == true)
                RdoYellow2.ForeColor = Color.FromName("Yellow");
            else
                RdoYellow2.ForeColor = Color.FromName("Black");

        }
    }
}
