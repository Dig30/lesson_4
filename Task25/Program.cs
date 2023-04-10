/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int numberA = ParseNumber("Введите число А: ");
int numberB = ParseNumber("Введите число В: ");
OutputDisplay(MyPow(numberA, numberB));


int ParseNumber(string str)
{
    Console.WriteLine(str);
    return int.Parse(Console.ReadLine());
}

int MyPow(int A, int B)
{
    int mult = 1; 

    for(int i = 0; i < B; i++)
    {
        mult *= A;
    }
    return mult;
}


void OutputDisplay(int value)
{
    Console.WriteLine("Ответ = " + value);
}
