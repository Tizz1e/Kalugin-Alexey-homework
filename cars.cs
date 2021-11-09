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

        public void SetLabel(string label)
        {
            this.label = label;
        }
        public void SetPower(int power)
        {
            this.power = power;
        }
        public void SetYear(int year_of_production)
        {
            this.year_of_production = year_of_production;
        }
        public string GetLabel()
        {
            return label;
        }
        public int GetPower()
        {
            return power;
        }
        public int GetYear()
        {
            return year_of_production;
        }
    }
    public class PassengerCar : Car 
    {
        private int passengers_сount;
        private Dictionary<int, string> repair_book;

        public PassengerCar(string label, int power, int year_of_production, int passengers_сount) : base(label, power, year_of_production)
        {
            this.label = label;
            this.power = power;
            this.year_of_production = year_of_production;
            this.passengers_сount = passengers_сount;
            repair_book = new Dictionary<int, string>();
        }


        public void SetPassengersCount(int passengers_сount)
        {
            this.passengers_сount = passengers_сount;
        }

        public void SetRepairBook(Dictionary<int, string> repair_book)
        {
            this.repair_book = repair_book;
        }

        public int GetPassengersCount()
        {
            return passengers_сount;
        }

        public Dictionary<int, string> GetRepairBook()
        {
            return repair_book;
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
            return $"Марка автомобиля: {label}" + '\n' + $"Мощность автомобиля: {power}" +
                '\n' + $"Год производства автомобиля: {year_of_production}" + '\n' + $"Вместимость автомобиля: {passengers_сount} + '\n'";
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
            this.label = label;
            this.power = power;
            this.year_of_production = year_of_production;
            this.max_lifting_capacity = max_lifting_capacity;
            this.drivers_name = drivers_name;
            this.current_cargo = current_cargo;
        }

        public int GetMaxLiftingCapacity()
        {
            return max_lifting_capacity;
        }

        public string GetDriversName()
        {
            return drivers_name;
        }

        public string GetCurrentCargo()
        {
            return current_cargo;
        }

        public void SetMaxLiftingCapacity(int max_lifting_capacity)
        {
            this.max_lifting_capacity = max_lifting_capacity;
        }

        public void SetDriversName(string drivers_name)
        {
            this.drivers_name = drivers_name;
        }

        public void SetCurrentCargo(string current_cargo)
        {
            this.current_cargo = current_cargo;
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

        public string getAutoparkName()
        {
            return autopark_name;
        }

        public List<PassengerCar> GetListOfPassengerCars()
        {
            return passenger_cars;
        }

        public List<Truck> GetListOfTrucks()
        {
            return trucks;
        }

        public void SetAutoparkName(string autopark_name)
        {
            this.autopark_name = autopark_name;
        }

        public void SetListOfPassengerCars(List<PassengerCar> passenger_cars)
        {
            this.passenger_cars = passenger_cars;
        }

        public void SetListOfTrucks(List<Truck> trucks)
        {
            this.trucks = trucks;
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
