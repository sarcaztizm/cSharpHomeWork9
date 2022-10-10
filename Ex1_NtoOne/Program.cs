// Задать значение N. НАписать программу, которая выведет
// все натуральные числа в промежутке от N до 1.

Console.Clear();

Console.WriteLine("Введите число N:");
int myNumber = Convert.ToInt32(Console.ReadLine());
string lineIntNum = String.Empty;

void PrintNumbers (int num)
{
    if (num == 0) Console.WriteLine (lineIntNum);
    else
    {
        lineIntNum = lineIntNum + " " + Convert.ToString(num);
        PrintNumbers(num -1);
    }
}

PrintNumbers(myNumber);

