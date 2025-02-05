using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment assignment1 = new Assignment();

        assignment1.SetStudentName("Adson Mettler");
        assignment1.SetTopic("Multiplication");

        
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment();

        assignment2.SetStudentName("Roberto Rodriguez");
        assignment2.SetTopic("Fractions");
        assignment2.SetTextBookSection("Section 7.3");
        assignment2.SetProblem("Problem 8-19");

        Console.WriteLine(assignment2.GetHomeworkList());


        WritingAssigment assignment3 = new WritingAssigment();

        assignment3.SetStudentName("Mary Waters");
        assignment3.SetTopic("European History");
        assignment3.SetTitle("The Cause of World War II by Mary Waters");

        Console.WriteLine(assignment3.GetWritingInformation());

    }
}