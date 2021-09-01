using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.Extensions.Logging;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
             // CallWhithOutDecorator();

            //config with asp DI
            //var collection = new ServiceCollection();
            //collection.AddScoped<IPlayersService, PlayersService>();
            //IServiceProvider serviceProvider = collection.BuildServiceProvider();
            //var _playersService = serviceProvider.GetService<IPlayersService>();
            //IPlayersService _playersServiceDecorator = new PlayersServiceLoggingDecorator(_playersService);
            //var players = _playersServiceDecorator.GetPlayersList();


            var collection = new ServiceCollection();
            collection.AddScoped<IPlayersService, PlayersService>();
            collection.Decorate<IPlayersService, PlayersServiceCachingDecorator>();
            collection.Decorate<IPlayersService, PlayersServiceLoggingDecorator>();
            IServiceProvider serviceProvider = collection.BuildServiceProvider();
            var _playersService = serviceProvider.GetService<IPlayersService>();
            var players = _playersService.GetPlayersList();
            foreach (var player in players)
            {
                Console.WriteLine($"{player.Id} {player.Name}");
            }

            Console.ReadKey();

        }


 


     private static void CallWhithOutDecorator()
     {
         var collection = new ServiceCollection();
         collection.AddTransient<IPlayersService, PlayersService>();
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
