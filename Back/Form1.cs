using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Back
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        ToolTip t = new ToolTip();
        private void Form1_Load(object sender, EventArgs e)
        {
 
        }
        public async void pereliv1( int v1, int v2)
        {
            probirka1.Value = v1;
            probirka3.Value = 100 - v1;
            p1.Text = probirka1.Value.ToString();
            p3.Text = probirka3.Value.ToString();
            await Task.Delay(1000);
            probirka2.Value = v2;
            probirka1.Value = v1 - v2;
            p1.Text = probirka1.Value.ToString();
            p2.Text = probirka2.Value.ToString();
            await Task.Delay(1000);
            probirka2.Value  += probirka3.Value;
            probirka3.Value = 0;
            p2.Text = probirka2.Value.ToString();
            p3.Text = probirka3.Value.ToString();
            await Task.Delay(1000);
            probirka1.Value--;
            probirka3.Value = 1;
            p1.Text = probirka1.Value.ToString();
            p3.Text = probirka3.Value.ToString();
        }

        public async void pereliv2(int v1, int v2)
        {
            probirka2.Value = v2;
            probirka3.Value = 100 - v2;
            p2.Text = probirka2.Value.ToString();
            p3.Text = probirka3.Value.ToString();
            await Task.Delay(1000);
            probirka1.Value = v1;
            probirka2.Value = v2 - v1;
            p1.Text = probirka1.Value.ToString();
            p2.Text = probirka2.Value.ToString();
            await Task.Delay(1000);
            probirka1.Value += probirka3.Value;
            probirka3.Value = 0;
            p1.Text = probirka1.Value.ToString();
            p3.Text = probirka3.Value.ToString();
            await Task.Delay(1000);
            probirka2.Value--;
            probirka3.Value = 1;
            p2.Text = probirka2.Value.ToString();
            p3.Text = probirka3.Value.ToString();
        }
        public async void pereliv3(int v1, int v2)
        {
            probirka1.Value = 100-v2;
            probirka2.Value = v2;
            p1.Text = probirka1.Value.ToString();
            p2.Text = probirka2.Value.ToString();
            await Task.Delay(1000);
            probirka3.Value = 1;
            probirka1.Value--;
            p1.Text = probirka1.Value.ToString();
            p3.Text = probirka3.Value.ToString();
        }
        public async void pereliv4(int v1, int v2)
        {
            probirka1.Value = v1;
            probirka2.Value = v2;
            probirka3.Value = 100 - v1 - v2;
            p1.Text = probirka1.Value.ToString();
            p3.Text = probirka3.Value.ToString();
            p2.Text = probirka2.Value.ToString();
            await Task.Delay(1000);
            probirka1.Value += v2;
            probirka2.Value = 0;
            p1.Text = probirka1.Value.ToString();
            p2.Text = probirka2.Value.ToString();
            await Task.Delay(1000);
            probirka2.Value = probirka3.Value;
            probirka3.Value = 0;
            p2.Text = probirka2.Value.ToString();
            p3.Text = probirka3.Value.ToString();
            await Task.Delay(1000);
            probirka1.Value --;
            probirka3.Value = 1;
            p1.Text = probirka1.Value.ToString();
            p3.Text = probirka3.Value.ToString();
        }
        public async void pereliv5(int v1, int v2)
        {
            probirka1.Value = v1;
            probirka2.Value = v2;
            probirka3.Value = 100 - v1 - v2;
            p1.Text = probirka1.Value.ToString();
            p3.Text = probirka3.Value.ToString();
            p2.Text = probirka2.Value.ToString();
            await Task.Delay(1000);
            Thread.Sleep(100);
            probirka2.Value += v1;
            probirka1.Value = 0;
            p1.Text = probirka1.Value.ToString();
            p2.Text = probirka2.Value.ToString();
            await Task.Delay(1000);
            Thread.Sleep(100);
            probirka1.Value = probirka3.Value;
            probirka3.Value = 0;
            p1.Text = probirka1.Value.ToString();
            p3.Text = probirka3.Value.ToString();
            await Task.Delay(1000);
            Thread.Sleep(100);
            probirka2.Value--;
            probirka3.Value = 1;
            p3.Text = probirka3.Value.ToString();
            p2.Text = probirka2.Value.ToString();
        }

        int ris1 = 1, ris2 = 1;
        public bool check(int v1, int v2)
        {
            bool ook = false;
            do
            {
                if (/*Math.Abs*/((v1 - v2) % ris1 == 1)&&(v1>v2))
                {
                    ook = true;
                    pereliv1(v1, v2);
                }
                else
                {
                    if (/*Math.Abs*/((v1 - v2) % ris2 == 1)&&(v2>v1))
                    {
                        ook = true;
                        pereliv2(v1, v2);
                    }
                    else
                    {
                        if (v1 + v2 == 99)
                        {
                            ook = true;
                            pereliv3(v1,v2);
                        }
                        else
                        {
                            if (((v1 + v2) % ris1 == 1) && (v1 + v2 <= 100))
                            {
                                pereliv4(v1, v2);
                                ook = true;
                            }
                            else
                            {
                                if(((v1 + v2) % ris2 == 1) && (v1 + v2 <= 100))
                                {
                                    pereliv5(v1, v2);
                                    ook = true;
                                }
                                else
                                {
                                    v2 += ris2;     
                                }
                        
                            }
                        }
                        /*if ((v1 + v2 == 99 || (v1 + v2) % ris1 == 1 || (v1 + v2) % ris2 == 1) && (v1 + v2 <= 100))
                        {
                            ook = true;
                        }*/
                        
                    }
                }
            } while (v2 > 100 && (!ook));
            if (v1 != 100 && !ook)
            {
                if (v1 + ris1 > 100)
                {
                    ook = check(100, 0);
                }
                else
                {
                    ook = check( v1 + ris1, 0);
                }
            }
            
            return ook;
        }

        public bool proverka(string tmp, ref int a)
        {
            return int.TryParse(tmp, out a);
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(proverka(riska.Text,ref ris1)&& proverka(riska2.Text, ref ris2))
            {

                if (check(ris1, 0))
                {
                    MessageBox.Show("Можно перелить 1 мл в 3 пробирку");
                }
                else
                {
                    MessageBox.Show("Нельзя перелить 1 мл в 3 пробирку");
                }
            }
            else
            {
                MessageBox.Show("У вас беды с целыми числами");
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("29. Задача о пробирках. Даны три пробирки объемом 100 мл. Две из них имеют шкалу рисок. Уровни рисок указываются пользователем. Из начального состояния { 100мл, 0мл, 0мл} (в первой пробирке 100мл, а две другие пусты) определить, возможен ли переход путем переливания жидкости из одной пробирки в другую в состояние { _, _, 1мл} (в пробирках с рисками— произвольное количество миллилитров, а в пробирке без рисок— 1мл).");
        }

        private void riska2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void probirka1_MouseEnter(object sender, EventArgs e)
        {
            t.SetToolTip(probirka1, "я с рисками на " + riska.Text + " мл.");
        }

        private void probirka2_MouseEnter(object sender, EventArgs e)
        {
            t.SetToolTip(probirka2, "я с рисками на " + riska2.Text + " мл.");
        }

        private void probirka3_MouseEnter(object sender, EventArgs e)
        {
            t.SetToolTip(probirka3, "а я томат");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
