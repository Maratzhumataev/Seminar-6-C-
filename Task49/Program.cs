// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] CreateMatrixRndInt(int rows,int columns, int min, int max)
{
   int[,] matrix = new int[rows,columns];
   Random rnd = new Random();

   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrix[i,j] = rnd.Next(min, max + 1);
      }
   }
   return matrix;
}

void PrintMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         Console.Write($"{matrix[i, j], 5} ");
      }
      Console.WriteLine();
   }
}
int[,] SquareEvenIndex(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i+=2)
   {
      for (int j = 0; j < matrix.GetLength(1); j+=2)
      {
         matrix[i, j] *= matrix[i, j];
      }
   }
   return matrix;
}

int[,] matrix = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(matrix);
Console.WriteLine();
SquareEvenIndex(matrix);
PrintMatrix(matrix);