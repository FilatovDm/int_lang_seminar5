/*
Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элементы, второй и 
предпоследний и т. д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3      [6 7 3 6] -> 36 21
*/

int[] FillRandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int[] NewArray(int[] array)
{
    int[] newArray;

    if (array.Length % 2 == 0)
    {
        newArray = new int[array.Length/2];
        for (int i = 0;  i < array.Length / 2; i++) 
        {
           newArray[i] = array[i] * array[array.Length - i - 1];
        }
    }
    else 
    {
        newArray = new int[array.Length/2 + 1];
        for (int i = 0;  i < array.Length / 2; i++) 
        {
            newArray[i] = array[i] * array[array.Length - i -1];
        }
        newArray[newArray.Length - 1] = array[array.Length / 2];
    }
    return newArray;
}

Console.Write("Укажите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[sizeArray];

int[] randomArray = FillRandomArray(array);
int[] newArray = NewArray(randomArray);

Console.Write("Массив из 8 элементов: ");
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.Write("Произведение пар массива: ");
Console.WriteLine("[{0}]", string.Join(", ", newArray));