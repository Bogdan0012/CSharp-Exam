using System;
using System.Collections.Generic;
namespace proj
{
    class Program{
        static void Main(string[] args){
            Console.Clear();
            Administrator Admin = new Administrator();

            List<BankCard> cardholders = new List<BankCard>();
            BankCard Vasya = new BankCard("B-Bank", new Date(2,6,2009), 239012731, 714, "Vasya", "Bublicov", "VasyaBublic@gmail.com", "vasyapasswor1", 18);
            BankCard Petya = new BankCard("A-Bank", new Date(21,9,2017), 432089723, 527, "Petya", "Petrov", "Petrov@gmail.com", "petyapasswor23", 28);
            Admin.MyAdd(cardholders, Vasya);
            Admin.MyAdd(cardholders, Petya);
            Console.WriteLine("\t\t\tAll cardholders:");
            Admin.Watch(cardholders);
            
            Admin.MyDelete(cardholders, Vasya);
            Console.WriteLine("\t\t\tAfter deleting:");
            Admin.Watch(cardholders);

            Admin.PushToXml(cardholders);


            // List<BankCard> cardholders = Admin.PullFromXml();
            // Admin.Watch(cardholders);

            Console.Read();
        }
    }
}