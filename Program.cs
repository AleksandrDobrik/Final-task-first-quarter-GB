// Из массива строк сформируйте массив из строк длина которых меньше либо равна 3 символа

int RL () // READLINE
{
    int n;
    Console.WriteLine("Enter number ");
    return n = Convert.ToInt32(Console.ReadLine());
}

void PrintArray(string[] array)
{
    Console.Write(" [ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void FillingArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Enter {i + 1} element array "); 
        array[i] = Console.ReadLine();
    }
    Console.WriteLine("Thanks!");
}

int CountLenghtString(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) count += 1;
    }
    return count;
}

void FillingEndArray(string[] array, string[] endArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            endArray[count] = array[i];
            count +=1;
        }
    }
}

Console.WriteLine("Hello, enter lenght array string ");
int lenghtArray = RL();
string[] newArray = new string[lenghtArray];
FillingArray(newArray);
PrintArray (newArray);
int lenghtEndArray = CountLenghtString(newArray);
string[] endArray = new string [lenghtEndArray];
FillingEndArray(newArray, endArray);
PrintArray (endArray);
