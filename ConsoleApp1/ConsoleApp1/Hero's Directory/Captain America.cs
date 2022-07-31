namespace ConsoleApp1;

public class Captain_America : Heros
{
    public override int Armor { get; set; } = 15;
    public override int Brunt { get; set; } = 5;
    
    
    public override string ToString()
    {
        return "Captain America";
    }
}