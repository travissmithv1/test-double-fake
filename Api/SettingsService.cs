namespace Api
{
    public class SettingsService
    {
        private readonly SettingsStoreContext _settingsStoreContext;

        public SettingsService(SettingsStoreContext settingsStoreContext)
        {
            _settingsStoreContext = settingsStoreContext;
        }
        
        public void Insert(settings settingsModel)
        {
            _settingsStoreContext.Settings.Add(settingsModel);
            _settingsStoreContext.SaveChanges();
        }
    }
}