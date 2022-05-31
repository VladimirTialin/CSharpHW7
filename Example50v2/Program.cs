
/*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
5 -> 9
*/
//Формируем массив случайных чисел

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
// Выводим массив случайных чисел
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
// Функция поиска позиции элемента и вывода значения массива
int GetIndexArray(int[,] findIndexArray, int positionNumber, int indexRow = 0, int indexColumn = 0)
{
    if (positionNumber >= 0 && positionNumber < findIndexArray.Length)
    {
        indexRow = positionNumber / findIndexArray.GetLength(0);
        indexColumn = positionNumber / findIndexArray.GetLength(1);
        return findIndexArray[indexRow, indexColumn];
    }
    return positionNumber;
}
// Красивый вывод массива с результатом
void ColorPrintArray(int[,] arrayToPrint, int findNumber, int index, bool resetColor = false)
{
    Console.WriteLine();
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (var j = 0; j < arrayToPrint.GetLength(1); j++)
        {

            if (findNumber == arrayToPrint[i, j] && resetColor == false)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                resetColor = true;
            }
            else
            {
                Console.ResetColor();
            }
            Console.Write(arrayToPrint[i, j] + " ");
        }
        Console.WriteLine();
    }
    if (findNumber <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n {findNumber} - > позиции данного элемента не существует! Повторите ввод.");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n{index} -> {findNumber}");
        Console.ResetColor();
    }
}
Console.Write("Введите размер двумерного массива:\nширина m = ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("длина  n = ");
int column = Convert.ToInt32(Console.ReadLine());
var dimensionArray = new int[row, column];
var numberRandom = new Random().Next(1, 10);

int[,] result = NumberArray(dimensionArray, numberRandom);
PrintArray(result);
Console.Write("\nВыберите позицию элемента массива: ");
int index = Convert.ToInt32(Console.ReadLine());
int number = GetIndexArray(result, index);
ColorPrintArray(result, number, index);
