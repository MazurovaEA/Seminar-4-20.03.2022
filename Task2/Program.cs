// Напишите программу, которая принимает на вход число 
//и выводит количество цифр в числе.

string number = Prompt("Введите число => ");
int len = number.Length;
int temp = int.Parse(number);

int i = 1;

 while (temp / 10 != 0)
{
    temp = temp/10;
    i++;
}

Console.WriteLine($"Количество цифр в числе {number} равно {i}");

//string number = Randomize();      // Вариант с рандомным числом.
//int len = number.Length;          // Вариант с рандомным числом.

//Console.WriteLine($"Количество цифр в числе {number} равно {len}");

string Randomize()
{
    Random rnd = new Random();
    int digit = rnd.Next();
    string newDigit = digit.ToString();
    return newDigit;
}

string Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    return strValue;
}