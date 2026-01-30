namespace ARRAYLIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NB - ülesanded kasutavad tsükleid, tingimuslauseid, soovitavalt tee enne vähemalt tsükliteülesandeid ka

            //1. - "artifitsiaalne ebaintelligents"
            //Kirjuta massiiv (Array), milles on sõned. Tekita loend tühjalt, aga tee loendi pikkuseks 5 elementi.
            //Kirjuta for tsükkel, tsükkel peaks käima niikaua kuni massiivis elemente jätkub
            //tsükkel teeb iga elemendi juures järgnevad tegevused
            //- küsib kasutajalt nimisõna
            //- asetab vastavasse järjendi elementi kasutaja sisestuse
            //Kui tsükkel on läbi, kuvatakse kasutajale lause, iga elemendiga:
            // NB [0], [1] jne tekstis väljendab mitmendat elementi massiivist kasutatakse, seal pead ise kirjutama elementide kasutuse õigesti:
            //"Teie päringule [0] kohta oskan ainult vastata nii:\nMinu [2]-süsteem ei taju kuidas [3] on [0]iga seotud, \nja arvan et [0] probleemi lahendaks ära hoopis [4] rakendamine"

            //2. - "Statistikakuvar"
            //Kirjuta loend (List) tüüpi muutuja, milles on komakohaga arvud. Omista selle loendi sisse kolm komakohaga arvu
            //Kuva foreach tsükliga elemendid ükshaavalvälja
            //tekita string-tüüpi muutuja "uusSisestus", hetkel omista muutujasse ""
            //kirjuta while tsükkel, mille tingimus kontrollib, kas kasutaja sisestus ei ole "ei soovi"
            //tsükli sees küsi kasutajalt "kas soovid sisestada veel andmeid? kui ei, kirjuta "ei soovi""
            //tsükli sees omista muutujasse "uusSisestus" käsurea pealt saadud info
            //tsükli sees tee tingimuslause, mis kontrollib, kas "uusSisestus" ei ole "ei soovi"
            //tingimuse täitumisel, lisa loendile otsa element, kasutades selle jaoks muutujat "uusSisestus", ning samaaegselt teisendades muutuja komakohaga arvuks
            //kui while tsükkel lõppeb, kuva nagu alguseski, foreach tsükliga kogu loendi elemendid ükshaaval välja, nüüd kuvades ka juurde lisatud arve


        }
    }
}
