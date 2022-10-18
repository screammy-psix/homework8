//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 1 строка
void Zadanie56()
{
    Console.WriteLine("Введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m > n)
    {
        int[,] arr = new int[m, n];
        FillArray(arr);
        PrintArray(arr);
        SumElementRows(arr);
    }
    else
    {
        Console.WriteLine("Массив должен быть прямоугольным. \nКоличество строк должно быть больше, чем количество столбцов!");
    }
}
void SumElementRows(int[,] arr)
{  
    int minSum = 0;
    int sumRows = SumElements(arr, 0);
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int temp = SumElements(arr, i);
        if (sumRows > temp)
        {
        sumRows = temp;
        minSum = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов = {sumRows}, находится в {minSum + 1} строке.");
}
int SumElements(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}


//Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить 
//произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

void Zadanie58()
{
    Random random = new Random();
    
    int m = random.Next(2,2);
    int n = random.Next(2,2);
    int k = random.Next(2,2);
    int[,] arrOne = new int[m, n];
    int[,] arrTwo = new int[n, k];
    FillArray(arrOne, 2,4);
    FillArray(arrTwo, 1,2);
    PrintArray(arrOne);
    Console.WriteLine("________________");
    Console.WriteLine();
    PrintArray(arrTwo);
    int[,] arrMultiplier = new int[m, k];
    MultiplyArr(arrOne, arrTwo, arrMultiplier);
    Console.WriteLine("Произведение первой и второй матриц: ");
    PrintArray(arrMultiplier);
}
void MultiplyArr(int[,] arrOne, int[,] arrTwo, int[,] arrResult)
{

    int rowsResult = arrResult.GetLength(0);
    int columnsResult = arrResult.GetLength(1);
    int columnsOneArr = arrOne.GetLength(1);
    for (int i = 0; i < rowsResult; i++)
    {
        for (int j = 0; j < columnsResult; j++)
        {
            int sum = 0;
            for (int k = 0; k < columnsOneArr; k++)
            {
                sum += arrOne[i, k] * arrTwo[k, j];
            }
            arrResult[i, j] = sum;
        }
    }
 }



//Задача 62  Напишите программу, которая заполнит
// спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
// 1  2  3  4
//12 13 14  5
//11 16 15  6
//10  9  8  7

void Zadanie62()
{
            
    Console.WriteLine("Массив заполненный спиралью: ");
    int m = 4;
    int[,] arr = new int[m, m];
    FillSpirallAray(arr);
}

void FillSpirallAray(int[,] arr)
{
    int prod = arr.GetLength(0) * arr.GetLength(1);
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= prod)
    {
        arr[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < columns - 1)
        { j++; }
        else if (i < j && i + j >= rows - 1)
        { i++; }
        else if (i >= j && i + j > columns - 1)
        { j--; }
        else
        { i--; }
    }
    PrintArray(arr);
}
Zadanie62();



//Задача 47.Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

void Zadanie47()
{
    Console.WriteLine("Введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    double[,] arr = new double[m, n];
    FillArrayDoubleTwoArr(arr);
    PrintArrayDoubleTwoArr(arr);
}

void FillArrayDoubleTwoArr(double[,] num)  
{
    Random random = new Random();
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            num[i, j] = random.NextDouble() * 200 - 100;
            num[i, j] = Math.Round(num[i, j], 1);
        }
    }

}

void PrintArrayDoubleTwoArr(double[,] num)  
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            Console.Write(num[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


//Задача 50. Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
void Zadanie50()
{
    Random random = new Random();
    
    int m = random.Next(2,10);
    int n = random.Next(2,10);
    int[,] arr = new int[m, n];
    FillArray(arr);
    PrintArray(arr);
    FindingElement(arr);
}
void FillArray(int[,] num, 
                int minValue = 0, 
                int maxValue = 100)  
{
    maxValue++;
    Random random = new Random();
        for (int i = 0; i < num.GetLength(0); i++)
        {
            for (int j = 0; j < num.GetLength(1); j++)
            {
                num[i, j] = random.Next(minValue, maxValue);
            }
        }
}
void PrintArray(int[,] num) 
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            Console.Write(num[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FindingElement(int[,] arr)
{
    Console.WriteLine("Введите номер строки: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m < arr.GetLength(0))
    {
        Console.WriteLine($"Значение элемента = {arr[m, n]}");
    }
    else
    {
        Console.WriteLine("Такого элемента не существует!");
    }
}

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Zadanie52()
{
    Random random = new Random();
    int m = random.Next(2,10);
    int n = random.Next(2,10);
    int[,] a = new int[m, n];
    double[] b = new double[n];

    FillArray(a);
    PrintArray(a);
    ArithmeticMean(a, b);
}

void ArithmeticMean(int[,] arr, double[] mass)
{
    Console.WriteLine();
    for (int i = 0, k = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        mass[k] = Math.Round(sum / arr.GetLength(0), 1);
        Console.Write(mass[k] + "\t");
        k++;
    }

    Console.WriteLine(" Среднее арифметическое каждого столбца");
}


//Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 
//ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
void Zadanie41()
{
Console.WriteLine("Сколько чисел требуется ввести?");
int countOfNumbers = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] numbers = new int[countOfNumbers];
for(int i=1; i<=countOfNumbers; i++)
{
    Console.WriteLine($"Введите {i} число");
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    numbers[i-1] = inputNumber;
    if (inputNumber > 0) count++;
}
Console.WriteLine($"Положительных чисел введено "+ count);
}


//Задача 43: Напишите программу, которая найдёт
// точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//k1 = 5, b1 = 2, k2 = 9, b2 = 4,  -> (-0,5; -0,5)
void Zadanie43()
{
    Console.WriteLine($"Введите значение k1");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Введите значение b1");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Введите значение k2");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Введите значение b2");
    double b2 = Convert.ToDouble(Console.ReadLine());

    double x = Convert.ToDouble(b2-b1)/Convert.ToDouble(k1-k2);
    x  = Math.Round(x, 2);
    double y = k1 * x + b1;
    y  = Math.Round(y, 2);
    Console.WriteLine($"точка пересечения А {x}, {y}");
}


