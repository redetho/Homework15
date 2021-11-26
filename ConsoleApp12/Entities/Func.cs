namespace ConsoleApp12.Entities
{
    abstract class Funcionario
    {
        //guarda a informação de cada funcionário.
        public string Nome { get; set; }
        public double SalarioTotal { get; set; }
        public double Horas { get; set; }
        public double Valor { get; set; }

        protected Funcionario(string nome, double salarioTotal, double valor)
        {
            Nome = nome;
            SalarioTotal = salarioTotal;
            Valor = valor;

        }

        public abstract double Salario();
    }
}