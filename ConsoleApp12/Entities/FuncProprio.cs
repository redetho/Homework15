namespace ConsoleApp12.Entities
{
    class FuncProprio : Funcionario
    {

        public FuncProprio(string nome, double horas, double valor)
            : base(nome, horas, valor)
        {
            Nome = nome;
            Horas = horas;
            Valor = valor;
        }

        public override double Salario()
        {
            SalarioTotal = Horas * Valor;
            return SalarioTotal;
        }
    }
}
