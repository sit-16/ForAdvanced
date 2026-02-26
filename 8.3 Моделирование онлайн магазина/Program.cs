using System.Collections.Generic;

namespace sit16.OnlineStore
{
    public class Store
    {
        public List<Product> Products;
        public List<Product> Basket;
        public List<Order> Orders;
        public List<Customer> Customers;
        public int CurCustIndx;
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
            this.Customers = new List<Customer>()
            {
                new Customer("Админ"),
                new Customer("Аноним")
            };
            this.CurCustIndx = 1;
        }
        public void ShowCatalog()
        {
            int number = 1;
            Console.WriteLine("Каталог продуктов");
            this.ShowList(this.Products);
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
            this.ShowList(this.Basket);
        }
        public void ShowList(List<Product> catalog)
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
            this.Orders.Add(order);
            this.Customers[this.CurCustIndx].Orders.Add(order);
            this.Basket.Clear();
            Console.WriteLine("Заказ оформлен.");
        }
        public int GetCustomerIndx(string name)
        {
            for (int i = 0; i < Customers.Count; i++)
            {
                if (Customers[i].Name == name) return i;
            }
            return -1;
        }
        public void GetReportCustomers()
        {
            Console.WriteLine("Отчёт о пользователях онлайн-магазина");
            foreach (var custr in this.Customers)
            {
                Console.WriteLine($"{"",3}Логин: {custr.Name}");
                if (custr.Orders.Count == 0) Console.WriteLine($"{"",6}Нет заказов.");
                else Console.WriteLine($"{"",6}Выполнил {custr.Orders.Count} заказов:");
                foreach (var orr in custr.Orders)
                {
                    Console.WriteLine($"{"",6}Закакз стоимостью {orr.FullPrice}");
                    foreach (var prt in orr.Products)
                    {
                        Console.WriteLine($"{prt.Name,20} {prt.Price}");
                    }
                }
            }
        }
        public void GetReportOrders()
        {
            Console.WriteLine("Отчёт о выполненных заказах онлайн-магазина");
            foreach (var orr in this.Orders)
            {
                Console.WriteLine($"{"",6}Закакз стоимостью {orr.FullPrice}");
                foreach (var prt in orr.Products)
                {
                    Console.WriteLine($"{prt.Name,20} {prt.Price}");
                }
            }

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
            this.Products = new List<Product>(products);
            foreach (var prod in products)
            {
                FullPrice += prod.Price;
            }
        }
    }

    public class Customer
    {
        public string Name;
        public List<Order> Orders;
        public Customer(string name, List<Order> orders) : this(name)
        {
            this.Orders.AddRange(orders);
        }
        public Customer(string name) : this()
        {
            this.Name = name;
        }
        public Customer()
        {
            this.Name = "Покупатель";
            this.Orders = new List<Order>();
        }

    }

    public class Menu
    {
        Dictionary<int, MenuItem> Мenu;
        public string User;
        public Menu(string name)
        {
            this.User = name;
            this.Мenu = new Dictionary<int, MenuItem>()
            {
                {0, new MenuItem("Повторить меню?",false, "Завершите действие!",[2,3,4,6],[])},
                {1, new MenuItem("Авторизироваться?",false, "Завершите действие!",[0,1,3],[2,4,5,6])},
                {2, new MenuItem("Добавить продукт в каталог?",true, "Ознакомьтесь с каталогом!",[0,1,2,3],[4,5,6])},
                {3, new MenuItem("Показать каталог продуктов?", true, "Авторизируйтесь!",[0,1,2,3,4],[5,6])},
                {4, new MenuItem("Добавить продкут в корзину?",true, "Ознакомьтесь с каталогом!",[0,1,3,4,5,6],[2])},
                {5, new MenuItem("Показать корзину?",true, "Добавьте продукт в корзину!", [0,3,4,5,6],[1,2])},
                {6, new MenuItem("Оформирть заказ?",true, "Ознакомьтесь с содержимым корзины!",[0,1],[2,3,4,5,6])},
                {7, new MenuItem("Отчёт о покупателях.",false, "",[],[])},
                {8, new MenuItem("Отчёт о заказах.",false, "",[],[])},
                {9, new MenuItem("Выйти.",false, "",[],[])}
            };
        }
        public void Print()
        {
            Console.Clear();
            Console.WriteLine($"{this.User}, добро пожаловать в онлайн-магазин.");
            foreach (var item in this.Мenu)
            {
                Console.Write($"{item.Key}. ");
                Console.WriteLine(item.Value.Name);
            }
            Console.WriteLine("Выберите номер действия которое хоите совершить:");
        }
        public bool TakeChoice(int n)
        {
            if (!Мenu.ContainsKey(n))
            {
                Console.WriteLine("Такого варианта нет в списке.");
                return false;
            }
            if (Мenu[n].Blocked)
            {
                Console.Write("Недоступно. ");
                Console.WriteLine(Мenu[n].Hint);
                return false;
            }
            for (int i = 0; i < Мenu[n].LockArr.Length; i++)
                Мenu[Мenu[n].LockArr[i]].Blocked = true;
            for (int i = 0; i < Мenu[n].UnLockArr.Length; i++)
                Мenu[Мenu[n].UnLockArr[i]].Blocked = false;
            return true;
        }
        public void SetCustomer(string name)
        {
            this.User = name;
            this.Print();
        }
    }

    public class MenuItem
    {
        public string Name;
        public bool Blocked;
        public string Hint;
        public int[] UnLockArr;
        public int[] LockArr;
        public MenuItem(string name, bool locked, string hint, int[] unlock, int[] llock)
        {
            this.Name = name;
            this.Blocked = locked;
            this.Hint = hint;
            this.UnLockArr = unlock;
            this.LockArr = llock;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var onlineStore = new Store();
            var menu = new Menu(onlineStore.Customers[onlineStore.CurCustIndx].Name);
            menu.Print();
            int numberAction = 0;
            do
            {
                do
                {
                    Console.Write(">> ");
                    numberAction = int.TryParse(Console.ReadLine(), out int result) ? result : -1;
                } while (!menu.TakeChoice(numberAction));

                switch (numberAction)
                {
                    case 0:
                        menu.Print();
                        break;
                    case 1:
                        Console.Write("Введите Имя: ");
                        string name = Console.ReadLine();
                        int indx = onlineStore.GetCustomerIndx(name);
                        if (indx == -1)
                        {
                            Customer customer = new Customer();
                            customer.Name = name;
                            onlineStore.CurCustIndx = onlineStore.Customers.Count;
                            onlineStore.Customers.Add(customer);
                            menu.SetCustomer(name);
                        }
                        else
                        {
                            onlineStore.CurCustIndx = indx;
                            menu.SetCustomer(onlineStore.Customers[indx].Name);
                        }
                        break;
                    case 2:
                        if (menu.User == onlineStore.Customers[0].Name)
                        {
                            Console.Write("Наименование нового продукта: ");
                            string tmpName = Console.ReadLine();
                            Console.Write("Цена нового продукта: ");
                            int tempCost = Convert.ToInt32(Console.ReadLine());
                            var product = new Product(tmpName, tempCost);
                            onlineStore.Products.Add(product);
                        }
                        else Console.WriteLine($"Недоступно. Доступ имеет только пользователь с именем {onlineStore.Customers[0].Name}.");
                        break;
                    case 3: onlineStore.ShowCatalog(); break;
                    case 4:
                        if (menu.User != onlineStore.Customers[0].Name && menu.User != onlineStore.Customers[1].Name)
                        {
                            Console.Write("Номер продукта: ");
                            int productNumber = Convert.ToInt32(Console.ReadLine());
                            onlineStore.AddToBasket(productNumber);
                        }
                        else Console.WriteLine($"Недоступно. {menu.User}, у вас нет прав на закупку.");
                        break;
                    case 5:
                        onlineStore.ShowBasket();
                        break;
                    case 6:
                        onlineStore.CreteOrder();
                        break;
                    case 7:
                        onlineStore.GetReportCustomers();
                        break;
                    case 8:
                        onlineStore.GetReportOrders();
                        break;
                    case 9:
                        return;
                        break;
                    default: Console.WriteLine("Ahtung!"); break;
                }
            } while (true);
        }

        static bool IsYes(string answer)
        {
            return answer.ToLower() == "да";
        }
    }
}
