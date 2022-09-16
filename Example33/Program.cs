/*
Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/

string FindNumberToArray(int[] array, int number)
{
    string foundNumber = "hello";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) 
        {
            foundNumber = "Заданное число есть в массиве";
            break;
        }
        else foundNumber = "Заданного числа нет в массиве";
    }
    return foundNumber;
}

int[] array = {6, 7, 19, 345, 3};
Console.Write("Введите число для поиска в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
string fNumber = FindNumberToArray(array, number);

Console.WriteLine(fNumber);