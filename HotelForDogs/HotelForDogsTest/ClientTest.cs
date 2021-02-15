using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelForDogs;

namespace HotelForDogsTest
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Client client = new Client
            {
                FirstName = "Monika",
                LastName = "Macik"
            };

            string expected = "Monika Macik";

            //--Act
            string actual = client.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
