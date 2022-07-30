namespace ConsoleApp1;

public static class BattleHelper
{
    public static Heros ChooseHero(string question)
    {
        
        Heros hero;
        do
        {
            Console.WriteLine(question);
            string response = Console.ReadLine();
            hero = GetHero(response);
            
            if (hero == null)
            {
                Console.WriteLine("Try again");
            }
        } while (hero == null);
        return hero;
    }

    public static Heros GetHero(string enter)
    {
        if (int.TryParse(enter, out int result))
        {
            switch (result)
            {
                case 1: return new Batman();
                case 2: return new Wolverine();
                case 3: return new Black_Panther();
                case 4: return new IronMan();
                default: return null;
            }
        }

        return null;
    }

   

  

}