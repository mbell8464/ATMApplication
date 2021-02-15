using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            decimal savingsBalance = 0m;
            decimal checkingBalance = 0m;
            int accountNumber = 123456789;
            int accountPIN = 1234;

            do
            {
                //TODO 1. Add while loop for attempt-counter
                Console.WriteLine("Please enter your 9 digit account number");
                int enteredNumber = Convert.ToInt32(Console.ReadLine());
                if (enteredNumber == accountNumber)
                {
                    //TODO 2. Add while loop for PINAttempt-counter
                    Console.WriteLine("Please enter your 4 digit PIN number");
                    int enteredPIN = Convert.ToInt32(Console.ReadLine());
                    if (enteredPIN == accountPIN)
                    {
                        bool mainMenu = true;
                        do
                        {
                            Console.WriteLine("Please select one of the following options: ");
                            Console.WriteLine("\n(1) Check Account Balance" +
                                "\n(2) Make Deposit" +
                                "\n(3) Make Withdrawl" +
                                "\n(4) Transfer" +
                                "\n(5) Exit");

                            ConsoleKey userChoice = Console.ReadKey(true).Key;
                            Console.Clear();

                            #region userChoice Switch

                            
                            switch (userChoice)
                            {
                                
                                case ConsoleKey.D1:
                                    Console.WriteLine("Account Balances");
                                    #region Account Balances
                                    bool account = true;
                                    do
                                    {
                                        Console.WriteLine("What account would you like to check?");
                                        Console.WriteLine("\n(1) Checking" +
                                            "\n(2) Savings" +
                                            "\n(3) Go Back");
                                        ConsoleKey accountChoice = Console.ReadKey(true).Key;
                                        Console.Clear();

                                        switch (accountChoice)
                                        {
                                            case ConsoleKey.D1:
                                                Console.WriteLine($"Your checking account has a balance of: {checkingBalance:c}");
                                                account = false;
                                                break;
                                            case ConsoleKey.D2:
                                                Console.WriteLine($"Your savings account has a balance of: {savingsBalance:c}");
                                                account = false;
                                                break;
                                            case ConsoleKey.D3:
                                                account = false;
                                                break;
                                            default:
                                                Console.WriteLine("Please choose a valid options");
                                                break;
                                        }
                                    } while (account);

                                    break;
                                #endregion

                                case ConsoleKey.D2:
                                    Console.WriteLine("Make Depsosit");
                                    //TODO 4. Ask user what account they would like to depsosit to (Checking or Saving)


                                    //TODO 5. Ask the user how much they would like to deposit, then deposit given amount into correct account


                                    break;
                                case ConsoleKey.D3:
                                    Console.WriteLine("Make Withdrawl");
                                    //TODO 6. Ask the user what account they would like to withdrawl from (Checking or saving)

                                    //TODO 7. Ask the user how much they would like to withdrawl, then withdrawl given amount from correct account
                                    //NOTE: If amountToWithdrawl is greater than the users account balance, then withdrawl should NOT go through


                                    break;
                                case ConsoleKey.D4:
                                    Console.WriteLine("Make Transfer");
                                    //TODO 8. Ask the user what account (Checking or Saving) they would like to transfer from

                                    //TODO 9. Ask the user what account (Checking or Saving) they would like to transfer to
                                    //NOTE: The account they want to transfer to should NOT be able to be the account they're transferring from

                                    //TODO 10. Ask the user how much they would like to transfer

                                    //TODO 11. subtract given amount from account transferred from, and add given amount to account transferred to. Give confirmation message

                                    break;
                                case ConsoleKey.D5:
                                    Console.WriteLine("Thank you for using this ATM");
                                    repeat = false;
                                    break;


                                default:
                                    Console.WriteLine("Please choose one of the given options");
                                    break;
                            }//end userChoice switch
                            #endregion
                        } while (true);
                        

                    }//end PIN-If statment
                    else
                    {
                        Console.WriteLine("PIN number incorrect. Please try again.");
                        //Update PINAttempt-Counter
                    }//end PIN-else statement
                }//end accountNumber-If statement
                else
                {
                    Console.WriteLine("Account number incorrect. Please try again.");
                    //Update attempt-counter here
                }//end accountNumber-else statment

            } while (repeat); //end do-while loop (entire application)
        }//end Main()
    }//end class Program
}//end namespace
