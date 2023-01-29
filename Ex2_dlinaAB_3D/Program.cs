// Найти расстояние между двумя точками в 3D пространстве.

double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
}

double GetValue (string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double xa = GetValue ("Введите Xa: ");
double ya = GetValue ("Введите Ya: ");
double za = GetValue ("Введите Za: ");
double xb = GetValue ("Введите Xb: ");
double yb = GetValue ("Введите Yb: ");
double zb = GetValue ("Введите Zb: ");

double distance = GetDistance(xa, ya, za, xb, yb, zb);
Console.WriteLine(distance);

