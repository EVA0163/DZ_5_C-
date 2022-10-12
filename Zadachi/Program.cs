/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */


/*Console.Clear();
int[] array = new int [4];
int len = array.Length;
Console.WriteLine("Массив с числами:");
for (int i=0; i<len; i++)
    {
     array[i]= new Random().Next(100,1000);
     Console.WriteLine($"{array[i]} ");
     
    }
  Console.WriteLine("Чётные: ");
for (int i=0; i<len; i++)
{
if (array[i] % 2==0) 
{
    Console.WriteLine(array[i]);
}
}*/





/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

// Console.Clear();
// Console.Write($"Введи количество элементов массива: ");
// int numberElements = Convert.ToInt32(Console.ReadLine()); 
// int randomNumbers =  RandomNumbers(numberElements, 1, 10);
// int RandomNumbers(int numberElements, int min, int max)
//   {
//   int[] randomNumbers = new int[numberElements];
//   int sumElements = 0;
//   Console.Write("Получившийся массив: ");

//     for (int i = 0; i <randomNumbers.Length; i++ )
//     {
//       randomNumbers[i] = new Random().Next(min, max);

//       Console.Write(randomNumbers[i] + " ");

//       if (i % 2 != 1)
//       {
//         sumElements = sumElements + randomNumbers[i];
//       }
//     }
//   return sumElements;
//   }

// Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");





/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 768*/
Console.Clear();
double[] arrayRealNumbers = new double[10];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayRealNumbers[i] + " ");
  }

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным ({minNumber}) элементами: {decision}");