// MIS 3033 003 HW1
// Trotter Stewart
// 113499495


Console.WriteLine(Factorial(5));





static int Factorial(int n)
{
    int combinedValue = 1;
    int i = n;
    while (i > 0)
    {
        combinedValue = combinedValue * i;
        i--;
    }
    return combinedValue;
}
