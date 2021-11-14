using System;

public class Metro // класс метро
{
	// Поля класса

	private List<Line> lines; // Список линий метро
	private string city; // Название города

	// Конструктор
	public Metro(string city)
	{
		lines = new List<Line>(); // Создаем список
		this.city = city; // Присваиваем city полученное значение

	}

	// Свойства ( простите, я написал как вы когда то показывали на уроке, а не как в плане. надеюсь это не критично, а то исправлять не хочется :D)
	public string City // возвращаем название города
	{
		get { return city; }
	}

	public List<station> Lines // возвращаем список станций
    {
		get { return null; }  // возвращаем ничего
    }


	// Основные методы класса

	public void AddLine(string name, string color) // добавление в список новой линии по заданному имени и цвету
	{
		lines.Add(new Line(name, color)); // добавляем в список новый объект класса Line
	}


	public void RemoveLine(string name) // удаление линии метро
	{
		// проходимся по списку lines
		foreach (Line i in lines)
		{
			// если i равен имени ветки в списке, то удаляем из этого списка элемент с заданным именем
			if (name == i.getName())
			{
				lines.Remove(i);
				break; // удаление нужной линии произошло, выходим из цикла
			}
		}
	}
}