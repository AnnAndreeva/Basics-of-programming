using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР08
{
    class LinkedListVector : IVector
    {
        class Node
        {
            public double el = 0.0;
            public Node link = null;
        }
        Node first;
        public LinkedListVector(int n)
        {

            for (int i = 0; i <= n; i++)
            {
                Node curr = new Node();
                curr.link = first;
                first = curr;
            }


        }

        public LinkedListVector()
        {
            for (int i = 0; i < 4; i++)
            {
                Node curr = new Node();
                curr.link = first;
                first = curr;
            }

        }

        public int Length
        {
            get
            {
                int l = 0;
                Node curr = first;
                while (curr.link != null)
                {
                    l++;
                    curr = curr.link;
                }
                return l;
            }
        }

        public double this[int id]
        {

            get
            {
                try
                {
                    Node curr = first;
                    for (int i = 0; i < id; i++)
                    {
                        curr = curr.link;
                    }
                    return curr.el;
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Неверный индекс");
                    return 0.0;
                }

            }
            set
            {
                try
                {
                    Node curr = first;
                    for (int i = 0; i < id; i++)
                    {
                        curr = curr.link;
                    }
                    curr.el = value;
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Элемента с таким индексом нет");
                }
            }
        }


        public double GetNorm()
        {

            double norm = 0.0;
            Node curr = first;
            while (curr.link != null)
            {
                norm += Math.Pow(curr.el, 2);
                curr = curr.link;
            }
            return Math.Sqrt(norm);

        }
        public override string ToString()
        {
            string v = "";
            Node curr = first;
            while (curr.link != null)
            {
                v += curr.el + " ";
                curr = curr.link;
            }
            return "Число координат вектора: " + Length + ", координаты вектора через пробел:" + v + ".";
        }
    }
}
