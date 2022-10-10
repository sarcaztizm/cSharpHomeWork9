// Задать значения M и N. Написать программу, которая найдет
// сумму натуральных чисел в промежутке от M до N.

Console.Clear();
int sum = 0;
int SumForMtoN (int M, int N)
{
    if (M > N) return sum;
    else    return sum + M + SumForMtoN(M+1,N); 
}

Console.WriteLine("Введите числа M и N:");
int numberM = Convert.ToInt32(Console.ReadLine());
int numbetN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumForMtoN(numberM, numbetN));

