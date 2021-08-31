using System;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace Decorator
{
    public class PlayersServiceLoggingDecorator : IPlayersService
    {
        private readonly IPlayersService _playersService;
  
        public PlayersServiceLoggingDecorator(IPlayersService playersService
            )
        {
            _playersService = playersService;
        
        }

        public IEnumerable<Player> GetPlayersList()
        {
            Console.WriteLine("Starting to fetch data");

            var stopwatch = Stopwatch.StartNew();

            IEnumerable<Player> players = _playersService.GetPlayersList();

            foreach (var player in players)
            {
                Console.WriteLine("Player: " + player.Id + ", Name: " + player.Name);
            }

            stopwatch.Stop();

            var elapsedTime = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Finished fetching data in {elapsedTime} milliseconds");

            return players;
        }
    }
}