//Bank application assignment (.Net Framework)
// 7.5% interest rate for money kept in the bank for more than 5 years
//5.4% interest rate for money kept in the bank for less than 5 years

// Author : Maxwell Muthui Mwangi
// AdmNo  : BSCIT-05-0039/2021
// Date   : 8th November 2023


using System;

namespace Application
{
    public class Calc
    {
        public static void Interest()
        {
            double  amount;
            Console.WriteLine("\t\t\t#######################################################################");
            Console.WriteLine("\t\t\t##### Baller Bank Interest Rate Calculator ############################");
            Console.WriteLine("\t\t\t#######################################################################");
            Console.Write("\t\t\tInput the amount of money you would like to deposit in the bank: ");
            double bankbalance = Convert.ToDouble(Console.ReadLine());

            Console.Write("\t\t\tInput the number of years you want to leave your money in the bank: ");

            double years = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\t\t\t#######################################################################");
            Console.WriteLine("\t\t\t_______________________________________________________________________");
            Console.WriteLine("\t\t\t#######################################################################");
            Console.WriteLine("\t\t\t##### Baller Bank Interest Rate Calculator ############################");
            Console.WriteLine("\t\t\t#######################################################################");


            if (years >= 5)
            {
                amount = (years *( bankbalance * (7.5 / 100))) + bankbalance;
                double Gain = amount - bankbalance;
                Console.WriteLine("\t\t\tYour Initial Balance is:   " + bankbalance);
                Console.WriteLine("\t\t\tYour total Balance will be:   " + amount);
                Console.WriteLine("\t\t\tYour total Interest gained is:   " + Gain);
                Console.WriteLine("\t\t\tInterest P.A:   7.5% ");
                Console.WriteLine("\t\t\tDuration:   " + years + " Years");

                Console.WriteLine("\t\t\t#######################################################################");
                Console.WriteLine("\t\t\t#######################################################################");
                Console.WriteLine("\t\t\t############################ Finance ##################################");
                Console.WriteLine("\t\t\t#######################################################################");
            }
            else if (years < 5)
            {
                amount = (years *( bankbalance * (5.4 / 100)))+ bankbalance;
                Console.WriteLine("\t\t\tYour Initial Balance is:   " + bankbalance);
                Console.WriteLine("\t\t\tYour total Balance will be:   " + amount);
                double Gain = amount - bankbalance;
                Console.WriteLine("\t\t\tYour total interest gained is:   " + Gain);
                Console.WriteLine("\t\t\tInterest P.A:   5.4% ");
                Console.WriteLine("\t\t\tDuration:   " + years + " Years");


                Console.WriteLine("\t\t\t#######################################################################");
                Console.WriteLine("\t\t\t#######################################################################");
                Console.WriteLine("\t\t\t############################ Finance ##################################");
                Console.WriteLine("\t\t\t#######################################################################");
            }
            else
            {
                Interest();
                Console.WriteLine("\t\t\t#######################################################################");
                Console.WriteLine("\t\t\t#######################################################################");
                Console.WriteLine("\t\t\t#######################################################################");
            }
            Interest();
           
        }

        public static void Main(string[] args)
        {
            Calc Inter = new Calc();
            Interest();
        }
    }


}