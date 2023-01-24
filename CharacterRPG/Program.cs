using CharacterRPG.Classes;
using static CharacterRPG.Classes.Characters;
using System.Globalization;

namespace CharacterRPG
{
    internal class Program
    {
        private static List<Character> Player = new List<Character>();
        private static Characters characters = new Characters();
        static void Main(string[] args)
        {

        }

        static void ShowPlaysers()
        {
            foreach (Character item in Player)
            {
                Console.WriteLine(characters.ShowPlayer(item) + "\n");
            }
        }

        static void GetData()
        {
            string name = "";
            do
            {
                Console.Write("Player name: ");
                name = Console.ReadLine();
            } while (name.All(char.IsSymbol));

            string[] classes = { "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue" };
            int classChoice = 0;
            do
            {
                for (int i = 0; i < classes.Length; i++)
                {
                    Console.WriteLine($"{i}. {classes[i]}");
                }

            } while (!int.TryParse(Console.ReadLine(), out classChoice));

            string[] races = { "Dragonborn", "Dwarf", "Elf", "Gnome", "Half-elf", "Halfling", "Half-orc", "Human", "Tiefling" };
            int raceChoice = 0;

            do
            {
                for (int i = 0; i < races.Length; i++)
                {
                    Console.WriteLine($"{i}. {races[i]}");
                }

            } while (!int.TryParse(Console.ReadLine(), out raceChoice));

            DateTime creationdate;
            do
            {
                Console.WriteLine("yyyy-mm-dd\nCreation date: ");
            } while (!DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out creationdate));

            Stats.Stat stat = new();
            Characters.Character player = new Character(name, classes[classChoice], races[raceChoice], creationdate, stat);
            Player.Add(player);
        }
    }
}