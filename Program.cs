// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string [] CreateArray()
{
    System.Console.WriteLine("Введите длину массива");
    int sizeArray = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        string input =  Console.ReadLine();
        // if (input == "end") break;
        array[i] = input;
    }
    return array;
}

string [] FormateArray(string [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            array[count] = array[i];
            count++;
        }
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

string [] createArray = CreateArray();
string [] formateArray = FormateArray(createArray);
PrintArray(createArray);
System.Console.WriteLine();
PrintArray(formateArray);

