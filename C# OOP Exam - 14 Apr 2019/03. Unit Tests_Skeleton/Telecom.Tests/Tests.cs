namespace Telecom.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class Tests
    {
        private Phone phone;
        private string model="3310";
        private string make = "Nokia";
        private Dictionary<string, string> phonebook;
        
        [SetUp]
        public void SetUp()
        {
            this.phonebook = new Dictionary<string, string>();

            this.phone = new Phone(make, model);
        }

        [Test]
        public void CheckIfConstructorWorkCorrectly()
        {
            Assert.That(make.Equals(phone.Make));
            Assert.That(model.Equals(phone.Model));
        }

    [Test]
        [TestCase(null)]
        [TestCase("")]
        public void MakeShouldThrowArgumentExceptionIfInitializeWithNullOrEmpty(string make)
        {
            //Assert
            Assert.Throws<ArgumentException>(() =>
            {
                //Act
                this.phone = new Phone(make, model);
            });
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void ModelShouldThrowArgumentExceptionIfInitializeWithNullOrEmpty(string model)
        {
            //Assert
            Assert.Throws<ArgumentException>(() =>
            {
                //Act
                this.phone = new Phone(make, model);
            });
        }

        [Test]
        public void CountShouldReturnCurrentCountOfContactsInThePhonebook()
        {
            //Arrange
            
            //Act
            this.phonebook.Add("Dragan", "0888555666");

            var expected = 1;
            var actual = this.phonebook.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CountShouldReturnZeroWhenThereAreNotCurrentContactsInThePhonebook()
        {
            //Arrange
            var expected = 0;
            var actual = this.phonebook.Count;

            //Act

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddingThreeDifferentContactsInPhoneBookShouldReturnCountEqualTo3()
        {
            //Arrange

            //Act
            this.phonebook.Add("Dragan", "0888555666");
            this.phonebook.Add("Pesho", "0888777666");
            this.phonebook.Add("Gosho", "0888444666");

            var expected = 3;
            var actual = this.phonebook.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddSamePersonInPhonebookShouldThrowInvalidOperationException()
        {
            //Arrange
            this.phone.AddContact(make, model);

            //Assert

            Assert.Throws<InvalidOperationException>(() =>
            {
                //Act
                this.phone.AddContact(make, "anotherModel");
            }).Message.Equals("Person already exists!");
        }

        [Test]
        public void TryingToCallToUnExisstingUserShouldThrowInvalidOperationException()
        {
            //Arrange
            this.phone.AddContact(make, model);

            //Assert

            Assert.Throws<InvalidOperationException>(() =>
            {
                //Act
                this.phone.Call("Someone");
            }).Message.Equals("Person doesn't exists!");
        }

        [Test]
        public void SuccessfullCall()
        {
            phone.AddContact(make, model);
            var expectedResult = $"Calling { make} - { model}...";

            //Assert
            Assert.AreEqual(expectedResult, phone.Call(make));
        } 
        
        //Do not forget to remove all references and added usings( if any )and save before send it to judge
    }
}