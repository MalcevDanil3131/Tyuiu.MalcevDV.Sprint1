using Tyuiu.MalcevDV.Sprint1.Task0.V28.Lib;
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
PrintCenteredLine("Задание #0", width);
PrintCenteredLine("Вариант #28", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать консольную программу на C#, которая которая считает", width);
PrintCenteredLine("значение выражения 48/12-48/6/4 ", width);
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("48/12-48/6/4 ", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine($"{ds.Calculate()}", width);
Console.WriteLine(new string('*', width));

