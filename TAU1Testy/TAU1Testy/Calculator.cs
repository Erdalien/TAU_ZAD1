using System;

namespace TAU1Testy
{
    public class Calculator
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Substract(int number1, int number2)
        {
            return number2 - number1;
        }

        public int Multiple(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Divide(int number1, int number2)
        {
            return number2 / number1;
        }

        public int Factorial(int number1)
        {
            if (number1 > 1)
                return Factorial(number1 - 1) * number1;

            else
                return 1;
        }

        public string GetOutput(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";

            if (number % 3 == 0)
                return "Fizz";

            if (number % 5 == 0)
                return "Buzz";

            return number.ToString();
        }

        private readonly string m_customerName;
        private double m_balance;

        public Calculator() { }

        public Calculator(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance -= amount; 
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }

        public static void Main()
        {
            Calculator ba = new Calculator("Mr. Bryan Walton", 11.99);

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }

        public int Fibonacci(int number)
        {

            if (number == 0)
                return 0;
            else if (number == 1)
                return 1;
            else
            {
                return (number - 2) + (number - 1);
            }

        }
    }
}
