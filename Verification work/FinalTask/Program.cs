// Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись искючительно массивами.


string[] SortArray(string[] inputArray, int limit)
{   
    int ArraySize = inputArray.Length;
    string[] tmpArray = new string[ArraySize];
    int count = 0;
    for (int i = 0; i < ArraySize; i++)
    {   
        int RowSize = inputArray[i].Length;
        if (RowSize <= limit)
        {
            tmpArray[count] = inputArray[i];
            count++;
        }   
    }

    string[] outputArray = new string[count];

    for (int i = 0; i < count; i++)
    {   
        outputArray[i] = tmpArray[i];
    }

    return outputArray;
}

void PrintArray(string[] array)
{   
    int size = array.Length;
    Console.Write("[ ");  
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i]+ " ");  
    }
    Console.WriteLine("]");  
}

string[] inputArray = new string[] {"как", "ваши", "дела", "?", "(・`ω´・)", "PC", "RPG"};
Console.WriteLine("Первоначальный массив :");
PrintArray(inputArray);
string[] outputArray = SortArray(inputArray, 3);
Console.WriteLine("Итоговый массив :");
PrintArray(outputArray);
