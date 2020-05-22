namespace PlayersAndMonsters.Models.Players.Contracts
{
    using System;
    using PlayersAndMonsters.Repositories.Contracts;

    public interface IPlayer
    {
        ICardRepository CardRepository { get; }

        string Username { get; }

        int Health { get; set; }

        bool IsDead { get; }

        void TakeDamage(int damagePoints);
    }
}
