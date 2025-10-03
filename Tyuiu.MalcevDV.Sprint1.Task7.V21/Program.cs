using Tyuiu.MalcevDV.Sprint1.Task7.V21.Lib;
DataService ds = new DataService();
void PrintCenteredLine(string text, int totalWidth)
{
    var padding = totalWidth - text.Length - 2; // -2 для звездочек по бокам
    Console.WriteLine($"* {text}{new string(' ', padding)}*");
}

var width = 75;

Console.WriteLine(new string('*', width));
PrintCenteredLine("Спринт #1", width);
PrintCenteredLine("Тема: Создание итогового решения по спринту", width);
PrintCenteredLine("Задание #7", width);
PrintCenteredLine("Вариант #21", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать программу, вычисляющую значение выражения", width);
PrintCenteredLine("с вводом переменных через консоль", width);
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
Console.WriteLine(new string('*', width));
Console.WriteLine("Введите x:");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y:");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine($"{ds.Calculate(x, y)}", width);
Console.WriteLine(new string('*', width));
