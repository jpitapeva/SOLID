namespace SOLID.ISP.GOOD_PRATICE
{
    public interface ISalaryCalculator
    {
        void CalculateSalary();
    }

    public interface IBenefitsCalculator
    {
        void CalculateBenefits();
    }

    public class FullTimeEmployee : ISalaryCalculator, IBenefitsCalculator
    {
        public void CalculateBenefits()
        {
            Console.WriteLine("Calculating benefits for full-time employee");
        }

        public void CalculateSalary()
        {
            Console.WriteLine("Calculating salary for full-time employee");
        }
    }

    public class ContractEmployee : ISalaryCalculator
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Calculating salary for contract employee");
        }
    }
}
