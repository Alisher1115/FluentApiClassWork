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
                #region InsertData

                Team team = new Team
                {
                    Id = 1,
                    Name = "Manchester United"
                };

                Player player1 = new Player
                {
                    Id = 1,
                    FullName = "Messi",
                    Number = 1,
                    TeamId = 1
                };

                Player player2 = new Player
                {
                    Id = 2,
                    FullName = "Ronoldo",
                    Number = 2,
                    TeamId = 1
                };

                context.Teams.Add(team);
                context.Players.Add(player1);
                context.Players.Add(player2);
                context.SaveChanges();

                #endregion

                // Дополнитель приложение по спорту, написанное в классе таким образом, чтобы можно было искать игроков по именам.

                Console.Write("Input name: ");
                string playerName = Console.ReadLine();
                Player filteredPlayserByName = new Player();
                try
                {
                    filteredPlayserByName = context.Players.Single(player => player.FullName.ToLower() == playerName);
                    Console.WriteLine($"Name: {filteredPlayserByName.FullName}");
                    Console.WriteLine($"Number: {filteredPlayserByName.Number}");
                    Console.WriteLine($"Team name: {filteredPlayserByName.Team.Name}");
                }
                catch (ArgumentNullException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                catch (InvalidOperationException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                catch (NullReferenceException exception)
                {
                    Console.WriteLine(exception.Message);
                }

                #region ClassWork
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

//                var result1 = from player in context.Players
//                              where player.Number == 7
//                              select new
//                              {
//                                  UniqueIdentifier = Guid.NewGuid(),
//                                  PlayerName = player.FullName,
//                                  TeamName = player.Team.Name,
//                                  TeamNameA = context.Teams.FirstOrDefault(team => team.Name.Contains("a"))
//                              };

//                Console.WriteLine(result1.ToList()[0].TeamNameA);
//                var result2 = context.Players.Where(player => player.Number == 7);
//                var ronaldo = context.Players.Single(player => player.FullName.ToLower() == "ronaldo");
                

                #endregion
            }
        }
    }
}
