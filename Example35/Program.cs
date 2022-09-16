/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат 
в отрезке [10, 99].
Пример для массива из 5 элементов: [5, 18, 123, 6, 2] -> 1 
*/

int[] FillRandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 124);
    }
    return array;
}

int FindNumberElements(int[] array, int minNumber, int maxNumber)
{
    int numberElem = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= minNumber && array[i] <= maxNumber)
        {
            numberElem = numberElem + 1;
        }
    }
    return numberElem;
}

Console.Write("Введите минимальное значение отрезка: ");
int minNmber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение отрезка: ");
int maxNmber = Convert.ToInt32(Console.ReadLine());

int[] array = new int[123];
int[] randomArray = FillRandomArray(array);

int findNumElem = FindNumberElements(randomArray, minNmber, maxNmber);
Console.WriteLine($"Количество элементов массива в указанном отрезке: {findNumElem}");

