using System;
using System.Collections.Generic;

namespace Learning02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two Job instances
            Job job1 = new Job();
            job1._company = "Microsoft";
            job1._jobTitle = "Software Engineer";
            job1._startYear = 2019;
            job1._endYear = 2022;

            Job job2 = new Job();
            job2._company = "Apple";
            job2._jobTitle = "Manager";
            job2._startYear = 2022;
            job2._endYear = 2023;

            // Display the job details
            job1.Display();
            job2.Display();

            // Create a Resume instance and add jobs to it
            Resume myResume = new Resume();
            myResume._personName = "Allison Rose";
            myResume._jobs = new List<Job> { job1, job2 };

            // Display the resume
            myResume.Display();
        }
    }
}
