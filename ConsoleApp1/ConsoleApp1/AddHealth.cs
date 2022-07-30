namespace ConsoleApp1;

public class AddHealth : Interface_addsuperpower
{
    public void AddSuperpower(Heros hero, int power)
    {
        hero.Health += power;
    }
}