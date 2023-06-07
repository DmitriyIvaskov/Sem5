//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*int[] RandomArray(int size)
{
int[] resultArray = new int[size];
Random rand = new Random();

for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rand.Next(100,999);
    }
    return resultArray;
}

int[] array = RandomArray(4);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");

int EvenNumbers(int[] even);
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}
Console.WriteLine($"Количество четных чисел {EvenNumbers(even)}");
*/

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int count = 0;
ArrayRandom(numbers);
PrintArray(numbers);


for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    count++;
}

Console.WriteLine($"количество чётных чисел в массиве -> {count} ");

int[] ArrayRandom(int[] size)
{
    Random rnd = new Random();
	int[] result = new int[size];
	for(int i= 0; i < result.Length; i++)
	{
        result[i] = rnd.Next(100, 999);
    }
	return result;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}