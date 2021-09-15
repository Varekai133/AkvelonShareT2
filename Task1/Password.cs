using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.IO;

namespace Task1
{
    public class Password
    {
        private int hard;
        private string login;
        private string password;
        private List<long> presstimerlist;
        private List<long> dynamicpresstimerlist;
        private TimeSpan time;
        private int date;
        private List<long> tau;
        public string vector;

        public Password()
        {
            
        }

        public Password(string password)
        {
            this.password = password;
        }

        public Password(int hard, string vector, string login, string password, List<long> presstimerlist, List<long> dynamicpresstimerlist, TimeSpan time, int date, List<long> tau)
        {
            this.hard = hard;
            this.vector = vector;
            this.login = login;
            this.password = password;
            this.presstimerlist = presstimerlist;
            this.dynamicpresstimerlist = dynamicpresstimerlist;
            this.time = time;
            this.date = date;
            this.tau = tau;
        }

        public void SetHard(int hard)
        {
            this.hard = hard;
        }

        public int GetHard()
        {
            return hard;
        }

        public void SetVector(string vector)
        {
            this.vector = vector;
        }

        public string GetVector()
        {
            return vector;
        }

        public string TTostring()
        {
            string str = "";
            int count = tau.Count();
            for (int i = 0; i < count; i++)
            {
                str += Convert.ToString(Math.Round(Convert.ToDouble(tau[i]), 2)) + " ";
            }
            return str;
        }

        public string TauTostring()
        {
            string str = "";
            int count = presstimerlist.Count();
            for (int i = 0; i < count; i++)
            {
                str += Convert.ToString(Math.Round(Convert.ToDouble(presstimerlist[i]), 2)) + " ";
            }
            return str;
        }

        public List<long> GetTau()
        {
            return tau;
        }

        public void SetTau(List<long> tau)
        {
            this.tau = tau;
        }

        public void SetLogin(string login)
        {
            this.login = login;
        }

        public string GetLogin()
        {
            return login;
        }

        public void SetTime(TimeSpan time)
        {
            this.time = time;
        }

        public void SetDate(int date)
        {
            this.date = date;
        }

        public TimeSpan GetTime()
        {
            return time;
        }

        public int GetDate()
        {
            return date;
        }

        public void ClearDynamicPressTimerList()
        {
            dynamicpresstimerlist.Clear();
        }

        public List<long> GetDynamicPressTimerList()
        {
            return dynamicpresstimerlist;
        }

        public List<long> GetPressTimerList()
        {
            return presstimerlist;
        }

        public List<long> GetDynamicPressTimerListForButton()
        {
            MapDynamicPressTimerList();
            return dynamicpresstimerlist;
        }

        public List<long> GetPressTimerListForButton()
        {
            MapPressTimerList();
            return presstimerlist;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }

        public string SaveData()
        {
            return password + ";" + Convert.ToString(time.TotalSeconds) + ";" + Convert.ToString(date);
        }

        public double GetComplexity()
        {
            int length = password.Length;
            int complexityNumber = 0;
            Regex symbols = new Regex("[$&+,:;=?@#|'<>.^*()%!-]");
            Regex numbers = new Regex("^[0-9]+$");
            Regex uppercaseLetters = new Regex("[A-ZА-ЯЁ]");
            Regex lowercaseLetters = new Regex("[a-zа-яё]");

            if (symbols.IsMatch(password))
                complexityNumber += 22;
            if (numbers.IsMatch(password))
                complexityNumber += 10;
            if (uppercaseLetters.IsMatch(password))
                complexityNumber += 59;
            if (lowercaseLetters.IsMatch(password))
                complexityNumber += 59;
            
            double bincomplexity = Math.Round((Math.Log(Math.Pow(complexityNumber, length), 2)));

            return bincomplexity;
        }

        public void MapDynamicPressTimerList()
        {
            Random r = new Random();
            List<long> d = new List<long>();
            int count = dynamicpresstimerlist.Count;
            for (int i = 0; i < count - 1; i++)
            {
                if (i + 1 < count)
                {
                    if (dynamicpresstimerlist[i] == dynamicpresstimerlist[i + 1])
                    {
                        d.Add(dynamicpresstimerlist[i]);
                        d.Add(dynamicpresstimerlist[i] - r.Next(1, 10));
                        i++;
                    }
                    else d.Add(dynamicpresstimerlist[i]);
                }
                else d.Add(dynamicpresstimerlist[i]);
            }
            dynamicpresstimerlist = d;
        }

        public void MapPressTimerList()
        {
            Random r = new Random();
            List<long> d = new List<long>();
            int count = presstimerlist.Count;
            for (int i = 0; i < count; i++)
            {
                if (i + 1 < count)
                {
                    if (presstimerlist[i] == presstimerlist[i + 1])
                    {
                        d.Add(presstimerlist[i]);
                        d.Add(presstimerlist[i] + r.Next(1, 10));
                        i++;
                    }
                    else d.Add(presstimerlist[i]);
                }
                else d.Add(presstimerlist[i]);
            }
            presstimerlist = d;
        }
    }
}
