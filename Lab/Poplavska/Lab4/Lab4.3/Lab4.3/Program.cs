using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 0, 3, 0, 0, -1, 5, 4, 0, 0, 0, 1, 3, 4, 0, 0, 1, -1 };
            int zero=0;
            int plus=0;

            for (int i = 0; i < num.Length; i++) {
            
            Console.Write(num[i]+ " ");
            if(i+1<num.Length){
                if(num[i]>0&& num[i+1]>0){
                    plus++;
                }
                if(num[i]==0 && num[i+1]==0){
                    zero++;
                }
            }
            }
            Console.WriteLine();
            Console.WriteLine("Кiлькiсть сусiдств двох додатнiх чисел =  " + plus);
            Console.WriteLine("Кiлькiсть сусiдств двох нульових елементiв =  " + zero);
            Console.ReadLine();
        }
    }
}
