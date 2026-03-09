using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MILESTONE_2_PRG
{
    internal class Program
    {

        //We use a method called StoreCustomer that will store the customer names in our database
        static void StoreCustomer()
        {
            Console.WriteLine("Please enter the customer's name.");
            string one = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please enter a title you want to rent (VHS/CD/DVD)");
            string title = Console.ReadLine();
            Console.WriteLine("Customer name stored.");
        }

        //We use a method called RegistrationYear that we calculate whether a customer qualifies for discount depending on the years
        static void RegistrationYear()
        {
            Console.WriteLine("");
            Console.WriteLine("How many years has the customer been registered ?");
            double years = Convert.ToDouble(Console.ReadLine());
            if (years >= 0 && years <= 4)
            {
                Console.WriteLine("Customer gets 5% discount.");
            }
            else if (years >= 5 && years <= 9)
            {
                Console.WriteLine("Customer gets a 10% discount.");
            }
            else if (years >= 10 && years <= 14)
            {
                Console.WriteLine("Customer gets a 20% discount.");
            }
            else if (years > 15)
            {
                Console.WriteLine("Customer gets a 35% discount.");
            }
        }

        //We use a method called TotalRentals to check how many rentals does a customer have
        static void TotalRentals()
        {
            Console.WriteLine("");
            Console.WriteLine("Please enter the total number of rentals that the customer has rented.");
            int totalrentals = Convert.ToInt32(Console.ReadLine());
            if (totalrentals >= 75)
            {
                Console.WriteLine("8 free rentals");
            }
            else if (totalrentals >= 50 && totalrentals < 75)
            {
                Console.WriteLine("4 free rentals");
            }
            else if (totalrentals >= 25 && totalrentals < 50)
            {
                Console.WriteLine("2 free rentals");
            }
            else if (totalrentals >= 10 && totalrentals < 25)
            {
                Console.WriteLine("1 free rental");
            }
            else
            {
                Console.WriteLine("The customer does not reach the minimum rentals for a Coupon");
            }
            Console.WriteLine("Total number of rentals has successfully been recorded.");
        }

        //We use a method called TotalMoneyspent to calculate how much the customer has spent
        static void TotalMoneyspent()
        {
            Console.WriteLine("What is the total money that the customer has spent?");
            Console.ReadLine();
            Console.WriteLine("Total money of customer has been successfully recorded.");
        }

        //We use a method called AddCustomer that will add new customers to the list
        static void AddCustomers()
        {
            Console.WriteLine("Please enter the new customers names.");
            string[] names = new string[5];
            for (int i = 0; i < names.Length; i++)
            {

                names[i] = Console.ReadLine();

            }
        }

        //We add a method called SelectCustomer to select a customer from a list
        static void SelectCustomer()
        {
            Console.WriteLine("Plaese select a customer.");
            string customer = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Customer selected.");
        }

        //We use a method called Rewards to check if a customer qualifies for a reward
        static void Reward()
        {
            Console.WriteLine("How many years have you been registered? ");
            int period = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many time have you rented from us? ");
            int rental = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You have been rented for {period} years");
            int rentals = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine($"You have rented {rental} ");
            if(period <= 5 && period >= 9 && rental <= 25)
{
                Console.WriteLine("You have a reward of 1 Bronze-Tier");
            }
            else if (period <= 10 && period >= 14 && rental <= 50)
            {
                Console.WriteLine("You have a reward of 3 Bronze-Tier + 1 Silver-Teir");
            }
            else if (period <= 15 && rental <= 75)
            {
                Console.WriteLine("You have a reward of 5 Bronze-Tier + 2 Silver-Tier + 1 Gold-Tier ");
            }
            else
            {
                Console.WriteLine("You can't get for Lost Media Reward ");
            }
        }
        static void Main(string[] args)
        {
            
             Console.WriteLine("1.Customer's name.");
             Console.WriteLine("2.Registration year.");
             Console.WriteLine("3.Total rentals and Discount coupons");
             Console.WriteLine("4.Total money spent.");
             Console.WriteLine("5.New customers.");
             Console.WriteLine("6.Select Customer.");
             Console.WriteLine("7.Rewards");
             Console.WriteLine("8.Exit");
            int option = int.Parse(Console.ReadLine());
            while (option !=8)
            {
                switch (option)
                {
                    case 1:
                        StoreCustomer();
                        break;
                    case 2:
                        RegistrationYear();
                        break;
                    case 3:
                        TotalRentals();
                        break;
                    case 4:
                        TotalMoneyspent();
                        break;
                    case 5:
                        AddCustomers();
                        break;
                    case 6:
                        SelectCustomer();
                        break;
                    case 7:
                        Reward();
                        break;

                
                }
                Console.ReadKey();
                //option = int.Parse(Console.ReadLine());
            }
          
            
        }
    }
}
