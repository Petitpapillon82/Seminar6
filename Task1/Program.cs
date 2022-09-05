//Задача 39: Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1,2,3] -> [3,2,1]
Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

int [] array = FillArray(size, 1, 10);

int [] FillArray(int size, int min, int max){
    int [] result = new int[size];
    for(int i = 0; i < size;i++){
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

Console.WriteLine("Входной массив: ");
Console.WriteLine(String.Join(" ", array));

Console.WriteLine("Полученный массив: ");
Console.WriteLine(String.Join(" ", array.Reverse()));

Console.WriteLine("Полученный массив (2 способ): ");
Console.WriteLine(String.Join(" ", ReverseArray(array))); 

int [] ReverseArray(int [] array){
    int [] result = new int[array.Length];
    for(int i = 0; i < array.Length;i++){
        result[i] = array[array.Length - 1 - i];
    }
    return result;
}
