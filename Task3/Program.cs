/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/




/*Console.Clear();
Console.WriteLine("Введите число: ");
int value = int.Parse(Console.ReadLine());
string BinaryCode = Convert.ToString(value, 2);
Console.WriteLine("Число в двоичной системе: ");
Console.WriteLine(BinaryCode);*/


Console.Clear();
Console.WriteLine("Введите число: ");
int value = int.Parse(Console.ReadLine());

string i = " ";

while (value > 0)
{
    if (value % 2 != 0){
        i += "1";
    }
    else{
        i += "0";
    }
    value = value / 2;
}
Console.WriteLine($"в двоичной системе:");
Console.WriteLine(String.Join(" ", i.Reverse()));


