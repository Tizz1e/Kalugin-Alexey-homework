using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using namespace test
{
    public class Item
    {
        protected string name;
        protected double price;
        protected static int valueAddedTax = 20;

        public Item()
        {
            name = "NoData";
            price = 150;
        }
        public Item(string name, double price)
        { 
            this.name = name;
            this.price = price;
        }
        public int ValueAddedTax
        {
            get { return valueAddedTax; }
            set { valueAddedTax = value; }
        }
        public virtual double Price
        {
            get { return price * (1 + valueAddedTax * 0.01); }
            set { price = value; }
        }

        public static void AddItem(List<Item> list, Item item)
        {
            if (item is Food)
            {
                Food food = (Food)item;
                if (Food.Amounts.Contains(food.Amount))
                {
                    list.Add(item);
                }
                else
                {
                    Console.WriteLine("Такого количества продукта не существует");
                }
            }
            else
            {
                Drink drink = (Drink)item;
                if (Drink.Volumes.Contains(drink.Volume))
                {
                    list.Add(item);
                }
                else
                {
                    Console.WriteLine("Такого объема напитка не существует");
                }
            }
        }
    }

    public class Drink : Item
    {
        protected double volume;
        protected static List<double> volumes = new List<double> { 0.3, 0.5, 0.7};

        public Drink(string name, double price, double volume) : base(name, price)
        {
            this.volume = volume; 
        }

        public override double Price
        {
            get {return price * (1 + valueAddedTax * 0.01) * volume; }
        }

        public static List<double> Volumes
        {
            get { return volumes; }
        }

        public double Volume
        {
            get { return volume; }
        }
    }

    public class Food : Item
    {
        protected int amount;
        protected static List<int> amounts = new List<int> { 1, 2, 3};

        public Food(string name, double price, int amount) : base(name, price)
        {
            this.amount = amount;
        }

        public override double Price
        {
            get {return price * (1 + valueAddedTax * 0.01) * amount; }
        }
        
        public static List<int> Amounts
        {
            get { return amounts; }
        }

        public int Amount
        {
            get { return amount; }
        }
    }



    class ConsoleApp
    {
        static void Main(string[] args)
        {
            List<Item> list = new();
            Item.AddItem(list, new Food("Bigmac", 130, 2));
            Item.AddItem(list, new Food("Fries middle", 63, 5));
            Item.AddItem(list, new Drink("Coca Cola", 70, 1));
        }
    }
}