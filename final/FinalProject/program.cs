// Program.cs
class Program
{
    static void Main()
    {
        Game game = new Game();
        Warrior warrior = new Warrior("Sir Knight", 100, 20);
        Mage mage = new Mage("Merlin", 80, 30);

        game.AddCharacter(warrior);
        game.AddCharacter(mage);

        game.DisplayCharactersInfo();
        game.PlayGame();
    }
}
