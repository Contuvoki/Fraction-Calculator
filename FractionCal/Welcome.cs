using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionCal
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btn_Multi_Click(object sender, EventArgs e)
        {
            Freg main = new Freg();
            main.Show();
        }

        private void btn_Data_Click(object sender, EventArgs e)
        {
            CalWithFile cal = new CalWithFile();
            cal.Show();
        }

        private void btn_Classic_Click(object sender, EventArgs e)
        {
            Frm_StdCal std = new Frm_StdCal();
            std.Show();

        }
    }
}
