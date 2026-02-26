
namespace _0___proov_meetoditega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("baisic ahh calculator");
            //muutujad
            int Arv1 = 0;
            int Arv2 = 0;
            string valik = "";

            //küsime muutujasse väärtused
            Console.WriteLine("Sisesta esimene arv");
            Arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta teine arv");
            Arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("kas soovid liita või lahutada +  -");
            valik = Console.ReadLine();

            //valikus prindime knsoolile välja
            if (valik == "+")
            {
                int summa = Liitmine(Arv1, Arv2);
                Console.WriteLine(summa);
            }
            else if (valik == "-")
            {
                int summa = Lahutamine(Arv1, Arv2);
                Console.WriteLine(summa);
            }
            else
            {
                Console.WriteLine("Pole valikus");
            }
        }

        public static int Liitmine(int arv1, int arv2)
        {
            return arv1 + arv2;
        }
        public static int Lahutamine(int arv1, int arv2)
        {
            return arv1 - arv2;
        }
    }
}
