using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using HotelBookingApp.Facade;
using HotelBookingApp.Model;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetMethod()
        {
            var guest = new Guest(1, "Rudi", "Brobbers");

            guest = Facade.GetGuestAsync(1).Result;
            Assert.AreEqual(1, guest.Guest_No);

        }
    }
}
