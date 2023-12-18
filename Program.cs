// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


// void rec (int n, int m)
// {
//     if (n < m)
//         return;
//     else {
//         rec(n-1, m);
//         Console.Write($"{n}, ");
//     }

// }

// Console.Clear();
// Console.Write("Введите значение M: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = int.Parse(Console.ReadLine());
// rec (n, m);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int rec (int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return rec(m - 1, 1);
    else return rec(m - 1, rec(m, n - 1));

}

Console.Clear();
Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());
int x = rec(m,n);
Console.Write(x);

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// void Array (int[] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         array[i] = new Random().Next(-10,11);
//         Console.WriteLine(string.Join(", ", array));
// }

// void PrintArray (int[] array, int Length)
// {
//     if (Length == 0)
//         return;
//     Console.Write($"{array[Length-1]}\t");
//     PrintArray (array, (Length-1));
// }

// Console.Clear();
// Console.Write("Введите количество элементов массива: ");
// int[] a = new int [int.Parse(Console.ReadLine())];
// Array(a);
// Console.Write("Перевернутый массив: ");
// PrintArray (a, a.Length);