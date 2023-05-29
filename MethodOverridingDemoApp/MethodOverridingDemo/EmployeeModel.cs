namespace MethodOverridingDemo
{
    public class EmployeeModel : PersonModel
    {
        public decimal HourlyRate { get; set; }
        public virtual decimal GetPaycheckAmount(int hoursWorked) // virtual allows us to override
        {
            return HourlyRate * hoursWorked;
        }
    }
}