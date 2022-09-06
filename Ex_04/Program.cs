//Написать метод, принимающий бинарное представление числа
//и возвращающее десятиченое представление числа

int[] ConvertMas(int value, int lenghtmas) //перевод из числа в массив
{
    int[] mas = new int[lenghtmas];
    for (int i = lenghtmas - 1; i > -1; i--)
    {
        mas[i] = value % 10;
        value = value / 10;
    }
    return mas;
}



double Denary(int[] Mas) //перевод в десятичное представление числа
{
    double result = 0;
    double count = 0;
    for (int i = 0; i < Mas.Length; i++)
    {
        count = Math.Pow(2, Mas.Length - i - 1) * Mas[i];
        result = result + count;
    }
    return result;

}

System.Console.WriteLine("Введите число в бинарном представлении");
string binarstr = Console.ReadLine();
int col = binarstr.Length;
int binar = Convert.ToInt32(binarstr);

Console.WriteLine($"В десятичной системе число равно: {Denary(ConvertMas(binar, col))}");







