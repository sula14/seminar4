// Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.

int ReadInt(string massage)
{
    System.Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

int a = ReadInt("Введите первое число");
int b = ReadInt("Введите второе число");
int size = 1;
int result = 1;
while (size <= b)
{
    result = result * a;
    size++;
}
Console.WriteLine($"{a},{b} ->{result}");