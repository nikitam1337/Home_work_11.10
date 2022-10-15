// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int[] array = GetArray(8);
PrintArray(array);

///////////////////////// Определение методов /////////////////////////////////////////////
int[] GetArray(int size)
{
    int[] NewArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        int count = i + 1;
        NewArray[i] = GetNumberFromUser("Введите число №", count, "Ошибка ввода!");
    }
    return NewArray;
}

int GetNumberFromUser(string message, int count, string errorMessage)
{
    while (true)
    {
        Console.Write($"{message} {count}  ");
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length-1]); // Добавил три лишние команды Console.Write() для вывода ответа как в задаче.
    Console.Write("]");
}

/*можем упросить Printrray до вида:
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}
*/
