// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16     

Console.Clear();
int numA = GetNumber1FromUser("Введите целое число A: ", "Ошибка ввода!");
int numB = GetNumber2FromUser("Введите целое число B: ", "Ошибка ввода!");
int power = TheBPower(numA, numB);
Console.WriteLine($"{numA}, {numB} -> {power}");


////////// Определение методов///////////
int GetNumber1FromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetNumber2FromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int TheBPower(int numA, int numB)
{
    int C = 1;
    for (int i = 0; i < numB; i++)
    {
        C = numA * C;
    }
    return C;
}