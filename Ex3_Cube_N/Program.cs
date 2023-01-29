// Ввести число N и вывести таблицу кубов от 1 до N.

void CubeTable(int x)
{
    for (int i = 1; i<=x; i++)
    {
        Console.WriteLine(i*i*i);
    }
}

Console.WriteLine("Введите N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
CubeTable(number);
