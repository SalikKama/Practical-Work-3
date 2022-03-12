// 5. Массив из 8-ми элементов, заполненных 0 и 1, вывести на экран
int[] array = new int[8];
Console.WriteLine("Массив:");
for (int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(0,2);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

// 6. Массив из 12 элементов, заполненных числами из [-8,9]. Найти сумму положительных/отрицательных элементов массива.
int[] mass = new int[12];
Console.WriteLine("Массив:");
for (int i = 0; i < 12; i++)
{
    mass[i] = new Random().Next(-8,9);
    Console.Write(mass[i] + " ");
}
Console.WriteLine();
int sum1 = 0;
for (int i = 0; i<12; i++)
{
    if (mass[i] > 0)
    {
        sum1 = sum1 + mass[i];
    }
}
Console.WriteLine("Сумма положительных чисел: " + sum1);
int sum2 = 0;
for (int i = 0; i<12; i++)
{
    if (mass[i] < 0)
    {
        sum2 = sum2 + mass[i];
    }
}
Console.WriteLine("Сумма отрицательных чисел: " + sum2);