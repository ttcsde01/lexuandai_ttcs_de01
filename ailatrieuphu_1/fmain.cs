using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ailatrieuphu_1
{
    public partial class fmain : Form
    {
        public fmain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fplay f = new fplay();
            this.Hide();
            f.ShowDialog();
            
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            finfo f = new finfo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            fcapnhap f = new fcapnhap();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
