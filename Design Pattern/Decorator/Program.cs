using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.Extensions.Logging;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            CallWhithOutDecorator();
            CallWhithDecorator();
        }


     private static void  CallWhithDecorator()
        {
            var collection = new ServiceCollection();
            collection.AddScoped<IPlayersService, PlayersService>();
            IServiceProvider serviceProvider = collection.BuildServiceProvider();
            var _playersService = serviceProvider.GetService<IPlayersService>();
            //var logger = serviceProvider.GetService<ILogger<PlayersServiceLoggingDecorator>>();
            IPlayersService _playersServiceDecorator = new PlayersServiceLoggingDecorator(_playersService);
            var players = _playersServiceDecorator.GetPlayersList();


            foreach (var player in players)
            {
                Console.WriteLine($"{player.Id} {player.Name}");
            }

        }


     private static void CallWhithOutDecorator()
     {
         var collection = new ServiceCollection();
         collection.AddScoped<IPlayersService, PlayersService>();
         IServiceProvider serviceProvider = collection.BuildServiceProvider();
         var _playersService = serviceProvider.GetService<IPlayersService>();
         var players = _playersService.GetPlayersList();
         foreach (var player in players)
         {
             Console.WriteLine($"{player.Id} {player.Name}");
         }

        }
    }
}
