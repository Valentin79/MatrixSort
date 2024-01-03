namespace ArraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 }, { 12, 11, 10 } };

            int[] temp = Solution.OperationToMatrix(array, 1);
            
            Array.Sort(temp);

            int[,] newarray = Solution.ConvertToMatrix(temp, array.GetLength(0), array.GetLength(1));

            Solution.OperationToMatrix(newarray, 2);

        }
    }
}
