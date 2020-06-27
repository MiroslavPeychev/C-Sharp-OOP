//using FightingArena;//remove this befor safe it for judge
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class ArenaTests
    {
        private Arena arena;
        private Warrior w1;
        private Warrior w2;
        private Warrior attacker;
        private Warrior deffender;

        [SetUp]
        public void Setup()
        {
            this.arena = new Arena();

            this.w1 = new Warrior("Pesho", 5, 50);

            this.w2 = new Warrior("Gosho", 5, 60);

            this.attacker = new Warrior("Ivan", 10, 80);

            this.deffender = new Warrior("Andrei", 5, 60);
        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            Assert.IsNotNull(this.arena.Warriors);
        }

        [Test]
        public void EnrollShouldAddTheWarriorToTheArena()
        {
            //Act
            this.arena.Enroll(this.w1);

            //Assert
            Assert.That(this.arena.Warriors, Has.Member(this.w1));
        }

        [Test]
        public void EnrollShouldIncreaceCount()
        {
            //Arrange
            int expectedCount = 2;

            //Act
            this.arena.Enroll(w1);
            this.arena.Enroll(w2);

            int actualCount = this.arena.Count;

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void EntrollSameWarriorShouldTrhowInvalidOperationException()
        {
            //Arrange
            this.arena.Enroll(this.w1);

            //Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                //Act
                this.arena.Enroll(this.w1);
            });
        }

        [Test]
        public void EntrollTwoWarriorsWithSameNameShouldThrowllInavalidOperationException()
        {
            //Arrange
            Warrior w1Coppy = new Warrior(w1.Name, w1.Damage, w1.HP);

            arena.Enroll(this.w1);

            //Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                //Act
                this.arena.Enroll(w1Coppy);
            });
        }

        [Test]
        public void TestFightingWithMissingAttackerShouldThrowInvalidOperationException()
        {
            //Arrange
            this.arena.Enroll(this.deffender);

            //Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                //Act
                this.arena.Fight(this.attacker.Name, this.deffender.Name);
            });
        }

        [Test]
        public void TestFightingWithMissingDeffenderShouldThrowInvalidOperationException()
        {
            //Arrange
            this.arena.Enroll(this.attacker);

            //Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                //Act
                this.arena.Fight(this.attacker.Name, this.deffender.Name);
            });
        }

        [Test]
        public void TestFightingBetweenThoWarriorsShouldReturnProperValues()
        {
            //Arrange
            int expectedAttackerHP = this.attacker.HP - this.deffender.Damage;
            int expectedDeffenderHP = this.deffender.HP - this.attacker.Damage;

            this.arena.Enroll(this.attacker);
            this.arena.Enroll(this.deffender);

            //Act
            this.arena.Fight(this.attacker.Name, this.deffender.Name);

            //Assert
            Assert.AreEqual(expectedAttackerHP, this.attacker.HP);
            Assert.AreEqual(expectedDeffenderHP, this.deffender.HP);

        }
    }
}
