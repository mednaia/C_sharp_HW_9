// Показать натуральные числа от M до N, N и M заданы
string NumbersRec(int m, int n)
{
if (m <= n) return NumbersRec(m + 1, n) + $"{m} ";
else return String.Empty;
}
Console.WriteLine(NumbersRec(12, 55));
