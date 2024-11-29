namespace _3_04_Loekker_Oppgave_3
{
    //Lag en while-løkke som printer ut "Runde nummer:"
    // + et tall som øker med 1 per runde,
    // så lenge rundetelleren er mindre enn 10
    // Eks:
    // Runde nr 1
    // Runde nr 2
    // Runde nr 3
    internal class Program
    {
        static void Main()
        {
            int number = 1; // Starter på 1
            while (number <= 10) // Stopper på 10
            {
                Console.WriteLine("Runde nr: " + number); // Skriver ut 'Runde nr' + tall (starter på 1)
                number++; // Øker nummeret med +1 for hver gang koden kjøres.
            }

        }
    }
}

