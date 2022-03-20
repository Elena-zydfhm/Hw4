// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
int Number1 = Prompt("Введите число 1 => ");
int Number2 = Prompt("Введите число 2 => ");
int Number = Number1;
Number1 = Square(Number);
int Square(int Number)
{
    for (int i = 1; i < Number2; i++)
    {
        Number1 = Number1 * Number;
    }
    return Number1;
}
Console.WriteLine(Number1);