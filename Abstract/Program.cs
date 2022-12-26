
using Abstract;

public class Program
{
    private static void Main(string[] args)
    {
        Player player = new Player();
        Weapon[] _players = { new LaserGun(), new Gun() };
        foreach (Weapon weap in _players)
        {
            player.Fire(weap);
            Console.WriteLine();
        }
    }
}