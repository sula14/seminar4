// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int ReadInt(string massage)
{
    System.Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

int num = ReadInt("Введите число");
int res = 0;
while (num > 0)
{
    res = res + num % 10;
    num = num / 10;
}

Console.WriteLine($"Сумма числа равна {res}");