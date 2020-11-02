using System;

namespace Oleg { 

public class MainClass
{
    static void Main()
    {
        Proc16();
    }
    static void PowerA3(int A, ref int B)
    {
        B = (int)Math.Pow(A, 3);
    }
    static void Proc1()
    {
        int A = 0;
        PowerA3(3, ref A);
        Console.WriteLine(A);
    }
    
   
    public static int Sign(double x)
    {
        if (x < 0)
            return -1;
        if (x == 0)
            return 0;
        return 1;
    }
    public static int Proc16()
    {
        double A = 1.5;
        double B = 5.6;
        Console.WriteLine(Sign(A) + Sign(B));
    }
    static int RootsCount(int A, int B, int C)
    {
        double D = Math.Pow(B, 2) - 4 * A * C;
        if (D < 0)
            return 0;
        if (D == 0)
            return 1;
        return 2;
    }
    public static doble Proc17()
    {
        int A = 5;
        int B = 8;
        int C = 1;
        Console.WriteLine(RootsCount(A, B, C));
    }
    static double Circles(int R)
    {
        return Math.PI * Math.Pow(R, 2);
    }
    static void Proc18()
    {
        int R = 5;
        Console.WriteLine(Circles(R));
    }
    static double RingS(int R1, int R2)
    {
        return (Math.PI * R1 * R1) - (Math.PI * R2 * R2);
    }
    static void Proc19()
    {
        int R1 = 10;
        int R2 = 7;
        Console.WriteLine(RingS(R1, R2));
    }
    static double TriangleP(double a, double h)
    {
        double b = Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(h, 2));
        return b + b + a;
    }
    static void Proc20()
    {
        double a = 6;
        double h = 7;
        Console.WriteLine(TriangleP(a, h));
    }
    static int SumRange(int A, int B)
    {

        int sum = 0;
        if (A > B)
        {
            return sum;
        }
        else
        {
            for (int i = A; i <= B; i++)
                sum += i;
            return sum;
        }
    }
    static void Proc21()
    {
        int A = 4;
        int B = 8;
        int C = 12;
        Console.WriteLine(SumRange(A, B));
        Console.WriteLine(SumRange(B, C));
    }
} }