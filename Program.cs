void PrintArray(string[] array)
{
    for(int c = 0;c<array.Length;c++)
    {
        Console.Write(array[c]);
        Console.Write(", ");
    }
}

string[] Vvod ()
{
    Console.WriteLine("Введите значения череp запятую в одну строку : ");
    string vvod = Console.ReadLine();
    string[] vvod_array  = (vvod.Split(","));
    return vvod_array;
}

