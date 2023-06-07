// Задача 34: Задайте массив 
// заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет к
// оличество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] array = new int [4];
// Console.Write("[");

// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100,1000);
//     Console.Write(array[i]+",");
// }
// Console.Write("]");

// int count = 0;
// for(int i = 0; i < array.Length; i++)
// if (array[i] % 2 == 0)
// {
//     count++;
// }
// Console.Write("Количество чётных чисел в массиве = " + count);

// -------------------------------------------------------------------------------

// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на 
// нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] array = new int [4];
// Console.Write("[");

// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1,100);
//     Console.Write(array[i]+" ");
// }
// Console.Write("]");
// int sum = 0;
// for (int i = 1; i < array.Length; i+=2)
//      sum = sum + array[i];
// Console.Write($" сумма элементов, стоящих на нечётных позициях = {sum}");

// --------------------------------------------------------------------------------------

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Console.Write("Введите количество элементов массива от 1 до 100: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("[");
// double[] randomArray = new double[a];
// void mas(int a)

// {
// Random rand = new Random();
// for (int i = 0; i < a; i++)
// {
// randomArray[i] = rand.Next(1, 100);
// Console.Write(randomArray[i] +  " ");
// }

// }

// double raz(double[] randomArray)
// {
// double min = randomArray[0];
// double max = randomArray[0];
// int i = 1;
// while (i < randomArray.Length)
// {
// if (max<randomArray[i])
// max = randomArray[i];
// if (min>randomArray[i])
// min = randomArray[i];
// i = i + 1;
// }
// Console.Write("]");
// return max-min;
// }

// mas(a);


// Console.Write($" Разница между максимальным и минимальным элементов массива = {raz(randomArray)}");

// ------------------------------------------------------------------------------------------------------