// Ввести пятизначное число. Проверить, является ли оно палиндромом.

void Palindrome(int n)
{
    int x1 = n / 10000;
    int x5 = n % 10;
    int x2 = n / 1000 % 10;
    int x4 = n / 10 % 10;
    if ((x1 == x5) && (x2 == x4))
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrome(number);
