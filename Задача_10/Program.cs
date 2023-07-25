// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
string? value = Console.ReadLine();
int result;
if (int.TryParse(value, out result))
{
    if (result >= 100 && result <= 999)
    {
        result = (result / 10) % 10;
        Console.Write($"Вторая цифра числа = {result}");
    }
    else
    {
        Console.WriteLine("Проверьте кол-во цифр ввода! Введите трёхзначное число!");
    }
}
else
{
    Console.WriteLine("Ошибка! Введите трёхзначное число!");
}


// v2 в работе используются строковые операции для получения цифр из числа
// Console.Write("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string numText = Convert.ToString(num);

// if (numText.Length < 3 || numText.Length > 3)
// {
//     Console.WriteLine("Проверьте ввод! Введите трёхзначное число!");
// }
// else
// {
//     Console.Write("Вторая цифра числа =  " + numText[1]);
// }