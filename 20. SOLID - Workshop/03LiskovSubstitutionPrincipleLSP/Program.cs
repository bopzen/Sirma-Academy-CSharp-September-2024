namespace _03LiskovSubstitutionPrincipleLSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentMethod creditCard = new CreditCard();
            PaymentMethod bankTransfer = new BankTransfer();

            ProcessPayment(creditCard, 100);
            ProcessPayment(bankTransfer, 100);

            RefundPayment(creditCard, 100);
            RefundPayment(bankTransfer, 100);

        }

        static void ProcessPayment(PaymentMethod paymentMethod, double amount)
        {
            paymentMethod.Pay(amount);
        }

        static void RefundPayment(PaymentMethod paymentMethod, double amount)
        {
            if (paymentMethod is IRefundable refundable)
            {
                refundable.Refund(amount);
            }
            else
            {
                Console.WriteLine($"Refund not supported for {paymentMethod.GetType().Name}.");
            }
        }
    }
}
