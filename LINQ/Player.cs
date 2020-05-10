using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Player
    {
        public Player(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
            DateTime now = DateTime.Today;
            int ageNow = now.Year - birthday.Year;
            if (birthday > now.AddYears(-ageNow)) ageNow--;
            Age = ageNow;
        }

        readonly string Name;
        readonly DateTime Birthday;
        readonly int Age;

        public static IEnumerable<Player> ReadStartString (string startString)
        {
            IEnumerable<Player> players = (from t in startString.Split("; ")
                                           let player = t.Split(", ")
                                           select new Player(player.First(), DateTime.Parse(player.Last())));
            return players.OrderBy(p => p.Age);
        }

        public static void ShowPlayers (IEnumerable<Player> players)
        {
            foreach(Player item in players)
            Console.WriteLine("Имя:  " + item.Name + ", \tДата рождения: " + item.Birthday.ToShortDateString() + ",\tВозраст: " + item.Age + " полных лет");
        }
    }
}
