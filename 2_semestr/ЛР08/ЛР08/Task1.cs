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
    public partial class Task1 : Form
    {
        int n, ind;
        ArrayVector arr;
        public Task1()
        {
            InitializeComponent();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void N_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n = Convert.ToInt32(N.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверная длина");
            }
            try
            {
                arr = new ArrayVector(n);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Неверная длина");
            }
        }

        private void VectorB_Click(object sender, EventArgs e)
        {
            string[] words = Coord.Text.Split(' ', ';', ':', '!', '?');
            int err = 0;
            for (int i = 0; i < n; i++)
            {
                try
                {
                    arr[i] = Convert.ToDouble(words[i]);
                }
                catch (Exception)
                {
                    err = 1;
                    arr[i] = 0;
                }
            }
            if (err == 1)
            {
                MessageBox.Show("Введена(ы) неверная(ые) координата(ы). Она(и) будет(ут) заменена(ы) на 0.");
            }

            V.Text = arr.ToString();
            V.Visible = true;
        }

        private void Coord1B_Click(object sender, EventArgs e)
        {
            ind = Convert.ToInt32(ind1.Text);
            double newElement = Convert.ToDouble(NewE.Text);
            try
            {
                arr[ind] = newElement;
            }
            catch (FormatException)
            {
                MessageBox.Show("Введена неверная координата. Она не будет изменена");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Введен неверный индекс. Координата не будет изменена");
            }
            ResSet.Text = arr.ToString();
            panelSet.Visible = true;
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            ind = Convert.ToInt32(Coord2.Text);
            try
            {
                GetCoord.Text = Convert.ToString(arr[ind]);
                panelGet.Visible = true;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Введен неверный индекс. Координата не будет прочитана");
            }            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Norm.Text = Convert.ToString(arr.GetNorm());
            panelNorm.Visible = true;
        }
    }
}
