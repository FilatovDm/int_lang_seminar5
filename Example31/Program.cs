/*
Задача 31. Задайте массив из 12 элементов, заполненный случайными числами
из промежутка [-9, 9]. Найдите сумму отрицательных и
положительных элементов массива.
*/

int[] GetArray(int size, int startValue, int endValue)
{
    var array = new int[size];

    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startValue, endValue + 1);
    }

    return array;
}

int GetSumPositiveNumbers(int[] array)
{
    var sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum = sum + array[i];
    }
    return sum;
}

int GetSumNegativeNumbers(int[] array)
{
    var sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum = sum + array[i];
    }
    return sum;
}

var array = GetArray(12, -9, 9);
var sumPositive = GetSumPositiveNumbers(array);
var sumNegative = GetSumNegativeNumbers(array);

Console.Write($"Сумма положительных чисел {sumPositive}\n" +
                $"Сумма отрицательных чисел {sumNegative}");
