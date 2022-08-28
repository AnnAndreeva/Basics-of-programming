using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Task1Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task1 t1 = new Task1();
            t1.FormClosed += formClosed;
            t1.Show();
        }

        private void Task2Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task2 t2 = new Task2();
            t2.FormClosed += formClosed;
            t2.Show();
        }


        private void Task3Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task3 t3 = new Task3();
            t3.FormClosed += formClosed;
            t3.Show();
        }

        void formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

    }
}
