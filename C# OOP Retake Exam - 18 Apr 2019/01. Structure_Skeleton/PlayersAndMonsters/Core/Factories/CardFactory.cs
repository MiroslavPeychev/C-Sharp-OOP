namespace PlayersAndMonsters.Core.Factories
{
    using PlayersAndMonsters.Core.Factories.Contracts;
    using PlayersAndMonsters.Models.Cards.Contracts;
    using PlayersAndMonsters.Models.Players;
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories;
    using System;
   
    public class CardFactory : ICardFactory
    {
        public ICard CreateCard(string type, string name)
        {
            return null;//not implemented
        }
    }
}
