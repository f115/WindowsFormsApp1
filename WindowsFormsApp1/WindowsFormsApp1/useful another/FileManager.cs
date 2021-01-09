using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysecondFormsApp1
{
    class FileManager
    {
        public static void WriteLogs(string path, string userEmail, bool login)
        {
            if (File.AppendAllText(path))
            {
                File.AppendAllText(path, GetLogInfo(userEmail, login));
            }
            else
            {
                File.WriteAllText(path, GetLogInfo(userEmail, login));
            }

        }

        public static string GetPath(string folder, string filename)
        {
            DirectoryInfo directoryInfo = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString());
            string path = $"{directoryInfo}/{folder}/{filename}";
            return path;
        }

        private static string GetLogInfo(string userEmail, bool logIn)
        {
            DateTime time = DateTime.Now;
            string formattedTime = $"{time.Day}/{time.Month}/{time.Year}/{time.Hour}:{time.Minute}:{time.Second}";
            string log = string.Empty;
            if (logIn)
            {
                log = $"\nUser { userEmail} logged in. Time: {formattedTime}";
            }
            else
            {
                log = $"\nUser { userEmail} logged out. Time: {formattedTime}";
            }
            return log;
        }

        public static string GetNewFileNameUserPicture(string oldFileName)
        {
            Random random = new Random();

            string newFilename = $"userPicture{random.Next()}.png";
            string path = GetPath("pics", newFilename);
            File.Copy(oldFileName, path);

            return path;
        }
    }
}
