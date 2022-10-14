//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
int num = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int sum = SumNumbers(num);

Console.WriteLine($"{num} -> {sum}");

////////// Определение методов///////////

int GetNumberFromUser(string message, string errorMessage)
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

int SumNumbers(int num)
{
    int sum = 0;
    while (num / 10 > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    sum = sum + num % 10;
    return sum;
}