

namespace PlayersAndMonsters.Models.Players
{
    using System;
    using PlayersAndMonsters.Repositories.Contracts;

    public class Beginner : Player
    {
        private const int InitialHealtPoints = 50;
        
        public Beginner(ICardRepository cardRepository, string username)
            : base(cardRepository, username, InitialHealtPoints)
        {
        }
    }
}
