namespace Exercício3
{
    class Program
    {
        static void Main(string[] args)
        {
           AlbumDeFotos af = new AlbumDeFotos();
           af.DefinirAlbum(40, 71);
           Console.WriteLine("------------------------------");
           AlbumDeFotos af2 = new AlbumDeFotos();
           af2.DefinirAlbum(40, 81);
        }
    }
}