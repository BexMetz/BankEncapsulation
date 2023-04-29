namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bexBank = new BankAccount();

            Console.WriteLine("What is the amount of your deposit?");
            var depositAmount = double.Parse(Console.ReadLine());

            bexBank.Deposit(depositAmount);
            Console.WriteLine($"Deposit successful. New Balance: {bexBank.GetBalance()}");
        }
    }
}
