using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

//Viết chương trình cho phép nhập nhiều phân số. 
//Tính Tổng, Hiệu, Tích, Thương và Phân số tối giản của các phân số đã nhập. 
//Người sử dụng được chọn một hoặc nhiều trong số các phép tính. 
//Hiển thị các phân số đã nhập và kết quả tính ra màn hình
namespace FractionCal
{
    public partial class Fmain : Form
    {
        public static int n = 4;
        int i = 0;
        //Biến định dạng UI
        TextBox[] Tuso = new TextBox[n];
        TextBox[] Mauso = new TextBox[n];
        TextBox[] Dau = new TextBox[n];
        Panel[] Gach = new Panel[n];
        int tbWidth = 25;
        int tbHeigh = 20;
        int pnWidth = 25;
        int pnHeigh = 1;
        int tbLocation = 0;
        //Biến bool gắn cờ
        private bool isCalc = false;

        

        public Fmain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (i = 0; i < n; i++)
            {
                Tuso[i] = new TextBox();
                Gach[i] = new Panel();
                Mauso[i] = new TextBox();
                Dau[i] = new TextBox();

               

                Tuso[i].Width = Mauso[i].Width = tbWidth;
                Tuso[i].Height = Mauso[i].Height = tbHeigh;
                Gach[i].Height = 1;
                Gach[i].Width = tbWidth - 2;
                Gach[i].BackColor = Color.Aqua;
                Dau[i].Width = Dau[i].Height = 20;


                Tuso[i].Location = new Point((i+tbLocation) * tbWidth, 3);
                Gach[i].Location = new Point((i + tbLocation) * tbWidth, 25);
                Mauso[i].Location = new Point((i + tbLocation) * tbWidth, 27);
                Dau[i].Location = new Point((i + tbLocation) * tbWidth + tbWidth + 2 , 15);

                panel3.Controls.Add(Tuso[i]);
                panel3.Controls.Add(Gach[i]);
                panel3.Controls.Add(Mauso[i]);
                if(i+1 != n)
                    panel3.Controls.Add(Dau[i]);

                tbLocation += 1;
            }
        }
        public class PhanSo         
        {
            public int iTuSo { get; set; }
            public int iMauSo { get; set; }
            public PhanSo()
            {
            }
            public PhanSo(int tuso, int mauso)
            {
                this.iTuSo = tuso;
                this.iMauSo = mauso;
            }
            //Cộng hai phân số
            public static PhanSo operator +(PhanSo a, PhanSo b)
            {
                if (a.iMauSo == b.iMauSo)
                {
                    return new PhanSo(a.iTuSo + b.iTuSo, a.iMauSo);
                }
                int tu1 = a.iTuSo * b.iMauSo;
                int tu2 = b.iTuSo * a.iMauSo;
                PhanSo ps = new PhanSo(tu1 + tu2, a.iMauSo * b.iMauSo);
                ps.rutGon();
                return ps;
            }
            //Cộng phân số và một số nguyên
            public static PhanSo operator +(PhanSo a, int num)
            {
                return new PhanSo(a.iTuSo + a.iTuSo * num, a.iMauSo);
            }

            
            //Trừ 2 phân số
            public static PhanSo operator -(PhanSo a, PhanSo b)
            {
                if (a.iMauSo == b.iMauSo)
                {
                    return new PhanSo(a.iTuSo - b.iTuSo, a.iMauSo);
                }
                int tu1 = a.iTuSo * b.iMauSo;
                int tu2 = b.iTuSo * a.iMauSo;

                PhanSo ps = new PhanSo(tu1 - tu2, a.iMauSo * b.iMauSo);
                ps.rutGon();
                return ps;
            }

            //Nhân 2 phân số
            public static PhanSo operator *(PhanSo a, PhanSo b)
            {
                return new PhanSo(a.iTuSo * b.iTuSo, a.iMauSo * b.iMauSo);
            }

            //Chia 2 phân số
            public static PhanSo operator /(PhanSo a, PhanSo b)
            {
                return new PhanSo(a.iTuSo * b.iMauSo, a.iMauSo * b.iTuSo);
            }


            //Ép số nguyên về kiểu phân số
            public static implicit operator PhanSo(int num)
            {
                PhanSo kq = new PhanSo(num, 1);
                return kq;
            }
            //Ép phân số về kiểu double
            public static explicit operator double(PhanSo ps)
            {
                double kq = (double)ps.iTuSo / ps.iMauSo;
                return kq;
            }
            private int UCLN(int a, int b)
            {

                if (a != 0)
                {
                    if (a > 0)
                    {
                        while (a != b)
                        {
                            if (a > b) a -= b;
                            else b -= a;
                        }
                        return a;
                    }
                    else
                    {
                        a = -a;
                        while (a != b)
                        {
                            if (a > b) a -= b;
                            else b -= a;
                        }
                        return a;
                    }
                }
                else return 0;

            }

            public void rutGon()
            {
                int a = UCLN(this.iTuSo, this.iMauSo);

                if (a != 0)
                {
                    if (a > 0)
                    {
                        this.iTuSo = this.iTuSo / a;
                        this.iMauSo = this.iMauSo / a;
                    }
                    else
                    {
                        this.iTuSo = this.iTuSo / (-a);
                        this.iMauSo = this.iMauSo / (a);
                    }
                }

            }
            public void Xuat()
            {
                Console.WriteLine(this.iTuSo + "/" + this.iMauSo);
            }

        }

        
        private void btn_New_Click(object sender, EventArgs e)
        {
            this.Close();
          

        }
        private void bt_Calc_Click(object sender, EventArgs e)
        {
            try
            {
                //Biến để tính toán
                PhanSo[] ps = new PhanSo[n];
                string[] dau = new string[n];
                PhanSo Dapan = new PhanSo();
                Label daTu = new Label();
                Label daMau = new Label();
                Panel daGach = new Panel();
                for (i = 0; i < n; i++)
                {
                    ps[i] = new PhanSo();
                    int a, b;
                    a = int.Parse(Tuso[i].Text);
                    b = int.Parse(Mauso[i].Text);
                    ps[i].iTuSo = a;
                    ps[i].iMauSo = b;
                    if (i + 1 != n)
                        dau[i] = Dau[i].Text;
                }

                for (i = 0; i < n - 1; i++)
                {
                    if (dau[i] == "+")
                        Dapan = ps[i] + ps[i + 1];
                    else if (dau[i] == "-")
                        Dapan = ps[i] - ps[i + 1];
                    else if (dau[i] == "*")
                        Dapan = ps[i] * ps[i + 1];
                    else if (dau[i] == "/")
                        Dapan = ps[i] / ps[i + 1];
                    else MessageBox.Show("Xin nhập đúng định dạng");
                }

                Txt_Numerator.Text = Convert.ToString(Dapan.iTuSo);
                Txt_Denominator.Text = Convert.ToString(Dapan.iMauSo);
            }
            catch { MessageBox.Show("Xin nhập đúng định dạng"); }
           
        
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
