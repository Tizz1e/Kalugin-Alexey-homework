using System;

public class Line
{
    // Поля класса

    private List<Station> stations; // список  станций
    private string name; // название линии
    private string color; // цвет линии

    // Конструктор
    public Line(string name, string color)
    {
        stations = new List<Station>(); // создаем список station
        this.name = name; // присваиваем name полученное значение
        this.color = color; // присваиваем color полученное значение
    }

    // Геттеры

    // получение названия
    public string getName()
    {
        return name;
    }

    // получение цвета
    public string getColor()
    {
        return color;
    }

    // получение объекта класса Station из списка stations по заданному имени станции
    public Station getStation(string name)
    {
        // проходимся по списку stations
        foreach (Station i in stations)
        {
            // проверка на совпадение названия станции и полученного названия
            if (i.getName() == name)
            {
                return i; // возвращаем объект класса Station при совпадении
            }
        }
        // возвращаем null если название станции не было найдено в списке stations
        return null;
    }

    // метод получения списка stations
    public List<Station> getStationList()
    {
        return stations; // возращаем список stations
    }

    // сеттеры
    // присваивание имя линии
    public void setName(string name)
    {
        this.name = name; // присваиваем name полученное значение
    }

    // присваивание цвета
    public void setColor(string color)
    {
        this.color = color; // присваиваем color полученное значение
    }


    // Основные методы класса

    // добавление новой станции в список stations
    public void AddStation(string name, string color)
    {
        // создаем объект класса Station и задаем ему параметры которые мы получили
        //  затем добавляем в список stations созданный объект класса Station
        stations.Add(new Station(name, color));
    }

    // добавление новой станции в список stations
    public void AddStation(string name, string color, List<Station> transfers)
    {
        // создаем объект класса Station и задаем ему параметры которые мы получили
        // затем добавляем в список stations созданный объект класса Station
        stations.Add(new Station(name, color, transfers));
    }

    // удаление объекта класса Station из списка stations
    public void RemoveStation(string name)
    {
        // проходимся по списку stations
        foreach (Station i in stations)
        {
            // проверка на совпадение названия станции и полученного названия
            if (name == i.getName())
            {
                // eсли равен, то удаляем объект класса Station из списка stations
                stations.Remove(i);
                break; // выходим из цикла после удаления нужной станции
            }
        }
    }

    // нахождение станции по заданному параметру name
    public Station FindStationbyName(string name)
    {
        // проходимся по списку stations
        foreach (Station i in stations)
        {
            // проверка на совпадение названия станции и полученного названия
            if (name == i.getName())
            {
                // если равен, то возращаем объект класса Station
                return i;
            }
        }
        // Возращаем null (ничего), если объекта класса Station
        // возвращаем null если название станции не было найдено в списке stations
        return null;
    }

}