using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game g = new Game();
            g.FormClosed += formClosed;
            g.Show();
        }
        void formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            Cursor.Show();
        }
    }
}
