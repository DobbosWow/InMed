using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InMed_Forms
{
    public class Pacient
    {
        public enum pacgender { male, female };
        private string name, surname, secondname;
        private pacgender pacGender;
        private int pacAge;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Secname
        {
            get { return secondname; }
            set { secondname = value; }
        }
        public pacgender pacg
        {
            get { return pacGender; }
            set { pacGender = value; }
        }
        public int Age
        {
            get { return pacAge; }
            set { pacAge = value; }
        }


    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Pacient myp = new Pacient();
            myp.Name = "Ivan";
            myp.pacg = 0;
            myp.Secname = "Ivanivich";
            myp.Surname = "Ivanov";
            myp.Age = 45;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(myp));
        }
    }
}
