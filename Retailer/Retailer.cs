/**
* SWENG 421
* M8 Lab
* Yifan Liu, Sunghee Choi
* 
* Retailer class
* - must only have association with TV class
* - allows the user to input a budget amount
* - finds the best matching TV based on that budget
* - display the TV details
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSystem;

namespace Retailer
{
    public class Retailer
    {
        TV t; // reference to TV object

        public Retailer()
        {
            t = new Proxy_TV();
        }

        public static void Main(string[] args)
        {
            // loop control flags
            bool loop = true;
            bool invalid;
            do
            {
                // create Retailer instance  
                Retailer retailer = new Retailer();

                // get budget input
                Console.Write("\n\nEnter Budget: ");
                string userBudget = Console.ReadLine();
                int budget = Convert.ToInt32(userBudget);

                // call TV selection and display details
                try
                {
                    if (retailer.t != null)
                    {
                        Console.WriteLine(retailer.t.ReplenishTV(budget).GetInfo());
                    }
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine("No matching TV");
                }
                

                // check whether user wants to enter budget again
                do
                {
                    Console.Write("\nCheck budget again?\n1: YES\n2: NO\n");
                    string input = Console.ReadLine();
                    int selection = Convert.ToInt32(input);

                    // set loop and invalid flags
                    if (selection == 1)
                    {
                        loop = true;
                        invalid = false;
                    }
                    else if (selection == 2)
                    {
                        loop = false;
                        invalid = false;
                    }
                    else
                    {
                        Console.Write("\nPlease enter valid input\n");
                        invalid = true;
                    }
                } while (invalid);
            } while (loop);
        }
    }
}
