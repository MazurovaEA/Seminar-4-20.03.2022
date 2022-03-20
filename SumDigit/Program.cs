// Напишите программу, которая принимает на вход число (А)
// и выдает сумму числео от 1 до А

int number = Prompt ("Введите число => ");
Console.WriteLine($"Сумма чисел от 1 до {number} равна {NumberSumm(number)}");


int NumberSumm(int digit)
{
   int sum = 0;
for (int i = 1; i <= digit; i++)
{
    sum += i;
} 
return sum;
}

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

