
//skriv ett program som frågar efter användarens namn och skriver ut en hälsning på konsolen.
//om namnet är "david" ska det skriva ut "hej david!"

//Console.WriteLine("Hej, vad heter du?"); 
//string name = Console.ReadLine();
//Console.WriteLine("Hej, " + name + "!");

//---------------------------------------------------------------------------------

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


//Skriv ett program som upprepade gånger frågar användaren efter ett tal ända till man skriver något som inte är ett tal (t.ex bara trycker enter). 
//Efter varje inmatning ska summan av alla tal som matats in skrivas ut, innan nästa inmatning efterfrågas. 
//Innan programmet avslutas ska man även skriva ut medelvärde av de inmatade talen. Hint: TryParse()

string inputtedvalue = "";
int num;
int sum = 0;
int.TryParse(inputtedvalue, out num);
Console.WriteLine("Skriv in ett tal");
Console.ReadLine();

