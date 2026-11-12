Console.Clear();
string again = "a";
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("***************************************");
    Console.WriteLine("******** Vykreslení obdelniku *********");
    Console.WriteLine("***************************************");
    Console.WriteLine("************** Tomáš Žižka ************");
    Console.WriteLine("***************************************");
    Console.WriteLine("***************************************");

    // Vstup pro šířku
    Console.Write("Zadejte šířku obrazce (kladné celé číslo): ");
    int width;
    while(!int.TryParse(Console.ReadLine(), out width) ||  width <= 0 )
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste kladné celé číslo! Zadejte šířku obrazce znovu: ");
        Console.ResetColor();
    }

    // Vstup pro výšku
    Console.Write("Zadejte výšku obrazce (kladné celé číslo): ");
    int height;
    while(!int.TryParse(Console.ReadLine(), out height) ||  height <= 0 )
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste kladné celé číslo! Zadejte výšku obrazce znovu: ");
        Console.ResetColor();
    }

    
    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("==================================");
    // Výpis zadaných hodnot do jednoho řádku
    Console.WriteLine($"Šířka: {width}; Výška: {height}");
    Console.WriteLine("==================================");
    Console.WriteLine();

    // Jádro konkrétního algortimu

    // Vnější cyklus, který bude řídit správný počet zobrazených řádků (výška) 
    for(int i = 1; i <= height ; i++)
    {
        if(i % 2 == 0)
        {
            // sudý řádek
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else
        {
            // lichý řádek
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        
        
        // Vnitřní cyklus se stará o to, aby se v každém řádku vykreslil správný počet znaků (šířka krát)
        for(int j = 1; j <= width; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));    
        }
        
        Console.WriteLine();
        
    }
    Console.ResetColor();

    // Konec jádra konkrétního algoritmu


    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}   



