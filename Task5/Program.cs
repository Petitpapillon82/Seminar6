
//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.Clear();

Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

int [] array1 = FillArray(size, 1, 10);

int [] FillArray(int size, int min, int max){
    int [] result = new int[size];
    for(int i = 0; i < size;i++){
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}
Console.WriteLine(String.Join(" ", array1));
int [] array2 = new int[size];
for(int i = 0; i <size; i++)
{
    array2[i] = array1[i];
}
Console.WriteLine(String.Join(" ", array2));

