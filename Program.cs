// // Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// // Примеры:
// // [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] “”
// // [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// // [“Russia”, “Denmark”, “Kazan”] → []

string[] CreateArray()
{
    int sizeArray = 0;
    while (sizeArray < 1) // && Console.ReadKey().Key == ConsoleKey.Enter)
    {
        System.Console.Write("Введите длину массива: ");
        sizeArray = Convert.ToInt32(Console.ReadLine());
    }

    string[] array = new string[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        System.Console.Write($"Введите значение {i + 1}: ");
        string input = Console.ReadLine()!;
        if (string.IsNullOrEmpty(input)) break;
        array[i] = input;
    }
    return array;
}

string[] FormatArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != null && array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] formattedArray = new string[count];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != null && array[i].Length <= 3)
        {
            formattedArray[index] = array[i];
            index++;
        }
    }
    return formattedArray;
}

void PrintArray(string[] array)
{
    int i = 0;
    System.Console.Write("[");
    for (; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.Write($"“{array[i]}”");
        else
            Console.Write($"“{array[i]}”, ");
    }
    System.Console.Write("]");
}

void Main()
{
    string[] createArray = CreateArray();
    string[] formatArray = FormatArray(createArray);
    System.Console.Write("Ваш массив: ");
    PrintArray(createArray);
    System.Console.WriteLine();
    System.Console.Write($"Массив из {formatArray.Length} элементов в котором длинна каждого элемента не превышает трех значений: ");
    PrintArray(formatArray);
}

Main();