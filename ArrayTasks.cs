using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MethodTasks
{
    internal class ArrayTasks
    {
        internal int[] EnterArray()
        {
            Console.WriteLine("Massivin uzunlegunu daxil edin:");
            int n=int.Parse(Console.ReadLine());
            int[] mass=new int[n];
            
            for(int i=0; i<mass.Length; i++)
            {
                Console.Write($"mass[{i}]=");
                mass[i] = int.Parse(Console.ReadLine());

            }
            return mass;
        }
        internal int[] SqrtArray()
        {
            int[] mass = EnterArray();
            Console.Write("Kvadrat koklu elementler:");

            for (int i=0; i<mass.Length;i++)
            {
                if (Math.Sqrt(mass[i]) % 1 == 0)
                {
                    Console.Write(mass[i] + " ");
                }
            }
            Console.WriteLine("\t");
            return mass;

        }
        internal void Print(int[] mass)
        {
            Console.Write("Heqiqi massivin elementleri:");
             foreach (var item in mass)
            {
                Console.Write(item + " ");

            }
             Console.WriteLine();
            
            
        }
    }
}
