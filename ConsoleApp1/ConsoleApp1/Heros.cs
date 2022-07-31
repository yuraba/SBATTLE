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
    
    public bool IsAlive => Health > 0;
    
    public int Attack()
    {
        if (Armor>0)
            return Brunt;
        if (Brunt == 1)
            return 1;
        return Brunt--;
    }

    public void Defense(int power)
    {
        if (Armor == 0)
        {
            Health -= power;
        }
        if (Armor > power)
        {
            Armor -= power / 2;
        }
        else
        {
            Health -= (-Armor + power);
            Armor = 0;
        }
        
    }
    
    public override string ToString()
    {
        return "Base Hero";
    }
}