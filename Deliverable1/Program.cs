
using System;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace RestockCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message//

            Console.WriteLine("Hello, Welcome to the restocking tool.");
            Console.WriteLine();
            Console.WriteLine();


            //Total Items and Restock Limit//

            int totalsodas = 100;
            int sodalimits = 40;
            int totalchips = 40;
            int chiplimits = 20;
            int totalcandys = 60;
            int candylimits = 40;



            //Sodas Sold//

            {
                Console.WriteLine("How many Sodas have been sold today?");
                int sodassold = int.Parse(Console.ReadLine());

                //sodas left//

                int sodasleft = totalsodas - sodassold;

                if (sodassold >= totalsodas + 1)
                {
                    Console.WriteLine("That value is too high. Stock not adjusted!");

                }

                if (sodasleft <= totalsodas - 60)
                {
                    Console.WriteLine(value: $"Soda will need restock. Only {sodasleft} sodas remaining.");

                }
                else
                {
                    Console.WriteLine(value: $"No restock needed. {sodasleft} sodas remaining");
                }


                //Chips Sold//


                Console.WriteLine();
                Console.WriteLine("How many Chips have been sold today?");
                int chipssold = int.Parse(Console.ReadLine());

                //chips left//

                int chipsleft = totalchips - chipssold;

                if (chipssold >= totalchips + 1)
                {
                    Console.WriteLine("That value is too high. Stock not adjusted!");
                }

                if (chipsleft <= totalchips - 20)
                {
                    Console.WriteLine(value: $"Chips will need restock. Only {chipsleft} Chips remaining.");
                }

                else
                {
                    Console.WriteLine(value: $"No restock needed. {chipsleft} sodas remaining");
                }
                {

                    //Candy Sold//
                }

                Console.WriteLine();
                Console.WriteLine("How many Candys have been sold today?");
                int candyssold = int.Parse(Console.ReadLine());

                //Candys left//
                int candysleft = totalcandys - candyssold;

                if (candyssold >= totalcandys + 1)
                {
                    Console.WriteLine("That value is too high. Stock not adjusted!");
                }

                if (candysleft <= totalcandys - 20) 
                {
                    Console.WriteLine(value: $"Candys will need restock. Only {candysleft} Candys remaining.");
                }
                else

                Console.WriteLine(value: $"No restock needed. {candysleft} sodas remaining");
                Console.WriteLine();
                Console.WriteLine();


                Console.WriteLine("Thank you for filling out the values. The items needed for restock are listed above.");
                Console.WriteLine();
                Console.WriteLine("Thank You GoodBye!");

               
                  
                }
            }

        }
    }
