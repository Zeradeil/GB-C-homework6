// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int NumMassive = Readnum("Введите размер массива => ");

int[] massive = FillArray(NumMassive);
Print(massive);

System.Console.WriteLine($"=> {PositiveCount(massive, NumMassive)}");

int PositiveCount(int[] massive, int NumMassive)
{
    int count = 0;
    for (int i = 0; i < NumMassive; i++)
    {
        if (massive[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int Readnum(string massage)
{
    System.Console.Write(massage);
    return Convert.ToInt32(System.Console.ReadLine());
}

int[] FillArray(int NumMassive)
{
    int[] array = new int[NumMassive];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Readnum($"Введите {i + 1} число => ");
    }
    return array;

    int Readnum(string massage)
    {
        System.Console.Write(massage);
        return Convert.ToInt32(System.Console.ReadLine());
    }
}

void Print(int[] FillArray)
{
    for (int i = 0; i < massive.Length; i++)
    {
        System.Console.Write($"{massive[i]} ");
    }
}
