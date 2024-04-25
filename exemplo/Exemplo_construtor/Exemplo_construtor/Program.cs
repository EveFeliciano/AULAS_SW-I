namespace Exemplo_construtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXEMPLO CONSTRUTOR");

            Cliente xyz = new Cliente();

            xyz.Nome = "EVELLYN";
            xyz.Email = "evellyn@gmail.com";
            xyz.Senha = 339030303;

            xyz.MostraDados();
        }
    }
}