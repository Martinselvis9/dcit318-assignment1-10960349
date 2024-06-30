using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("WELCOME TO GRADE CALCULATOR");
        Console.WriteLine("Please Enter a numerical grade between 0 and 100:");
        int grade = int.Parse(Console.ReadLine());

        char letterGrade = GetLetterGrade(grade);

        Console.WriteLine($"Letter Grade: {letterGrade}");
    }

    static char GetLetterGrade(int grade)
    {
        if (grade >= 90) return 'A';
        if (grade >= 80) return 'B';
        if (grade >= 70) return 'C';
        if (grade >= 60) return 'D';
        return 'F';
    }
}
