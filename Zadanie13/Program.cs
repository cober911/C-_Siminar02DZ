/* Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int GetNumber()
{
    Console.Write("Введите трехзначное чписло: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.Clear();
int number=GetNumber();
string twoNumber = Convert.ToString(number);
if(twoNumber.Length > 2) // Если длина строки больше двух.
Console.WriteLine($"Третья цифра числа: {twoNumber[2]}");
else
Console.WriteLine($"Третьей цифры нет.");