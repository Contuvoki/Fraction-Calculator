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
    public partial class Frm_StdCal : Form
    {
        //these methods are grouped by function

        #region Arguments

        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction();
        Fraction fracResult = new Fraction();

        bool showed = false;

        #endregion

        #region Stuff

        public Frm_StdCal()
        {
            InitializeComponent();
        }

        private void Frm_StdCal_Load(object sender, EventArgs e)
        {
            this.Size = new Size(370, 133);
        }

        private void Txt_Howto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        

        #endregion

        #region Perform

        private void Btt_Show_Click(object sender, EventArgs e)
        {
            Btt_Show.Visible = false;
            GroupBox2.Location = new System.Drawing.Point(12, 68);
            GroupBox1.Enabled = false;

            timer1.Start();


            ShowHow();
        }

        private void Btt_NewExamp_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (showed == false)
            {
                this.Size = new Size(370, this.Size.Height + 25);
                if (this.Size.Height > 470)
                {
                    timer1.Stop();
                    this.Size = new Size(370, 470);
                    showed = true;
                }

            }
            else
            {
                this.Size = new Size(370, this.Size.Height - 25);
                if (this.Size.Height < 121)
                {
                    timer1.Stop();
                    this.Size = new Size(370, 133);
                    GroupBox2.Location = new System.Drawing.Point(12, 97);
                    Btt_Show.Visible = true;
                    GroupBox1.Enabled = true;

                    showed = false;
                }

            }
        }

        #endregion

        #region Show info

        private void ShowHow()
        {
            ShowValue();

            if (Rd_Add.Checked == true)
            {
                fracResult = frac1 + frac2;
                ShowHowToAdd_Sub();
            }
            if (Rd_Sub.Checked == true)
            {
                fracResult = frac1 - frac2;
                ShowHowToAdd_Sub();
            }
            if (Rd_Multi.Checked == true)
            {
                fracResult = frac1 * frac2;
                ShowHowToMul();
            }
            if (Rd_Div.Checked == true)
            {
                fracResult = frac1 / frac2;
                ShowHowToDiv();
            }

            ShowResult();
        }

        private void ShowValue()
        {
            Random a = new Random();
            int number;

            number = a.Next(1, 25);
            Lb_Num1.Text = "" + number;
            frac1.numerator = number;

            number = a.Next(2, 25);
            Lb_Den1.Text = "" + number;
            frac1.denominator = number;

            number = a.Next(1, 25);
            Lb_Num2.Text = "" + number;
            frac2.numerator = number;

            number = a.Next(2, 25);
            Lb_Den2.Text = "" + number;
            frac2.denominator = number;

            if (Rd_Add.Checked == true)
                Lb_Operator.Text = "+";
            if (Rd_Sub.Checked == true)
                Lb_Operator.Text = "-";
            if (Rd_Multi.Checked == true)
                Lb_Operator.Text = "x";
            if (Rd_Div.Checked == true)
                Lb_Operator.Text = "÷";
        }

        private void ShowResult()
        {
            Lb_Num3.Text = "" + fracResult.numerator;
            Lb_Den3.Text = "" + fracResult.denominator;
        }

        public void ShowHowToAdd_Sub()
        {
            string howto;

            howto = "Step 1: Finding common denominator of " + frac1.denominator + " and " + frac2.denominator;

            howto += "\r\n  - Divisors of " + frac1.denominator + ": ";
            howto += frac1.Divisor(frac1.denominator);

            howto += "\r\n  - Divisors of " + frac2.denominator + ": ";
            howto += frac2.Divisor(frac2.denominator);

            howto += "\r\n\r\n => Greatest common divisor: ";
            int GreatComDiv = frac1.GreatestCommonDivisor(frac1.denominator, frac2.denominator); ;
            howto += GreatComDiv;

            howto += "\r\n => Common denominator: (" + frac1.denominator + " x " + frac2.denominator + ")/" + GreatComDiv + "= ";
            int ComDen;
            ComDen = frac1.CommonDenominator(frac2);
            howto += ComDen;

            howto += "\r\n\r\n Step 2: Result";

            howto += "\r\n - Nummerator = " + frac1.numerator + " x (" + ComDen + "/" + frac1.denominator + ")";

            if (Rd_Add.Checked == true)
            {
                howto += " + ";
            }
            else
                howto += " - ";

            howto += frac2.numerator + " x (" + ComDen + "/" + frac2.denominator + ")";
            howto += "\r\n - Denominator = " + ComDen;

            howto += "\r\n\r\n After reduce: \r\n - Nummerator = " + fracResult.numerator;
            howto += "\r\n - Denominator = " + fracResult.denominator;

            Txt_Howto.Text = howto;
        }

        public void ShowHowToMul()
        {
            string howto;

            howto = "Result:";
            howto += "\r\n - Nummerator = " + frac1.numerator + " x " + frac2.numerator;
            howto += "\r\n - Denominator = " + frac1.denominator + " x " + frac2.denominator;

            howto += "\r\n\r\n After reduce: \r\n - Nummerator = " + fracResult.numerator;
            howto += "\r\n - Denominator = " + fracResult.denominator;

            Txt_Howto.Text = howto;
        }

        public void ShowHowToDiv()
        {
            string howto;

            howto = "Result:";
            howto += "\r\n - Nummerator = " + frac1.numerator + " x " + frac2.denominator;
            howto += "\r\n - Denominator = " + frac1.denominator + " x " + frac2.numerator;

            howto += "\r\n\r\n After reduce: \r\n - Nummerator = " + fracResult.numerator;
            howto += "\r\n - Denominator = " + fracResult.denominator;

            Txt_Howto.Text = howto;
        }

        #endregion
    }
}
