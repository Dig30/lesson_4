/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int number = ParseNumber("Введите число: ");
int result = SumDigits(number);
OutputDisplay(result);





int ParseNumber(string str)
{
    Console.WriteLine(str);
    return int.Parse(Console.ReadLine());
}

int SumDigits(int number)
{
    int sum = 0;
    while(number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

void OutputDisplay(int value)
{
    Console.WriteLine("Ответ = " + value);
}