using System;

// the responsability of the Job class is to keep track of the person's name asd a list of their jobs.

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear} ({Duration()} years)");
    }
    public int Duration()
    {
        return _endYear - _startYear;
    }
}