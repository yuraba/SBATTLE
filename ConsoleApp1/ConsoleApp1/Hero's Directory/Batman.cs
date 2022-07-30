namespace ConsoleApp1;

public class Batman : Heros
{
    public override int Armor { get; set; } = 13;
    public override int Brunt { get; set; } = 7;

    
    public override string ToString()
    {
        return "Batman";
    }
}