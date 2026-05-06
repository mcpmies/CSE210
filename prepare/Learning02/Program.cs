using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Adobe";
        job1._startYear = 2010;
        job1._endYear = 2015;

        Job job2 = new Job();
        job2._jobTitle = "Computer Scientist";
        job2._company = "Microsoft";
        job2._startYear = 2016;
        job2._endYear = 2026;

        Resume resume1 = new Resume();
        resume1._name = "John Smith";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}