/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/



Console.Clear();
Console.WriteLine("введите число ");
int n = Convert.ToInt32(Console.ReadLine());

int fib1 = 0;
int fib2 = 1;
int sum = 0;

while (sum <= n) 
{
    Console.Write(sum);
    sum = fib1 + fib2;
    fib1 = fib2;
    fib2 = sum;                
}

/*
Console.Clear();
Console.WriteLine("введите число ");
int n = Convert.ToInt32(Console.ReadLine());

int fib1 = 0;
//Console.Write("{0} ", fib1);
int fib2 = 1;
//Console.Write("{0} ", fib2);
int sum = 0;

while (n >= sum)
{
    Console.Write(sum);
    sum = fib1 + fib2;
    //Console.Write("{0} ", sum);
    fib1 = fib2;
    fib2 = sum;                
}
*/

/*Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 0;
int Fib1 = 0;
int Fib2 = 1;
while(i<N)
{
Console.WriteLine(Fib1);
Fib2 = Fib1+Fib2;
Fib1 = Fib2-Fib1;
i++;
}
*/
