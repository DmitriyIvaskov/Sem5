/* // void - будет дальше (после двумерных массивов)

// тип_возр_значения ИмяМетода (параметы)
//PascalCase
//calculate - переменная, Calculate - имя метода
int Calculate(int a, int b, char sign)
//a - число 1, b - число; char это 1 символ например '+' пишеться в ОДИНАРНЫХ ковычках
{
     int result = 0;
     if (sign == '+')
     {
         result = a + b;
     }
     else if (sign == '-')
     {
         result = a - b;
     }
     else
     {
         Console.WriteLine("Такого знака еще нет :(");
     }
     return result;
 }
// Вызов метода
Console.WriteLine(Calculate(100,25,'-')); // 100 - 25 
Console.WriteLine(Calculate(100,400,'+')); // 100 + 400 
Console.WriteLine(Calculate(100,400,'*')); // 100 * 400  -> 0
*/

/* // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3 , 9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.
// Глагол
int[] GetArray(int size, int minValue, int maxValue)
// size = 12, minValue = -9, maxValue = 9
{
int[] resultArray = new int[size];

for (int i = 0; i < resultArray.Length; i++)  // ФРАЗУ i < resultArray.Length МОЖНО ТАК ЖЕ НАПИСАТЬ ВОТ ТАК  i < size
{
resultArray[i] = new Random().Next(minValue, maxValue + 1);
}
return resultArray;
}

int[] array = GetArray(12, -9, 9);
// Интерполяция ($)
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");

int positiveSum = 0; // +
int negativeSum = 0; // -

/* 1 Вариант

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        {
            positiveSum += array[i]; // positiveSum = positiveSum + array[i]
        }
    else // <=0
        {
            negativeSum += array[i]; // negativeSum = negativeSum + array[i]
        }
}


// Вариант 2 Тернарный оператор
// условие ? значение_ист : значение_ложное
for (int i = 0; i < array.Length; i++)
{
positiveSum += array[i] > 0 ? array[i] : 0; // Если число поло-е, то прибавляю array[i]
// иначе - прибавляю 0
negativeSum += array[i] < 0 ? array[i] : 0;
}
Console.WriteLine($"Сумма пол: {positiveSum}, отрц.: {negativeSum}");


*/





//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] GetArray(int size, int minValue, int maxValue)
// size = 12, minValue = -9, maxValue = 9
{
    int[] resultArray = new int[size];

    for (int i = 0; i < resultArray.Length; i++)  // ФРАЗУ i < resultArray.Length МОЖНО ТАК ЖЕ НАПИСАТЬ ВОТ ТАК  i < size
    {
    resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

int[] ReversArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= (-1); // каждый элемент массива умнажается на -1
    }
    return arr;
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");
Console.WriteLine($"Перевернутый массив: [ {String.Join("; ", ReversArray(array))} ]");