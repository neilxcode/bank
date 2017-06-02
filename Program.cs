using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basicCAM
{
    public class Customer
    {
        public decimal interestRate;
         public string name;
        public decimal balance;

        public Customer(string n, decimal b, decimal ir)
        {
            this.name = n;
            this.balance = b;
            this.interestRate = ir;
        }
    
    }

    class Program
    {
        static void Main(string[] args)
        {
            //define global variables and list
            string n = "";
            decimal b = 0;
            string q = "";
            decimal ir = 0;
            List<Customer> myCustomers = new List<Customer>();

            int customerSelection = 0;
            //while selection is within range continue
            while (customerSelection <= 4)
            {
            //dispplay user options
            Console.WriteLine("Welcome to Big Bank Inc.");
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1 - Create an account?");
            Console.WriteLine("2 - Make a deposit?");
            Console.WriteLine("3 - Withdraw funds");
            Console.WriteLine("4 - Quit");

            //get customer selection
            customerSelection = Convert.ToInt32(Console.ReadLine());
            
            //switch to define each customer selection case
            switch (customerSelection)
            {
                
                //CREATE ACCOUNT
                case 1:
                    //NAME
                    Console.WriteLine("What is your name?");
                    n = Console.ReadLine();

                    Console.WriteLine("Would you like to open a Checking or Saving account? [1 or 2]");
                    q = Console.ReadLine();
                    

                    //INITIAL BALANCE
                    Console.WriteLine("How much would you like to open the account with?");
                    b = Convert.ToDecimal(Console.ReadLine());


                    

                    if (q == "2")
                    {
                        ir = 1.5m;
                        myCustomers.Add(new Customer(n, b, ir) {});

                        foreach(Customer obj in myCustomers)
                        {
                            if (obj.name == n)
                            {
                                obj.interestRate = 1.5m;
                            }
                        }
                    }
                    if (q == "1")
                    {
                        ir = 0;
                        myCustomers.Add(new Customer(n, b, ir));
                        
                    }



                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");       
                    Console.WriteLine("Welcome aboard,{0} to NR Banking", n);
                    Console.WriteLine("Account Balance: {0}", b);
                    Console.WriteLine("Fixed Yearly Interest Rate: {0}", ir);
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");

                        
                    
                    break;
            
                //DEPOSIT
                 case 2:
                 //deposit
            
                    //SIGN IN. Require correct name.
                    //ACCEPT Username
                    Console.WriteLine("Please enter your name.");
                            string z = Console.ReadLine();
                            string l = "";

                    
                    foreach(Customer obj in myCustomers)
                        {
                            l = z;
                            decimal o = obj.balance;
                            if(obj.name == l)
                                {
                                    Console.WriteLine("How much would you like to deposit");
                                    decimal deposit = Convert.ToDecimal(Console.ReadLine());
                                    o = o + deposit;
                                    Console.WriteLine("\n");
                                    Console.WriteLine("\n");
                                    Console.WriteLine("Your new balance is {0}.", o);
                                    Console.WriteLine("\n");
                                    Console.WriteLine("\n");
                                    Console.WriteLine("\n");

                                    break;
                                }
                                else
                                {
                                    break;
                                }
                        
                    }
                    break;

                case 3:
                    Console.WriteLine("Please enter your name.");
                    string h = Console.ReadLine();
                    string j = "";

                    foreach(Customer obj in myCustomers)
                        {
                            j = h;
                            decimal o = obj.balance;
                            if(obj.name == h)
                                {
                                    Console.WriteLine("How much would you like to withdraw");
                                    decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                                    o = o - withdraw;
                                    Console.WriteLine("\n");
                                    Console.WriteLine("\n");
                                    Console.WriteLine("Your new balance is {0}.", o);
                                    Console.WriteLine("\n");
                                    Console.WriteLine("\n");
                                    Console.WriteLine("\n");

                                    break;
                                }
                                else
                                {
                                    break;
                                }
                        }

                    break;

                case 4:
                    break;

                default:  
                    Console.WriteLine("Sorry, invalid selection");  
                    break;
            }


               
            }
        }
    }
}
