
namespace ClassLibrary1
{
    public class Matrix
    {
        public static string GetRowWithMaxSum(int[,] matrix)
        {
            int maxElement = int.MinValue;
            int maxElementColumn = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] > maxElement)
                    {
                        maxElement = matrix[i, j];
                        maxElementColumn = j;
                    }
                }
            }
            string vector = string.Empty;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                vector += matrix[i, maxElementColumn] + " ";
            }
            return vector.Trim();
        }
    }
}
