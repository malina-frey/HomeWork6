/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Сейчас будем вводить числа и считать сколько из них больше нуля! Сколько чисел будем вводить ? : ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ОК!Вводи числа!");

int FillNumber(int [] array1)
{
    int Count = 0;
    for (int i = 0; i < M; i++)
    {
        array1[i] = Convert.ToInt32(Console.ReadLine());
        if (array1[i] > 0)
        {
            Count++;
        }
    }
    return Count;
}

void PrintArray(int [] array2)
{
    for (int i = 0; i < M; i++)
    {
        Console.Write(array2[i]);
        if (i != M-1)
        {
            Console.Write(", ");
        }
    }
}

int[] array = new int[M];
int result = FillNumber(array);
PrintArray(array);
Console.Write(" -> " + result);