/*
//Задайте массив, заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве. 
Console.Clear();
Console.WriteLine("Введите размер массива ");
int n = Math.Abs(int.Parse(Console.ReadLine()!));
int[] array = new int[n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write($"Количество четных чисел в массиве {FuncCount(array)}");

int FuncCount(int[] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
       if (array[i]%2 == 0)
       {
            count++;
       }
    }
    return count;
}

void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i=0; i<array.Length; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i=0; i<array.Length; i++)
    {
       Console.Write(array[i]);
       if (i == array.Length-1)
       {
            Console.Write("]");
       }
       else
       {
            Console.Write(", ");
       }
    }
}
*/

/*
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
Console.WriteLine("Введите числа через пробел ");
string input = Console.ReadLine()!;
int[] array = ParseToArray(input);
Console.Write($"Сумма элементов, стоящих на нечетных позициях {FuncSum(array)}");

int FuncSum(int[] array)
{
    int sum = 0;
    for (int i=0; i<(array.Length/2); i++)
    {
       sum += array[2*i+1];
    }
    return sum;
}

int[] ParseToArray(string str)
{
    string[] stringArray = str.Split(" ");
    int[] result = new int[stringArray.Length];
    for (int i=0; i<stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }
    return result;
}
*/

/*
// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
Console.WriteLine("Введите размер массива ");
int n = Math.Abs(int.Parse(Console.ReadLine()!));
double[] array = new double[n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write($"Разница между максимальным и минимальным элементом массива {FuncDiff(array)}");

double FuncDiff(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i=1; i<array.Length; i++)
    {
       if (max < array[i])
       {
            max = array[i];
       }
       else  
       {
            if (min > array[i])
            {
                min = array[i];
            }
       }
    }
    return max-min;
}

void FillArray(double[] array)
{
    Random rand = new Random();
    for (int i=0; i<array.Length; i++)
    {
        array[i] = rand.NextDouble();
        //array[i] = rand.Next(0, 20);
    }
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i=0; i<array.Length; i++)
    {
       Console.Write(array[i]);
       if (i == array.Length-1)
       {
            Console.Write("]");
       }
       else
       {
            Console.Write(", ");
       }
    }
}
*/