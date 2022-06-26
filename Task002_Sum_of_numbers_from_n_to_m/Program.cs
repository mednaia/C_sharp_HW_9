// Найти сумму элементов от M до N, N и M заданы

int SumOfNumbers (int m, int n)
{
    if (m==n) return n;    
    else return n+SumOfNumbers(m,n-1);    
}
Console.WriteLine(SumOfNumbers(1,10));
