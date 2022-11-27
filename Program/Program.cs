// Написать программу, которая из имеющигося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// ["1234", "1586", "-2"] -> ["-2"]

Console.WriteLine("Введите размернотсь массива; ");
int size = Convert.ToInt32(Console.ReadLine()!);
string[] array1 = new string[size];
int len = 3;// - какой размерности элемент записывать в конечный массив

SecondArray(array1, size);
Console.WriteLine();
PrintArray(array1);

void SecondArray(string[] array, int size)
{

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент: ");
        string element = Convert.ToString(Console.ReadLine()!);
        if (element.Length <= len)
            array1[i] = element;
    }

}

void PrintArray(string[] array)
{
    array = array.Where(x => !string.IsNullOrEmpty(x)).ToArray();
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"|{array[j]}| ");
    }
    Console.WriteLine();
}