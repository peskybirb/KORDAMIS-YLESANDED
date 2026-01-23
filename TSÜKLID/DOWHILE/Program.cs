namespace DOWHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Do-while ülesanded*/

            // 1. "arvuta kuni summani"
            // tee muutuja "täisarv" mille sees on täisarv 0
            // kirjuta do while tsükkel
            // tsükli tegevusena lahuta muutujast "täisarv" maha 2
            // ja kuva muutuja "täisarv" välja
            // -> do while tsükli tingimuseks kirjuta kontroll, mis kontrollib kas muutujas "täisarv" on arv miinuses rohkem kui -31
            // peale tsüklit kuva sõnum "tsükkel lõppes"

            /*
            int täisArv = 0;
            do
            {
                täisArv = täisArv - 2;
                Console.WriteLine(täisArv);
            }while (-31 < täisArv);
            Console.WriteLine("TSÜKKEL LÕPPES!");

            */

            // 2. "pikenda sõnumit"
            // tee muutuja "sõnum" mille sees on tühi string, nt ""
            // kirjuta do while tsükkel
            // tsükli tegevusena küsi kasutajalt sõnumile lisa "palun lisa järgmine sõnumi osa
            // lisa muutujasse "sõnum" kasutaja poolt tehtud sisestus
            // kuva muutuja "sõnum" välja
            // -> do while tsükli tingimuseks kirjuta kontroll, mis kontrollib muutuja "sõnum" pikkust .Length abil, kui sõnum on pikem kui 140 tähte, siis tsükkel lõppeb
            // peale tsüklit kuva sõnum "see sõnum enam twitterisse ei mahuks, kirjuta vähem fam"

            string sõnum = string.Empty;      //sama mis "string sõnum = "";"
            do
            {

                Console.WriteLine("Palun lisa sõnumi järgmine osa");
                string sisestus = string.Empty;
                sisestus = Console.ReadLine();
                sõnum += sisestus;
                Console.WriteLine(sõnum);

            } while (sõnum.Length <= 140);

            Console.WriteLine("see sõnum enam twitterisse ei mahuks, kirjuta vähem fam");

        }
    }
}
