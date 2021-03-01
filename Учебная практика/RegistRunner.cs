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
    public partial class RegistRunner : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 6, 30);
        public RegistRunner()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void RegistRunner_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            string FileName = openFile.FileName;
            pictureBox1.ImageLocation = FileName;
            textBox4.Text = FileName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            ProverkaBegunov proverkaBegunov = new ProverkaBegunov();
            proverkaBegunov.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_Click_1(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Пароль")
            {
                textBoxPassword.Text = "";
            }
        }

        private void textBoxEmail_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Введите вашу почту")
            {
                textBoxEmail.Text = "";
            }

        }

        private void textBoxPassword1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword1.Text == "Повторите пароль")
            {
                textBoxPassword1.Text = "";
            }
        }

        private void textBoxName_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Имя")
            {
                textBoxName.Text = "";
            }
        }

        private void textBoxFamilia_Click(object sender, EventArgs e)
        {
            if (textBoxFamilia.Text == "Фамилия")
            {
                textBoxFamilia.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            RegistrOnMarathone registrOnMarathone = new RegistrOnMarathone();
            registrOnMarathone.Show();
        }
    }
}
