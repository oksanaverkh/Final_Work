Main();

void Main()
{
    Console.Clear();
    Console.Write("Enter array length: ");
    int size = GetSize();
    string[] array = GetValues(size);
    Console.Write("");
    PrintArray(array);
    PrintSpecialArray(array);

    int GetSize()
    {
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    string[] GetValues(int m)
    {
        string[] result = new string[m];
        for (int i = 0; i < m; i++)
        {
            Console.Write($"Enter array element {i + 1}: ");
            result[i] = (Console.ReadLine());
        }
        return result;
    }

    void PrintArray(string[] inArray)
    {
        Console.Write("[");
        for (int i = 0; i < inArray.Length - 1; i++)
        {
            Console.Write($"{inArray[i]}, ");
        }
        Console.Write($"{inArray[inArray.Length - 1]}] ");

    }

    void PrintSpecialArray(string[] arr)
    {
        Console.Write("--> [");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                if (i < arr.Length - 1)
                {
                    Console.Write($"{arr[i]}, ");
                }
                else Console.Write($"{arr[i]}");
            }
        }
        Console.Write("]");
    }
}