string[] CreateArray(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива №{i + 1}:  ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}
void PrintArray(string[] array)
{
    Console.Write("[\"");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}\", \"");
        else Console.Write($"{array[i]}");
    }
    Console.Write("\"]");

}
int SizeNewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 && array[i].Length != 0) count++;
    }
    return count;
}
string[] ChangeElementLenghtNotMore3(string[] array, int count)
{

    string[] newArr = new string[count];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 && array[i].Length != 0)
        {
            newArr[index] = array[i];
            index++;
        }
    }
    return newArr;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size < 1)
    Console.WriteLine("Введите число больше 0");
else
{
    string[] array = CreateArray(size);
    PrintArray(array);

    int countNewArray = SizeNewArray(array);
    if (countNewArray > 0)
    {
        string[] newArray = ChangeElementLenghtNotMore3(array, countNewArray);
        Console.Write(" -> ");
        PrintArray(newArray);
    }
    else Console.Write(" -> []");
}