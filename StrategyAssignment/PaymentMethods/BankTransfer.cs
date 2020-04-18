using System;

namespace StrategyAssignment
{
    public class BankTransfer : PaymentMethod
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paying {amount} using Bank Transfer");
        }
    }
}
