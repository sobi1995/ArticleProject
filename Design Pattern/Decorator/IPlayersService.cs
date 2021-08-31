using System.Collections.Generic;

namespace Decorator
{
    public interface IPlayersService
    {
        IEnumerable<Player> GetPlayersList();
    }
}