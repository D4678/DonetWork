using System;
class Test
{
    static void Main()
    {
        int i = 100;
        float f = i;
        Console.WriteLine(f);

        //float v = 1234569874444.45F;
        //int a = Convert.ToInt32(v);
        //Console.WriteLine(a);

        string strNumber = "100Tg";
        int e = int.Parse(strNumber);
        Console.WriteLine(e);
    }
}