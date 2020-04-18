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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        int i = 1;
        private void BtnLogin_Click(object sender, EventArgs e)
        {

            while (i <= 3)
            {
                if (TxtUser.Text == "khaled" && TxtPass.Text == "1234")
                {

                    MessageBox.Show("Login successful");
                    break;
                }

                else
                {
                    MessageBox.Show("Incorrect username or password");
                    i = i + 1;


                }
                
            }
            i = 0;
        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog(); 
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            FrmCombo frm = new FrmCombo();
            frm.ShowDialog();
        }

        private void BtnCheckBox_Click(object sender, EventArgs e)
        {
            Frmcheck frm = new Frmcheck();
            frm.ShowDialog();
        }

        private void BtnGR_Click(object sender, EventArgs e)
        {
            FrmRandomCombo  frm = new FrmRandomCombo ();
            frm.ShowDialog();
        }

        private void BtnPictureBox_Click(object sender, EventArgs e)
        {
            FrmPick01 frm = new FrmPick01 ();
            frm.ShowDialog();
        }
    }
}
