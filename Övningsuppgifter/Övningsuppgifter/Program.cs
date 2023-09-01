// Uppgift 1

//skriv ett program som frågar efter användarens namn och skriver ut en hälsning på konsolen.
//om namnet är "david" ska det skriva ut "hej david!"

//Console.WriteLine("Hej, vad heter du?"); 
//string name = Console.ReadLine();
//Console.WriteLine("Hej, " + name + "!");

//---------------------------------------------------------------------------------

//Uppgift 2

//Skriv ett program som frågar användaren efter ett lösenord. 
//Hitta på ett hemligt lösenord och spara det i en variabel. 
//När användaren har skrivit in ett lösenord ska programmet jämföra med det sparade lösenordet och skriva ut om det var rätt eller inte. 
//Använd en if-sats.

//string password = "Bajskorv";
//Console.WriteLine("Skriv in ditt lösenord");
//string inputtedpassword = Console.ReadLine();

//if (password == inputtedpassword)
//{
//    Console.WriteLine("Korrekt lösenord");
//}
//else if (password != inputtedpassword)
//{
//    Console.WriteLine("Fel läsenord");
//}

//----------------------------------------------------------------------------------

//Uppgift 3

//Skriv ett program som frågar användaren efter ett tal. 
//Det ska skriva ut om talet är mindre än 100, lika med 100 eller större

//Console.WriteLine("Skriv en siffra mellan 1 och 100");
//double inputtednumber = double.Parse(Console.ReadLine());


//if (inputtednumber < 100)
//{
//    Console.WriteLine("Siffran du skrev var lägre än 100");
//    Console.WriteLine("Du skrev: " + inputtednumber);
//}
//else if (inputtednumber > 100)
//{
//    Console.WriteLine("Din siffra var högre än 100");
//    Console.WriteLine("Du skrev: " + inputtednumber);
//}
//else if (inputtednumber == 100)
//{

//    Console.WriteLine("Du skrev: " + inputtednumber);
//}
//else
//{
//    Console.WriteLine("Du skrev inte någon siffra:("); //Fråga Niklas hur jag får programmet att läsa in strings och ints/doubles samti

//}



//-------------------------------------------------------------------------------------------

//Uppgift 4

//Uppdatera programmet i uppgift 1 så att det även frågar efter ett tal. 
//Skriv hälsningen så många gånger som användaren anger.


//Console.WriteLine("Hej, vad heter du?"); 
//string name = Console.ReadLine();
//Console.WriteLine("Hej, " + name + "!");
//Console.WriteLine("Skriv in en siffra");
//int num = int.Parse(Console.ReadLine());   // Vad är det för skillnad på Convert.ToInt32 och Int.Parse i detta läget, vad är bäst att använda?

//for (int i = 0; i < num; i++)
//{
//    Console.WriteLine("Hej, " + name + "!");

//}


//--------------------------------------------------------------------------------------------

//Uppgift 5

//Skriv ett program som upprepade gånger frågar användaren efter ett tal ända till man skriver något som inte är ett tal (t.ex bara trycker enter). 
//Efter varje inmatning ska summan av alla tal som matats in skrivas ut, innan nästa inmatning efterfrågas. 
//Innan programmet avslutas ska man även skriva ut medelvärde av de inmatade talen. Hint: TryParse()

using System.Reflection.Metadata.Ecma335;  //Vad är detta? :O
using System.Xml;

//string inputtedvalue = "";
//int num;
//int sum = 0;
//int iterations = 0;
//int.TryParse(inputtedvalue, out num);
//bool correctinput = true;
//while (correctinput)
//{
//    Console.WriteLine("Skriv in ett tal");
//    inputtedvalue = Console.ReadLine();



//    if (int.TryParse(inputtedvalue, out num))
//    {
//        Console.WriteLine("Du skrev in talet: " + inputtedvalue);
//        sum = sum + num;
//        Console.WriteLine("Summan av dina tal är: " + sum);
//        iterations++;

//    }
//    else
//    {
//        Console.WriteLine("Du skrev inte in ett tal");
//        int avg = sum / iterations; 
//        Console.WriteLine("Medelvärdet av dina inskrivna tal är: " + avg);
//        correctinput = false;
//    }
//}

//---------------------------------------------------------------------------------------------------------

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
        Console.WriteLine("Du e fan dum i huvudet");
    }
}
catch 
{
    Console.WriteLine("Du skrev inte in ett tal");
}
