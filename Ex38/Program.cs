//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int size = 10;
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

double max = numbers[0];
double min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

Console.WriteLine($"МИНИМАЛЬНОЕ ЧИСЛО: {min}");
Console.WriteLine($"МАКСИМАЛЬНОЕ ЧИСЛО: {max}");
Console.WriteLine($"Разница между МАСИМАЛЬНЫМ и МИНИМАЛЬНЫМ числами: {max - min}");



void FillArrayRandomNumbers(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(1, 100)) / 1.2; 
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}