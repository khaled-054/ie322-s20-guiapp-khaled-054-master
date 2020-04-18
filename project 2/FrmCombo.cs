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
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
            CmbDays.Items.Add("Sunday");
            CmbDays.Items.Add("Monday");
            CmbDays.Items.Add("Tuesday");
            CmbDays.Items.Add("Wednesday");
            CmbDays.Items.Add("Thursday");
            CmbDays.Items.Add("Friday");
            CmbDays.Items.Add("Saturday");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CmbDays.Items.Remove("Friday");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var item = CmbDays.GetItemText(CmbDays.SelectedItem);
            MessageBox.Show(item);
        }

        private void BtnBackk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmCombo_Load(object sender, EventArgs e)
        {

        }

        private void BtnM1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbDays.Text);
        }

        private void BtnRi_Click(object sender, EventArgs e)
        {
            CmbDays.Items.RemoveAt(1);
        }
    }
}
