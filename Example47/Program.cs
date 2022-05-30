/*
Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
double [,] NumberArray(double [,] numberArray,int numberRandom)
{
    for (var i = 0; i < numberArray.GetLength(0); i++)
    {
        for (var j = 0; j < numberArray.GetLength(1); j++)
        {
            numberArray[i,j]=new Random().NextDouble()*numberRandom;
        }       
    }
    return numberArray;
}
void PrintArray(double [,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    for (var i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write("["+ i + "]\t");
        for (var j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(Math.Round(arrayToPrint[i,j],1)+"\t");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите размер двумерного массива:\nширина m = ");
int row =Convert.ToInt32(Console.ReadLine());
Console.Write("длина  n = ");
int column =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое число для формирования случайных числе: ");
int number =Convert.ToInt32(Console.ReadLine());
double [,] RandomArray = new double[row,column];
double [,] result = NumberArray(RandomArray,number);
PrintArray(result);
