using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basics
{
    class Basics
    {
        public static ulong Fibo(uint n)
        {
            ulong oldnum = 0;
            ulong currnum = 1;

            ulong nextNumber;

            if (n <= 2)
            {
                return  (ulong) n;
            }

            while (n > 1)
            {

                nextNumber = currnum + oldnum;

                oldnum = currnum;
                currnum = nextNumber;
                n--;
            }

            return currnum;
        }

        public static char Rotchar( char c, int key)
        {
            int keyLetter = key % 26;
            if (keyLetter < 0)
            {
                keyLetter += 26;
            }
            int keyNumber = key % 10;
            if (keyNumber < 0)
            {
                keyNumber += 10;
            }

            if (c >= 'a' && c <= 'z')
            {
                c = (char) ((c - 'a' + keyLetter) % 26 +'a');
            }
            if (c >= 'A' && c <= 'Z')
            {
                c = (char) ((c - 'A' + keyLetter) % 26 + 'A');
            }
            if (c >= '0' && c <= '9')
            {
                c = (char) ((c - '0' + keyNumber) % 10 + '0');
            }
            return c;
        }

        public static string RotN( string str )
        {
            int key = (int) (Fibo(60) % 26);
            string rtn = " ";
            foreach (char c in str)
            {
                rtn += Rotchar(c, - key);
            }

            return rtn;
        }
        
        public static int HighestValueInMemory(int[] arr)
        {
            // the hill increases first
            bool isIncreasing = true;
            int max = arr.Length > 0 ? arr[0] : 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (isIncreasing && arr[i] >= max)
                    max = arr[i];
                else
                {
                    if (isIncreasing)
                        isIncreasing = false;
                    if (arr[i] > arr[i - 1])
                        return -1;
                }
            }
            return max;
        }

        public static int XWingPosition(int[][] arr)
        {
            int R = 6;
            int C = 6;
            //va de C-2 a R-2
            int max_sum = int.MinValue;
            for (int i = 0; i < R - 2; i++)
            {
                for (int j = 0; j < C - 2; j++)
                {
                    int sum = (arr[i][j] + arr[i][j + 1] +
                               arr[i][j + 2]) + (arr[i + 1][j + 1]) +
                              (arr[i + 2][j] + arr[i + 2][j + 1] +
                               arr[i + 2][j + 2]);
                    max_sum = Math.Max(max_sum, sum);
                }
            }
            return max_sum;
        }
    }
}