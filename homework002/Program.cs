/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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
        matrix[i,j] = new Random().Next(1 , 26) ;
        Console.Write(matrix[i,j] + "\t") ;
    }
    Console.WriteLine();
 }
 System.Console.WriteLine("Введите число которое нужно найти : ");
 int search =  int.Parse(Console.ReadLine());

for (int k = 0; k < matrix.GetLength(0); k++)
{
    for (int m = 0; m < matrix.GetLength(1); m++)
    {
        if (search == matrix[k , m]){
            System.Console.WriteLine($"Число находится в позиции : {k}{m} ");
            break;
        }
    }
}