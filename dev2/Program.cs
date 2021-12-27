// Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 26);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int ArraySize(int[] newarray)
{
    int newarraylength = 0;
    for (int i = 0; i < newarray.Length; i++)
    {
        if (newarray[i] > 8)
        {
            newarraylength++;
        }
    }
    return newarraylength;
}

void FillNewArray(int[] array, int[] newarray)
{
    for (int j = 0, k = 0; j < array.Length; j++)
    {
        if (array[j] > 8)
        {
            newarray[k] = array[j];
            k++;
        }
    }
}

void Demo ()
{
    int[] array = new int[25];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine("");
    int[] newarray = new int [ArraySize(array)];
    FillNewArray (array, newarray);
    PrintArray(newarray);
}

Demo ();