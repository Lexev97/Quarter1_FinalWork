string[] FilterArray(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }

    string[] filtredArr = new string[count];
    count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            filtredArr[count] = array[i];
            count++;
        }
    }

    return filtredArr;
} 

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

string[] arr = {"Hello", "97", "world", ":-)"};
PrintArray(arr);
string[] filtredArr = FilterArray(arr);
Console.Write(" -> ");
PrintArray(filtredArr);
