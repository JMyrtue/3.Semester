
// See https://aka.ms/new-console-template for more information


public class Manager : Employee
{
    public decimal YearlyBonus { get; set; }

    public Manager(string name, string jobTitle, decimal salary, decimal yearlyBonus) 
        : base(name, jobTitle, salary)
    {
        YearlyBonus = yearlyBonus;
    }

    public override decimal CalculateYearlySalary()
    {
        return base.CalculateYearlySalary() + YearlyBonus;
    }
}