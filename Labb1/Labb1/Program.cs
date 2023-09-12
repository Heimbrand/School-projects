﻿

using System;
using System.Globalization;

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
    //+  spara strängtextvariabeln i en array
    //+  skapa en variabel som adderar alla tal som fångas upp i strängen
    //+  gör en loop som går igenom strängarrayens alla index (foreach (string i in inputarray) t ex)
    //+  skriv ett programm med villkor som går igenom och fångar upp de gemensamma nämnarna (if satser?)
    //+  gör en loop som adderar alla tal som programmet har fått fram
    //+  gör ett villkor som fångar upp == siffror. t ex: if i == i {(fler if-satser för att utesluta bokstäver etc)}
    //+  gör ett villkor som tvingar de gemensamma nämnarna att vara minst 100-tal

    Console.WriteLine("Var god mata in en text");
    string inputtedString = Console.ReadLine();
    Console.WriteLine("Kanon, mata nu in endast en del av din text");
    string inputtedStringSequence = Console.ReadLine();
    int loopCount = 0;
    string sequence = string.Empty;


    for (int i = 0; i < inputtedString.Length; i++)
    {
          if (inputtedString[i] == inputtedStringSequence[loopCount])
          {
            sequence += inputtedString[i];
            loopCount++;
            // Console.WriteLine(loopCount);

            if (sequence == inputtedStringSequence)
            {
                Console.WriteLine("Den andra texten du skrev var: " + "'" + sequence + "'");
                break;

            }
          }
    }
}

// TESTSTRÄNG 29535123p48723487597645723645

Console.WriteLine("Var god mata in en text");
Console.WriteLine("Du matade in 29535123p48723487597645723645");
string inputtedString = "29535123p48723487597645723645";
string sequence;
double sequenceSum = 0;

for (int i = 0; i < inputtedString.Length; i++)
{
    if (char.IsDigit(inputtedString[i]))
    {
        for (int j = i + 1; j < inputtedString.Length; j++)
        {
            
            if (inputtedString[i] == inputtedString[j])
            {

                
                sequence = (inputtedString.Substring(i, j - i + 1));
               Console.WriteLine(sequence);
                double sequenceResult;
                double.TryParse(sequence, out sequenceResult);
                sequenceSum += sequenceResult;
                break;
            }
            else if (!char.IsDigit(inputtedString[j]))
            {
                break;
            }
        }
    }
}
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("Den inskrivna strängen är " + inputtedString);
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("den totala summan av alla delsträngar är  " + sequenceSum);
Console.WriteLine("-------------------------------------------------------");






