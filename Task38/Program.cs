/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.*/
int size = 10;

double[] numbers = new double[size];

double GetRandomNumber(double minimum, double maximum)
{ 
    Random random = new Random();
    return Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 3);
}

void FillArray()
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = GetRandomNumber(0, 100);
    }
}

void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine('\n');
}

double LimitDigital (double[] numbers, bool isMax)
{
    
    double max = numbers[0];
    double min = numbers[0];

    for (int i = 0; i < numbers.Length; i++)
    {
        if ( numbers[i] > max)
        {
            max = numbers[i];
        }        
        if ( numbers[i] < min)
        {
            min = numbers[i];
        }        
    }
    if (isMax == true)
    {
        return max;
    }
    return min;   
}

double Different (double max, double min)
{
   return max - min;
}

FillArray();
PrintArray(numbers);
Console.WriteLine("Максимальное число: " + LimitDigital(numbers, true));
Console.WriteLine("Минимальное число: " + LimitDigital(numbers, false));
Console.WriteLine("Разница между числами: " + Different(LimitDigital (numbers, true), LimitDigital (numbers, false)));
