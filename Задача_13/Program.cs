// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Привет!");
Console.Write("Введите минимум трёхзначное число : ");
int num = Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(num);

if (numText.Length > 2)
{
    Console.WriteLine("Третий символ ввода числа равен числу : " + numText[2]);
}
else
{
    Console.WriteLine("Проверьте ввод! Третьей цифры нет!");
}