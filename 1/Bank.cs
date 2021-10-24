using System;

namespace _1
{
    class Bank<T, double, string>
    {
        private T BankNumber { get; set; }
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
        {
        }

        public T GetBankNumber()
        {
            Console.WriteLine("Введите номер счета: ");
            Console.Read();
            return BankNumber;
        }
        public T ReadNumber()
        {
            return BankNumber;
        }
        public double GetBalance()
        {
            Console.WriteLine("Введите баланс: ");
            Balance = Convert.ToDouble(Console.Read());
            return Balance;
        }
        public double ReadBalance()
        {
            return Balance;
        }
        public string GetOwnerName()
        {
            Console.WriteLine("Введите ФИО владельца: ");
            OwnerName = Convert.ToString(Console.Read());
            return OwnerName;
        }
        public string ReadOwnerName()
        {
            return OwnerName;
        }
    }
}
