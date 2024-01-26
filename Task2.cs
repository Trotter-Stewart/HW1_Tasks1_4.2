// MIS 3033 HW1
// Trotter Stewart
// 113499495

double exams;
double examstorage = 0;

for(int i = 1; i < 4; i++)
{
    Console.WriteLine($"Please input exam {i} grade: ");
    exams = Convert.ToDouble(Console.ReadLine());
    examstorage = examstorage + exams;
}

Console.WriteLine($"The average grade percentage is {((examstorage/100) / 3).ToString("P2")}");
Console.ReadKey();
