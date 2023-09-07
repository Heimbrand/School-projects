

void övningsuppgift1()
{
    // Uppgift 1

    //skriv ett program som frågar efter användarens namn och skriver ut en hälsning på konsolen.
    //om namnet är "david" ska det skriva ut "hej david!"

    Console.WriteLine("Hej, vad heter du?");
    string name = Console.ReadLine();
    Console.WriteLine("Hej, " + name + "!");
}  //program som ber användaren skriva in ett namn, sedan returnar programmet namnet som användaren skrev
void övningsuppgift2()
{
    //Uppgift 2

    //Skriv ett program som frågar användaren efter ett lösenord. 
    //Hitta på ett hemligt lösenord och spara det i en variabel. 
    //När användaren har skrivit in ett lösenord ska programmet jämföra med det sparade lösenordet och skriva ut om det var rätt eller inte. 
    //Använd en if-sats.

    string password = "Bajskorv";
    Console.WriteLine("Skriv in ditt lösenord");
    string inputtedpassword = Console.ReadLine();

    if (password == inputtedpassword)
    {
        Console.WriteLine("Korrekt lösenord");
    }
    else if (password != inputtedpassword)
    {
        Console.WriteLine("Fel läsenord");
    }
} //skriv ett program som ber om ett lösen, om det är rätt så skrivs det, om det är fel so skrivs det med
void övningsuppgift3()
{
    //Uppgift 3

    //Skriv ett program som frågar användaren efter ett tal. 
    //Det ska skriva ut om talet är mindre än 100, lika med 100 eller större

    Console.WriteLine("Skriv en siffra mellan 1 och 100");
    double inputtednumber = double.Parse(Console.ReadLine());


    if (inputtednumber < 100)
    {
        Console.WriteLine("Siffran du skrev var lägre än 100");
        Console.WriteLine("Du skrev: " + inputtednumber);
    }
    else if (inputtednumber > 100)
    {
        Console.WriteLine("Din siffra var högre än 100");
        Console.WriteLine("Du skrev: " + inputtednumber);
    }
    else if (inputtednumber == 100)
    {

        Console.WriteLine("Du skrev: " + inputtednumber);
    }
    else
    {
        Console.WriteLine("Du skrev inte någon siffra:(");

    }
}// program som ber om ett tal. programmet skriver sedan ut om talet var > < eller == med 100
void övningsuppgift4()
{
    //Uppgift 4

    //Uppdatera programmet i uppgift 1 så att det även frågar efter ett tal. 
    //Skriv hälsningen så många gånger som användaren anger.


    Console.WriteLine("Hej, vad heter du?");
    string name = Console.ReadLine();
    Console.WriteLine("Hej, " + name + "!");
    Console.WriteLine("Skriv in en siffra");
    int num = int.Parse(Console.ReadLine());

    for (int i = 0; i < num; i++)
    {
        Console.WriteLine("Hej, " + name + "!");

    }
} //program som skriver en hälsning, sedan skriver man ett tal och efter det skrivs samma hälsning så lika många gånger som talet man angav
void övningsuppgift5()
{
    //Uppgift 5

    //Skriv ett program som upprepade gånger frågar användaren efter ett tal ända till man skriver något som inte är ett tal (t.ex bara trycker enter). 
    //Efter varje inmatning ska summan av alla tal som matats in skrivas ut, innan nästa inmatning efterfrågas. 
    //Innan programmet avslutas ska man även skriva ut medelvärde av de inmatade talen. Hint: TryParse()



    string inputtedvalue = "";
    int num;
    int sum = 0;
    int iterations = 0;
    int.TryParse(inputtedvalue, out num);
    bool correctinput = true;
    while (correctinput)
    {
        Console.WriteLine("Skriv in ett tal");
        inputtedvalue = Console.ReadLine();



        if (int.TryParse(inputtedvalue, out num))
        {
            Console.WriteLine("Du skrev in talet: " + inputtedvalue);
            sum = sum + num;
            Console.WriteLine("Summan av dina tal är: " + sum);
            iterations++;

        }
        else
        {
            Console.WriteLine("Du skrev inte in ett tal");
            int avg = sum / iterations;
            Console.WriteLine("Medelvärdet av dina inskrivna tal är: " + avg);
            correctinput = false;
        }
    }
} // ber användaren skriva in ett tal, sedan ett till tal och så fortsätter den så. för varje tal som skrivs in adderar man alla tal. program avslutas när man inte skriver ett tal
void övningsuppgift6()
{
    //Uppgift 6

    //Skriv ett program som först frågar efter ett tal, sedan frågar efter ett av följande tecken: +, -, *eller /
    //Därefter ska ytterligare ett tal efterfrågas. Programmet ska fungera som en simpel miniräknare. 
    //Om man t.ex matat in först 3, sedan *, och sist 5, så ska programmet skriva ut: 3 * 5 = 15.

    double firstInput;
    double secondInput;
    double inputSum;
    string calculator;

    try
    {

        Console.WriteLine("Hej och välkomna till abrahams magiska matteäventyr");
        Console.WriteLine("Skriv ett tal");
        firstInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Kanon, nu skall du skriva in en operand!");
        calculator = Console.ReadLine();
        Console.WriteLine("Mycket bra! skriv nu ett till tal");
        secondInput = Convert.ToDouble(Console.ReadLine());

        if (calculator == "+")
        {
            inputSum = firstInput + secondInput;
            Console.WriteLine("additionen av dina tal är: " + inputSum);
        }
        else if (calculator == "-")
        {
            inputSum = firstInput - secondInput;
            Console.WriteLine("Subtrationen av dina tal är: " + inputSum);
        }
        else if (calculator == "/")
        {
            inputSum = firstInput / secondInput;
            Console.WriteLine("Divisionen av dina tal är: " + inputSum);
        }
        else if (calculator == "*")
        {
            inputSum = firstInput * secondInput;
            Console.WriteLine("Multiplikationen av dina tal är: " + inputSum);
        }
        else
        {
            Console.WriteLine("Verkar som att du inte skrev in en operand");
        }
    }
    catch
    {
        Console.WriteLine("Du skrev inte in ett tal");
    }
} //simpel miniräknare
void övningsuppgift7()
{
    //Upgift 7
    //Skriv ett program som ber användaren skriva in en månad. 
    //Programmet ska göra om månaden till månadens siffervärde. 
    //T.ex. ska januari bli 1 och december 12. Använd switch. Alternativ: Prova även att lösa uppgiften med array och/eller enum.
    //Extra utmaning: Be användaren om två månader och räkna sedan ut hur många månader som skiljer mellan dem. 
    //Tänk på att ett månaderna upprepas till nästa år. 
    //Skriver man mars och maj bör man få 2. Likaså om man skriver november och januari.


    int month;
    bool twomonths = true;

    while (twomonths)
    {
        Console.WriteLine("Skriv in två månader");
        string inputtedmonth = Console.ReadLine();




        switch (inputtedmonth)


        {
            case "Januari":
                month = 1;
                Console.WriteLine(month);

                break;

            case "Februari":
                month = 2;
                Console.WriteLine(month);

                break;

            case "Mars":
                month = 3;
                Console.WriteLine(month);

                break;

            case "April":
                month = 4;
                Console.WriteLine(month);

                break;

            case "Maj":
                month = 5;
                Console.WriteLine(month);

                break;

            case "Juni":
                month = 6;
                Console.WriteLine(month);

                break;

            case "Juli":
                month = 7;
                Console.WriteLine(month);

                break;

            case "Augusti":
                month = 8;
                Console.WriteLine(month);

                break;

            case "September":
                month = 9;
                Console.WriteLine(month);

                break;

            case "Oktober":
                month = 10;
                Console.WriteLine(month);

                break;

            case "November":
                month = 11;
                Console.WriteLine(month);

                break;

            case "December":
                month = 12;
                Console.WriteLine(month);

                break;

        }
    }
} //ber användaren skriva in en månad, programmet returnar månades siffervärde. extra utmaning ej avklarad (användare skall kunna skriva in fler månader)
void övningsuppgift8()
{
    //Skapa ett program som skriver ut 1 på första raden, 2 på nästa, sedan 4, o.s.v (dubbelt så hög siffra för varje rad). 
    //Fortsätt till du skrivit ut 16 rader.

    int number = 1;

    for (int i = 1; i < 17; i++)
    {
        Console.WriteLine(number);
        number = number * 2;
    }
} // programm som skriver ut 16 rader, och talet i varje rad dubblar i värde, 2,4,8,16 etc
void övningsuppgift9()
{
    // Skriv ett program som frågar användaren efter ett tal mellan 1 och 100. 
    // Programmet ska ha ett hemligt tal lagrat i en variabel. 
    // Det ska fortsätta fråga användaren till dess att användaren gissar det hemliga talet. 
    // Om man gissade för högt eller för lågt så ska det skrivas ut, så att användaren har en rimlig chans att klara det. 
    // Exempel: programmet har det hemliga talet 27. Användaren gissar på 50. Programmet skriver ut att användaren gissade för högt. 
    // Användaren gissar på 20. Programmet skriver ut att det var för lågt. Användaren gissar på 27. Programmet skriver ut att det var rätt och avslutas.

    // Extra utmaning: slumpa det hemliga talet med hjälp av Random (kolla upp på google hur det fungerar). 
    // Spara antalet gissningar i en variabel och skriv ut det när användaren gissat rätt. 

    // Extra utmaning 2: skriv ett sten-sax-påse spel. 
    // Användaren skriver in “sten”, “sax” eller “påse”. 
    // Dators val slumpas med Random. Skriv sedan ut vad datorn valde, och vem som vann omgången. 
    // Lägg det hela i en loop så spelet fortsätter tills man matar in en tom sträng (trycker enter utan att skriva något). Skriv även ut poäng.

    Console.WriteLine("Välkommen till Abrahams magiska taljakt!");
    Console.WriteLine("Var god och skriv in ett tal! Utmaningen går ut på att hitta rätt tal mellan 1-100!");
    bool abrahamstaljakt = true;
    var rnd = new Random();
    int secretnumber = rnd.Next(1, 100);
    int numberofguesses = 0;

    while (abrahamstaljakt)
    {
        try
        {



            int inputtednumber = int.Parse(Console.ReadLine());
            numberofguesses++;

            if (inputtednumber < secretnumber)
            {
                Console.WriteLine("Fel! Siffran du skrev var för låg!");
                Console.WriteLine("Försök igen!");
            }
            else if (inputtednumber > secretnumber)
            {
                Console.WriteLine("Fel! Siffran du skrev var för hög!");
                Console.WriteLine("Försök igen!");
            }
            else if (inputtednumber == secretnumber)
            {

                Console.WriteLine("Du gissade rätt med: " + inputtednumber + " efter " + numberofguesses + " försök!");
                abrahamstaljakt = false;
            }

        }
        catch
        {
            Console.WriteLine("Du skrev inte något tal!");
            abrahamstaljakt = false;
        }
    }
} //gissningslek mellan 1-100
void övningsuppgift10()
{
    //Be användaren mata in en sträng. Skriv ut varje tecken i strängen på en egen rad. Ex:

    //Hej
    //H
    //e
    //j

    Console.WriteLine("Skriv in en sträng");
    string inputtedstring = Console.ReadLine();


    foreach (char letter in inputtedstring)
    {
        Console.WriteLine(letter);
    }


    // char == Datatyp likt int, string, bool etc.
    // letter == en variabel jag själv skapat lokalt i loopen. alltid samma som datatypen.
    // in == letter blir en variabel som håller alla chars i/in "inputtedstring"
    // inputtedstring == min egen variabel som inte är lokal, utan finns även utanför loopen som "undersöks"
    // i loopen.
    // foreach = i detta fall går den igenom hur många chars(bokstäver) som finns i min strängvariabel och
    // lagrar den informationen i min lokala variabel "letter". skriver jag ut detta så kommer varje
    // bokstav i strängvariabeln inputtedstring att skrivas ut individuellt på en egen rad
} // ber användaren skriva in en sträng som sedan skriver ut varje bokstav på en ny rad
void övningsuppgift11()
{

    // Skapa ett program med en array som innehåller 
    // strängarna “noll”, “ett”, “två”, “tre”, “fyra”, “fem”, “sex”, “sju”, “åtta”, “nio”. 
    // Be sedan användaren att mata in en siffra. Använd arrayen för att skriva ut siffrans ord. 
    // Ex. Inmatning “3” => “tre”.
    // Extra utmaning: Användaren kan mata in en sträng med fritt antal siffror, om man skriver in t.ex 432 
    // så svarar programmet: “fyra - tre - två”.



    string stringinput;
    string[] numbers = new string[10] { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };

    Console.WriteLine("Skriv en siffra");
    stringinput = Console.ReadLine();
    Console.WriteLine(stringinput);


    for (int i = 0; i < stringinput.Length; i++)
    {
        int siffra = int.Parse(stringinput[i] + ""); //gör en int.Parse och stoppar in min stringinput i () för att det är just den jag parsear till en ny int
        Console.Write(numbers[siffra]); //skriver ut min array och inom hakparanteserna skriver jag ut min nya int variabel som jag parseade min stringinput
        if (2 > i)
        {
            Console.Write(" - ");
        }
        else
        {
            Console.WriteLine(".");
        }
    }

} // array som ber användaren skriva ut en 3 siffrig kod för att sedan skriva ut den i bokstäver. t ex 484 blir "fyra - åtta - sju."
 void övningsuppgift12()
{

    //Fråga användaren hur många tal den vill mata in. 
    //Fråga sedan efter talen i tur och ordning (“Ange tal 1:” osv). När alla tal är inmatade skriv ut dem i omvänd ordning.

    Console.WriteLine("Skriv in hur många siffror du vill mata in");
    int amountOfNumbers = Convert.ToInt32(Console.ReadLine()); // int variabel som returnar vad användaren skriver
    int[] amountOfNumbersarray = new int[amountOfNumbers];  // int array som lagrar min int variabel i sin index

    for (int i = 0; i < amountOfNumbers; i++)  //for loop som loopar värdet använder ger variabeln
    {
        int currentNumber = i; // variabel som håller koll på vilken index som är nuvarande talet
        currentNumber++; //counter till föregående förklaring
        Console.WriteLine("Ange tal " + currentNumber); //writeline för vilket tal som skall anges
        amountOfNumbersarray[i] = Convert.ToInt32(Console.ReadLine()); // läser in vad användaren skriver för tal i ordningen för loopen


    }
    for (int j = amountOfNumbersarray.Length - 1; j >= 0; j--) //for loop som skriver ut alla skrivna tal bakåtvänt
    {

        Console.WriteLine(amountOfNumbersarray[j]); //writeline som skriver ut vad loopen gör
    }
} // be användare mata in valt tal, sedan be användaren skriva en siffra per tal och skriv sedan ut alla dem tal omvänt
// void övningsuppgift13()
{

    //Be användaren mata in en text. Skriv sedan ut texten baklänges.

    Console.WriteLine("Mata in en text");
    string greeting = Console.ReadLine();

    for (int i = greeting.Length - 1; i >= 0; i--) // Loop som tar den inmatade stränges längd och deklarerar den som "i", tar sedan bort 1 tills "i" är 0aj
    {

        Console.Write(greeting[i]);
        //greetingArray[i] = Convert.ToInt32(Console.ReadLine()); 

    }
} // program som ber användaren skriva in en text, man returnar sedan den texten baklänges