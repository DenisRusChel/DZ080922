// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// вводим позиции по i и j -> если таких нет - выводим, что позиции не существует. 
// Если есть - выводим элемент по этим индексам.

Console.Clear();


System.Console.WriteLine("Введите позицию строки i (от 1 до 3):");
int i = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите позицию столбца j (от 1 до 4) :");
int j = Convert.ToInt32(Console.ReadLine());

int[,] array = GetRandomArray(3,4);
PrintArray(array);

if (i > array.GetLength(0) || j > array.GetLength(1) || i <= 0 || j <=0) System.Console.WriteLine("Такого элемента нет");
else System.Console.WriteLine($"строка {i} и столбец {j} → {array[i-1, j-1]}");

int[,] GetRandomArray(int m, int n)
{
    int[,] arr = new int[m,n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
        }
    }
    return arr;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    
}







    

