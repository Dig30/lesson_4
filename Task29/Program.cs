/*Задача 29: Напишите программу, которая приниматет на вход длину массива, минимальное значение массива и максимальное значение массива, создаёт массив с заданными параметрами и выводит значения на экран
5, 1, 19 -> [1, 2, 5, 7, 19]
3, 1, 33 -> [6, 1, 33]*/

int arrayLenght = ParsNumber("Введите длину массива: ");
int minValue = ParsNumber("Введите минимальное значение массива: ");
int maxValue = ParsNumber("Введите максимаьное значение массива: ");
int[] array = CreatArray(arrayLenght, minValue, maxValue);
OutputArray(array, arrayLenght);


int ParsNumber(string str)
{
    Console.WriteLine(str);
    return int.Parse(Console.ReadLine());
}

int[] CreatArray(int lenght, int minValue, int maxValue)
{
    int[] array = new int[lenght];
    Random rand = new Random();
    for(int index = 0; index < lenght; index++)
    {
        array[index] = rand.Next(minValue, maxValue + 1);
    }   
    return array;
}

void OutputArray(int[] array, int lenght)
{
    Console.Write("[");
    for(int index = 0; index < lenght - 1; index++)
    {
        Console.Write(array[index] + ", ");
    }
    Console.Write(array[lenght - 1] + "]");
}