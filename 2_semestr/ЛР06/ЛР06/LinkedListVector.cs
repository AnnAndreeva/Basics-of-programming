using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР06
{
    [Serializable]
    class LinkedListVector : IVector, IComparable, ICloneable
    {
        [Serializable]
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
                    Console.WriteLine("Неверный индекс");
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
                    Console.WriteLine("Элемента с таким индексом нет");
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

        public override bool Equals(object obj)
        {
            IVector v = (IVector)obj;
            int k = 0;
            for (int i = 0; i < Length; i++)
            {
                if (this[i] == v[i])
                    k++;
            }
            if ((this.Length == v.Length) && (k == v.Length))
                return true;
            else return false;
        }

        public override int GetHashCode()
        {
            return Length.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            IVector v = (IVector)obj;
            if (v == null)
            {
                throw new ArgumentException("Объект не вектор.");
            }
            else
            {
                if (this.Length > v.Length) return 1;
                else if (this.Length < v.Length) return -1;
                else return 0;
            }

        }

        public object Clone()
        {
            LinkedListVector clone = new LinkedListVector(Length);
            for (int i = 0; i < Length; i++)
            {
                clone[i] = this[i];
            }
            return clone;
        }
    }
}
