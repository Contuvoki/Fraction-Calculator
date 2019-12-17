using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace FractionCal
{
    public partial class CalWithFile : Form
    {
        public CalWithFile()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Text files (*.rtf)|*.rtf";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(opf.FileName);

            }
            //richTextBox1.SelectedRtf = Properties.Resources.Document1;
            string doc = richTextBox1.Text;
        }
        private void btn_Cal_Click(object sender, EventArgs e)
        {
            try
            {
                string clean = Regex.Replace(richTextBox1.Text, "[() ]", "");
                double res = MathParser.EvalExpression(clean.ToCharArray());
                res = Math.Round(res, 5);
                string result = res.ToString();
                //richTextBox2.Text = MathParser.EvalExpression(clean.ToCharArray()).ToString();
                richTextBox2.Text = result;
                Conv(result);
            }
            catch
            {
                MessageBox.Show("Xin nhập đúng định dạng phân số");
            }
            
           
        }

        private void Conv(string result)
        {
            Decimal FirstNumber = Decimal.Parse(result);
            Decimal SecondNumber = Math.Floor(Decimal.Parse(result));
            Decimal ThirdNumber = FirstNumber - SecondNumber;
            int Times = 0; 

            while(ThirdNumber % 1 != 0)
            {
                ThirdNumber = ThirdNumber * 10;
                Times++;
            }
            int Denominator = Convert.ToInt32(Math.Pow(10, Times));
            int Numerator = Convert.ToInt32(ThirdNumber);
            int i = 2;
            while (Numerator >= i && Denominator >= i) 
            {
                if (Numerator % i == 0 && Denominator % i == 0)
                {
                    Numerator = Numerator / i;
                    Denominator = Denominator / i;
                }
                else
                {
                    i = i + 1;
                }
            }
            Txt_Numerator.Text = Numerator.ToString();
            Txt_Denominator.Text = Denominator.ToString();
        }

       
    }
}
