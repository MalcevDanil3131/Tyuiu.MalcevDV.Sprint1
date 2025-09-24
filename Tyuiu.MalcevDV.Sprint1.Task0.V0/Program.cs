using Tyuiu.MalcevDV.Sprint1.Task0.V0.Lib;

void PrintCenteredLine(string text, int totalWidth)
{
    var padding = totalWidth - text.Length - 2; // -2 для звездочек по бокам
    Console.WriteLine($"* {text}{new string(' ', padding)}*");
}

var width = 75;

Console.WriteLine(new string('*', width));
PrintCenteredLine("Спринт #1", width);
PrintCenteredLine("Тема: Написать программу, которая вычисляет выражение", width);
PrintCenteredLine("48/12-48/6/4 и печатает результат на экране.", width);
PrintCenteredLine("Задание #0", width);
PrintCenteredLine("Вариант #28", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ: выражение 48/12-48/6/4", width);
PrintCenteredLine("", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ: 48/12-48/6/4", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ: ", width);
Console.WriteLine(new string('*', width));

DataService ds = new DataService();
Console.WriteLine(ds.Calculate());

