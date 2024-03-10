using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Bookkeeper";
        job1._company = "Dabane";
        job1._startYear = 2014;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Blenigel";
        job2._startYear = 2020;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Nigel Ndlovu";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}