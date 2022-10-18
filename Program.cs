/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

using static System.Console;
Clear();

WriteLine("Введите кол-во строк: ");
int rows = int.Parse(ReadLine()!);
WriteLine("Введите кол-во стобцов: ");
int columns = int.Parse(ReadLine()!);
WriteLine("Введите диапозон от 1 до: ");;
int randomNumber = int.Parse(ReadLine()!);

int[,] array = new int[rows, columns];
GetArray(array);
PrintArray(array);

int minElements = 0;
int sumElements = SumElementsrows(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int temp = SumElementsrows(array, i);
  if (sumElements > temp)
  {
    sumElements = temp;
    minElements = i;
  }
}

WriteLine($"{minElements+1} - строкa с наименьшей суммой ({sumElements}) элементов ");


int SumElementsrows(int[,] array, int i)
{
  int sumElements = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumElements += array[i,j];
  }
  return sumElements;
}


void GetArray(int[,] inArray) {
    for(int i = 0; i < inArray.GetLength(0); i++) {
        for(int j = 0; j < inArray.GetLength(1); i++) {
            inArray[i,j] = new Random().Next(randomNumber);
        }
    }
}

void PrintArray(int[,] inArray) {
    for(int i = 0; i < inArray.GetLength(0); i++) {
        for(int j = 0; j < inArray.GetLength(1); j++) {
            Write(inArray[i,j] + " ");
        }
        WriteLine();
    }
}

