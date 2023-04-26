// Task1 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// int[] CreateArrayOfThreeDigitNumbers (int size)
// {
//     int[] array = new int[size];
//     for (int i=0; i<size; i++)
//     {
//         array[i]=new Random().Next(101,1000);
//     }
// return array;
// }
// void ShowArray(int[] array)
// {
//     for(int i=0; i<array.Length; i++)
//     Console.Write(" " + array[i] + " ");
// }
// int EvenNumbers (int[] array)
// {
//     int count = 0;
//     for(int i=0; i<array.Length; i++)
//         if (array[i]%2 == 0) count++;
// return count;
// }
// Console.WriteLine("Please enetr the size of massiv");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArrayOfThreeDigitNumbers(size);
// ShowArray(array);
// int even_count = EvenNumbers(array);
// Console.WriteLine($"In massiv - {even_count} even numbers");

// Task2 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// int[] CreateArray (int size)
// {
//     int[] array = new int[size];
//     for (int i=0; i<size; i++)
//     {
//         array[i]=new Random().Next(0,101);
//     }
// return array;
// }
// void ShowArray(int[] array)
// {
//     for(int i=0; i<array.Length; i++)
//     Console.Write(" " + array[i] + " ");
// }
// int TheSumOfTheNumbersInOddPositions(int[] array)
// {
//     int sum = 0;
//     for (int i=1; i<array.Length; i=i+2)
//     sum = sum+array[i];
// return sum;
// }

// Console.WriteLine("Please eneter the size of massiv");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size);
// ShowArray(array);
// int sum = TheSumOfTheNumbersInOddPositions(array);
// Console.WriteLine($"The sum of the numbers in odd positions are {sum}");

// Task3 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// double[] CreateArray(int size)
// {
//     double[] array = new double [size] ;
//     for (int i=0; i<size; i++)
//     {
//         Console.WriteLine($"Please enter the {i+1}' element of the massiv");
//         array[i] = Convert.ToDouble(Console.ReadLine());
//     }
// return array;
// }

// double TheDifferenceBetweenTheMaximumAndMinimum(double[] array)
// {
//     double max = array[0];
//     for(int i=1; i<array.Length; i++)
//     {
//         if (array[i]>max) max = array[i];
//      }    
//     double min = array[0];
//     for(int i=1; i<array.Length; i++)
//     {
//         if (array[i]<min) min = array[i];
//      }    
// Console.WriteLine();
// Console.WriteLine($"Min number is {min}");
// Console.WriteLine($"Max number is {max}");
// double dif = max-min;
// return dif;
// }
// void ShowArray(double[] array)
// {
//     for (int i =0; i<array.Length; i++)
//     Console.Write(" " + array[i] + " ");
// }
// Console.WriteLine();
// Console.WriteLine("Please enter the size of massiv ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] array = CreateArray(size);
// ShowArray(array);
// double dif = Math.Round(TheDifferenceBetweenTheMaximumAndMinimum(array),2);
// Console.WriteLine("The difference between the maximum and minimum is - " + dif);
