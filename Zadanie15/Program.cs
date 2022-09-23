/* Напишите программу, которая принимает на вход цифру, обозначающую
 день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

int GetNumber()
{
    Console.Write("Введите цифру от 1 до 7: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void CheckDays(int number)
{
    if(number == 6 || number == 7)
    Console.WriteLine($"{number} да");
    else if(number >=1 && number <=5)
    Console.WriteLine($"{number} нет");
    else if(number < 1 || number > 7)
    Console.WriteLine("Это не день недели");
}

Console.Clear();
int number = GetNumber();
CheckDays(number);
