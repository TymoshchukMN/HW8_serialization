using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW8_offline
{
    public class Handler
    {
        /// <summary>
        /// Резистрация пользователя.
        /// </summary>
        /// <param name="user">Пользователь.</param>
        public static void RunRegistration(User user)
        {
            StoreInfo storeInfo = StoreInfo.GetInstance();

            if (!Directory.Exists(storeInfo.StoreFolderPath))
            {
                Directory.CreateDirectory(storeInfo.StoreFolderPath);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(User));

            string filePath = $"{storeInfo.StoreFolderPath}\\{user.Login}.xml";
            using (FileStream fileStream =
                new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(fileStream, user);
                fileStream.Close();
            }
        }
    }
}
