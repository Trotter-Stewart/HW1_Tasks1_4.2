// MIS 3033 HW1
// Trotter Stewart
// 113499495

double exams;
double examstorage = 0;
int numExams = 1;
string another = "yes";


do
{
    Console.WriteLine($"Please input one exam grade: ");
    exams = Convert.ToDouble(Console.ReadLine());
    examstorage = examstorage + exams;
    Console.WriteLine("Do you have another exam grade? (yes/no)");
    another = Console.ReadLine();
    if( another == "yes" )
    {
        numExams++;
    }

} while (another == "yes");

Console.WriteLine($"The number of exams is {numExams}.");
Console.WriteLine($"The average grade percentage is {((examstorage / numExams) / 100).ToString("P2")}");
Console.ReadKey();
