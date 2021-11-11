using System;
using System.Collections.Generic;

namespace test {
	
	// Класс станции метро
	public class Station
	{
		// ==== ПОЛЯ КЛАССА ====

		private string name; // Название станции
		private string color; // Цвет станции
		private List<Station> transfers; // Список станций
		private Line line; // Объект класса Line
		private bool isWheelchairAccessible;
		private bool hasParkAndRide;
		private bool hasNearbyCableCar;

		// ==== КОНСТРУКТОР 1 ==== 
		public Station(string name, string color)
		{
			transfers = new List<Station>(); // Инициализируем список
			this.name = name; // Присваиваем переменной name значение, которое получили
			this.color = color; // Присваиваем переменной color значение, которое получили
		}
		
		// ==== КОНСТРУКТОР 2 ==== 
		public Station(string name, string color, List<Station> transfers)
		{
			this.name = name; // Присваиваем переменной city значение, которое получили
			this.color = color; // Присваиваем переменной color значение, которое получили

			// Присваиваем списку transfers параметры, которые находятся в списке, который получили
			foreach(Station i in transfers)
            {
				this.transfers.Add(i);
            }
		}

		// ==== ГЕТТЕРЫ ====

		// Метод получения названия станции
		public string getName()
		{
			return name; // Возращаем значение переменной name
		}

		// Метод получения названия линии
		public string GetLineName()
        {
			return line.getName(); // Возращаем значение переменной line
		}

		// Метод получения списка станций
		public List<Station> GetTransferList()
        {
			return transfers; // Возращаем список transfers
		}

		public bool IsWheelchairAccessible()
		{
			return isWheelchairAccessible;

		}

		public bool HasParkAndRide()
		{
			return hasParkAndRide;
		}

		public bool HasNearbyCableCar()
		{
			return hasNearbyCableCar;
		}

		// ==== СЕТТЕРЫ ====

		// Метод записи названия станции
		public void setName(string name)
		{
			this.name = name; // Записываем в переменную name значение, которое получили
		}

		
	}
}
