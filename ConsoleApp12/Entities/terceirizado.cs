namespace ConsoleApp12.Entities
{
    class Terceirizado : Funcionario
    {

        public double Bonus { get; set; }
        public double SalarioTerc { get; set; }

        public Terceirizado(string nome, double horas, double valor, double bonus)
            : base(nome, horas, valor)
        {
            Bonus = bonus;
            SalarioTotal = ((horas * valor) / 100) * bonus;
        }
        public override double Salario()
        {
            return SalarioTotal;
        }
    }
}