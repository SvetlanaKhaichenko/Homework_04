// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

int Sum(int value)
{
    int count = 0;
    if (value < 10) return value;
    else
        while (value > 10)
        {
            int b = value % 10;
            value = value / 10;
            count = count + b;
        }
    return count = count + value;

}

System.Console.WriteLine("Введите число");
int valuePolz = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Sum(valuePolz));




