// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt16(Console.ReadLine());
string numText = Convert.ToString(num);

if (numText.Length < 3 || numText.Length > 3)
{
    Console.WriteLine("Проверьте ввод! Введите трёхзначное число!");
}
else 
{
    Console.Write("Вторая цифра числа =  " + numText[1]);
}