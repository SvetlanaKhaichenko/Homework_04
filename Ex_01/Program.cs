//Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//нельзя использовать pow
//3, 5 -> 243 (3⁵)

//2, 4 -> 16
int res(int x, int y)
{
    int result = x;
    for (int i = 1; i < y; i++)
    {
        result = result * x;
    }
    return result;

}
System.Console.WriteLine("Введите числа через запятую");
string first = Console.ReadLine();
first = first.Replace(" ", "");
string[] mas = first.Split(",");
string a = mas[0];
string b = mas[1];
int a1 = Convert.ToInt32(a);
int b2 = Convert.ToInt32(b);

System.Console.WriteLine(res(a1, b2));