// 1. Найти кубы чисел от 1 до N
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.WriteLine("Кубы чисел от 1 до N:");
while ( i < N+1 )
{
    Console.Write( i*i*i +" " );
    i++;
}
Console.WriteLine();

// 2. Найти сумму чисел от 1 до A
int A = N;
int sum = 0;
for ( int c = 0; c < A+1; c++ )
{
    sum = sum + c;
}
Console.WriteLine("Сумма чисел от 1 до A: " + sum);

// 3. Подсчитать сумму цифр в числе
int B = new Random().Next(1, 10000);
Console.Write("Сумма цифр числа " + B + " : ");
int S = 0; 
int b = B; 
while ( b > 0)
{
    S = S + b % 10;
    b = b / 10;
}
Console.WriteLine(S);
