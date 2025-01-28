namespace FaktorielBul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı girin: ");
            int sayi = int.Parse(Console.ReadLine());

            long sonuc = faktorielBul(sayi);
            Console.WriteLine($"{sayi}!={sonuc}");
            Console.ReadKey();

        }
        public static long faktorielBul(int n)
        {
            long faktoriel = 1;
            for(int a = 1; a<=n; a++)
            {
                faktoriel *= a;
            }
            return faktoriel;
        }
    }
}
