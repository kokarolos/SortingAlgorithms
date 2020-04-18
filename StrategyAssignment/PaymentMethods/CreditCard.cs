using System;

namespace StrategyAssignment
{
    public class CreditCard : PaymentMethod
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paying {amount} using Credit Card");
        }
    }
}
