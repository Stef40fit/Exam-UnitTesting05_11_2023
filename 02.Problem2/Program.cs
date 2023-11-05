//. Calculate Average Grade
//Write a program that:
//•	Reads an integer number N (count of the students) from the console
//•	For each student (from first to the last (N)): read from the console his grade (floating-point number) 
//•	Print the average grade of the students, formatted to the second digit








int numberN = int.Parse(Console.ReadLine());
double totalGrade = 0.0;

for (int i = 0; i < numberN; i++)
{
    double grade = double.Parse(Console.ReadLine());
    totalGrade += grade;
}


double averageGrade = totalGrade / numberN;
Console.WriteLine($"{averageGrade:f2}");
