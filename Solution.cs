using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    public class Solution
    {
        //метод переписывает двумерный массив в одномерный, и по желанию выводит его в консоль
        public static int[] OperationToMatrix(int[,]array, int operation)
        {
            int[] array2 = new int[array.Length];
            int index = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    switch(operation){
                        case 1:
                            array2[index] = array[i, j];
                            index++;
                            break;
                        case 2:
                            Console.Write(String.Format("{0,3}", array[i, j]));
                            if (j == 2) { Console.Write($"\n"); }
                            break;
                    }
                }
            }
            return array2;
        }
        
        // конвертируем простой массив в двумерный
        public static int[,] ConvertToMatrix(int[] array, int col, int row)
        {
            int[,] newarray = new int[col, row];

            int index = 0;
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    newarray[i, j] = array[index];
                    index++;
                }
            }
            return newarray;
        }
    }
}
