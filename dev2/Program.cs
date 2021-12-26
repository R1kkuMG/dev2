// Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();

int[] array = new int [50];

Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 51);
    Console.Write(" " + array[i] + " ");
}
Console.WriteLine("]");

Console.WriteLine(" ");
Console.Write("[");
for (int j = 0; j < array.Length; j++)
{
    if(array[j] > 8)
    {
        Console.Write(" " + array[j] + " ");
    }
}
Console.Write("]");