namespace DadosPessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Eve";
            p.DataNascimento = new DateTime(2008, 2, 14);
            p.Altura = 1.60f;

            p.ImprimirDados();

            int idade = p.CalcularIdade();

            Console.WriteLine("Idade: " + idade);

            Console.ReadKey();


        }
    }
}