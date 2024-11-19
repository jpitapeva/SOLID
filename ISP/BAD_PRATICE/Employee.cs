namespace SOLID.ISP.BAD_PRATICE
{
    public interface IEmployee
    {
        string Name { get; set; }
        void CalculateSalary();
        void CalculateBenefits();
    }

    public class FullTimeEmployee : IEmployee
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CalculateBenefits()
        {
            Console.WriteLine("Calculating benefits for full-time employee");
        }

        public void CalculateSalary()
        {
            Console.WriteLine("Calculating salary for full-time employee");
        }
    }

    public class ContractEmployee : IEmployee
    {
        string IEmployee.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IEmployee.CalculateBenefits()
        {
            //Erro aqui, empregado contratado não tem benefícios(por exemplo ele é PJ), então não faz sentido calcular os benefícios
            throw new NotImplementedException();
        }

        void IEmployee.CalculateSalary()
        {
            Console.WriteLine("Calculating salary for contract employee");            
        }
    }
}
