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

        //calcula e retorna o salário de um funcionário próprio.
        public override double Salario()
        {
            SalarioTotal = Horas * Valor;
            return SalarioTotal;
        }
    }
}
