namespace HW8_offline
{
    public class StoreInfo
    {
        private static StoreInfo _instance;
        private readonly string _folderPath = @".\Store";

        private StoreInfo()
        {
        }

        public string StoreFolderPath
        {
            get { return _folderPath; }
        }

        public static StoreInfo GetInstance()
        {
            if (_instance == null)
            {
                _instance = new StoreInfo();
            }

            return _instance;
        }
    }
}
