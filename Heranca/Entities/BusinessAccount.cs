using System.Text;

namespace Heranca.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount < LoanLimit)
                WithDrow(amount);
            else
                System.Console.WriteLine("Operação não realizada. Valor excede o Limite.");
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
