using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Program
    {
       

        public static void GetEvenNumber() 
        {
            List<int> number = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            //List<int> EvenNumber = new List<int>();
            //foreach (int i in number)
            //{
                                                                ////<<<<<<<<<<<------------this is a normal code to get Even number from list .
            //    if (i % 2 == 0)
            //        EvenNumber.Add(i);
            //}

            List<int> EvenNumber = number.FindAll(x => x % 2 == 0);    /////<<<<<<<<<<<<<-------this is using LINQ  (x => x % 2 == 0) using LAMBDA Expression.


            //just printinng the list
            int count = EvenNumber.Count();
            for (int i = 0; i < count; ++i)
            {
                Console.Write("{0}\t", EvenNumber[i].ToString());
            }
            Console.ReadLine();
        }
        
        static void Main(string[] args)
        {
            
         Program program = new Program();
         GetEvenNumber();
            
            
        }
    }
}
