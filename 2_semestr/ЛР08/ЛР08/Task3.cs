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
    public partial class Task3 : Form
    {
    IVector v1, v2, v3;
        int n1, n2;
        public Task3()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void N1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToInt32(N1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверная длина");
            }

            if (A1.Checked)
            {
                try
                {
                    v1 = new ArrayVector(n1);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Неверная длина");
                }
            }

            if (L1.Checked)
            {
                try
                {
                    v1 = new LinkedListVector(n1);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Неверная длина");
                    v1 = new LinkedListVector();
                }
            }

        }

        private void N2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n2 = Convert.ToInt32(N2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверная длина");
            }

            if (A2.Checked)
            {
                try
                {
                    v2 = new ArrayVector(n2);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Неверная длина.");
                }
            }

            if (L2.Checked)
            {
                try
                {
                    v2 = new LinkedListVector(n2);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Неверная длина");
                }
            }
        }


        private void V1Btn_Click(object sender, EventArgs e)
        {
            string[] words = Coord1.Text.Split(' ', ';', ':', '!', '?');
            int err = 0;
            for (int i = 0; i < n1; i++)
            {
                try
                {
                    v1[i] = Convert.ToDouble(words[i]);
                }
                catch (Exception)
                {
                    err = 1;
                    v1[i] = 0;
                }
            }
            if (err == 1)
            {
                MessageBox.Show("Введена(ы) неверная(ые) координата(ы). Она(и) будет(ут) заменена(ы) на 0.");
            }

            if (A1.Checked)
            {
                V1.Text = v1.ToString() + "   (AV)";
            }

            if (L1.Checked)
            {
                V1.Text = v1.ToString() + "   (LLV)";
            }
            
            V1.Visible = true;
        }


        private void V2Btn_Click(object sender, EventArgs e)
        {
            string[] words = Coord2.Text.Split(' ', ';', ':', '!', '?');
            int err = 0;
            for (int i = 0; i < n1; i++)
            {
                try
                {
                    v2[i] = Convert.ToDouble(words[i]);
                }
                catch (Exception)
                {
                    err = 1;
                    v2[i] = 0;
                }
            }
            if (err == 1)
            {
                MessageBox.Show("Введена(ы) неверная(ые) координата(ы). Она(и) будет(ут) заменена(ы) на 0.");
            }

            if (A2.Checked)
            {
                V2.Text = v2.ToString() + "   (AV)";
            }

            if (L2.Checked)
            {
                V2.Text = v2.ToString() + "   (LLV)";
            }

            V2.Visible = true;
        }


        private void SumB_Click(object sender, EventArgs e)
        {
            try
            {
                v3 = Vectors.Sum(v1, v2);
                ResSum.Text = v3.ToString();
                panelSum.Visible = true;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Размерность векторов не совпадает");
            }

        }

        private void ScalB_Click(object sender, EventArgs e)
        {
            try
            {
                double scalar = Vectors.Scalar(v1, v2);
                ResScal.Text = Convert.ToString(scalar);
                panelScal.Visible = true;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Размерность векторов не совпадает");
            }            
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(Num.Text);
            v3 = Vectors.NumberMul(v1, m);
            ResMul1.Text = v3.ToString();
            v3 = Vectors.NumberMul(v2, m);
            ResMul2.Text = v3.ToString();
            panelMul.Visible = true;
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            Norm1.Text = Convert.ToString(v1.GetNorm());
            Norm2.Text = Convert.ToString(v2.GetNorm());
            panelNorm.Visible = true;
        }
    }
}
