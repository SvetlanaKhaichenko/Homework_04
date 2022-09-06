//Написать метод, принимающий десятиченое представление и основание СС в которую нужно это число перевести, 2<= основание СС<= 9

int LenghtMas(int value, int exponent) //Считает длину необходимого массива
{
    int count = 0;
    while (value >= exponent)
    {
        value = value / exponent;
        count = count + 1;
    }
    return count + 1;
}

int[] ResultMas(int a, int b, int lght) //Создает массив в виде заданной системы СС
{
    int[] Mas = new int[lght];
    for (int i = Mas.Length-1; i >= 0; i--)
    {
        Mas[i] = a % b;
        a = a / b;
    }
    return Mas;
}


void PrintTotal(int[] Mas) //Печает массив в виду числа
{
    for (int i=0; i<Mas.Length; i++)
    {
        Console.Write(Mas[i]);
    }
}
    

System.Console.WriteLine("Введите число, которое необходимо перевести: ");
int value = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите основание системы СС: ");
int baseSs = Convert.ToInt32(Console.ReadLine());
if ( baseSs == 0) System.Console.WriteLine("Ошибка ввода СС");
else
{
int [] Res = ResultMas (value, baseSs, LenghtMas(value, baseSs));
PrintTotal (Res);
}