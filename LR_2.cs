using System;

namespace OOP {
    class LR_2 {
        static void Main(string[] args) {
            int summ = 0; 
            for (int i = 15; i < 90; i++) {
                if (i % 2 == 0) {
                    summ += i * 2;
                }
            }
            Console.Write("Сумма = " + summ);
        }
        
    }
}