using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Car
    {
        protected string label;
        protected int power;
        protected int year_of_production;

        public Car(string label, int power, int year_of_production)
        {
            this.label = label;
            this.power = power;
            this.year_of_production = year_of_production;

        }

        public string Label
        {
            get { return label; }
            set { label = value; }
        }
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public int Year_of_production
        {
            get { return year_of_production; }
            set { year_of_production = value; }
        }
    }
    public class PassengerCar : Car
    {
        private int passengers_сount;
        private Dictionary<int, string> repair_book;

        public PassengerCar(string label, int power, int year_of_production, int passengers_сount) : base(label, power, year_of_production)
        {
            this.passengers_сount = passengers_сount;
            repair_book = new Dictionary<int, string>();
        }


        public int Passengers_сount
        {
            get { return passengers_сount; }
            set { passengers_сount = value; }
        }

        public Dictionary<int, string> Repair_book
        {
            get { return repair_book; }
            set { repair_book = value; }

        }

        public void AddRepairInfo(int repair_year, string sparepart_repair)
        {
            repair_book[repair_year] = sparepart_repair;
        }

        public int GetYearBySparepart(string sparepart)
        {
            foreach (int i in repair_book.Keys)
            {
                if (repair_book[i] == sparepart)
                {
                    return i;
                }
            }
            return -1;
        }

        public void PrintRepairInfo()
        {
            if (repair_book.Count == 0)
            {
                Console.WriteLine("Автомобиль не был в ремонте\n");
            }
            else
            {
                foreach (int i in repair_book.Keys)
                {
                    Console.WriteLine("Деталь " + repair_book[i] + "была заменена" + i.ToString() + '\n');
                }
            }
        }

        public override string ToString()
        {
            return $"Марка автомобиля: {label}" + '\n' + $"Мощность автомобиля: {power}" + '\n' + 
                $"Год производства автомобиля: {year_of_production}" + '\n' + $"Вместимость автомобиля: {passengers_сount} + '\n'";
        }

    }

    public class Truck : Car
    {
        private int max_lifting_capacity;
        private string drivers_name;
        private string current_cargo;

        // ==== КОНСТРУКТОР ====
        public Truck(string label, int power, int year_of_production, int max_lifting_capacity, string drivers_name, string current_cargo)
            : base(label, power, year_of_production)
        {
            this.max_lifting_capacity = max_lifting_capacity;
            this.drivers_name = drivers_name;
            this.current_cargo = current_cargo;
        }

        public int Max_lifting_capacity
        {
            get { return max_lifting_capacity; }
            set { max_lifting_capacity = value; }
        }

        public string Drivers_name
        {
            get { return drivers_name; }
            set { drivers_name = value; }
        }

        public string Current_cargo
        {
            get { return current_cargo; }
            set { current_cargo = value; }
        }

        public void RemoveCurrentCargo()
        {
            current_cargo = "Груз убран\n";
        }

        public void PrintCurrentCargoInfo()
        {
            Console.WriteLine($"Текущий заказ у {drivers_name}: {current_cargo}" + '\n');
        }

        public override string ToString()
        {
            return $"Марка автомобиля: {label}" + '\n' + $"Мощность автомобиля: {power}" +
                '\n' + $"Год производства автомобиля: {year_of_production}" + '\n' +
                $"Максимальная грузоподъёмность: {max_lifting_capacity}" + '\n' +
                $"ФИО водителя: {drivers_name}" + '\n';
        }
    }

    public class Autopark
    {
        private string autopark_name;
        private List<PassengerCar> passenger_cars;
        private List<Truck> trucks;

        public Autopark(string autopark_name)
        {
            this.autopark_name = autopark_name;
            passenger_cars = new List<PassengerCar>();
            trucks = new List<Truck>();
        }

        public string Autopark_name
        {
            get { return autopark_name; }
            set { autopark_name = value; }
        }

        public List<PassengerCar> Passenger_cars
        {
            get { return passenger_cars; }
            set { passenger_cars = value; }
        }

        public List<Truck> Trucks
        {
            get { return trucks; }
            set { trucks = value; }
        }

        public override string ToString()
        {
            string info = "";
            foreach (PassengerCar i in passenger_cars)
            {
                info += i.ToString();
            }

            foreach (Truck i in trucks)
            {
                info += i.ToString();
            }

            return info;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
