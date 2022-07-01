// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

string FindArrayElement(int[,] array, int rowPosition, int columnPosition)
{
    string result = "";
    if (rowPosition > array.GetLength(0) || columnPosition > array.GetLength(1))
    {
        result = $"На введенной позиции ({rowPosition}; {columnPosition}) элемента нет.";
    }
    else
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i, j] == array[rowPosition - 1, columnPosition - 1])
                {
                result = $"На введенной позиции ({rowPosition}; {columnPosition}) находится элемент {array[i, j]}.";
                }
   
            }
        }
return result;
}

int row = Prompt("Введите количество строк -> ");
int column = Prompt("Введите количество столбцов -> ");
int min = 0;
int max = 10;
int[,] myArray = GenerateArray(row, column, min, max);
PrintArray(myArray);
int rowPosition = Prompt("Введите номер строки = > ");
int columnPosition = Prompt("Введите номер столбца = > ");
Console.WriteLine(FindArrayElement(myArray, rowPosition, columnPosition));
