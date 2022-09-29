
// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Employee : Person
{
    public string JobTitle { get; set; }
    private int _seniorityLevel;

    public int SeniorityLevel
    {
        get { return _seniorityLevel; }
        set
        {
            if (value >= 0 || value < 10)
                _seniorityLevel = value;
        }
    }

    private decimal _salary;
    public decimal Salary 
    {
        get 
        {
            if (SeniorityLevel < 1)
                return _salary;
            else
                return _salary + (_salary * SeniorityLevel * 0.1M);

        }
        set 
        { 
            if(value < 0)
                 throw new ArgumentOutOfRangeException("value");
            _salary = value;
        } 
    }

    public Employee(string name, string jobTitle, decimal salary) : base (name)
    {
        JobTitle = jobTitle;
        Salary = salary;
        SeniorityLevel = 0;
    }

    public virtual decimal CalculateYearlySalary()
    {
        return (Salary + (Salary * SeniorityLevel * 0.1M)) * 12;
    }

    public void IncreaseSeniority()
    {
        if (SeniorityLevel <= 10)
        {
            SeniorityLevel++;
        }
    }


}