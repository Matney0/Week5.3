﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Week5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                DisplayMenu();
            } while (true);
        }
        public static void DisplayMenu()
        {
            //Program to simulate a Call Center menu

            Console.WriteLine("Welcome to the Call Center!");
            Console.WriteLine("Please select an option from the menu below:");
            Console.WriteLine("1. Add customer to the collection");
            Console.WriteLine("2. Serve the next customer in the queue");
            Console.WriteLine("3. Display all customers in the queue");
            Console.WriteLine("4. Exit the program");

            string input = Console.ReadLine();
            int choice = Convert.ToInt32(input);


            switch (choice) {
                case 0: Console.WriteLine("Invalid choice. Please try again.");
                    break;
                case 1: AddCustomer();
                    break;
                case 2: ServeCustomer();
                    break;
                case 3: DisplayCustomers();
                    break;
                case 4: ExitProgram();
                    Environment.Exit(0);
                    break;

            }
        }


            public static void AddCustomer()
        {
            List<string> customers = new List<string>();
            int i = 1;
            Console.WriteLine("Please enter the customer's name:");
            //adding new customer to the list
            string name = Console.ReadLine();
            customers.Add(name);
            Console.WriteLine("Please enter the customer's phone number:");
            string phone = Console.ReadLine();
            Console.WriteLine("Please enter the customer's email address:");
            string email = Console.ReadLine();
            Console.WriteLine("You will reacieve a queue number shortly.");
            Console.WriteLine("Your queue number is: " + i);
            i++;

        }
        public static void ServeCustomer()
        {   
            Console.WriteLine("Serving the next customer in the queue... ");
        }
        public static void DisplayCustomers()
        {
            Console.WriteLine("Displaying all customers in the queue...");
            //displaying all customers from the customer list
            List<string> customers = new List<string>();

        }
        public static void ExitProgram()
        {
            Console.WriteLine("Exiting the program...");
        }
    }
}
