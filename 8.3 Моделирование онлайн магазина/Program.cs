using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _8._3_Моделирование_онлайн_магазина
{
    public class Store
    {
        public List<Product> Products;
        public List<Product> Basket;
        public List<Order> Orders;
        public Store()
        {
            this.Products = new List<Product>()
            {
                new Product("Хлеб", 25),
                new Product("Молоко", 100),
                new Product("Печенье", 50),
                new Product("Масло", 250),
                new Product("Йогурт", 300),
                new Product("Сок", 80)
            };
            this.Basket = new List<Product>();
            this.Orders = new List<Order>();
        }
        public void ShowCatalog()
        {
            int number = 1;
            Console.WriteLine("Каталог продуктов");
            this.ShowProducts(this.Products);
        }
        public void AddToBasket(int numberProduct)
        {
            Basket.Add(Products[numberProduct - 1]);
            Console.WriteLine($"Продукт{Products[numberProduct - 1].Name} успешно добавлен в корзину.");
            Console.WriteLine($"В коризине {Basket.Count} продуктов.");
        }
        public void ShowBasket()
        {
            int number = 1;
            Console.WriteLine("Содержимое корзины   ");
            this.ShowProducts(this.Basket);
        }
        public void ShowProducts(List<Product> catalog)
        {
            int number = 1;
            foreach (var prod in catalog)
            {
                Console.Write(number++ + ". ");
                prod.Print();
            }
        }

        public void CreteOrder()
        {
            //передать в отдел доставки
            var order = new Order(this.Basket);
            Orders.Add(order);
            this.Basket.Clear();
        }

    }

    public class Product
    {
        public string Name;
        public decimal Price;

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public void Print()
        {
            Console.WriteLine($"{this.Name} {this.Price}");
        }
    }

    public class Order
    {
        public List<Product> Products;
        public decimal FullPrice;
        public Order(List<Product> products)
        { 
            this.Products = products;
            foreach (var prod in products)
            {
                FullPrice += prod.Price;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var onlineStore = new Store();
            Console.WriteLine("Здравствуйте. Выберите действие:");
            Console.WriteLine("1.Показать каталог продуктов?");
            Console.WriteLine("Выберите номер действия которое хоите совершить.");
            int numberAction = Convert.ToInt32(Console.ReadLine());

            switch (numberAction)
            {
                case 1: onlineStore.ShowCatalog(); break;
                default: Console.WriteLine("Выберите номер действия из списка"); break;
            }
            bool yes = false;
            do
            {
                Console.WriteLine("Хотите добавить продкут в корзину? Наберите Да или Нет.");
                yes = IsYes(Console.ReadLine());
                if (yes)
                {
                    onlineStore.ShowCatalog();
                    Console.WriteLine("Напишите номер продукта, который нужно добавитьв корзину");
                    int productNumber = Convert.ToInt32(Console.ReadLine());
                    onlineStore.AddToBasket(productNumber);
                }
            } while (yes);
            do
            {
                Console.WriteLine("Хотите посмотреть корзину? Наберите Да или Нет.");
                yes = IsYes(Console.ReadLine());
                if (yes)
                {
                    onlineStore.ShowBasket();
                    Console.WriteLine("Напишите номер продукта, который нужно добавитьв корзину");
                    int productNumber = Convert.ToInt32(Console.ReadLine());
                    onlineStore.AddToBasket(productNumber);
                }
            } while (yes);
            do
            {
                Console.WriteLine("Хотите оформить заказ? Наберите Да или Нет.");
                yes = IsYes(Console.ReadLine());
                if (yes)
                {
                    onlineStore.CreteOrder();

                }
            } while (yes);
        }

        static bool IsYes(string answer)
        {
            return answer.ToLower() == "да";
        }
    }
}
