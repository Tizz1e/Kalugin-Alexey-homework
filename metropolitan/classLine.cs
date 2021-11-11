using System;
using System.Collections.Generic;
using System.Linq;

namespace test {
    
    // Класс ветки метро
    public class Line
    {
        // ==== ПОЛЯ КЛАССА ====

        private List<Station> stations; // Список  со станциями
        private string name; // Название линии
        private string color; // Цвет линии

        // ==== КОНСТРУКТОР ====
        public Line(string name, string color)
        {
            stations = new List<Station>(); // Инициализируем список stations
            this.name = name; // Присваиваем переменной name значение, которое получили
            this.color = color; // Присваиваем переменной color значение, которое получили
        }

        // ==== ГЕТТЕРЫ ====

        // Метод получения названия линии
        public string getName()
        {
            return name;
        }

        // Метод получения цвета линии
        public string getColor()
        {
            return color;
        }

        // Метод получения объекта класса Station из списка stations по заданному имени станции
        public Station getStation(string name)
        {
            // Проходимся по списку stations
            foreach (Station i in stations) 
            {
                // Проверяем, совпадает ли имя объекта класса Station с заданным параметром name
                if (i.getName() == name)
                {
                    return i; // Если совпадает, возращаем объект класса Station
                }
            }
            // Возращаем null (ничего), если объекта класса Station
            // не существует в списке stations с заданным параметром name
            return null; 
        }

        // Метод получения списка stations
        public List<Station> getStationList()
        {
            return stations; // Возращаем список stations
        }

        // ==== СЕТТЕРЫ ====
        // Метод присваивания переменной name заданного параметра
        public void setName(string name)
        {
            this.name = name; // Присваиваем переменной name значение, которое получили
        }

        // Метод присваивания переменной color заданного параметра
        public void setColor(string color)
        {
            this.color = color; // Присваиваем переменной color значение, которое получили
        }


        // ==== ОСНОВНВЕ МЕТОДЫ КЛАССА ====

        // Метод добавления новой станции в список stations
        public void AddStation(string name, string color)
        {
            // Создаем объект класса Station; задаем ему параметры, значения которых мы получили
            // Добавляем в список stations созданный объект класса
            stations.Add(new Station(name, color)); 
        }

        // Метод добавления новой станции в список stations
        public void AddStation(string name, string color, List<Station> transfers)
        {
            // Создаем объект класса Station; задаем ему параметры, значения которых мы получили
            // Добавляем в список stations созданный объект класса
            stations.Add(new Station(name, color, transfers));
        }

        // Метод удаления объекта класса Station из списка stations
        public void RemoveStation(string name)
        {
            // Проходимся по списку stations
            foreach (Station i in stations)
            {
                // Проверяем, равно ли заданное значение
                // name имени объекта класса Station
                if (name == i.getName())
                {
                    // Если равен, то удаляем объект
                    // класса Station из списка stations
                    stations.Remove(i); 
                    break; // Выходим из цикла, т к мы нашли то, что искали 
                }
            }
        }

        // Метод нахождения станции по заданному параметру name
        public Station FindStationbyName(string name)
        {
            // Проходимся по списку stations
            foreach (Station i in stations)
            {
                // Проверяем, равно ли заданное значение
                // name имени объекта класса Station
                if (name == i.getName())
                {
                    // Если равен, то возращаем
                    // объект класса Station
                    return i;
                }
            }
            // Возращаем null (ничего), если объекта класса Station
            // не существует в списке stations с заданным параметром name
            return null;
        }

    }
}
