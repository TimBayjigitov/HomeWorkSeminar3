// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xLine = x2 - x1;
    double yLine = y2 - y1;
    double zLine = z2 - z1;

    double distQuad = (xLine*xLine + yLine*yLine + zLine*zLine);
    double result = Math.Sqrt(distQuad);

    return result;
}
Console.WriteLine("Input Coordinates: ");
double a1 = Convert.ToInt32(Console.ReadLine());
double b1 = Convert.ToInt32(Console.ReadLine());
double c1 = Convert.ToInt32(Console.ReadLine());
double a2 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double c3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetDistance(a1,b1,c1,a2,b2,c3));