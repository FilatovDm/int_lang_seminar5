/*
Задача 32: Напишите программу замена элементов массива: положительные
элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, 8, 2]
*/

int[] GetArrayReplacement(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }

    return array;
}

int[] array = {-4, -8, 8, 2};
var arrayReplacment = GetArrayReplacement(array);

Console.WriteLine("[{0}]", string.Join(", ", arrayReplacment));