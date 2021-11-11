using System;
using System.Collections.Generic;
using System.IO;


namespace test
{

	// Класс метро
	public class Metro
	{
		// ==== ПОЛЯ КЛАССА ====
		
		private List<Line> lines; // Список линий метро
		private string city; // Имя города

		// ==== КОНСТРУКТОР ==== 
		public Metro(string city)
        {
			lines = new List<Line>(); // Инициализируем список
			this.city = city; // Присваиваем переменной city значение, которое получили

		} 

		// ==== ГЕТТЕРЫ ====

		// Метод получения имени города
		public string GetCity()
        {
			return city; // Возращаем переменную city
        }

		// Метод получения списка станций
		public List<Station> GetStationList()
        {
			return null; // Возращаем null (ничего)
        }


		// ==== ОСНОВНЫЕ МЕТОДЫ КЛАССА ====

		// Метод добавления в список новой линии по заданному имени и цвету
		public void AddLine(string name, string color)
        {
			lines.Add(new Line(name, color)); // Добавляем в список новый объект класса Line
        }


		// Метод удаления линии метро
		public void RemoveLine(string name)
        {
			// Проходимся по списку lines
			foreach (Line i in lines)
            {
				// Если полуенный параметр равен имени ветки в списке, то удаляем из этого списка элемент с заданным именем
				if (name == i.getName())
                {
					lines.Remove(i);
					break; // Выходим из цикла, т к мы нашли то, что искали
                }
            }
        }

		// Метод загрузки данных о станциях из файла
		public void LoadStationsFromfile(string filename)
        {
			StreamReader sr = new StreamReader(filename); // Создаем объект класса StreamReader, чтобы мы могли читать файл с именем filename
			string station = sr.ReadLine(); // Считываем первую строку
			// Проверяем, равна ли переменная station нулю (пустая ли строка)
			while (station != null)
            {
				// Тут должен быть код для работы с именами станций
				station = sr.ReadLine(); // Считываем следующую строку
            }
        }
	}
}
