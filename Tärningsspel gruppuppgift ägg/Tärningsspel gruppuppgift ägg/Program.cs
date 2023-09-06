using System.Threading.Tasks.Sources;

static void playercount()
{

    Console.WriteLine("Hur många spelare är ni?");
    int numberofplayers = Convert.ToInt32(Console.ReadLine());

    for (int p = 0; p < numberofplayers; p++)
    {

    }
}

Console.WriteLine("Hur många spelare är ni?");
int numberofplayers = Convert.ToInt32(Console.ReadLine());
int numberofturns = 6;
//int biggestNumber = 0;
int[] score = new int[7] {0, 0, 0, 0, 0, 0, 0};





for (int i = 0; i < numberofturns; i++)
{
    // Skapa en variabel som håller största talet
    // Skapa en loop för antalet spelare
     for (int p = 1; p < numberofplayers + 1; p++)
        {
            Console.WriteLine("Spelare " + p + " tryck enter för att slå tärning");
            Console.ReadKey();

      // Gör en metod för slumpa tärningen
            var rnd = new Random();
            int randomNumber = rnd.Next(1, 7);
      //biggestNumber = randomNumber;
            score[p] = randomNumber;
        Console.WriteLine("Spelare " + p + " slår: " + score[p]);
        
        
    }
     
    Console.WriteLine("vinnare av omgången är spelare: " + score.Max());

}



