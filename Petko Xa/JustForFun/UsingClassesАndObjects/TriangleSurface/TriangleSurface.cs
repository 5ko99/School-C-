using System;
class TriangleSurface
{
    static void SideAndAltitude(double side, double att)
    {
        double surface = (side * att) / 2;
        Console.WriteLine("Surface of the triangle by given side and attitude to it: {0:F2}sm", surface);
    }
    static void ThreeSides(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double s = Convert.ToDouble(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        Console.WriteLine("Surface of the triangle by given all its sides: {0:F2}sm", s);
    }

    static void SurfaceByTwoSidesAndAngleBetweenThem(double a, double b, double ang)
    {
        double s = Convert.ToDouble((a * b * Math.Sin(ang)) / 2);
        Console.WriteLine("Surface of the triangle by given two sides and angle between them: {0:F2}sm", s);
    }

    static void Main()
    {
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());
        Console.Write("h=");
        double h = double.Parse(Console.ReadLine());
        Console.Write("angle=");
        double ang = double.Parse(Console.ReadLine());
        double angle = Convert.ToDouble((Math.PI * ang) / 180);

        SideAndAltitude(a,h);
        ThreeSides(a,b,c);
        SurfaceByTwoSidesAndAngleBetweenThem(a, b, angle);

        Console.ReadLine();
    }
}

