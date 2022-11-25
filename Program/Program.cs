// Написать программу, которая из имеющигося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// ["1234", "1586", "-2"] -> ["-2"]
string[] array1 = new string[5];
// 5 - колличество элементов массива
int len = 3;


for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine()!);
    if (element.Length <= len)
        array1[i] = element;
}

Console.WriteLine();
PrintArray(array1);

void PrintArray(string[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }
    Console.WriteLine();
}