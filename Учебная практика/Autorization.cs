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
    public partial class Autorization : Form
    {
        public static Users users = new Users();
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 6, 30);
        public Autorization()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Autorization_Load(object sender, EventArgs e)
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

        private void labelTime1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Введите вашу почту")
            {
                textBoxEmail.Text = "";
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Введите ваш пароль")
            {
                textBoxPassword.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach(User user in Program.marathonSkillsEntities.User)
                {
                    if (textBoxEmail.Text == user.Email && textBoxPassword.Text == user.Password)
                    {
                        key = true;
                        users.login = user.Email;
                        users.password = user.Password;
                        users.type = user.RoleId;
                    }
                }
                if (!key)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxEmail.Text = "";
                    textBoxPassword.Text = "";
                }
                else
                { 
                    if (users.type == "R")
                    {
                        Close();
                        MessageBox.Show("Данные введены верно", "Пользователь найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RunnerMenu runnerMenu = new RunnerMenu();
                        runnerMenu.Show();
                        this.Hide();
                    }
                    else if (users.type == "A")
                    {
                        Close();
                        MessageBox.Show("Данные введены верно", "Пользователь найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdministratorMenu administratorMenu = new AdministratorMenu();
                        administratorMenu.Show();
                        this.Hide();
                    }
                    else if (users.type == "C")
                    {
                        Close();
                        MessageBox.Show("Данные введены верно", "Пользователь найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CoordinatorMenu coordinatorMenu = new CoordinatorMenu();
                        coordinatorMenu.Show();
                        this.Hide();
                    }

                }
            }

        }
    }
}
