/* Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int GetNumber()
{
    Console.WriteLine("Введите трёхзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.Clear();
int number = GetNumber();
string strNumber = Convert.ToString(number);
Console.WriteLine("вторая цифра этого числа: " + strNumber[1]); // Выводит вторую по индексу цифру