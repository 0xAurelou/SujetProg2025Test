using System;
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
            if (c >= 'a' && c <= 'z')
            {
                c = (char) ((c - 'a' + key) % 26 +'a');
            }
            if (c >= 'A' && c <= 'Z')
            {
                c = (char) ((c - 'A' + key) % 26 + 'A');
            }
            if (c >= '0' && c <= '9')
            {
                c = (char) ((c - '0' + key) % 10 + '0');
            }
            return c;
        }

        public static string RotN( string str )
        {
            int key = (int) (Fibo(60) % 26);
            string rtn = " ";
            foreach (char c in str)
            {
                rtn += Rotchar(c, key);
            }

            return rtn;
        }
    }
}