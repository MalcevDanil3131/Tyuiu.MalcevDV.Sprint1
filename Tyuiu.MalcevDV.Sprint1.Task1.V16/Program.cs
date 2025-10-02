using Tyuiu.MalcevDV.Sprint1.Task1.V16.Lib;
DataService ds  = new DataService();
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
PrintCenteredLine("Вариант #16", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать программу, которая запрашивает у пользователя исходные данные", width);
PrintCenteredLine("и вычисляет периметр круга округленный до 3х знаков после запятой", width);
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
Console.WriteLine(new string('*', width));
Console.WriteLine("Введите значение радиуса круга:");
int value;
value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine($"{ds.CalculatePerimetrCircle(value)}", width);
Console.WriteLine(new string('*', width));