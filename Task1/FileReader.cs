using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    public class FileReader
    {
        public static void WriteLineToFile(string fileName, string line)
        {
            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine(line);
            }
        }

        public static List<string> ReadLogin(string filename, string login)
        {
            string line;
            List<string> logins = new List<string>();

            StreamReader file = new StreamReader(filename);

            while ((line = file.ReadLine()) != null)
            {
                string log = line;
                logins.Add(log);

            }
            file.Close();
            return logins;
        }

        public static List<double> ReadPasswords(string filename, string password)
        {
            string line;
            List<string> passwords = new List<string>();
            List<double> speeds = new List<double>();

            StreamReader file = new StreamReader(filename);
            while ((line = file.ReadLine()) != null)
            {
                string pass = ReadPassword(line);
                double sp = Convert.ToDouble(ReadPasswordSpeed(line));

                if (pass == password)
                {
                    passwords.Add(pass);
                    speeds.Add(sp);
                }
            }
            file.Close();
            return speeds;
        }

        public static List<double> ReadPasswordsDayTime(string filename, string password)
        {
            string line;
            List<string> passwords = new List<string>();
            List<double> speeds = new List<double>();

            StreamReader file = new StreamReader(filename);
            while ((line = file.ReadLine()) != null)
            {
                string pass = ReadPassword(line);
                double sp = Convert.ToDouble(ReadPasswordSpeed(line));
                int daytimenowt = DateTime.Now.Hour;
                int daytimenow = TimeToInt(daytimenowt);
                double daytime = ReadPasswordDayTime(line);

                if (pass == password && daytimenow == daytime)
                {
                    passwords.Add(pass);
                    speeds.Add(sp);
                }
            }
            file.Close();
            return speeds;
        }

        public static int TimeToInt(double time)
        {
            int dayortime = 1;
            if (time >= 6 && time < 12)
                dayortime = 2;
            if (time >= 12 && time < 18)
                dayortime = 3;
            if (time >= 18 && time < 24)
                dayortime = 4;
            return dayortime;
        }

        public static string ReadPassword(string line)
        {
            string pass = "";
            int index = GetIndexOfParser(line);
            pass += line.Substring(0, index);
            return pass;
        }

        public static string ReadPasswordSpeed(string password)
        {
            string time = "";
            int index = GetIndexOfParser(password);
            int index2 = GetIndexOfParser2(password);
            time += password.Substring(index + 1, index2 - index - 1);
            return time;
        }

        public static int ReadPasswordDayTime(string password)
        {
            int dayortime = 1;
            string time = "";
            int index2 = GetIndexOfParser2(password);
            time += password.Substring(index2 + 1, password.Length - index2 - 1);
            double time2 = Convert.ToDouble(time);
            if (time2 >= 6 && time2 < 12)
                dayortime = 2;
            if (time2 >= 12 && time2 < 18)
                dayortime = 3;
            if (time2 >= 18 && time2 < 24)
                dayortime = 4;
            return dayortime;
        }

        public static int GetIndexOfParser(string line)
        {
            int index = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line.Substring(i, 1) == ";")
                {
                    index = i;
                    return index;
                }
            }
            return index;
        }

        public static int GetIndexOfParser2(string line)
        {
            int index = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line.Substring(i, 1) == ";")
                    index = i;
            }
            return index;
        }
    }
}
