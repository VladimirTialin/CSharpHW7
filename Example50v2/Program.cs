/*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
5 -> 9
*/
//Формируем массив случайных чисел
int[,] NumberArray(int[,] numberArray)
{
    for (var i = 0; i < numberArray.GetLength(0); i++)
    {
        for (var j = 0; j < numberArray.GetLength(1); j++)
        {
            numberArray[i, j] = new Random().Next(20,80);
        }
    }
    return numberArray;
}
// Выводим массива случайных чисел
void PrintArray(int[,] arrayToPrint)
{
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {  
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
                Console.Write(" " + arrayToPrint[i, j] + " ");
        }
        Console.WriteLine();
    }
    
}
// Функция поиска позиции элемента и вывода значения массива
int GetIndexArray (int[,] findIndexArray,
                   int positionNumber)
{
    if (positionNumber >= 0 &&
        positionNumber <= findIndexArray.Length-1)
    {
        return findIndexArray
        [positionNumber / findIndexArray.GetLength(1),
         positionNumber % findIndexArray.GetLength(1)];
    }
    return positionNumber;
}
// Красивый вывод массива с результатом
void ColorPrintArray(int[,] arrayToPrint,int index,
                     int result=0,int colorIndex=0)
{
    Console.WriteLine();
        for (var i = 0; i < arrayToPrint.GetLength(0); i++)
        {
            for (var j = 0; j < arrayToPrint.GetLength(1); j++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                if (index == colorIndex)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    result = GetIndexArray(arrayToPrint, index);
                }
                else
                {
                    Console.ResetColor();
                }
                Console.Write(" " + arrayToPrint[i, j] + " ");
                colorIndex++;
            }
        Console.WriteLine();
        }
    if (index < 0 || index > arrayToPrint.Length - 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n{index}" +
        $" - > позиции данного элемента не существует! Повторите ввод.");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n В позиции {index} находится значение = {result}");
        Console.ResetColor();
    }
}
Console.Write("Введите размер двумерного массива:\nширина m = ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("длина  n = ");
int row= Convert.ToInt32(Console.ReadLine());
var arrRandom = new int[column,row ];
int[,] result = NumberArray(arrRandom);
PrintArray(result);
Console.Write("\nВыберите позицию элемента массива: ");
int index = Convert.ToInt32(Console.ReadLine());
ColorPrintArray(result, index);
