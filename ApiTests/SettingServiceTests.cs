using System;
using System.Linq;
using Api;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace ApiTests
{
    public class SettingServiceTests
    {
        [Test]
        public void Insert()
        {
            var options = new DbContextOptionsBuilder<SettingsStoreContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var settingsDbContext = new SettingsStoreContext(options);
            var settingsService = new SettingsService(settingsDbContext);

            var settingsModel = new settings
                {id = Guid.NewGuid(), category = "Theme", name = "DarkMode", value = "true"};
            settingsService.Insert(settingsModel);

            var settingsDbRecords = settingsDbContext.Settings.ToList();
            Assert.AreEqual(1, settingsDbRecords.Count);
            var settingsDbRecord = settingsDbRecords.Single();
            Assert.That(settingsDbRecord.Equals(settingsModel));
        }
    }
}