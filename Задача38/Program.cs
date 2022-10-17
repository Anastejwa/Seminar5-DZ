// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int[] arrayNumbers = new int[6];
  for (int i = 0; i < arrayNumbers.Length; i++ )
  {
    arrayNumbers[i] = new Random().Next(-50, 100);
    Console.Write(arrayNumbers[i] + " ");
  }

int maxNum = arrayNumbers[0];
int minNum = arrayNumbers[0];

  for (int i = 1; i < arrayNumbers.Length; i++)
  {
        if (maxNum < arrayNumbers[i])
    {
      maxNum = arrayNumbers[i];
    }
        if (minNum > arrayNumbers[i])
    {
      minNum = arrayNumbers[i];
    }
  }
  int result = maxNum - minNum;
  Console.WriteLine($"Разница между максимальным и минимальным элементами: {result} ");