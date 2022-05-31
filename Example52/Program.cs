/*
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
double [,] NumberArray(double [,] numberArray,int numberRandom)
{
    for (var i = 0; i < numberArray.GetLength(0); i++)
    {
        for (var j = 0; j < numberArray.GetLength(1); j++)
        {
            numberArray[i,j]=new Random().Next(numberRandom);
        }       
    }
    return numberArray;
}
void Average(double [,] array)
{
    Console.WriteLine("\nСреднее арифметическое:\n");
    for (var i = 0; i < array.GetLength(0); i++)
    {
        double averageNumber=0;
        for (var j = 0; j < array.GetLength(1); j++)
        {
            averageNumber+=array[j,i]; 
        }
        Console.WriteLine($"AverageArray [{i}] = {averageNumber/array.GetLength(0)} "); 
    }
}
void PrintArray(double [,] arrayToPrint)
{
    Console.WriteLine();
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write("| ");
        for (var j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j]+"\t |");
        }
            Console.WriteLine();
    }
}
Console.Write("Введите размер двумерного массива:\nширина m = ");
int row =Convert.ToInt32(Console.ReadLine());
Console.Write("длина  n = ");
int column =Convert.ToInt32(Console.ReadLine());
var dimensionalArray= new double [row,column];
var  numberRandom = new Random().Next(10,99); 
double [,] result=NumberArray(dimensionalArray,numberRandom);
PrintArray(result);
Average(result);