﻿using System;

class Test
{
    enum Months
    {
        January,    // 0
        February,   // 1
        March = 6,    // 6
        April,      // 7
        May,        // 8
        June,       // 9
        July        // 10
    }

    static void Main(string[] args)
    {
        int myNum = (int)Months.May;
        Console.WriteLine(myNum);
    }
}