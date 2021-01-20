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
    public partial class fnhanthuong : Form
    {
        public fnhanthuong()
        {
            InitializeComponent();
        }

        private void btneixtt_Click(object sender, EventArgs e)
        {
           
            fplay f = new fplay();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmain f = new fmain();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

      
      
    }
}
