using System.ComponentModel.DataAnnotations.Schema;

namespace HalloWelt
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hallo Welt");

            //Deklanieren
            int alter;

            //Initiolisieren
            alter = 21;

            //Ausgeben
            Console.WriteLine(alter);
            alter = 10;
            Console.WriteLine(alter);

            //Ein Ausdruck ist eien Rechnung die ein Ergebnis liefert

            int zahl = 10 / 5;
            int zahl1 = 20;
            int zahl2 = 5;
            Console.WriteLine(zahl1 * zahl1 + zahl / zahl2);

            //Ein boolescher Ausdruck kann nur "true" oder "false" zurückgeben.
            // kann damit Bedingungen formulieren

            //if abfrage
            if (alter >= 18)
            {
                Console.WriteLine("Du bist alt genug!");
            }
            else
            {
                Console.WriteLine("Du bist nicht alt genug");
            }

            //switch
            int monat = 4;

            switch (monat)
            {
                case 1:
                    Console.WriteLine("Januar");
                    break;

                case 2:
                    Console.WriteLine("Februar");
                    break;

                case 3:
                    Console.WriteLine("März");
                    break;

                case 4:
                    Console.WriteLine("April");
                    break;

                case 5:
                    Console.WriteLine("Mai");
                    break;

                case 6:
                    Console.WriteLine("Juni");
                    break;

                case 7:
                    Console.WriteLine("Juli");
                    break;

                case 8:
                    Console.WriteLine("August");
                    break;

                case 9:
                    Console.WriteLine("September");
                    break;

                case 10:
                    Console.WriteLine("Oktober");
                    break;

                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine("Diesen Monat gibt es nicht");
                    break;
            }

            //While schleife
            int zahl3 = 1;

            while (zahl3 <= 10)
            {
                Console.WriteLine(zahl3);
                zahl3 += 1;
            }

            //Do-While Schleife
            int zahl4 = 1;

            do
            {
                Console.WriteLine(zahl4);
                zahl4 += 1;
            }
            while (zahl4 <= 5);

            //For Schleife

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //1D Arrays
            int[] integerListe = new int[4];

            integerListe[0] = 10;
            integerListe[1] = 20;
            integerListe[2] = 30;
            integerListe[3] = 40;

            Console.WriteLine(integerListe[1]);

            //2D Arrays
            string[,] personenTabelle = new string[3, 2];

            //Zeile 1
            personenTabelle[0, 0] = "Timo";
            personenTabelle[0, 1] = "13";

            //Zeile 2
            personenTabelle[1, 0] = "Max";
            personenTabelle[1, 1] = "14";

            //Zeile 3
            personenTabelle[2, 0] = "Dean";
            personenTabelle[2, 1] = "9";

            Console.WriteLine("Name: " + personenTabelle[0, 0]);
            Console.WriteLine("Alter: " + personenTabelle[0, 1]);

            //Methoden

            Begrüßung("Papa");
            Begrüßung("Mama");

            static void Begrüßung(string name)
            {
                Console.WriteLine("Hallo " + name);
            }

            //Methoden mit Rückgabewert

            Console.WriteLine(Subtraktion(10, 5));

            static int Subtraktion(int zahl5, int zahl6)
            {
                int ergebnis = zahl5 - zahl6;
                return ergebnis;
            }

            //Foreach Schleife

            int[] zahlenListe = new int[5];

            zahlenListe[0] = 10;
            zahlenListe[1] = 20;
            zahlenListe[2] = 30;
            zahlenListe[3] = 40;
            zahlenListe[4] = 50;

            foreach (int zahl7 in zahlenListe)
            {
                Console.WriteLine(zahl7);
            }

            //Klassen

            Person janek = new Person();

            janek.Name = "Janek";
            janek.SageHallo();

            Person Hendrik = new Person();

            Hendrik.Name = "Hendrik";
            Hendrik.SageHallo();

            Auto car = new Auto();

            car.Farbe = "Grün";
            Console.WriteLine(car.Farbe);

            //get und set

            Person2 peter = new Person2();
            peter.Alter = 10;
            Console.WriteLine(peter.Alter);
            
            
            //Methoden in eigenen Klassen
            
            Mensch Jürgen = new Mensch();
            Mensch Hans = new Mensch();
            Jürgen.Name = "Jürgen";
            Hans.Name = "Hansi";
            Hans.Begrüßung();
            Jürgen.Begrüßung();

            Buch lehrbuch = new Buch("Mathematik für Dummis", 250);
            Console.WriteLine(lehrbuch.AnzahlSeiten);
            Console.WriteLine(lehrbuch.Titel);
            
            Katze cat = new Katze();

            cat.Name = "Kimba";
            cat.Mautzen();
            cat.Geschlecht = "Kater";
            cat.Bewegen();

            Console.ReadKey();
        }
    }


    class Person
    {
        //Eigenschaften
        public string Name { get; set; }
        public int Alter { get; set; }

        //Methoden
        public void SageHallo()
        {
            Console.WriteLine(Name + " sagt: Hallo!");
        }
    }

    class Auto
    {
        //Variablen
        private bool motorAn;
        private bool scheibenwischerAn;

        //Eigenschaften
        public string Farbe { get; set; }
        public int PS { get; set; }
        public int AnzahlTüren { get; set; }
    }


    class Person2 
    {

        //Private Variablen
        private int alter;
    
        //Eigenschaften
        public int Alter
        {
            get
            {
                Console.WriteLine("Alter wurde gelesen");
                return alter;
            }
            set
            {
                Console.WriteLine("Alter wurde überschrieben");
                alter = value;
            }
        }
    }

    class Mensch
    {
        //Eigenschaften
        public string Name { get; set; }
        
        //Methoden
        public void Begrüßung()
        {
            Console.WriteLine(Name + " sagt Hallo!");
        }
    }

    class Buch
    {
        //eigenschaften
        public string Titel { get; set; }
        public int AnzahlSeiten { get; set; }
        
        //Konstruktor
        public Buch(string _titel, int _anzahlSeiten)
        {
            Titel = _titel;
            AnzahlSeiten = _anzahlSeiten;
        }
    }

    static class Mathematik
    {
        public static int Addition(int wert1, int wert2)
        {
            return wert1 + wert2;
        }

        public static int Subtraktion(int wert1, int wert2)
        {
            return wert1 - wert2;
        }
        public static int Division(int wert1, int wert2)
        {
            return wert1 / wert2;
        }
        public static int Multiplikation(int wert1, int wert2)
        {
            return wert1 * wert2;
        }
        public static int Modulo(int wert1, int wert2)
        {
            return wert1 + wert2;
        }
    }

    class Tier
    {
        //Eigenschaften
        public string Geschlecht { get; set; }
        
        //Methoden
        public void Bewegen()
        {
            Console.WriteLine("Bewegen...");
        }
    }

    class Katze : Tier
    {
        //Eigenschaften
        public string Name { get; set; }
        
        //Methoden
        public void Schnüffeln()
        {
            Console.WriteLine("Schnüffeln...");  
        }
        public void Mautzen()
        {
            Console.WriteLine("Mautzen...");
        }
    }
}