// Написать метод, который генерирует массив 0 и 1 заданного количества N
// 3 -> 1 1 0
// 1 0 0
// 0 0 1
int[,] RandomMas(int extent)
{
    int[,] Mas = new int[extent, extent];
    for (int i = 0; i < Mas.GetLength(0); i++)
    {
        for (int j = 0; j < Mas.GetLength(1); j++)
        {
            Mas[i, j] = new Random().Next(0, 2);
        }

    }
    return Mas;
}

void PrintMas(int[,] Mas)
{
    for (int i = 0; i < Mas.GetLength(0); i++)
    {
        for (int j = 0; j < Mas.GetLength(1); j++)
        {
            Console.Write($"{Mas[i, j]} ");
        }
        Console.WriteLine();
    }

}

System.Console.WriteLine("Введите число N");
int value = Convert.ToInt32(Console.ReadLine());

PrintMas(RandomMas(value));
