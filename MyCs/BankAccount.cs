using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCs
{
    class BankAccount
    {
        public int id;
        public decimal balance;
        public  int Id { get; set; }
        public decimal Balance { get; set; }

        public static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(cmdArgs[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account is alreay exist");
            }
            else
            {
                BankAccount acc = new BankAccount();
                acc.Id = id;
                accounts.Add(id, acc);
            }
        }
        public static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(cmdArgs[2]);
            decimal amount = decimal.Parse(cmdArgs[2]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                accounts[id].Balance += amount;
            }
        }
        public static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(cmdArgs[1]);
            decimal amount = decimal.Parse(cmdArgs[2]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else if (amount > accounts[id].Balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                accounts[id].Balance -= amount;
            }
        }
        public static void Print(string[] cmaArgs, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(cmaArgs[1]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                Console.WriteLine($"Account ID{accounts[id].Id}, balance {accounts[id].Balance:f2}");
            }
        }
    }
}
