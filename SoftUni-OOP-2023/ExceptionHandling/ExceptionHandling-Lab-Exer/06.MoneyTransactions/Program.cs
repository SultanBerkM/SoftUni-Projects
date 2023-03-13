using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.MoneyTransactions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bankAccaountInfo = Console.ReadLine().Split(",",
                 StringSplitOptions.RemoveEmptyEntries);

            Dictionary<int, double> bankAccounts = new();


            for (int i = 0; i < bankAccaountInfo.Length; i++)
            {
                string[] current = bankAccaountInfo[i].Split("-");

                bankAccounts.Add(int.Parse(current[0]), double.Parse(current[1]));

            }


            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                try
                {
                    string instruction = command[0];

                    int accountNumber = int.Parse(command[1]);

                    if (!bankAccounts.ContainsKey(accountNumber))
                    {
                        throw new ArgumentException("Invalid account!");
                    }

                    double sum = double.Parse(command[2]);

                    switch (instruction)
                    {
                        case "Deposit":
                            bankAccounts[accountNumber] += sum;
                            Console.WriteLine($"Account {accountNumber} has new balance: {bankAccounts[accountNumber]:f2}");//f2
                            break;

                        case "Withdraw":

                            if (sum >= bankAccounts[accountNumber])
                            {
                                throw new ArgumentException("Insufficient balance!");
                            }

                            bankAccounts[accountNumber] -= sum;
                            Console.WriteLine($"Account {accountNumber} has new balance: {bankAccounts[accountNumber]:f2}");//f2
                            break;

                        default:
                            throw new ArgumentException("Invalid command!");

                    }

                   
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }

                command = Console.ReadLine().Split();

            }
        }
    }
}
