using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Resume resume = new Resume();
        resume._name = "John Doe";
        resume._jobs.Add(new Job
        {
            _company = "Microsoft",
            _jobTitle = "Data Entry",
            _startYear = 2010,
            _endYear = 2015
        });

        resume._jobs.Add(new Job
        {
            _company = "Google",
            _jobTitle = "Software Developer",
            _startYear = 2015,
            _endYear = 2020
        });
        resume._jobs.Add(new Job
            {
                _company = "Facebook",
                _jobTitle = "Project Manager",
                _startYear = 2020,
                _endYear = 2025
            }  
        );
        resume.Display();

    }


}