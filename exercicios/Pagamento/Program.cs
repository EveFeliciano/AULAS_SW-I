namespace Exercicío4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pagamento p = new Pagamento();
            p.Nome = "Braia";
            p.Sal = 4000;
            p.HED = 0;
            p.HEN = 24;
            p.ND = 0;
            p.Fal = 32;
            p.DE = 5;
            p.REF = 2;
            p.Val = 0;
            Console.WriteLine(p.FolhaDePagamento());
        }
    }
}