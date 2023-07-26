// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите минимум трёхзначное число: ");
string? input = Console.ReadLine();
int result;
int i = 2;
if (int.TryParse(input, out result))
{
    if (result >= 100)
    {
        string numStr = result.ToString();
        if (i < numStr.Length)
        {
            int thirdNum = int.Parse(numStr[i].ToString());
            Console.WriteLine($"Третья цифра введенного числа: {thirdNum}");
        }
    }
    else
    {
        Console.WriteLine("Ошибка! Введенное число не содержит третью цифру!");
    }
    
}
else
    {
        Console.WriteLine("Ошибка! Введите цифровое значение!");
    }

    
// v2 в работе используются строковые операции для получения цифр из числа
// Console.WriteLine("Привет!");
// Console.Write("Введите минимум трёхзначное число : ");
// int num = Convert.ToInt32(Console.ReadLine());
// string numText = Convert.ToString(num);

// if (numText.Length > 2)
// {
//     Console.WriteLine("Третий символ ввода числа равен числу : " + numText[2]);
// }
// else
// {
//     Console.WriteLine("Проверьте ввод! Третьей цифры нет!");
// }