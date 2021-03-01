using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учебная_практика
{
    public struct Users
    {
        public string login;
        public string password;
        public string type;
    }

    static class Program
    {
        public static MarathonSkillsEntities marathonSkillsEntities = new MarathonSkillsEntities();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Glavnaya());
        }
    }
}
