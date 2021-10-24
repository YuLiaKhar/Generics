using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank<string> bankString = new Bank<string>();
            Console.WriteLine("Введите номер счета: ");
            bankString.BankNumber = Convert.ToString(Console.ReadLine());
            bankString.GetBalance();
            bankString.GetOwnerName();
            Console.WriteLine("Номер счета: {0}, баланс: {1}, ФИО владельца: {2}", bankString.ReadNumber(), bankString.ReadBalance(), bankString.ReadOwnerName());
            
            Bank<int> bankInt = new Bank<int>();
            Console.WriteLine("Введите номер счета: ");
            bankInt.BankNumber = Convert.ToInt32(Console.ReadLine());
            bankInt.GetBalance();
            bankInt.GetOwnerName();
            Console.WriteLine("Номер счета: {0}, баланс: {1}, ФИО владельца: {2}", bankInt.ReadNumber(), bankInt.ReadBalance(), bankInt.ReadOwnerName());
            Console.ReadKey();
        }
    }
    class Bank<T>
    {
        public T BankNumber { get; set; }
        double Balance { get; set; }
        string OwnerName { get; set; }
        public Bank()
        { }
        public T ReadNumber()
        {
            return BankNumber;
        }
        public double GetBalance()
        {
            Console.WriteLine("Введите баланс: ");
            Balance = Convert.ToDouble(Console.ReadLine());
            return Balance;
        }
        public double ReadBalance()
        {
            return Balance;
        }
        public string GetOwnerName()
        {
            Console.WriteLine("Введите ФИО владельца: ");
            OwnerName = Convert.ToString(Console.ReadLine());
            return OwnerName;
        }
        public string ReadOwnerName()
        {
            return OwnerName;
        }
    }
}
