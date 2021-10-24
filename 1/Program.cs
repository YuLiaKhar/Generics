using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank<string> bankString = new Bank<string>();

            bankString.GetBankNumber();
            bankString.GetBalance();
            bankString.GetOwnerName();
            Console.WriteLine("Номер счета: {0}, баланс: {1}, ФИО владельца: {2}", bankString.ReadNumber(), bankString.ReadBalance(), bankString.ReadOwnerName());
            Console.ReadKey();
        }
    }
    class Bank<T>
    {
        T BankNumber { get; set; }
        double Balance{ get; set; }
        string OwnerName { get; set; }
        //public T bankNumber
        //{
        //    get { return BankNumber; }
        //    set { BankNumber = value; }
        //}
        //public double balance
        //{
        //    get { return Balance; }
        //    set { Balance = value; }
        //}
        //public string ownerName
        //{
        //    get { return OwnerName; }
        //    set { OwnerName = value; }
        //}

        public Bank(T bankNumber, double balance, string ownerName)
        {
           BankNumber = bankNumber;
           Balance = balance;
           OwnerName = ownerName;
        }
        public Bank()
        { }
        public T GetBankNumber()
        {
            Console.WriteLine("Введите номер счета: ");
            Console.ReadLine();
            return BankNumber;
        }
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
