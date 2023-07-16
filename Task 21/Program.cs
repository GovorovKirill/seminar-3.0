// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки A: ");
Console.Write("X: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки A: ");
Console.Write("Y: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки A: ");
Console.Write("Z: ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B: ");
Console.Write("X: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B: ");
Console.Write("Y: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B: ");
Console.Write("Z: ");
int Z2 = Convert.ToInt32(Console.ReadLine());

double dist = GetDistance (X1, Y1, Z1, X2, Y2, Z2);
double distRound = Math.Round(dist, 2, MidpointRounding.ToZero);
Console.Write("расстояние между точками A и B: " +distRound);

double GetDistance (int x1, int x2, int y1, int y2, int z1, int z2) 
{
    double firstDiffCoordinate = x2 - x1;
    double secondDiffCoordinate = y2 - y1;
    double thirdDiffCoordinate = z2 - z1;
    double distance = Math.Sqrt(firstDiffCoordinate * firstDiffCoordinate + secondDiffCoordinate * secondDiffCoordinate + thirdDiffCoordinate * thirdDiffCoordinate);
    return distance;  
}

