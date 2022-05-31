
/*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
5 -> 9
*/
int[,] NumberArray(int[,] numberArray, int numberRandom)
{
    for (var i = 0; i < numberArray.GetLength(0); i++)
    {
        for (var j = 0; j < numberArray.GetLength(1); j++)
        {
            numberArray[i, j] = new Random().Next(numberRandom);
        }
    }
    return numberArray;
}
void PrintArray(int[,] arrayToPrint)
{
    Console.WriteLine();
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (var j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void GetIndexArray(int[,] findIndexArray, int count = 0)
{
    Console.Write("\nВыберите позицию элемента массива: ");
    int index = Convert.ToInt32(Console.ReadLine());
    if (index > findIndexArray.Length || index < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n {index} - > позиции данного элемента не существует! Повторите ввод.");
        Console.ResetColor();
    }
    else
    {
        for (var i = 0; i < findIndexArray.GetLength(0); i++)
        {
            for (var j = 0; j < findIndexArray.GetLength(1); j++)
            {
                count++;
                if (count == index)
                {
                    System.Console.WriteLine();
                    Console.WriteLine($"{index} -> {findIndexArray[i, j]}");
                    break;
                }
            }
        }
    }

}
Console.Write("Введите размер двумерного массива:\nширина m = ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("длина  n = ");
int column = Convert.ToInt32(Console.ReadLine());
var dimensionalArray = new int[row, column];
var numberRandom = new Random().Next(1, 15);
int[,] result = NumberArray(dimensionalArray, numberRandom);
PrintArray(result);
GetIndexArray(result);