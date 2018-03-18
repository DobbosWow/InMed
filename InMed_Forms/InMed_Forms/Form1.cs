using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InMed_Forms
{
    public partial class Form1 : Form
    {
        private Pacient initIt = new Pacient();
        public Form1(Pacient myPac)
        {
            InitializeComponent();
            initIt.Name = myPac.Name;
            initIt.Secname = myPac.Secname;
            initIt.Surname = myPac.Surname;
        }

        private void changeval()
        {
            label1.Text = initIt.Name;
            label2.Text = initIt.Secname;
            label3.Text = initIt.Surname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeval();
        }
    }
}
