
/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 
3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении 
не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*/
string[,] CreatStringArray()
{
    Console.WriteLine("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Сформируйте элемент массива: ");
    string user = String.Empty;

    string[,] array = new string[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        { 
                Console.WriteLine("Элемент: ");
                user = Console.ReadLine();
                array[i,j] = user;  

        }
    }
    return array;
}

void ShowArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

string[] NewArray(string[,] array)
{
    Console.WriteLine("Введите длину элемента массива, который или меньше, или равняется трём: ");
    int l = Convert.ToInt32(Console.ReadLine());
    
    int size = array.GetLength(0) * array.GetLength(1);
    string[] newArray = new string[size];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ( array[i,j].Length <= l)
            {
                newArray[count] = array[i,j];
                count++;
                
            }
        }
        
    }
    return newArray;
}

void ShowNewArray(string[] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        Console.Write(newArray[i] + " ");
        Console.WriteLine();
    }
}

string[,] myArray = CreatStringArray();
ShowArray(myArray);

string[] newArray = NewArray(myArray);
ShowNewArray(newArray);