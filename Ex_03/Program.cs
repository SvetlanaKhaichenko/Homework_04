//Напишите метод, который задаёт массив из 8 элементов (диапазон от 1 до 100) и выводит их на экран.
//пример вывода

int[] RandomMas()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
    return array;
}

void PrintMas(int[] Mas)
{
    for (int i = 0; i < 1; i++)
    {
        System.Console.Write($"[{Mas[i]}, ");
        for (int j = 1; j < Mas.Length - 1; j++)
        {
            System.Console.Write($"{Mas[j]}, ");
        }
        for (int k = Mas.Length - 1; k < Mas.Length; k++)
        {
            System.Console.Write($"{Mas[k]}]");
        }
    }
}

PrintMas(RandomMas());
