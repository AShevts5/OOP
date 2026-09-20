using System;

namespace OOP {
    class task_3 {
        static void Main8(string[] args) {
            Console.Write("Введите зарплату: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            double tax = salary * 13 / 100;
            Console.WriteLine("Сумма подоходного налога = " + tax);
        }
    }
}