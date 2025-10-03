using Tyuiu.MalcevDV.Sprint1.Task4.V14.Lib;
DataService ds = new DataService();
void PrintCenteredLine(string text, int totalWidth)
{
    var padding = totalWidth - text.Length - 2; // -2 для звездочек по бокам
    Console.WriteLine($"* {text}{new string(' ', padding)}*");
}

var width = 75;

Console.WriteLine(new string('*', width));
PrintCenteredLine("Спринт #1", width);
PrintCenteredLine("Тема: Создание решения по таску", width);
PrintCenteredLine("Задание #2", width);
PrintCenteredLine("Вариант #11", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать программу, которая запрашивает у пользователя значения", width);
PrintCenteredLine("переменных и вычисляет значение выражения ", width);
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
Console.WriteLine(new string('*', width));
Console.Write("Введите x: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите y: ");
double y = double.Parse(Console.ReadLine());
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine($"{ds.Calculate(x, y)}", width);
Console.WriteLine(new string('*', width)); 