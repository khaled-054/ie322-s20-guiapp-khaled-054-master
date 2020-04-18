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
        string username = "Atif";
        string myPassword = "1234";
        bool loggedIn = false;
        int attempt = 1;
        int MaxAttempts = 3;

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!loggedIn)
            {

                while (attempt <= MaxAttempts)
                {
                    if (TxtUser.Text != username)
                    {

                        MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                        attempt++;
                        return;
                    }
                    else
                    {

                        if (TxtPass.Text != myPassword)
                        {

                            attempt++;
                            MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                            return;
                        }
                        else
                        {

                            attempt = 1;
                            loggedIn = true;
                            MessageBox.Show("Hi " + username + ", your login successful");



                            BtnLogin.Text = "Logout";

                            break;
                        }

                    }
                }
            }
            else
            {
                BtnLogin.Text = "Login";

                loggedIn = false;

                TxtUser.Clear();
                TxtPass.Clear();


            }
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

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRandomCombo_Click(object sender, EventArgs e)
        {
            FrmRandom frm = new FrmRandom();
            frm.ShowDialog();



        }
    }
}
