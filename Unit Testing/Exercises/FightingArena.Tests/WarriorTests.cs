namespace Tests
{
    using System;

    //using FightingArena;
    using NUnit.Framework;

    [TestFixture]
    public class WarriorTests
    {
        public  const int MIN_ATTACK_HP = 30;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            //Arrange
            string expectedName = "Pesho";
            int expectedDmg = 50;
            int expectedHP = 100;

            //Act
            Warrior warrior = new Warrior(expectedName, expectedDmg, expectedHP);

            string actualName = warrior.Name;
            int actualDmg = warrior.Damage;
            int actualHP = warrior.HP;

            //Assert
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedDmg, actualDmg);
            Assert.AreEqual(expectedHP, actualHP);
        }

        [Test]
        public void TestWithNullNameShouldThrowArgumentException()
        {
            //Arrange
            string name = null;
            int dmg = 50;
            int hp = 100;

            //Assert
            Assert.Throws<ArgumentException>(() =>
            {
                //Act
                Warrior warrior = new Warrior(name, dmg, hp);
            });
        }

        [Test]
        public void TestWithEmptyNameShouldThrowArgumentException()
        {
            //Arrange
            string name = string.Empty;
            int dmg = 50;
            int hp = 100;

            //Assert
            Assert.Throws<ArgumentException>(() =>
            {
                //Act
                Warrior warrior = new Warrior(name, dmg, hp);
            });
        }

        [Test]
        public void TestWithWhiteSpaceNameShouldThrowArgumentException()
        {
            //Arrange
            string name = "         ";
            int dmg = 50;
            int hp = 100;

            //Assert
            Assert.Throws<ArgumentException>(() =>
            {
                //Act
                Warrior warrior = new Warrior(name, dmg, hp);
            });
        }

        [Test]
        public void TestWithZeroDamageShouldThrowArgumentException()
        {
            //Arrange
            string name = "Pesho";
            int dmg = 0;
            int hp = 100;

            //Assert
            Assert.Throws<ArgumentException>(() =>
            {
                //Act
                Warrior warrior = new Warrior(name, dmg, hp);
            });
        }

        [Test]
        public void TestWithNegativeDamageShouldThrowArgumentException()
        {
            //Arrange
            string name = "Pesho";
            int dmg = -10;
            int hp = 100;

            //Assert
            Assert.Throws<ArgumentException>(() =>
            {
                //Act
                Warrior warrior = new Warrior(name, dmg, hp);
            });
        }

        [Test]
        public void TestWithNegativeHealthPointsShouldThrowArgumentException()
        {
            //Arrange
            string name = "Pesho";
            int dmg = 50;
            int hp = -10;

            //Assert
            Assert.Throws<ArgumentException>(() =>
            {
                //Act
                Warrior warrior = new Warrior(name, dmg, hp);
            });
        }

        [TestCase(25, "Less than required minimum attackerHP")]
        [TestCase(30, "Equal to required minimum attackerHP")]
        public void AttackerAttackingWithLesThanMinimumHealthPointsShouldThrowInvalidOperationException(int attackerHP, string message)
        {
            //Arrange
            string attackerName = "Pesho";
            int attackerDmg = 10;

            string defenderName = "Gosho";
            int defenderDmg = 20;
            int defenderHP = 40;

            var attacker = new Warrior(attackerName, attackerDmg, attackerHP);
            var defender = new Warrior(defenderName, defenderDmg, defenderHP);

            //Assert

            //first way
            Assert.That(Assert.Throws<InvalidOperationException>(() =>
            {
                //Act
                attacker.Attack(defender);
            }).Message.Equals("Your HP is too low in order to attack other warriors!"));

            //second way
            Assert.That(() =>
            {
                //Act
                attacker.Attack(defender);
            }, Throws.InvalidOperationException.With.Message.EqualTo("Your HP is too low in order to attack other warriors!"));

            //third way
            var ex = Assert.Throws<InvalidOperationException>(() => attacker.Attack(defender));

            Assert.That(ex.Message, Is.EqualTo("Your HP is too low in order to attack other warriors!"));
        }

        [TestCase(25, "Less than required minimum deffenderHP")]
        [TestCase(30, "Equal to required minimum deffenderHP")]
        public void AttackingDeffenderWithLesThanMinimumHealthPointsShouldThrowInvalidOperationException(int deffenderHP, string message)
        {
            //Arrange
            string attackerName = "Pesho";
            int attackerDmg = 10;
            int attackerHP = 100;

            string deffenderName = "Gosho";
            int deffenderDmg = 20;
           

            var attacker = new Warrior(attackerName, attackerDmg, attackerHP);
            var deffender = new Warrior(deffenderName, deffenderDmg, deffenderHP);

            //Assert
            Assert.That(() =>
            {
                //Act
                attacker.Attack(deffender);
            }, Throws
            .InvalidOperationException
            .With
            .Message
            .EqualTo($"Enemy HP must be greater than {MIN_ATTACK_HP} in order to attack him!"));
        }

        [Test]
        public void AttackingDefenderWithMoreDamageThanAttackerHPShouldThrowInvalidOperationException()
        {
            //Arrange
            string attackerName = "Pesho";
            int attackerDmg = 10;
            int attackerHP = 35;

            string defenderName = "Gosho";
            int defenderDmg = 40;
            int defenderHP = 100;


            var attacker = new Warrior(attackerName, attackerDmg, attackerHP);
            var defender = new Warrior(defenderName, defenderDmg, defenderHP);

            //Assert
            Assert.That(() =>
            {
                //Act
                attacker.Attack(defender);
            }, Throws
            .InvalidOperationException
            .With
            .Message
            .EqualTo($"You are trying to attack too strong enemy"));
        }

        [Test]
        public void AttackingShouldDecreaceHPWhenSuccessfull()
        {
            //Arrange
            string attackerName = "Pesho";
            int attackerDmg = 10;
            int attackerHP = 40;

            string deffenderName = "Gosho";
            int deffenderDmg = 20;
            int deffenderHP = 40;

            var attacker = new Warrior(attackerName, attackerDmg, attackerHP);
            var deffender = new Warrior(deffenderName, deffenderDmg, deffenderHP);

            int expectedAttackerHP = attackerHP - deffenderDmg;
            int expectedDeffenderHp = deffenderHP - attackerDmg;

            //Act
            attacker.Attack(deffender);

            //Assert
            Assert.AreEqual(expectedAttackerHP, attacker.HP);
            Assert.AreEqual(expectedDeffenderHp, deffender.HP);
        }

        [Test]
        public void KillingEnemyWithSuccessfullAttackShouldSetDeadEnemyHPToZero()
        {
            
            //Arrange
            string attackerName = "Pesho";
            int attackerDmg = 80;
            int attackerHP = 100;

            string deffenderName = "Gosho";
            int deffenderDmg = 70;
            int deffenderHP = 50;

            var attacker = new Warrior(attackerName, attackerDmg, attackerHP);
            var deffender = new Warrior(deffenderName, deffenderDmg, deffenderHP);

            int expectedAttackerHP = attackerHP - deffenderDmg; //80 - 70 = 10;
            int expectedDeffenderHP = 0; //50 - 80 = -30 -> 0


            //Act
            attacker.Attack(deffender);

            

            //Assert
            Assert.AreEqual(expectedAttackerHP, attacker.HP);
            Assert.AreEqual(expectedDeffenderHP, deffender.HP);


            

        }
    }
}