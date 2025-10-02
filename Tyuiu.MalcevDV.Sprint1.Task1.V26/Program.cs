using Tyuiu.MalcevDV.Sprint1.Task1.V26;
using Tyuiu.MalcevDV.Sprint1.Task1.V26.Lib;
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
PrintCenteredLine("Задание #1", width);
PrintCenteredLine("Вариант #26", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать программу, которая запрашивает у пользователя исходные данные", width);
PrintCenteredLine("и вычисляет результат по формуле 5*x/ (2+y) и печатает его на экране", width);
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
Console.WriteLine(new string('*', width));
Console.WriteLine("Введите значение x:");
double x, y;
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение y:");
y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine($"{ds.Calculate(x,y)}", width);
Console.WriteLine(new string('*', width));