using BankoSistema.Models;
using System;

namespace ManoPrograma
{
    public class PagrindineKlase
    {
        public static void Main(string[] args)
        {
            // Josh'o accountai

            List<Transaction> joshTransactions1 = new List<Transaction>(); // pirmas acc
            Account josh1 = new Account("3001", 1300, joshTransactions1);

            List<Transaction> joshTransactions2 = new List<Transaction>(); // antras acc
            Account josh2 = new Account("3002", 240, joshTransactions2);

            List<Account> joshAccounts = new List<Account>();
            joshAccounts.Add(josh1);
            joshAccounts.Add(josh2);

            Customer customerJosh = new Customer("Josh", joshAccounts);

            // Anita accountai

            List<Transaction> anitaTransactions1 = new List<Transaction>(); // pirmas acc
            Account anita1 = new Account("4001", 5600, anitaTransactions1);

            List<Transaction> anitaTransactions2 = new List<Transaction>(); // antras acc
            Account anita2 = new Account("4002", 550, anitaTransactions2);

            List<Transaction> anitaTransactions3 = new List<Transaction>(); // trecias acc
            Account anita3 = new Account("4003", 320, anitaTransactions3);

            List<Account> anitaAccounts = new List<Account>();
            anitaAccounts.Add(anita1);
            anitaAccounts.Add(anita2);
            anitaAccounts.Add(anita3);

            Customer customerAnita = new Customer("Anita", anitaAccounts);

            // veiksmai 

            Console.WriteLine("Welcome to Late Night Bank!");

            string continueYesNo = "yes";

            while (continueYesNo == "yes")
            {
                Console.WriteLine("What is your name? (Josh/Anita)");

                string name = Console.ReadLine();

                if (name == "Josh")
                {
                    Console.WriteLine("Your accounts and balances:");
                    foreach (Account account in joshAccounts)
                    {
                        Console.WriteLine("Account number: " + account.Number + "    Balance - " + account.Balance + " Eur.");
                    }
                    Console.WriteLine("Total account balance: " + customerJosh.GetTotalBalance());

                    Console.WriteLine("Would you like to make a deposit or a withdrawal? (type deposit/withdraw)");

                    string actionType = Console.ReadLine();

                    if (actionType == "deposit")
                    {
                        Console.WriteLine("Please provide amount and account number to make a deposit");
                        Console.WriteLine("Amount: ");
                        double amount = double.Parse(Console.ReadLine());

                        Console.WriteLine("Account number: ");

                        switch (Console.ReadLine())
                        {
                            case "3001":
                                josh1.Deposit(amount);

                                Console.WriteLine("Deposit successful, new balance: " + josh1.Balance);
                                Console.WriteLine(josh1.Transactions.Count() + " transaction(s) made.");
                                break;

                            case "3002":
                                josh2.Deposit(amount);

                                Console.WriteLine("Deposit successful, new balance: " + josh2.Balance);
                                Console.WriteLine(josh2.Transactions.Count() + " transaction(s) made.");
                                break;

                            default:
                                Console.WriteLine("Wrong input");
                                break;

                        }
                    }

                    else if (actionType == "withdraw")
                    {
                        Console.WriteLine("Please provide amount and account number to make a withdrawal");
                        Console.WriteLine("Amount: ");
                        double amount = double.Parse(Console.ReadLine());

                        Console.WriteLine("Account number: ");

                        switch (Console.ReadLine())
                        {
                            case "3001":
                                josh1.Withdraw(amount);

                                Console.WriteLine("Withdrawal successful, new balance: " + josh1.Balance);
                                Console.WriteLine(josh1.Transactions.Count() + " transaction(s) made.");
                                break;

                            case "3002":
                                josh2.Withdraw(amount);

                                Console.WriteLine("Deposit successful, new balance: " + josh2.Balance);
                                Console.WriteLine(josh2.Transactions.Count() + " transaction(s) made.");
                                break;

                            default:
                                Console.WriteLine("Wrong input");
                                break;

                        }
                    }

                    else
                    {
                        Console.WriteLine("Wrong input");
                    }

                }
                else if (name == "Anita")
                {
                    Console.WriteLine("Your accounts and balances:");
                    foreach (Account account in anitaAccounts)
                    {
                        Console.WriteLine("Account number: " + account.Number + "    Balance - " + account.Balance + " Eur.");
                    }
                    Console.WriteLine("Total account balance: " + customerAnita.GetTotalBalance());

                    Console.WriteLine("Would you like to make a deposit or a withdrawal? (type deposit/withdraw)");

                    string actionType = Console.ReadLine();

                    if (actionType == "deposit")
                    {
                        Console.WriteLine("Please provide amount and account number to make a deposit");
                        Console.WriteLine("Amount: ");
                        double amount = double.Parse(Console.ReadLine());

                        Console.WriteLine("Account number: ");

                        switch (Console.ReadLine())
                        {
                            case "4001":
                                anita1.Deposit(amount);

                                Console.WriteLine("Deposit successful, new balance: " + anita1.Balance);
                                Console.WriteLine(anita1.Transactions.Count() + " transaction(s) made.");
                                break;

                            case "4002":
                                anita2.Deposit(amount);

                                Console.WriteLine("Deposit successful, new balance: " + anita2.Balance);
                                Console.WriteLine(anita2.Transactions.Count() + " transaction(s) made.");
                                break;

                            case "4003":
                                anita3.Deposit(amount);

                                Console.WriteLine("Deposit successful, new balance: " + anita3.Balance);
                                Console.WriteLine(anita3.Transactions.Count() + " transaction(s) made.");
                                break;

                            default:
                                Console.WriteLine("Wrong input");
                                break;



                        }
                    }

                    else if (actionType == "withdraw")
                    {
                        Console.WriteLine("Please provide amount and account number to make a withdrawal");
                        Console.WriteLine("Amount: ");
                        double amount = double.Parse(Console.ReadLine());

                        Console.WriteLine("Account number: ");

                        switch (Console.ReadLine())
                        {
                            case "4001":
                                anita1.Withdraw(amount);

                                Console.WriteLine("Withdrawal successful, new balance: " + anita1.Balance);
                                Console.WriteLine(anita1.Transactions.Count() + " transaction(s) made.");
                                break;

                            case "4002":
                                anita2.Withdraw(amount);

                                Console.WriteLine("Deposit successful, new balance: " + anita2.Balance);
                                Console.WriteLine(anita2.Transactions.Count() + " transaction(s) made.");
                                break;

                            case "4003":
                                anita3.Withdraw(amount);

                                Console.WriteLine("Deposit successful, new balance: " + anita2.Balance);
                                Console.WriteLine(anita2.Transactions.Count() + " transaction(s) made.");
                                break;

                            default:
                                Console.WriteLine("Wrong input");
                                break;


                        }
                    }

                    else
                    {
                        Console.WriteLine("Wrong input");
                    }

                }

                else
                {
                    Console.WriteLine("Wrong input");
                }

                Console.WriteLine("Another transaction? (yes/no)");
                continueYesNo = Console.ReadLine();

            }



            // klientu bendras account balance

            List<Customer> customerList = new List<Customer>();
            customerList.Add(customerAnita);
            customerList.Add(customerJosh);

            double allAccountBalance = 0;

            Console.WriteLine();
            Console.WriteLine();

            foreach (Customer customer in customerList)
            {
                

                if(customer.Accounts.Count > 1)
                {
                    Console.WriteLine("Customer " + customer.Name + " has more than one account");
                    allAccountBalance += customer.GetTotalBalance();

                }
            }

            Console.WriteLine("All account total balance is: " + allAccountBalance + " Eur.");

        } //PRIDET EURUS DAR VISUR PAZIUREK
    }
}