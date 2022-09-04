// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Введите число строк 1-й матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 1-й матрицы и строк 2-й: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 2-й матрицы: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,] firstMartrix = new int[a, b];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMartrix);

int[,] secondMartrix = new int[b, c];
CreateArray(secondMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secondMartrix);

int[,] resultMatrix = new int[a,c];

MultiplycationMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение матриц:");
WriteArray(resultMatrix);

void MultiplycationMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0,10);
    }
  }
}
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}