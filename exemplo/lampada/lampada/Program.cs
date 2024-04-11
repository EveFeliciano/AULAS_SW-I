namespace lampada
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            // INSTÂNCIA DE UM OBJETO
            Lampada lampada1= new Lampada();

            // ACESSANDO UM ATRIBUTO PUBLICO DP OBJETO 
            lampada1.Ligada= true;
            lampada1.Potencia = 150;
            lampada1.Cor = "Vermelha";

            // VIZUALIZANDO OS VALORES DE ATRIBUTOS
            Console.WriteLine("A Lâmpada esta ligada? " + lampada1.Ligada);


        }
    }
}