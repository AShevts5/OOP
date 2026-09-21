using System;
using static System.Console;

namespace OOP
{
    class Payment
    {
        public string Name;
        private double quantity;
        private double price;

        public Payment(string name, double quantity, double price)
        {
            this.Name = name;
            this.quantity = quantity;
            this.price = price;
        }

        public double Cost()
        {
            return quantity * price;
        }

        public void Print()
        {
            WriteLine($"{Name}: {Cost()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double goodsQuantity, goodsPrice;
            double electricityKv, electricityPrice;
            double gasVolume, gasPrice;
            double waterVolume, waterPrice;

            // Задача 6
            WriteLine("Задача 6:");

            goodsQuantity = ReadDouble("Введите количество купленного товара: ");
            goodsPrice = ReadDouble("Введите стоимость единицы товара: ");

            Payment purchase = new Payment("Стоимость товара", goodsQuantity, goodsPrice);
            purchase.Print();

            WriteLine();

            // Задача 7: электроэнергия

            WriteLine("Задачи 7-9: Коммунальные платежи:");

            electricityKv = ReadDouble("Введите количество расхода электроэнергии: ");
            electricityPrice = ReadDouble("Введите тариф оплаты за электроэнергию: ");

            Payment electricity = new Payment("Электроснабжение", electricityKv, electricityPrice);

            // Задача 8: газ
            gasVolume = ReadDouble("Введите объём расхода газа: ");
            gasPrice = ReadDouble("Введите цену газа: ");

            Payment gas = new Payment("Оплата за природный газ", gasVolume, gasPrice);

            // Вода (задача 9)
            waterVolume = ReadDouble("Введите объём израсходованной воды: ");
            waterPrice = ReadDouble("Введите цену за воду: ");

            Payment water = new Payment("Оплата за воду", waterVolume, waterPrice);

            WriteLine();

            // Задача 9: общая сумма оплаты за коммунальные услуги
            double total = electricity.Cost() + gas.Cost() + water.Cost();

            WriteLine($"Общая сумма оплаты за коммунальные услуги: {total}");
        }

        static double ReadDouble(string s)
        {
            Write(s);
            double result;
            while (!double.TryParse(ReadLine(), out result))
            {
                Write("Окак, ошибочка! Введите число ещё раз: ");
            }
            return result;
        }
    }
}