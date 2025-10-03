using Tyuiu.MalcevDV.Sprint1.Task6.V1.Lib;
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
PrintCenteredLine("Задание #5", width);
PrintCenteredLine("Вариант #1", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать программу, принимает на ввод координаты 2х точек", width);
PrintCenteredLine("переменных и вычисляет расстояние между ними ", width);
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
Console.WriteLine(new string('*', width));
Console.WriteLine("Введите символ и нажмите <Enter>.");
Console.WriteLine("Для завершения введите точку.");
Console.WriteLine();
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
while (true)
{
    Console.Write("Символ: ");
    string symbol = Console.ReadLine();

    // Проверка на точку для завершения программы
    if (symbol == ".")
    {
        Console.WriteLine("Завершение программы...");
        break;
    }

    // Проверка, что введен ровно один символ
    if (symbol?.Length == 1)
    {
        string code = ds.SymbolCode(symbol);
        Console.WriteLine($"Код символа '{symbol}': {code}");
    }
    else
    {
        Console.WriteLine("Ошибка: введите ровно один символ!");
    }

    Console.WriteLine();
}
Console.WriteLine(new string('*', width));