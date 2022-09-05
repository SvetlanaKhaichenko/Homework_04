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

string[] mass(string x)
{
    x = x.Replace(" ", "");
    string[] mas = x.Split(",");
    return mas;
}

System.Console.WriteLine("Введите числа через запятую");
string [] prom =  mass (Console.ReadLine());
int a1 = Convert.ToInt32(prom[0]);
int b2 = Convert.ToInt32(prom[1]);

System.Console.WriteLine(res(a1, b2));