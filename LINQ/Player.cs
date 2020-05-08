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
        int Age;

        public static IEnumerable<Player> ReadStartString (string startString)
        {
            List<Player> players = new List<Player>();
            string [] playersInString = startString.Split("; ");
            foreach (var item in playersInString)
            {
                string[] nameAndDate = item.Split(", ");
                players.Add(new Player(nameAndDate.First(), DateTime.Parse(nameAndDate.Last())));
            }
            return (IEnumerable<Player>)players.OrderBy(p => p.Age);
        }

        public static void ShowPlayers (IEnumerable<Player> players)
        {
            foreach(Player item in players)
            Console.WriteLine("Имя:  " + item.Name + ", \tДата рождения: " + item.Birthday.ToShortDateString() + ",\tВозраст: " + item.Age + " полных лет");
        }
    }
}
