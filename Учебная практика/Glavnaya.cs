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
    public partial class Glavnaya : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 6, 30);

        public Glavnaya()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = Convert.ToString(DateTime.Now);
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин.";
        }

        private void labelDate_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SponsorBeguna sponsorBeguna = new SponsorBeguna();
            sponsorBeguna.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            information.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProverkaBegunov proverkaBegunov = new ProverkaBegunov();
            proverkaBegunov.Show();
        }
    }
}
