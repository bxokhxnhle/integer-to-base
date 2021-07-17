using System;
using static System.Console;

namespace Bme121
{
    static class Program
    {
        static void Main( )
        {
            int num;
            int basenum;
            
            Write("Enter a number: ");
            num = int.Parse(ReadLine());
            WriteLine();
            if (num < 0)
            {
                WriteLine("ERROR!!!");
                return;
            }
            
            Write("Enter a base: ");
            basenum = int.Parse(ReadLine());
            WriteLine();
            if (basenum < 2)
            {
                WriteLine("ERROR!!!");
                return;
            }
            
            int i = num / basenum;
            int size = 2;
            
            while (i >= basenum)
            {
                i = i / basenum;
                size++;
            }
            
            int j = num;
            int[] digits = new int[size];
            
            int index = 0;
            bool notDone = true;
            while (notDone == true && index < digits.Length)
            {
                if (j >= basenum)
                {
                    digits[index] = j % basenum;
                    j = j / basenum;
                    index++;
                }
                else
                {
                    digits[index] = j;
                    notDone = false;
                }
            }
            Write(num + " in base " + basenum + " is ");
            if (basenum <= 9)
            {
                while (index >= 0)
                {
                    Write(digits[index]);
                    index--;
                }
            }
            else
            {
                while (index >= 0)
                {
                    if (index> 0)
                    {
                        Write(digits[index]);
                        Write(",");
                        index--;
                    }
                    else
                    {
                        Write(digits[index]);
                        index--;
                    }
                }
            }
            WriteLine();
        }
    }
}
