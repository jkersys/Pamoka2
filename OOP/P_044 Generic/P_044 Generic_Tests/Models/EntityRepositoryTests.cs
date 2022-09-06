using Microsoft.VisualStudio.TestTools.UnitTesting;
using P_044_Generic.Interface;
using P_044_Generic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_044_Generic.Models.Tests
{
    [TestClass()]
    public class EntityRepositoryTests
    {
        [TestMethod()]
        public void Add_AddingNewUser_ReturnDifferentCount()
        {     //Arrange
            int expected = 2;
            EntityRepository<IUser> repository = new EntityRepository<IUser>();
            IUser fakePrivateClient = new PrivateClient();
            IUser fakeBuisnessClient = new BusinessClient();
            //Act
            repository.Add(fakePrivateClient);
            repository.Add(fakeBuisnessClient);
            int actual = repository.Fetch().Count();
            //Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Fetch_CreatingWitchCtr_ReturnSameList()
        {
            //Arrange
            IUser fakePrivateClient = new PrivateClient();
            IUser fakeBusinessClient = new BusinessClient();
            List<IUser> expected = new List<IUser>()
            { fakePrivateClient, fakeBusinessClient};
            List<IUser> fakeUsers = new List<IUser>()
            { fakePrivateClient, fakeBusinessClient };
            EntityRepository<IUser> repository = new EntityRepository<IUser>(fakeUsers);

            //Act
            List<IUser> actual = repository.Fetch();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
            Assert.AreEqual(expected[0].Name, actual[0].Name);
            Assert.AreEqual(expected[1].Name, actual[1].Name);
        }

        [TestMethod()]
        public void Remove_CreatingWithCtr_ReturnSmallerList()
        {
            //Arrange
            IUser fakePrivateClient = new PrivateClient();
            IUser fakeBusinessClient = new BusinessClient();
            List<IUser> expected = new List<IUser>()
            { fakePrivateClient};
            List<IUser> fakeUsers = new List<IUser>()
            { fakePrivateClient, fakeBusinessClient };
            EntityRepository<IUser> repository = new EntityRepository<IUser>(fakeUsers);

            //Act
            repository.Remove(fakeBusinessClient);
            List<IUser> actual = repository.Fetch();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}