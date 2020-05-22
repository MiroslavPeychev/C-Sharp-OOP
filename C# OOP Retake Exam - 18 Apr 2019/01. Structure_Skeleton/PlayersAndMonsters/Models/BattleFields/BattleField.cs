namespace PlayersAndMonsters.Models.BattleFields
{
    using PlayersAndMonsters.Models.BattleFields.Contracts;
    using PlayersAndMonsters.Models.Players;
    using PlayersAndMonsters.Models.Players.Contracts;
    using System;
    using System.Linq;
    public class BattleField : IBattleField
    {
            private const int DefaultDamagePointsForBegginer = 30;
            private const int DefaultHealtPointsForBegginer = 40;
        
        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }

            CheckIfPlayerIsBegginer(attackPlayer);
            CheckIfPlayerIsBegginer(enemyPlayer);

            GetBonusHealtPoint(attackPlayer);
            GetBonusHealtPoint(enemyPlayer);

            while (true)
            {
                var attackerDamagePoints = attackPlayer.CardRepository.Cards.Sum(x=>x.DamagePoints);

                enemyPlayer.TakeDamage(attackerDamagePoints);
                
                if (enemyPlayer.IsDead)
                {
                    break;
                }

                var enemyDamagePoints = enemyPlayer.CardRepository.Cards.Sum(x => x.DamagePoints);

                attackPlayer.TakeDamage(enemyDamagePoints);

                if (attackPlayer.IsDead)
                {
                    break;
                }
            }
        }
       
        private void GetBonusHealtPoint(IPlayer player)
        {
            var bonusPoints = player.CardRepository.Cards.Sum(x => x.HealthPoints);
            player.Health += bonusPoints;
        }

        private void CheckIfPlayerIsBegginer(IPlayer player)
        {
            if (player is Beginner)
            {
                player.Health += DefaultHealtPointsForBegginer;

                foreach (var card in player.CardRepository.Cards)
                {
                    card.DamagePoints += DefaultDamagePointsForBegginer;
                }
            }
        }
    }
}