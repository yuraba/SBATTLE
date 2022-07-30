namespace ConsoleApp1;

public class Black_Panther : Heros
{
    public override int Armor { get; set; } = 15;
    public override int Brunt { get; set; } = 5;

    public override void AddSuperpower(Interface_addsuperpower superpower, int power)
    {
        base.AddSuperpower(superpower, power);
    }
    
    
    public override string ToString()
    {
        return "Black Panther";
    }
}