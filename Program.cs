//Задача 47. Создать двумерный массив m x n, заполненый случайными вещественными числами.
/*
Console.Write("Enter the number of rows of the array: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the number of columns of the array: ");
int columns = int.Parse(Console.ReadLine()!);

double [,] array = GetArray (rows, columns, 0, 10);
PrintArray(array);

double [,] GetArray (int m, int n, int min, int max)
{
    double [,] result = new double [m,n];
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            result [i,j] = new Random().NextDouble()*(max-min);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Console.WriteLine($"{inArray[i,j]:f1} ");
        }
        Console.WriteLine();
    }
}
/*
//Задача 50. написать программу, которая принимает значение элемента в двумерном массиве, и возвращает информацию о наличии этого элемента в массиве.

Console.Write("Enter the number of rows of the array: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the number of columns of the array: ");
int columns = int.Parse(Console.ReadLine()!);

int [,] array = GetArray (rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine("Enter the number of the element: ");
int element=int.Parse(Console.ReadLine()!);
if (FindElement(array, element))
{
    Console.WriteLine("Element is found");
}
else
{
    Console.WriteLine("Element is not found");
}

int [,] GetArray (int m, int n, int min, int max)
{
    int [,] result = new int[m,n];
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            result[i,j]=new Random().Next(min,max+1);
        }
    }
    return result;
}

void PrintArray (int[,] inArray)
{
    for (int i=0; i<inArray.GetLength(0);i++)
    {
        for (int j=0; j<inArray.GetLength(1);j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

bool FindElement(int[,]array, int el)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            if(array[i,j]==el) return true;

        }
    }
    return false;
}
*/
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Console.WriteLine("Enter the number of rows: ");
int rows=int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the number of columns: ");
int columns=int.Parse(Console.ReadLine()!);
int[,] array=GetArray(rows, columns, 0,10);
PrintArray(array);
double [] averageColumns=GetResultArray(array);
Console.WriteLine($"Average of each column is {String.Join(" ; ",averageColumns)} ");

int[,]GetArray(int m, int n, int min, int max)
{
    int[,] result=new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j]=new Random().Next(min,max+1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Console.WriteLine($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

double[] GetResultArray(int[,]array)
{
double[] result=new double [array.GetLength(1)];
for(int i=0; i<array.GetLength(1); i++)
{
double sum=0;
    for(int j=0; j<array.GetLength(0);j++)
    {
     sum+=array[j,i];
    }
     result[i]=Math.Round(sum/array.GetLength(0),2);
}
return result;
}
*/
