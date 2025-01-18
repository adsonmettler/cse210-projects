using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1._jobTitle = "Software Engineer Jr.";
        job1._company = "Microsoft";
        job1._startYear = 2015;
        job1._endYear = 2020;

        job2._jobTitle = "Software Engineer Sr.";
        job2._company = "Apple";
        job2._startYear = 2021;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Adson Mettler";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}