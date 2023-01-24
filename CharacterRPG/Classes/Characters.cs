using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterRPG.Classes
{
    internal class Characters
    {
        public string ShowPlayer(Character Player)
        {
            return $"Player Name: {Player.PlayerName}\n Player Class: {Player.PlayerClass} Player Race: {Player.PlayerRace}\n Player Level: {Player.PlayerLevel}\n Player Age: {Player.CalcAge()}\n {Player.Stat.GetStat(Player.Stat)}";
        }

        public class Character
        {
            public string PlayerName { get; set; }
            public string PlayerClass { get; set; }
            public string PlayerRace { get; set; }
            public int PlayerLevel { get; set; }
            public DateTime PlayerCreated { get; set; }
            public Stats.Stat Stat { get; set; }

            public Character(string playername, string playerclass, string playerrace, DateTime playercreated, Stats.Stat stat)
            {
                PlayerName = playername;
                PlayerClass = playerclass;
                PlayerRace = playerrace;
                PlayerLevel = stat.Avg;
                PlayerCreated = playercreated;
                Stat = stat;
            }

            public int CalcAge()
            {
                int age = DateTime.Now.Year - PlayerCreated.Year;
                if (DateTime.Now.DayOfYear < PlayerCreated.DayOfYear)
                {
                    age--;
                }
                return age;
            }
        }
    }
}
