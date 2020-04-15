using System.Text;
using System.Globalization;

namespace Heranca.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void WithDrow(double amount) 
        {
            if (amount < Balance)
                System.Console.WriteLine("A Operação não foi realizada. Saldo insuficiente.");
            else
                Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Number Account: " + Number);
            sb.AppendLine("Holder: " + Holder);
            sb.AppendLine("Balance: R$ " + Balance);
            
            return sb.ToString();
        }
    }
}
