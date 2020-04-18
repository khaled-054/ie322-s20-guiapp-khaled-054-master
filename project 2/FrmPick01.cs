using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace project_2
{
    public partial class FrmPick01 : Form
    {
        Assembly _assembly;
        Stream _imagestream;
        public FrmPick01()
        {
            InitializeComponent();
            Pictry.SizeMode  = PictureBoxSizeMode.StretchImage;
            Pictry2.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void BtnRe_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;


        }

        private void BtnLoad1_Click(object sender, EventArgs e)
        {
            try
            {
                Pictry.Image = Image.FromFile("C:\\Users\\kfa_h\\Desktop\\wallpapers\\4k-wallpaper-1.jpg");
            }
            catch
            {
                MessageBox.Show("Image not there");
            }
        }

        private void BtnLoad2_Click(object sender, EventArgs e)
        {
            
                Pictry2.Image = Image.FromStream(_imagestream);
           
        }

        private void FrmPick01_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly();
            _imagestream = _assembly.GetManifestResourceStream("project_2.res.star-wars-poster-4k-af.jpg");
        }
    }
}
