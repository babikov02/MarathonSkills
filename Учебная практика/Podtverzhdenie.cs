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
    public partial class Podtverzhdenie : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 6, 30);
        public Podtverzhdenie()
        {
            InitializeComponent();
            timer1.Start();
            
            
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelTime1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime1.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин.";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
           

        }

        private void labelMoney_Click(object sender, EventArgs e)
        {
            
        }

        private void Podtverzhdenie_Load(object sender, EventArgs e)
        {

        }
    }
}
