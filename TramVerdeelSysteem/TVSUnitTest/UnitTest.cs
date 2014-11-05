using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVSLibrary;

namespace TVSUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestTram()
        {
            Sector sector = new Sector(1, new Track(1, 1, new Remise("TestRemise")));
            TramDriver td = new TramDriver(1, "TestName");

            Tram tram = new Tram("TestType", 1);
            Assert.AreEqual(tram.TramType, "TestType");
            Assert.AreEqual(tram.TramId, 1);

            tram.SetTramDriver(td);
            Assert.AreEqual(tram.Tramdriver, td);

            tram.SetSector(sector);
            Assert.AreEqual(tram.Sector, sector);

            Assert.AreEqual(tram.Status, Status.Service);
            tram.SendToCleaning();
            Assert.AreEqual(tram.Status, Status.Cleaning);
            tram.SendToRepair();
            Assert.AreEqual(tram.Status, Status.Defect);
            tram.SetStatus(Status.Parked);
            Assert.AreEqual(tram.Status, Status.Parked);
        }

        public void TestSector()
        {
            Tram tram = new Tram("TestType", 1);
            Track track = new Track(1, 1, new Remise("TestRemise"));

            Sector sector = new Sector(1, track);

            Assert.AreEqual(sector.Number, 1);
            Assert.AreEqual(sector.Available, true);
            Assert.AreEqual(sector.Blocked, false);
            Assert.AreEqual(sector.Track, track);

            sector.ToggleAvailable();
            Assert.AreEqual(sector.Available, false);

            sector.ToggleBlocked();
            Assert.AreEqual(sector.Blocked, true);

            sector.SetTram(tram);
            Assert.AreEqual(sector.Tram, tram);
        }
    }
}
