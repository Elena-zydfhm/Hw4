//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число => ");
string strInput = Console.ReadLine();
int[] arr = new int[strInput.Length];
for (int i = 0; i < strInput.Length; i++)
{
    arr[i] = Convert.ToInt32(strInput.Substring(i, 1));
}
int Summ()
{
    int sum = 0;
    for (int a = 0; a < arr.Length; a++)
    {
        sum = sum + arr[a];
    }
    return sum;
}
Console.WriteLine(Summ());

