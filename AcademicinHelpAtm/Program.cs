//Developer: Oyekan A.O
//feedback: @tobainocycle || tobainocycle@gmail.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicinHelpAtm
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 9500, deposit, withdraw, accountno;
            int choice, pin = 0, x = 0;
            //string account_name = "";
            Console.WriteLine("Enter Your 4 Digit Pin.");
            pin = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("YOU ARE WELCOME TO ACADEMICIAN HELP ATM SERVICE\n");
                Console.WriteLine("1. Account Balance\n");
                Console.WriteLine("2. Withdraw \n");
                Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4. Create Account \n");
                Console.WriteLine("5. Cancel \n");
                Console.WriteLine("***************\n\n");
                Console.WriteLine("Enter your desired operation : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n YOUR Account Balance is N : {0} ", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n Please Input Amount to withdraw : ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n Please Input amount above N 100");
                        }
                        else if (withdraw > (amount - 1000))
                        {
                            Console.WriteLine("\n Sorry, transaction failed! Insufficient balance in Account");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n\n Retract your cash");
                            Console.WriteLine("\n Account Balance is N : {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n Inout money to be deposited");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("Money has been successfuly deposited");
                        Console.WriteLine("Your total account balance is N : {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("\n Create New Account, Enter account number");
                        accountno = int.Parse(Console.ReadLine());
                        Console.WriteLine("Account has been successfuly created");
                        Console.WriteLine("Your New account number is : {0}",  accountno);
                        break;
                    case 5:
                        Console.WriteLine("\n We appreciate your patronage");  
                            break;
                }
            }
              Console.WriteLine("\n\n Thanks for using our ATM");

        }

        }

}
