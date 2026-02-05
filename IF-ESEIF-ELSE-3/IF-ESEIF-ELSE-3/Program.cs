namespace IF_ESEIF_ELSE_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. kasutajapikkus*/
            //Küsi kasutajalt tema pikkust
            //kui ta on lühem kui 0cm, ütle võimatu pikkus
            //kui ta on lühem kui 1m, ütle juntsu
            //kui ta on lühem kui 2m, ütle tavaline kolge
            //kui ta on pikem kui 2m, ütle hiiglane

            Decimal Pikkus = 0;
            Console.WriteLine("palun sisesta oma pikkus (sentimeetrites)");
            Pikkus = Decimal.Parse(Console.ReadLine());

            if (Pikkus <= 0)
            {
                Console.WriteLine("Madalam kui muru");
            }
            else if (Pikkus >= 1 && Pikkus < 100)
            {
                Console.WriteLine("Juntsu");
            }
            else if (Pikkus >= 101 && Pikkus < 200)
            {
                Console.WriteLine("Tavaline kolge");
            }
            else
            {
                Console.WriteLine("Hiiglane");
            }


            /*2. sõnum noorukile*/
            //küsi kasutajalt kui vana ta on
            //küsi kasutajalt praegust aastaarvu
            //lahuta aastast kasutaja vanus
            //kui kasutaja on sündinud 2025-2020, ütle talle, kes sulle arvuti juba andis
            //kui kasutaja on sündinud 2020-2015, ütle talle, skibidi sigmaless
            //kui kasutaja on sündinud 2015-2010, küsi talt kas ta tahab saada programmeerijaks
            //    kui jah, ütle tubli
            //    kui ei, ütle kahju
            //kui kasutaja on sündinud enne 2010, küsi mitu rage comicsit ta täna oma redditi lugemise ajal leidis 




            /*3. suunakoodituvasti*/
            //küsi kasutajalt tema elukoha suunakoodi
            //kui suunakood on väiksem kui 5 tähte, ütle talle, 1 täht on puudu
            //kui suunakood on suurem kui 5 tähte, ütle talle, 1 täht on üle
            //kui suunakoodis on 5 tähte, ütle "ahha nüüd tean kus elad"
            /*

            // võib natukene erineda kuna võtsin programmi oma repost

            int suunaKood = 0;
            // "int" on täisarvuline muutuja mille järele pannakse selle nimetus.
            // "=" ühekordne võrdusmärk omistab muutuja sisse väärtuse mis on peale       võrdusmärki.
            // hetkel sisestatakse muutujasse "suunaKood" väärtus "0".
            // Lause lõpetab lasuselõpu märk ";".

            Console.WriteLine("Palun sisesta oma suunakood");
            // "Coonsole" on C# käsurea addresseerimise pakett millega saab teha erinevaid operatsioone.
            // "." punkti kasutatakse et lisada eelnevale "Console" käsule mingisugune funktsioon.
            // "WriteLine" on funktsioon mis kuvab väärtusi käsureale (uuele reale.)
            // "()" sulupaar omab funktsiooni tööks vajalikku infot.
            // "" tähistab sõne tüüpi andmeid . Andmed ise asuvad jutumärkide vahel.
            // ";" lause lõpetab lauselõpu märk.

            suunaKood = int.Parse(Console.ReadLine());
            // "suunaKood" on eelnevalt väljatoodud täisarvuline muutuja.
            // "=" ühekordne võrdusmärk omistab muutuja sisse väärtuse mis on peale võrdusmärki.
            // "int" tähistab täisarvulist muutujat.
            // "." punkti kasutatakse et saada punktist eelnevale meetodile mingi funktsioon mis kirjutatakse pärast punkti.
            // "Parse" on tekstist katse teisendada mingit tüüpi arvandmeid.
            // "()" sulupaar omab funktsiooni tööks vajalikku infot.
            // "Coonsole" on C# käsurea addresseerimise pakett millega saab teha erinevaid operatsioone.
            // "." punkti kasutatakse et saada punktist eelnevale meetodile mingi funktsioon mis kirjutatakse pärast punkti
            // "ReadLine" on funktsioon mis loeb käsureale vaikimisi sõne tüüpi andmeid.
            // "()" sulupaar omab funktsiooni tööks vajalikku infot.
            // ";" lause lõppeb lauselõpu märgiga.

            if (suunaKood > 9999 && suunaKood < 10000)
            // "if" on kaitstud sõna mis kutsub esile tingimus lause mille tingimusavaldis on sellele järgnevate sulgude sees.
            // "()" sulupaar omab funktsiooni tööks vajalikku infot.
            // "suunaKood" on eelnevalt välja toodud täisarvuline muutuja.
            // ">" ehk suurem kui märgist vasakul pool olev väärtus peab olema suurem kui märgist paremal pool olev väärtus et tehe oleks tõene.
            // "9999" hard kooditud väärtus mida võrreldakse täisarvulise muutuja  "suunaKood" vastu
            // "&&" ehk AND loogiline tehe mida kasutatakse tingimuste kirjutamisel. See annab positiivse vastuse kui mõlemal pool märki olevad vastused on ka positiivsed.
            // "suunaKood" on eelnevalt välja toodud täisarvuline muutuja.
            // "<" ehk väiksem kui märgist vasakul pool olev väärtus peab olema väiksem kui märgist paremal pool olev väärtus et tehe oleks tõene.
            // "10000" hardkooditud väärtus mida võrreldakse täisarvulise muutuja  "suunaKood" vastu.

            {
            // "{" loogiline sulg tähistab koodi ploki konteineri algust 

                Console.WriteLine("Nüüd ma tean kus sa elad");
                // "Coonsole" on C# käsurea addresseerimise pakett millega saab teha erinevaid funktsioone.
                // "." punkt on eelmise elemendi addreseerimiseks et saaks lisada sellele mingisuguse meetod funktsiooni.
                // "WriteLine" on funktsioon mida kasutatakse käsureale teksti või ka kaasatud parameetrite kuvamiseks.
                // "()" sulupaar omab funktsiooni tööks vajalikku infot.
                // "Nüüd ma tean kus sa elad" on sõne tüüpi muutuja mida parasjagu kuvatakse käsureale.
                // ";" koodirea lõpeta lauselõpumärgiga

            }
            // "}" loogiline sulg tähistab koodi ploki konteineri lõppu

                 else if (suunaKood <= 9999)
            // "else if" on kaitstud sõna ja sekundaarne tingimuslause mille tingimus on selle järele kirjutatud sulgude vahel. enne else if peab eelnema kas "if" või teine "else if". Tingimuse "False" korral liigutakse edasi ja ei täideta "else if" sees olevat koodi plokki. (viimane lause käib ka "if" kohta)  
            // "()" sulupaar omab funktsiooni tööks vajalikku infot.
            //"suunaKood" on eelnevalt välja toodud täisarvuline muutuja.
            // "<=" ehk väiksem kui või võrdne . Kontrolib kas märgist vasakul pool olev väärtus või muutujas olev väärtus on väiksem kui või võrdne paremal pool oleva väärtusega.
            // "9999" hard kooditud väärtus mid avõrreldakse väärtusega mis on muutujas "suunaKood".

            {
                // "{" loogiline sulg tähistab koodi ploki konteineri algust 

                Console.WriteLine("üks täht on puudu");
                // "Console" on C# käsurea addresseerimise pakett millega saab teha erinevaid funktsioone.
                // "." punkt on eelmise elemendi addreseerimiseks et saaks lisada sellele mingisuguse meetod funktsiooni.
                // "WriteLine" on funktsioon mida kasutatakse käsureale teksti või ka kaasatud parameetrite kuvamiseks.
                // "()" sulupaar omab funktsiooni tööks vajalikku infot.
                // "üks täht on puudu" on sõne tüüpi muutuja mida parasjagu kuvatakse käsureale (kui just programm on sinnamaani jõudnud).
                // ";" koodirea lõpeta lauselõpumärgiga

            }
            // "}" loogiline sulg tähistab koodi ploki konteineri lõppu

            else
            // "else" on kaitstud sõna mis kutsub esile järeltingimus lause millele peab eelnema kas "if" või "else if" tingimuslause . "Else" koodiploki sisu täidetakse ilma selle oma tingimuse kontrollita (ehk kasutatakse viimasena kui kõik tingimused on läbikukkunud).

          {
          // "{" loogiline sulg tähistab koodi ploki konteineri algust 

                  Console.WriteLine("üks täht on üle");
                // "Console" on C# käsurea addresseerimise pakett millega saab teha erinevaid funktsioone.
                // "." punkt on eelmise elemendi addreseerimiseks et saaks lisada sellele mingisuguse meetod funktsiooni.
                // "WriteLine" on funktsioon mida kasutatakse käsureale teksti või ka kaasatud parameetrite kuvamiseks.
                // "()" sulupaar omab funktsiooni tööks vajalikku infot.
                // "üks täht on üle" on sõne tüüpi muutuja mida parasjagu kuvatakse käsureale (kui just programm on sinnamaani jõudnud).
                // ";" koodirea lõpeta lauselõpumärgiga

            }
            // "}" loogiline sulg tähistab koodi ploki konteineri lõppu
            */




            /*4. töökoht*/
            //küsi kasutajalt kas ta töötab
            //kui kasutaja vastab jah, siis ütle tubli
            //kui kasutaja vastab ei, siis ütle, kahju, miks sa siis töökohta ei otsi?
            //kui kasutaja vastab otsin, siis ütle, loodan et saad varsti tööle c:



            /*5. 2FA autentija */
            //küsi kasutajalt tema parooli
            //seejärel küsi kasutajalt tema 2FA koodi,
            //kui parool on vale, ütle sissepääs keelatud
            //kui parool on õige, kontrolli 2FA koodi:
            //  kui 2FA kood on lühem kui 6 tähte, ütle sissepääs keelatud, kood on liiga lühike
            //  kui 2FA kood on pikem kui 6 tähte, ütle sissepääs keelatud, kood on liiga pikk
            //  kui 2FA kood on 6 tähte, siis lase sisse, öeldes "oled sissepääsenud"
            //NB: 2FA kood ei pea matchima eksisteeriva näitega nagu parool.

            string Parool = "";
            string TFA = "";

            Console.WriteLine("Mis on su parool?");
            Parool = Console.ReadLine();

            Console.WriteLine("Mis on sinu 2FA kood");
            TFA = Console.ReadLine();

            if(Parool == "V4G47UG3VPAR00L")
            {
                if (TFA.Length < 6)
                {
                    Console.WriteLine("2FA pikkus on liiga lühike");
                }
                else if (TFA.Length > 6)
                {
                    Console.WriteLine("2FA pikkus on liiga pikk");
                }
                else
                {
                    Console.WriteLine("Olete edukalt sisseloginud");
                }

            }
            else
            {
                Console.WriteLine("Sissepääs keelatud");
            }

        }
    }
}
