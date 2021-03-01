using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учебная_практика
{
    
    public partial class RegistrOnMarathone : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 6, 30);
        int a;

        public RegistrOnMarathone()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                a = a + 145;
                labelMoney.Text = "$" + Convert.ToString(a);
            }
            else
            {
                a = a - 145;
                labelMoney.Text = "$" + Convert.ToString(a);
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                a = a + 75;
                labelMoney.Text = "$" + Convert.ToString(a);
            }
            else
            {
                a = a - 75;
                labelMoney.Text = "$" + Convert.ToString(a);
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                a = a + 20;
                labelMoney.Text = "$" + Convert.ToString(a);
            }
            else
            {
                a = a - 20;
                labelMoney.Text = "$" + Convert.ToString(a);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                a = a + 0;
                labelMoney.Text = "$" + Convert.ToString(a);
            }
            else
            {
                a = a - 0;
                labelMoney.Text = "$" + Convert.ToString(a);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                a = a + 20;
                labelMoney.Text = "$" + Convert.ToString(a);
            }
            else
            {
                a = a - 20;
                labelMoney.Text = "$" + Convert.ToString(a);
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                a = a + 45;
                labelMoney.Text = "$" + Convert.ToString(a);
            }
            else
            {
                a = a - 45;
                labelMoney.Text = "$" + Convert.ToString(a);
            }

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            PodtverzhdenieRegistr podtverzhdenieRegistr = new PodtverzhdenieRegistr();
            podtverzhdenieRegistr.Show();
        }
    }
}
