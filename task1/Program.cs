// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int NumMassive = Readnum("Введите размер массива => ");

int[] massive = FillArray();
PrintArray(massive);
delegate int input();
input inp = new (Readnum);
int Readnum(string massage)
{
    System.Console.Write(massage);
    return Convert.ToInt32(System.Console.ReadLine());
}


int[] FillArray(int inp)
{
    int[] array = new int[NumMassive];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Readnum();
    }
    return array;
}

void PrintArray(int[] FillArray)
{
    for (int i = 0; i < massive.Length; i++)
    {
        System.Console.Write($"{massive[i]} ");
    }
}
