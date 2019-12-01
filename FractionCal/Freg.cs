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
    public partial class Freg : Form
    {
        public Freg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Fmain.n = Convert.ToInt32(textBox1.Text);
                if (Fmain.n < 2)
                    MessageBox.Show("Xin nhập nhiều hơn hoặc bằng 2 phần tử phân số");
                else
                {
                    Fmain form = new Fmain();
                    form.Show();
                }
            }
            catch { MessageBox.Show("Xin nhập nhiều hơn hoặc bằng 2 phần tử phân số"); }
            
        }

        
    }
}
