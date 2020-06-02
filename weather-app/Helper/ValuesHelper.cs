using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace weather_app.Helper
{
    public static class ValuesHelper
    {
        public static string ReadFile()
        {
            string result;
            try
            {
                FileStream fileStream = new FileStream("/data/testfile.txt", FileMode.Open);
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    result = reader.ReadLine();
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
    }
}
