/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов с нечётными индексами.*/

int size = 10;
int[] numbers = new int[size];

void FillArray()
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(0, 100);
    }
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine('\n');
}

int SumIndex(int[] numbers)
{
    int sum = 0;
    for (int i = 1; i < numbers.Length; i+=2)
    {
        sum += numbers[i];      
    }
    return sum;
}


FillArray();
PrintArray(numbers);
Console.WriteLine("Сумма чисел под нечетными индексами равна: " + SumIndex(numbers));