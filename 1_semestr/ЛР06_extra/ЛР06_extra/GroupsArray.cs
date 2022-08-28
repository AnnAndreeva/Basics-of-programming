using System;

namespace ЛР06_extra
{
    class GroupsArray
    {
        public int N;
        public int[] numArr;

        public GroupsArray()
        { }

        public GroupsArray(int N, int[] numArr)
        {
            this.N = N;
            this.numArr = numArr;
        }

        public Student[][] InputGroupsArr()
        {
            Console.Write("Введите кол-во групп на 6 факультете: ");
            N = Convert.ToInt32(Console.ReadLine());
            Student[][] Groups = new Student[N][];
            numArr = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Введите номер группы: ");
                numArr[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите кол-во студентов в группе {0}: ", numArr[i]);
                int k = Convert.ToInt32(Console.ReadLine());
                Groups[i] = new Student[k];
                for (int j = 0; j < k; j++)
                {
                    Console.WriteLine("Введите имя студента: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите оценки:");
                    int m1 = Convert.ToInt32(Console.ReadLine());
                    int m2 = Convert.ToInt32(Console.ReadLine());
                    int m3 = Convert.ToInt32(Console.ReadLine());
                    int m4 = Convert.ToInt32(Console.ReadLine());
                    int mid = (m1 + m2 + m3 + m4) / 4;
                    Groups[i][j] = new Student(name, m1, m2, m3, m4);
                }
            }
            return Groups;
        }

        public Student[][] OutputGroups(Student[][] Groups)
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Группа {0}:", numArr[i]);
                for (int j = 0; j < Groups[i].Length; j++)
                {
                    Console.Write(Groups[i][j].name + "  " + Groups[i][j].m1 + " " + Groups[i][j].m2 + " ");
                    Console.WriteLine(Groups[i][j].m3 + " " + Groups[i][j].m4);
                }
            }
            return Groups;
        }



        public Student[][] SortGroupsUp(Student[][] Groups)
        {
            int[][] MidGr = new int[N][];
            double s;
            double[] Mid = new double[N];

            for (int i = 0; i < N; i++)
            {
                s = 0;
                MidGr[i] = new int[1];
                Mid[i] = 0;
                for (int j = 0; j < Groups[i].Length - 1; j++)
                {
                    MidGr[i][j] = (Groups[i][j].m1 + Groups[i][j].m2 + Groups[i][j].m3 + Groups[i][j].m4) / 4;
                    s += MidGr[i][j];
                }
                Mid[i] = s / Groups[i].Length;
            }
            for (int i = 0; i < N-1; i++)
            {

                if (Mid[i] > Mid[i + 1])
                {
                    double v = Mid[i];
                    Student[] vd = Groups[i]; ;
                    Mid[i] = Mid[i + 1];
                    Groups[i] = Groups[i + 1];
                    Mid[i + 1] = v;
                    Groups[i + 1] = vd;
                }

            }

            return Groups;

        }

        public Student[][] SortGroupsDown(Student[][] Groups)
        {
            int[][] MidGr = new int[N][];
            double s;
            double[] Mid = new double[N];

            for (int i = 0; i < N; i++)
            {
                s = 0;
                MidGr[i] = new int[1];
                Mid[i] = 0;
                for (int j = 0; j < Groups[i].Length - 1; j++)
                {
                    MidGr[i][j] = (Groups[i][j].m1 + Groups[i][j].m2 + Groups[i][j].m3 + Groups[i][j].m4) / 4;
                    s += MidGr[i][j];
                }
                Mid[i] = s / Groups[i].Length;
            }
            for (int i = 0; i < N - 1; i++)
            {

                if (Mid[i] < Mid[i + 1])
                {
                    double v = Mid[i];
                    Student[] vd = Groups[i]; ;
                    Mid[i] = Mid[i + 1];
                    Groups[i] = Groups[i + 1];
                    Mid[i + 1] = v;
                    Groups[i + 1] = vd;
                }

            }

            return Groups;

        }



        public Student[][] SortGroupUp(Student[][] Groups)
        {

            for (int i = 0; i < N; i++)
            {
                int[] Mid = new int[Groups[i].Length];
                for (int j = 0; j < Groups[i].Length - 1; j++)
                {
                    Mid[j] = (Groups[i][j].m1 + Groups[i][j].m2 + Groups[i][j].m3 + Groups[i][j].m4) / 4;
                    Mid[j + 1] = (Groups[i][j + 1].m1 + Groups[i][j + 1].m2 + Groups[i][j + 1].m3 + Groups[i][j + 1].m4) / 4;
                    if (Mid[j] > Mid[j + 1])
                    {
                        int v = Mid[j];
                        Student vd = Groups[i][j]; ;
                        Mid[j] = Mid[j + 1];
                        Groups[i][j] = Groups[i][j + 1];
                        Mid[j + 1] = v;
                        Groups[i][j + 1] = vd;
                    }

                }
            }
            return Groups;
        }
        public Student[][] SortGroupDown(Student[][] Groups)
        {

            for (int i = 0; i < N; i++)
            {
                int[] Mid = new int[Groups[i].Length];
                for (int j = 0; j < Groups[i].Length - 1; j++)
                {
                    Mid[j] = (Groups[i][j].m1 + Groups[i][j].m2 + Groups[i][j].m3 + Groups[i][j].m4) / 4;
                    Mid[j + 1] = (Groups[i][j + 1].m1 + Groups[i][j + 1].m2 + Groups[i][j + 1].m3 + Groups[i][j + 1].m4) / 4;
                    if (Mid[j] < Mid[j + 1])
                    {
                        int v = Mid[j];
                        Student vd = Groups[i][j]; ;
                        Mid[j] = Mid[j + 1];
                        Groups[i][j] = Groups[i][j + 1];
                        Mid[j + 1] = v;
                        Groups[i][j + 1] = vd;
                    }

                }
            }
            return Groups;
        }
    }
}

