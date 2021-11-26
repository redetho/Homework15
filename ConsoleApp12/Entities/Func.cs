namespace ConsoleApp12.Entities
{
    abstract class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioTotal { get; set; }
        public double Horas { get; set; }
        public double Valor { get; set; }

        public Funcionario()
        {
        }

        protected Funcionario(string nome, double salarioTotal, double valor)
        {
            Nome = nome;
            SalarioTotal = salarioTotal;
            Valor = valor;

        }

        public abstract double Salario();
    }
}