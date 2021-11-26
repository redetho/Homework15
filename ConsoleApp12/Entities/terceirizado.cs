namespace ConsoleApp12.Entities
{
    class Terceirizado : Funcionario
    {

        //calcula o salário do funcionário terceirizado com bônus de 110%
        public double Bonus { get; set; }
        public double SalarioTerc { get; set; }

        public Terceirizado(string nome, double horas, double valor, double bonus)
            : base(nome, horas, valor)
        {
            Bonus = bonus;
            SalarioTotal = ((horas * valor) / 100) * bonus;
        }
        //devolve o salário total do funcionário terceirizado.
        public override double Salario()
        {
            return SalarioTotal;
        }
    }
}