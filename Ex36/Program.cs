//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int size = 4;
int[] numbers = new int[size];
ArrayRandom(numbers);
PrintArray(numbers);

int sumOfOddNum = 0;

for (int i = 1; i < numbers.Length; i += 2)
{
    sumOfOddNum += numbers[i];
}
Console.Write($"Сумма нечетных позиций {sumOfOddNum}");

void ArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}