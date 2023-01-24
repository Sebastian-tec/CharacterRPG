using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterRPG.Classes
{
    internal class Stats
    {
        private static int StatsRandomizer()
        {
            Random rand = new();

            return rand.Next(1, 20);
        }

        public class Stat
        {
            public int Strength { get; set; }
            public int Dexterity { get; set; }
            public int Constitution { get; set; }
            public int Intelligence { get; set; }
            public int Wisdom { get; set; }
            public int Charisma { get; set; }
            public int Avg { get; set; }

            public Stat()
            {
                Strength = StatsRandomizer();
                Dexterity = StatsRandomizer();
                Constitution = StatsRandomizer();
                Intelligence = StatsRandomizer();
                Wisdom = StatsRandomizer();
                Charisma = StatsRandomizer();

                Avg = Convert.ToInt32((Strength + Dexterity + Constitution + Intelligence + Wisdom + Charisma) / 6);
            }

            public string GetStat(Stat stat)
            {
                return $"Strength: {stat.Strength}\n Dexterity: {stat.Dexterity}\n Constitution: {stat.Constitution}\n Intelligence: {stat.Intelligence}\n Wisdom: {stat.Wisdom}\n Charisma: {stat.Charisma}\n Average: {stat.Avg}";
            }
        }
    }
}
