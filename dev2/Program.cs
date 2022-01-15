// Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 16);
    }
}

string PrintArray(int[] array)
{
    string result = "";
    for (int i = 0; i < array.Length; i++)
    {
        result = array[i].ToString();
        Console.Write($" {result} ");
    }
    return result;
}

int[] FillNewArray(int[] array)
{
    int newarraylength = 0;
    for (int i = 0; i < newarray.Length; i++)
    {
        if (newarray[i] > 8)
        {
            newarraylength ++;
        }
    }

    int[] newarray = new int [newarraylength];
    for (int j = 0, k = 0; j < array.Length; j++)
    {
        if (array[j] > 8)
        {
            newarray[k] = array[j];
            k++;
        }
    }
    return newarray;  
}

void Demo ()
{
    int[] array = new int[15];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine("");
    //int[] newarray = new int [ArraySize(array)];
    FillNewArray(array);
    PrintArray(array);
}

Demo ();