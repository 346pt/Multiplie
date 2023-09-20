using System;

class Multiplie
{
    static int multiply(int x, int y)
    {

        if (y == 0)
            return 0;

        if (y > 0)
            return (x + multiply(x, y - 1));

        if (y < 0)
            return -multiply(x, -y);

        return -1;
    }
    public static void Main()
    {

        Console.WriteLine(multiply(19, 2));
    }
}