﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstExercise = "Davis, Clyne, Fonte, Hooiveld, Shaw, Davis, Schneiderlin, Cork, Lallana, Rodriguez, Lambert";
            string [] arrayNames = firstExercise.Split(", ");
            Console.WriteLine("Первая строка:\n");
            Console.WriteLine(string.Join(",\n", Enumerable.Range(1, arrayNames.Length).
                                    Zip(arrayNames, (index, name) => new string(index + ". " + name))));

            string secondExercise = "Jason Puncheon, 26/06/1986; Jos Hooiveld, 22/04/1983; Kelvin Davis, 29/09/1976; Luke Shaw, 12/07/1995; Gaston Ramirez, 02/12/1990; Adam Lallana, 10/05/1988";
            IEnumerable<Player> players = Player.ReadStartString(secondExercise);
            Console.WriteLine("\nВторая строка:\n");
            Player.ShowPlayers(players);

            string thirdExercise = "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27";

        }
    }
}
