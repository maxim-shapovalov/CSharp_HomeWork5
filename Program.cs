// Задача 34 - начало
int[] GenerateArray() // используется и для задачи 2
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
     for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" " + array[i]);
    }
    Console.WriteLine();
    return;
}

void SummEvenNumber(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) sum++;
    }
    Console.Write("Количество четных чисел равно " + sum + "\n");
    return;
}
// Задача 34 - конец


// Задача 36 - начало
void SummOddIndexNumber(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
        Console.Write(i + " - " + array[i] + " ");
    }
    Console.WriteLine("\nСумма элементов массива с нечетными индексами равна " + sum);
    return;
}
// Задача 36 - конец


// Задача 38 - начало
double[] GenerateRealNumbersArray()
{
    double[] array = new double[10];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(-10,11));
    }
    return array;
}

void PrintRealNumberArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" " + array[i]);
    }
    return;
}

void FindDiffMaxMinRealNumberArray(double[] array)
{
    double max = 0;
    double min = 0;
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    diff = max - min;
    Console.WriteLine($"\nМинимальное значение {min}, максимальное значение {max}, разница между ними {diff}");
    return;
}

// Задача 38 - конец

Console.Clear();
Console.WriteLine("\n========= Список задач ==========\n");
Console.WriteLine("1 - Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве");
Console.WriteLine("2 - Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine("3 - Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. Диапазон [-10, 10].");
Console.WriteLine("0 - Выход\n");
Console.Write("Выберите задачу 1, 2 или 3:   ");
int task = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

switch (task)
{
    case 1:
        // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
        // [345, 897, 568, 234] -> 2
        
        int[] array = GenerateArray(); 
        PrintArray(array);
        SummEvenNumber(array);
        break;

    case 2:
        // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
        // [3, 7, 23, 12] -> 19
        // [-4, -6, 89, 6] -> 0
        int[] array2 = GenerateArray(); 
        PrintArray(array2);
        SummOddIndexNumber(array2);
        break;

    case 3:
        // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
        // Диапазон [-10, 10]. Обратите внимание на вещественных чисел
        // Для примера возьмём диапазон побольше. [3 7 22 2 78] -> 76
        double[] array3 = GenerateRealNumbersArray();
        PrintRealNumberArray(array3);
        FindDiffMaxMinRealNumberArray(array3);


        break;

    case 0:
        //Console.WriteLine();
        Console.WriteLine("Всего хорошего!");
        //Console.WriteLine();
        break;
}
Console.WriteLine();
   






