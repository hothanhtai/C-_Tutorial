using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIAODIENDEMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_GiaoVien"] == null)
            {
                frm_GiaoVien gv = new frm_GiaoVien();
                gv.MdiParent = this;
                gv.Show();
            }
            else
            {
                Application.OpenForms["frm_GiaoVien"].Activate();
            }
        }

        private void quảnLýSáchQuáHạnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýSáchChoMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_SinhVien"] == null)
            {
                frm_SinhVien sv = new frm_SinhVien();
                sv.MdiParent = this;
                sv.Show();
            }
            else
            {
                Application.OpenForms["frm_SinhVien"].Activate();
            }
        }
    }
}
