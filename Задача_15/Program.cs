// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
string? value = Console.ReadLine();
int dayNum;
if (int.TryParse(value, out dayNum))
{
    if (dayNum == 6 || dayNum == 7)
    {
        Console.WriteLine("Выходной день");
    }
    else if ((dayNum > 0) && (dayNum < 6))
    {
        Console.WriteLine("Будний день");
    }
    else
    {
        Console.WriteLine("Введите число от 1 до 7!");
    }
}
else
{
    Console.WriteLine("Ошибка! Введите число!");
}

// v2 в работе используются строковые операции для получения цифр из числа
// Console.Write("Введите число: ");
// int dayNum = Convert.ToInt32(Console.ReadLine());

// if (dayNum == 6 || dayNum == 7)
// {
//     Console.WriteLine("Выходной день");
// }
// else if ((dayNum > 0) && (dayNum < 6))
// {
//     Console.WriteLine("Будний день");
// }
// else
// {
//     Console.WriteLine("Введите число от 1 до 7!");
// }