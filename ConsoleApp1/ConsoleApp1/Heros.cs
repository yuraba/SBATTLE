namespace ConsoleApp1;

public abstract class Heros
{
    public virtual int  Armor { get; set; } = 10;
    public int Health { get; set; } = 100;
    public virtual int Brunt { get; set; } = 10;

    public virtual void AddSuperpower(Interface_addsuperpower superpower, int power)
    {
        superpower.AddSuperpower(this,power);
    }
}