using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basicCAM
{
    public class Customer
    {
        protected decimal interestRate;
         protected string name;
        protected decimal balance;

        public Customer(string n, decimal b, decimal ir)
        {
            this.name = n;
            this.balance = b;
            this.interestRate = ir;
        }

        public virtual decimal Withdraw(decimal amount)
        {
            return balance - amount;
        }

        public virtual decimal Deposit(decimal amount)
        {
            return balance + amount;
        }

        public virtual decimal addInterest(decimal balance, decimal interest)
        {
            return balance + (interest * balance);
        }


        List<Customer> myCustomers = new List<Customer>();

        
    }

    public class checkingAccount : Customer
    {
        public checkingAccount(string n, decimal b, decimal ir):
        base(n, b, ir) { }

        public override decimal Withdraw(decimal amount)
        {
            return balance - amount;
        }

        public override decimal Deposit(decimal amount)
        {
            return balance + amount;
        }

        public override decimal addInterest(decimal balance, decimal interest)
        {
            return balance + (interest * balance);
        }

    }

    public class savingAccount : Customer
    {
        public savingAccount(string n, decimal b, decimal ir):
        base(n, b, ir) { }

        public override decimal Withdraw(decimal amount)
        {
            return balance - amount;
        }

        public override decimal Deposit(decimal amount)
        {
            return balance + amount;
        }

        public override decimal addInterest(decimal balance, decimal interest)
        {
            return balance + (interest * balance);
        }

    }



    class Program
    {
        static void Main(string[] args)
        {

            int customerSelection = 0;
            while (customerSelection <= 4)
            {

            Console.WriteLine("Welcome to Big Bank Inc.");
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1 - Create an account?");
            Console.WriteLine("2 - Make a deposit?");
            Console.WriteLine("3 - Withdraw funds");
            Console.WriteLine("4 - Quit");

            customerSelection = Convert.ToInt32(Console.ReadLine());
            List<Customer> myCustomers = new List<Customer>();
            switch (customerSelection)
            {
                case 1:
                    //NAME
                    Console.WriteLine("What is your name?");
                    string n = Console.ReadLine();

                    //INITIAL BALANCE
                    Console.WriteLine("How much would you like to open the account with?");
                    decimal b = Convert.ToInt32(Console.ReadLine());

                    //ACCOUNT TYPE       
                    Console.WriteLine("Would you like to open a Checking or Savings account?");
                    Console.WriteLine("Enter 1 for Checking, or 2 for a Savings account.");
                    int accountType = Convert.ToInt32(Console.ReadLine());

                    if (accountType == 1)
                    {
                        myCustomers.Add(new checkingAccount(n, b, 0) {});
                        Console.WriteLine("Welcome aboard {0}, have successfully created a checking account with NR Banking.", n);
                        Console.WriteLine("Your current balance is {0}", b);
                        break;
                        
                        
                    }
                    if (accountType == 2)
                    {
                        myCustomers.Add(new savingAccount(n, b, 1.5M) {});
                        Console.WriteLine("Welcome aboard {0}, have successfully created a savings account with NR Banking.", n);
                        Console.WriteLine("Your fixed interest rate for this account is 1.5%");
                        Console.WriteLine("Your current balance is {0}", b);
                        break;
                        
                        
                    }
                    break;
            

                 case 2:
                 //deposit
                    Console.WriteLine("Please enter your name.");
                    //SIGN IN. Require correct name.
                    //ACCEPT Username
                    string a = Console.ReadLine();
                    //is Customer name = to string a?
                    foreach (Customer name in myCustomers)
                    {
                    if ( name.ToString() == a)
                        {
                            //find out how much to depsoit
                            Console.WriteLine("How much would you like to deposit?");
                            decimal deposit = Convert.ToDecimal(Console.ReadLine());
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("Please enter your name.");
                    string c = Console.ReadLine();
                    Parallel.ForEach<Customer>(myCustomers, (s) => c.Trim());
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
