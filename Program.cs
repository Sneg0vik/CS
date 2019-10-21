using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Number = new List<int>();
            int join = Convert.ToInt32(Console.ReadLine());                       
            Random rnd = new Random();
            GFG gg = new GFG();
            Print(join,Number, rnd,gg);
            var count = Number.Count();





            if (count % 2 != 0)  
            {
                var aver = Number[count / 2];
                Console.WriteLine("знач " + aver);
            }
            else
            {
                var aver1 = Number[count / 2 ];
                var aver2 = Number[count / 2 - 1];
                var aver = (aver1 + aver2) / 2;
                
                Console.WriteLine("знач " + aver);
               
            }

        }





        static void Print(int join,in List<int> Number, Random rnd, GFG gg) 
        {
            
            for (int i = 0; i < join; i++) 
            {
                
                Number.Add(Convert.ToInt32(rnd.Next(0,100)));    
                             


            }

            Number.Sort(0, Number.Count(), gg);
            for (int i = 0; i < join; i++)
            {
                Console.WriteLine("ТУТУ              " + Number[i]);
            }
            


        }
    }
}
