namespace ConsoleApp1;

public static class SuperPowerGenerator
{
    public static int GenerateSuperpower()
    {
        return new Random().Next(5, 10);
    }
}