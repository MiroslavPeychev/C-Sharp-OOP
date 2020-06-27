namespace Tests
{
    using System;

    using NUnit.Framework;

    [TestFixture]
    public class DatabaseTests
    {
        private Database database;
        private readonly int[] initialData = new int[] { 1, 2 };

        [SetUp]
        public void Setup()
        {
            this.database = new Database(initialData);
        }

        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { })]
        public void TestIfConstructorWorksCorrectly(int[] data)
        {

            this.database = new Database(data);

            int expectedCount = data.Length;
            int actualCount = this.database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void ConstructorShouldThrowExceptionWhenInitializingWithBiggerCollection()
        {
            //We have limit of 16 elements in the array, so we test it with bigger collection
            int[] data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            //Type of Exeption.     // delegate(anonymous action)
            Assert.Throws<InvalidOperationException>(() =>
            {
                //code that should cause the exception
                this.database = new Database(data);
            });
        }

        [Test]
        public void AddShouldIncreaceCountWhenAddedSuccessfully()
        {
            this.database.Add(3);

            int expectedCount = 3;
            int actualCount = this.database.Count;

            Assert.AreEqual(expectedCount, actualCount, "Adding numbers doesn't update the count correctly");
        }

        [Test]
        public void AddShouldThrowInvalidOperationExceptionWhenDatabaseOverflow()
        {
            //1 2 3 4 ....16
            for (int i = 3; i <= 16; i++)
            {
                this.database.Add(i);
            }

            //The collection is full (16 elements are added in the collection)

            Assert.Throws<InvalidOperationException>(() =>
            {
                //Try to Add 17th item
                this.database.Add(17);
            });
        }

        [Test]
        public void RemoveShouldDecreaceCountWhenSuccess()
        {
            //Arrange
            int expectedCount = 1;

            //Act
            this.database.Remove();

            int actualCount = this.database.Count;

            //Assert
            Assert.AreEqual(expectedCount, actualCount, "Removing numbers doesn't update the count correctly");
        }

        [Test]
        public void RemoveShouldThrowInvalidOperationExceptionWhenDatabaseEmpty()
        {
            //Arrange
            this.database.Remove();
            this.database.Remove();
            //Database.Count = 0;(no items left)

            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() =>
           {
                //Collection is empty
                //Act
                this.database.Remove();
           });

            Assert.AreEqual("The collection is empty!", ex.Message);
        }

        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void FetchShouldReturnCopyOfData(int[] expectedData)
        {
            this.database = new Database(expectedData);

            //returned Copy
            int[] actualData = this.database.Fetch();
            //AreEquivalent proves that collections have the same elements but could be ordered in different order
            //CollectionAssert.AreEquivalent(expectedData, actualData);
            //AreEqual proves that collections have the same elements in exactly the same order
            CollectionAssert.AreEqual(expectedData, actualData);
        }
    }
}