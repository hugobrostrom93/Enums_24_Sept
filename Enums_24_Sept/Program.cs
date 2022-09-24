using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //EnumsBaby();
        EnumsEz();

    }

    static void EnumsBaby()
    {
        //1. Fråga användaren om ett nummer mellan 1 och 7
        //2. Omvandla input från sträng till int
        //3. Omvandla talet från int till Veckodagar enum
        //4. Använd ToString för att skriva ut veckodagen

        Console.WriteLine("Välj ett nummer mellan 1 och 7");
        int nummer = Convert.ToInt32(Console.ReadLine());

        var nummerX = (Veckodagar)nummer; // Tar alltså nummer (input) i Veckodagar och hittar rätt plats och tillderar den till nummerX

        string minText = nummerX.ToString();
        Console.WriteLine(minText);

    }



    static void EnumsEz()
    {
        //1. Fråga användaren om en veckodag
        //2. Kontrollera att första bokstaven är i versal, resten gemener – för att Enum parse är case sensitive
        //3. Omvandla talet från text till Veckodagar enum
        //4. Skriv ut siffran för dagen (måndag = 1)

        Console.WriteLine("Välj en veckodag");
        string veckodag = Console.ReadLine();

        string firstLetter = veckodag.Substring(0, 1);
        var restLetter = veckodag.Substring(1, veckodag.Length - 1);

        bool firstUpperOrNot = Char.IsUpper(firstLetter, 0);
        bool lastUpperOrNot = Char.IsLower(restLetter, veckodag.Length - 2);

        while (firstUpperOrNot == true && lastUpperOrNot == true)
        {
            Enum.TryParse(veckodag, out Veckodagar stringToEnum);

            if (stringToEnum == Veckodagar.Måndag)
            {
                int nummerEnum = (int)Veckodagar.Måndag;
                Console.WriteLine(nummerEnum);
                break;
            }
            else if (stringToEnum == Veckodagar.Tisdag)
            {
                int nummerEnum = (int)Veckodagar.Tisdag;
                Console.WriteLine(nummerEnum);
                break;
            }
            else if (stringToEnum == Veckodagar.Onsdag)
            {
                int nummerEnum = (int)Veckodagar.Onsdag;
                Console.WriteLine(nummerEnum);
                break;
            }
            else if (stringToEnum == Veckodagar.Torsdag)
            {
                int nummerEnum = (int)Veckodagar.Torsdag;
                Console.WriteLine(nummerEnum);
                break;
            }
            else if (stringToEnum == Veckodagar.Fredag)
            {
                int nummerEnum = (int)Veckodagar.Fredag;
                Console.WriteLine(nummerEnum);
                break;
            }
            else if (stringToEnum == Veckodagar.Lördag)
            {
                int nummerEnum = (int)Veckodagar.Lördag;
                Console.WriteLine(nummerEnum);
                break;
            }
            else if (stringToEnum == Veckodagar.Söndag)
            {
                int nummerEnum = (int)Veckodagar.Söndag;
                Console.WriteLine(nummerEnum);
                break;
            }
            else
            {
                Console.WriteLine("Ange en dag men stor bokstav och små bokstäver därefter tack!");
                break;
            }
        }            
    }


    public enum Veckodagar
    {
        Måndag = 1,
        Tisdag,
        Onsdag,
        Torsdag,
        Fredag,
        Lördag,
        Söndag
    }
}





