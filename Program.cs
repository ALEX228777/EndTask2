using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraysParent[] arraysParents = new ArraysParent[3];
            Console.WriteLine("Ввод мвссивов с клавиатуры?");
            if(Console.ReadLine() == "Да")
            {
                Console.WriteLine("Задачи на одномерные массивы");
                arraysParents[0] = new One_dimension(false);
                Console.WriteLine("Задачи на двумерные массивы");
                arraysParents[1] = new Two_dimension(false);
                Console.WriteLine("Задачи на зубчатые массивы");
                arraysParents[2] = new Jagged(false);
                for (int i = 0; i < arraysParents.Length; i++)
                {
                    arraysParents[i].Print();
                    arraysParents[i].Getmiddle();
                }

            }
            if(Console.ReadLine() == "Нет")
            {
                arraysParents[0] = new One_dimension(true);
                arraysParents[1] = new Two_dimension(true);
                arraysParents[2] = new Jagged(true);
                for (int i = 0; i < arraysParents.Length; i++)
                {
                    arraysParents[i].Print();
                    arraysParents[i].Getmiddle();

                }
            }

        }
    }
}