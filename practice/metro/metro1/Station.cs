using System;

// Класс станции метро
public class Station
{
	// Поля класса

	private string name; // Название станции
	private string color; // Цвет станции
	private Line line; // Объект класса Line
	private bool isWheelchairAccessible;
	private bool hasParkAndRide;
	private bool hasNearbyCableCar;
	private List<Station> transfers; // Список станций

	// Конструктор №1
	public Station(string name, string color)
	{
		transfers = new List<Station>(); // создаем список
		this.name = name; // присваиваем name полученное значение
		this.color = color; //присваиваем color полученное значение
	}

	// Конструктор №2
	public Station(string name, string color, List<Station> transfers)
	{
		this.name = name; // присваиваем name полученное значение
		this.color = color; //присваиваем color полученное значение

		// Присваиваем списку transfers параметры, которые находятся в полученном списке
		foreach (Station i in transfers)
		{
			this.transfers.Add(i);
		}
	}

	// Геттеры

	// получение названия станции
	public string getName()
	{
		return name; // возращаем название станции
	}

	// получение названия линии станции
	public string GetLineName()
	{
		return line.getName(); // возращаем имя переменной line
	}

	// получение списка станций
	public List<Station> GetTransferList()
	{
		return transfers; // возращаем список transfers
	}

	public bool IsWheelchairAccessible() // проверка истинности isWheelchairAccessible
	{
		return isWheelchairAccessible;

	}

	public bool HasParkAndRide() // проверка истинности hasParkAndRide
	{
		return hasParkAndRide;
	}

	public bool HasNearbyCableCar() // проверка истинности hasNearbyCableCar
	{
		return hasNearbyCableCar;
	}

	// Сеттер

	// изменение названия станции
	public void setName(string name)
	{
		this.name = name; // запись в name полученного значения
	}
}