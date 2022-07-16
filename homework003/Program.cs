/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
System.Console.WriteLine("Задайте массив");
int columns = int.Parse(Console.ReadLine());
int rows = int.Parse(Console.ReadLine());
int [,] matrix = new int [rows,columns];
System.Console.WriteLine("Матрица");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1 , 5) ;
        Console.Write(matrix[i,j] + "\t") ;
    }
    Console.WriteLine();
}
System.Console.WriteLine("средне арифметическое каждого столбца : ");
for (int j = 0; j < matrix.GetLength(1); j++)
{
    int i = 0;
    double result = 0;
    while( i  <  matrix.GetLength(0))
    {
        
         result += matrix[i,j];
         i++;
    }
    result = result / i;
    System.Console.Write(result + " ");
}