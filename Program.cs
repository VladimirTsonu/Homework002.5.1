// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int [] NewArray (int size) // Метод для создания и заполнения массива
{
    int [] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Enter {i} the number your array: ");
        int number = Convert.ToInt32(Console.ReadLine());
        myArray[i] = number;
    }
    return myArray;
}

void ShowArray (int [] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {
       Console.Write(arrayPrint[i] + " " );
    }
    Console.WriteLine();
}

int ElementsControl (int [] array)
{
    int elemControl = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            elemControl += 1;
        }
    }
    return elemControl;
}

Console.WriteLine("Enter the size of your array: ");
int my_size = Convert.ToInt32(Console.ReadLine());
int [] newArray = NewArray(my_size);
ShowArray(newArray);
ElementsControl(newArray);
int controlElements = ElementsControl(newArray);
Console.WriteLine($"Quantity elements > 0 in your array is: {controlElements}");
