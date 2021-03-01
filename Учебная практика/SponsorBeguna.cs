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
    public partial class SponsorBeguna : Form
    {
        int money;
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 6, 30);

        public SponsorBeguna()
        {
            InitializeComponent();
            timer1.Start();

            
        }

        private void SponsorBeguna_Load(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            money = Convert.ToInt32(textBoxMoney.Text);
            if (money>=0)
                {
                    money = money + 10;
                    textBoxMoney.Text = Convert.ToString(money);
                    labelMoney.Text = "$" + Convert.ToString(money);
                }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            money = Convert.ToInt32(textBoxMoney.Text);
                if (money >9)
                {
                    money = money - 10;
                    textBoxMoney.Text = Convert.ToString(money);
                    labelMoney.Text = "$" + Convert.ToString(money);
                }
        }

        private void labelMoney_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxMoney_TextChanged(object sender, EventArgs e)
        {
            labelMoney.Text = "$" + textBoxMoney.Text;
        }

        private void labelTime1_Click(object sender, EventArgs e)
        {

        }

        private void buttonZaplatit_Click(object sender, EventArgs e)
        {
            Close();
            Podtverzhdenie podtverzhdenie = new Podtverzhdenie();
            podtverzhdenie.Show();
        }

        private void textBoxNumberCard_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxNumberCard_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (textBoxNumberCard.Text == "1234 1234 1234 1234")
            {
                textBoxNumberCard.Text = "";
            }
        }

        private void textBoxName_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Ваше имя")
            {
                textBoxName.Text = "";
            }
        }

        private void textBoxCard_Click(object sender, EventArgs e)
        {
            if (textBoxCard.Text == "Владелец карты")
            {
                textBoxCard.Text = "";
            }
        }

        private void textBoxMonthCard_Click(object sender, EventArgs e)
        {
            if (textBoxMonthCard.Text == "00")
            {
                textBoxMonthCard.Text = "";
            }
        }

        private void textBoxYearCard_Click(object sender, EventArgs e)
        {
            if (textBoxYearCard.Text == "0000")
            {
                textBoxYearCard.Text = "";
            }
        }

        private void textBoxCVC_Click(object sender, EventArgs e)
        {
            if (textBoxCVC.Text == "000")
            {
                textBoxCVC.Text = "";
            }
        }

        private void textBoxMoney_Click(object sender, EventArgs e)
        {
            
        }
    }
}
