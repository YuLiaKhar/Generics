using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank<string, double, string> bankString = new Bank<string, double, string>();
            bankString.GetOwnerName();
            bankString.GetBalance();
            bankString.GetBankNumber();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
    class Bank<T, Double, String>
    {
        T BankNumber { get; set; }
        Double Balance { get; set; }
        String OwnerName { get; set; }
        public Bank(T bankNumber, Double balance, String ownerName)
        {
            BankNumber = bankNumber;
            Balance = balance;
            OwnerName = ownerName;
        }
        public Bank()
        {
        }
        public T GetBankNumber()
        {
            Console.WriteLine("Введите номер счета: ");
            Console.ReadLine();
            return BankNumber;
        }
        public Double GetBalance()
        {
            Console.WriteLine("Введите баланс: ");
            Console.ReadLine();
            return Balance;
        }
        public String GetOwnerName()
        {
            Console.WriteLine("Введите ФИО владельца: ");
            Console.ReadLine();
            return OwnerName;
        }
        
    }
}
