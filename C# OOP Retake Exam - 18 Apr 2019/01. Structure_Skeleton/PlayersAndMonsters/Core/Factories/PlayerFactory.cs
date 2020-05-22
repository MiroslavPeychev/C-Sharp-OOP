using PlayersAndMonsters.Models.Players;
using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories;

namespace PlayersAndMonsters.Core.Factories.Contracts
{
   

    public class PlayerFactory : IPlayerFactory
    {
        public IPlayer CreatePlayer(string type, string username)
        {
            IPlayer player = null;

            if (type == "Begginer")
            {
                player = new Beginner(new CardRepository(), username);
            }
            else if (type == "Advanced")
            {
                player = new Advanced(new CardRepository(), username);
            }

            return player;
        }
    }
}
