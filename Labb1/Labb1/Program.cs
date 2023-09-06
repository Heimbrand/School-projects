

void labbinfo()
{
    //Skapa en konsollapplikation som tar en textsträng (string) som argument till Main eller uppmanar användaren mata in en sträng i konsollen.
    //Textsträngen ska sedan sökas igenom efter alla delsträngar som är tal som börjar
    //och slutar på samma siffra, utan att start/slutsiffran, eller något annat tecken än
    //siffror förekommer där emellan.
    //ex. 3463 är ett korrekt sådant tal, men 34363 är det inte eftersom det finns
    //ytterligare en 3:a i talet, förutom start och slutsiffran. Strängar med bokstäver i
    //t.ex 95a9 är inte heller ett korrekt tal.

    //Exempel output för input ”29535123p48723487597645723645”:

    //Programmet ska också addera ihop alla tal den hittat enligt ovan och skriva ut det
    //    sist i programmet.Gör gärna en tom rad emellan för att skilja från output ovan.
    //Exempel output för input ”29535123p48723487597645723645”:
    //Total = 5836428677242
}
void pseudokod()


{

    //+  gör en text som ber användaren skriva in en strängtext
    //+  gör en readline med en strängvariabel som läser in strängtexten
    //+  spara strängtextvariabeln i en array som jag kan använda till loopen för varje iteration
    //+  skriv ett programm med villkor som går igenom och fångar upp de gemensamma nämnarna
    //+  gör en loop för varje iteration av genomsökning som jobbar sig igenom strängtexten
    //+  gör en loop som adderar alla tal som programmet har fått fram
    //+  gör ett villkor som tvingar de gemensamma nämnarna att vara minst 100-tal



}

Console.WriteLine("Skriv in en sträng");
string inputtedstring = Console.ReadLine();

//Hur gör jag om inputtedstring till en array härifrån?

int[] b = new int[4] {1, 2, 6, 5 };

for (int i = b.Length - 1; i > 0; i--)  
{
    for (int j = 0; j < b.Length; j++) 
    {
        if (b[i] == b[j])
        {
            Console.WriteLine(b);
        }
    }
}