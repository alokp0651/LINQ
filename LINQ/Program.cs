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
        /// <summary>
        /// Diffrence between first and firstorDefaultS
        /// </summary>
        public static void FirstAndFirstorDefault() 
        {
            List<int> ListDontHaveEvenNo = new List<int>() { 1, 3, 5, 7, 9 };

           // int firstEvenNumber = ListDontHaveEvenNo.First(x => x % 2 == 0); // <<<<<<<<<----- it will throw exception 

            int firstDefaultNumber = ListDontHaveEvenNo.FirstOrDefault(x => x % 2 == 0);// <----it will return 0 as default number

            //Console.WriteLine(firstEvenNumber);
            Console.WriteLine(firstDefaultNumber);




        }

        static void Main(string[] args)
        {
            
         Program program = new Program();
            // GetEvenNumber();

            FirstAndFirstorDefault();




        }
    }
}
