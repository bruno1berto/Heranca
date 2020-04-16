using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1050, "BRUNO MAIA", 150.0);
            account.Deposit(200.0);

            BusinessAccount bsAccount = new BusinessAccount(1058, "ANDREZA MARIA", 100.0, 500.0);

            Console.WriteLine(account);

            Console.WriteLine(bsAccount);

            bsAccount.Loan(1000);

            Console.ReadLine();
        }
    }
}
