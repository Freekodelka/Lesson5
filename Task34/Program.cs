/*Задайте массив заполненный случайными положительными трёхзначными числами. 
 Напишите программу, которая покажет количество чётных чисел в массиве.*/
int size = 20;
int[] numbers = new int[size];

void FillArray()
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(100, 1000);
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


int CountNumbers(int[]numbers)
{
    int count = 0;
    
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] %2 ==0)
        {
            count++;
        }        
    }
    return count;
   
}


FillArray();
PrintArray(numbers);
Console.Write("Количество четных чисел: " + CountNumbers(numbers));

