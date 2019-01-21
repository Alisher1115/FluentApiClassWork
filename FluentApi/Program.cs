using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new SportContext())
            {
                //HashSet<Player> playersWithSeven = new HashSet<Player>();
                //var players = context.Players.ToList();

                //foreach (var player in players)
                //{
                //    if (player.Number == 7)
                //    {
                //        playersWithSeven.Add(player);
                //    }
                //}

                //var result1 = from player in context.Players
                //             where player.Number == 7
                //             select player;
                //from временная_переменная in набор_данных
                // where условие
                //select временная_переменная 

                var result1 = from player in context.Players
                              where player.Number == 7
                              select new
                              {
                                  UniqueIdentifier = Guid.NewGuid(),
                                  PlayerName = player.FullName,
                                  TeamName = player.Team.Name,
                                  TeamNameA = context.Teams.FirstOrDefault(team => team.Name.Contains("a"))
                              };

                Console.WriteLine(result1.ToList()[0].TeamNameA);

                var result2 = context.Players.Where(player => player.Number == 7);
                var ronaldo = context.Players.Single(player => player.FullName.ToLower() == "ronaldo");




                #region InsertData
                //Team team = new Team
                //{
                //    Id = 1,
                //    Name = "Manchester United"
                //};

                //Player player1 = new Player
                //{
                //    Id = 1,
                //    FullName = "Messi",
                //    Number = 1,
                //    TeamId = team.Id
                //};

                //Player player2 = new Player
                //{
                //    Id = 2,
                //    FullName = "Ronoldo",
                //    Number = 2,
                //    TeamId = team.Id
                //};

                //context.Teams.Add(team);
                //context.Players.Add(player2);
                //context.Players.Add(player2);
                //context.SaveChanges();
                #endregion


            }
        }
    }
}
