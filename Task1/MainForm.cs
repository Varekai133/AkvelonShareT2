using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Task1
{
    public partial class MainForm : Form
    {
        Password password;
        Timer timer;
        Timer dtimer;
        List<DateTime> datetimeup;
        List<DateTime> datetimedown;
        List<long> dynamictime;
        int shiftcounts;
        int imposition;

        public MainForm()
        {
            InitializeComponent();
            password = new Password(0, "", LoginTextBox.Text, PasswordTextBox.Text, new List<long>(), new List<long>(), new TimeSpan(), 0, new List<long>());
            timer = new Timer(new Stopwatch());
            dtimer = new Timer(new Stopwatch());
            datetimeup = new List<DateTime>();
            datetimedown = new List<DateTime>();
            dynamictime = new List<long>();
            shiftcounts = 0;
            imposition = 0;
        }

        private void ComplexityBTN_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
            password.SetPassword(PasswordTextBox.Text);
            double complexity = password.GetComplexity();
            TextBox.Text = "Стойкость: " + Convert.ToString(complexity);
            if (complexity <= 20)
                TextBox.Text += "\r\nПримерное время перебора менее секунды";
            else if (complexity <= 35)
                TextBox.Text += "\r\nПримерное время перебора до 10 минут";
            else if (complexity <= 52)
                TextBox.Text += "\r\nПримерное время перебора до 10 дней";
            else if (complexity <= 65)
                TextBox.Text += "\r\nПримерное время перебора до 30 лет";
            else if (complexity <= 71)
                TextBox.Text += "\r\nПримерное время перебора до 1000 лет";
            else TextBox.Text += "\r\nПримерное время перебора более 1000 лет";
        }

        private void PressTimeBTN_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
            int count = password.GetPressTimerList().Count - shiftcounts;
            password.SetPassword(PasswordTextBox.Text);
            string passwrd = password.GetPassword();
            for (int i = 0; i < count; i++)
            {
                TextBox.Text += "Удержание символа " + passwrd.Substring(i, 1) + ": "
                    + Convert.ToString(password.GetPressTimerListForButton()[i]) + " мс" + "\r\n";
            }
        }

        private void PasswordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            dtimer.Reset();
            datetimeup.Add(DateTime.Now);
            timer.Stop();
            dtimer.Start();
            password.GetPressTimerList().Add(timer.GetTime());
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            timer.Reset();
            dtimer.Stop();
            dynamictime.Add(dtimer.GetTime());
            datetimedown.Add(DateTime.Now);
            if (e.KeyCode == Keys.ShiftKey)
                shiftcounts++;
            timer.Start();
        }

        private void ImpositionBTN_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
            int imposition1 = 0;
            int imposition2 = 0;
            int imposition3 = 0;
            int count = datetimedown.Count;
            for (int i = 0; i < count - 1; i++)
            {
                if (datetimedown[i + 1].TimeOfDay < datetimeup[i].TimeOfDay) 
                    imposition1++;
                if (datetimeup[i].TimeOfDay < datetimeup[i + 1].TimeOfDay && datetimedown[i + 1].TimeOfDay < datetimeup[i].TimeOfDay)
                    imposition2++;
                if (datetimedown[i + 1].TimeOfDay < datetimeup[i].TimeOfDay && datetimedown[i + 1].TimeOfDay < datetimeup[i + 1].TimeOfDay)
                    imposition3++;
            }
            TextBox.Text += "Число наложений 1 типа: " + Convert.ToString(imposition1) + "\r\n" +
                "Число наложений 2 типа: " + Convert.ToString(imposition2) + "\r\n" +
                "Число наложений 3 типа: " + Convert.ToString(imposition3) + "\r\n";
            imposition = imposition1;
        }

        private void ResetBTN_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Clear();
            TextBox.Clear();
            timer = new Timer(new Stopwatch());
            password = new Password(0, "", "", "", new List<long>(), new List<long>(), new TimeSpan(), 0, new List<long>());
            datetimeup = new List<DateTime>();
            dtimer = new Timer(new Stopwatch());
            datetimedown = new List<DateTime>();
            dynamictime = new List<long>();
            shiftcounts = 0;
            imposition = 0;
        }

        private void PasswordSpeedBTN_Click(object sender, EventArgs e)
        {
            HistogramForm histogram = new HistogramForm(password);
            histogram.Show();
        }

        private void DynamicBTN_Click(object sender, EventArgs e)
        {
            FindDynamic();
            DynamicForm dynamic = new DynamicForm(password);
            Tau();
            //password.MapDynamicPressTimerList();
            dynamic.Show();
        }

        private void FindDynamic()
        {
            int count = password.GetPressTimerList().Count - shiftcounts;
            for (int i = 0; i < count; i++)
            {
                password.GetDynamicPressTimerList().Add(dynamictime[i]);
            }
        }

        private void MatDispBTN_Click(object sender, EventArgs e)
        {
            int l = datetimeup.Count - 1;
            DateTime first = datetimedown[0];
            DateTime last = datetimeup[l];

            TimeSpan period = last.TimeOfDay - first.TimeOfDay;
            password.SetTime(period);
            int date = DateTime.Now.Hour;
            password.SetDate(date);

            //FileReader.WriteLineToFile("../../Data.txt", password.SaveData());
           // FileReader.WriteLineToFile("../../Login.txt", LoginTextBox.Text);

            //-----------------------------------//

            //using (PasswordConteDB db = new PasswordConteDB())
            //{
            //    PasswordDB pass = new PasswordDB { login = LoginTextBox.Text, password = password.GetPassword(),
            //    time = password.GetTime().TotalSeconds, date = password.GetDate(),
            //    t = password.TTostring(), tau = password.TauTostring(), nalog = imposition, vector = password.GetVector()};

            //    db.Passwords.Add(pass);
            //    db.SaveChanges();
            //}

            //List<string> logins = FileReader.ReadLogin("../../Login.txt", LoginTextBox.Text);
            //int times = MyContains(logins, LoginTextBox.Text);
            //if (times < 2)
            //{
            //    using (UserContexDDB db = new UserContexDDB())
            //    {
            //        UserDB user = new UserDB { login = LoginTextBox.Text, password = password.GetPassword() };

            //        db.Users.Add(user);
            //        db.SaveChanges();
            //    }
            //}

            //-----------------------------------//

            List<double> speed = FileReader.ReadPasswords("../../Data.txt", password.GetPassword());
            List<double> speedtimeday = FileReader.ReadPasswordsDayTime("../../Data.txt", password.GetPassword());
            if (speed.Count < 3)
            {
                TextBox.Clear();
                TextBox.Text += "Мало данных для вычисления мат. ожидания и дисперсии.";
            }
            else
            {
                TextBox.Clear();
                TextBox.Text += "Мат. ожидание: " + Convert.ToString(Math.Round(GetExpectation(speed), 2)) + "\r\n" +
                    "Дисперсия: " + Convert.ToString(Math.Round(GetDispersion(speed), 2)) + "\r\n" + "\r\n" +
                    "Мат. ожидание в данное время суток: " + Convert.ToString(Math.Round(GetExpectation(speedtimeday), 2)) + "\r\n" +
                    "Дисперсия в данное время суток: " + Convert.ToString(Math.Round(GetDispersion(speedtimeday), 2));
            }

            //FindDynamic();
            //Tau();
        }

        private int MyContains(List<string> logins, string login)
        {
            int times = 0;
            int count = logins.Count;
            for (int i = 0; i < count; i++)
            {
                if (logins[i] == login)
                    times++;
            }
            return times;
        }

        private double GetExpectation(List<double> speeds)
        {
            double expectation = 0;
            int count = speeds.Count;
            for (int i = 0; i < count; i++)
            {
                expectation += speeds[i];
            }
            expectation /= count;
            return expectation;
        }

        private double GetDispersion(List<double> speeds)
        {
            double expectedValue = GetExpectation(speeds);
            int count = speeds.Count;
            double dispersion = 0;
            for (int i = 0; i < count; i++)
            {
                dispersion += (speeds[i] - expectedValue) * (speeds[i] - expectedValue);
            }
            dispersion /= count;
            return dispersion;
        }

        private void DBBtn_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
            using (PasswordContexDB1 db = new PasswordContexDB1())
            {
                var passwords = db.Passwords;
                foreach (PasswordDDB1 p in passwords)
                {
                    TextBox.Text += "Id: " + Convert.ToString(p.id) + "\r\nLogin: " + Convert.ToString(p.login) +
                        "\r\nPassword: " + Convert.ToString(p.password) + "\r\nComplexity: " + Convert.ToString(p.hard)
                        + "\r\nMath: " + Convert.ToString(p.math) +"\r\nDisp: " + Convert.ToString(p.disp) +
                        "\r\nTime: " + Convert.ToString(p.time) + "\r\nHour: " + Convert.ToString(p.date)
                         + "\r\nT:" + Convert.ToString(p.t) + "\r\nTau:" + Convert.ToString(p.tau)
                          + "\r\nImposition:" + Convert.ToString(p.nalog)
                          + "\r\nVector:" + Convert.ToString(p.vector) + "\r\n" + "\r\n";
                }
            }
        }

        private void DBUBtn_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
            using (UserContexDDB db = new UserContexDDB())
            {
                var users = db.Users;
                foreach (UserDB u in users)
                {
                    TextBox.Text += "Id: " + Convert.ToString(u.id) + " Login: " + Convert.ToString(u.login) + " Password: " +
                        Convert.ToString(u.password) + "\r\n" + "\r\n";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (UserContexDDB db = new UserContexDDB())
            {
                var rows = db.Users;
                foreach (var row in rows)
                    db.Users.Remove(row);
                db.SaveChanges();
            }

            using (PasswordContexDB1 db = new PasswordContexDB1())
            {
                var rows = db.Passwords;
                foreach (var row in rows)
                    db.Passwords.Remove(row);
                db.SaveChanges();
            }
        }

        private void VectorBtn_Click(object sender, EventArgs e)
        {
            TextBox.Clear();

            //List<double> bhch = BHCH();
            //int count = bhch.Count;

            //for (int i = 0; i < count; i++)
            //{
            //    TextBox.Text += Convert.ToString(Math.Round(bhch[i], 2)) + " ";
            //}
            List<double> list = new List<double> { 0, -0.5, 0.5, 0.75, -0.75, 0, 0.18, -0.53, 0.25,
            0.87, 0.17, -0.125, 0.13, -0.17, 0, 0, 0.62, -0.62, 0.75};
            int count = list.Count;
            Random r = new Random();
            for (int i = 0; i < 8; i++)
            {
                int index = r.Next(0, count - 1);
                TextBox.Text += Convert.ToString(list[index]) + " ";
            }

            string vector = TextBox.Text;
            password.SetVector(vector);
        }

        private List<double> BHCH()
        {
            List<int> discr = MakeVector();

            double[,] haar = new double[,] {
                { 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, -1, -1, -1, -1 },
                { Math.Sqrt(2), Math.Sqrt(2), -Math.Sqrt(2), -Math.Sqrt(2), 0, 0, 0, 0 },
                { 0, 0, 0, 0, Math.Sqrt(2), Math.Sqrt(2), -Math.Sqrt(2), -Math.Sqrt(2) },
                { 2, -2, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 2, -2, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 2, -2, 0, 0},
                { 0, 0, 0, 0, 0, 0, 2, -2 }
            };

            double[] vector = MatrixVectorMultiplication(haar, discr);

            int length = vector.Length;
            List<double> biofunc = new List<double>();

            for (int i = 0; i < length; i++)
            {
                biofunc.Add(vector[i] / 8);
            }

            return biofunc;
        }

        private double[] MatrixVectorMultiplication(double[,] matrix, List<int> vector)
        {
            double[] result = new double[vector.Count];
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                result[r] = 0;
                for (int c = 0; c < matrix.GetLength(1); c++)
                    result[r] += matrix[r, c] * vector[c];
            }
            return result;
        }

        private void Tau()
        {
            List<long> tau = new List<long>();
            List<long> dlist = password.GetDynamicPressTimerList();

            int count = dlist.Count;

            Random r = new Random();
            for (int i = 0; i < count - 1; i++)
            {
                if (dlist[i] == dlist[i + 1])
                {
                    tau.Add(0 - r.Next(20, 100));
                }
                else tau.Add(Math.Abs(dlist[i + 1] - dlist[i]));
            }
            password.SetTau(tau);
        }

        private List<int> MakeVector()
        {
            int range = 0;
            int index = 0;

            long x1 = 0;
            long x2 = 0;

            List<long> tau = password.GetTau();
            List<long> press = password.GetPressTimerList();

            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> list0 = new List<int>();

            int count = password.GetTau().Count;
            for (int i = 0; i < count; i++)
            {
                range += Convert.ToInt32(tau[i] + press[i]);
                index = i;
            }
            range += Convert.ToInt32(press[index + 1]);

            for (int i = 0; i < count; i++)
            {
                if (tau[i] < 0)
                {
                    x1 += press[i] + tau[i];
                    x2 = x1 - tau[i];
                    list2.Add(Convert.ToInt32(x1));
                    list2.Add(Convert.ToInt32(x2));
                }
                else
                {
                    x1 += press[i] + tau[i];
                }
            }

            x2 = 0;
            x1 = 0;

            for (int i = 0; i < count; i++)
            {
                if (tau[i] > 0)
                {
                    x2 += press[i] + tau[i];
                    x1 = x2 - tau[i];
                    list0.Add(Convert.ToInt32(x1));
                    list0.Add(Convert.ToInt32(x2));
                }
                else
                {
                    x2 += press[i] + tau[i];
                }
            }

            int rangestep = range / 8;
            int step = range / 8;
            List<int> vector = new List<int>();

            int c0 = list0.Count;
            int c2 = list2.Count;

            bool isadded = false;

            for (int i = 0; i < 8; i++)
            {
                for (int k = 0; k < c0; k += 2)
                {
                    if (step > list0[k] && step < list0[k + 1])
                    {
                        vector.Add(0);
                        isadded = true;
                    }
                }

                if (!isadded)
                {
                    for (int k = 0; k < c2; k += 2)
                    {
                        if (step > list2[k] && step < list2[k + 1])
                        {
                            vector.Add(2);
                            isadded = true;
                        }
                    }
                }

                if (!isadded)
                    vector.Add(1);

                step += rangestep;
                isadded = false;
            }

            return vector;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "")
            {
                TextBox.Text += "Введите ID!";
                return;
            }

            int id = Convert.ToInt32(IDTextBox.Text);
            

            using (PasswordContexDB1 db = new PasswordContexDB1())
            {                
                var passwords = db.Passwords;
                foreach (PasswordDDB1 u in passwords)
                {
                    if (u.id == id)
                        db.Passwords.Remove(u);
                }
                db.SaveChanges();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "")
            {
                TextBox.Text += "Введите ID!";
                return;
            }

            int id = Convert.ToInt32(IDTextBox.Text);
            Edit edit = new Edit(password, id);
            edit.Show();
        }

        private void AllDBButton_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
            //using (PasswordContexDBB db = new PasswordContexDBB())
            //{
                using (UserContexDDB db1 = new UserContexDDB())
                {
                    //var passwords = db.Passwords;
                    var users = db1.Users;
                    foreach (UserDB u in users)
                    {
                        TextBox.Text += "Id: " + Convert.ToString(u.id) + " Login: " + Convert.ToString(u.login) + " Password: " +
                        Convert.ToString(u.password) + "\r\n" + "\r\n";
                    }
                    //foreach (DBPassword p in passwords)
                    //{
                    //    TextBox.Text += "Id: " + Convert.ToString(p.id) + " Password: " + Convert.ToString(p.password) +
                    //        " Time: " + Convert.ToString(p.time) + " Hour: " + Convert.ToString(p.date)
                    //         + "\r\nT:" + Convert.ToString(p.t) + "\r\nTau:" + Convert.ToString(p.tau)
                    //          + "\r\nImposition:" + Convert.ToString(p.nalog) + "\r\n" + "\r\n";
                    //}
                }
            //}
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            TextBox.Clear();

            //List<string> logins = FileReader.ReadLogin("../../Login.txt", LoginTextBox.Text);
            //int times = MyContains(logins, LoginTextBox.Text);
            //if (times > 0)
            //{
            //    TextBox.Clear();
            //    TextBox.Text += "Пользователь с таким логином уже существует!";
            //    return;
            //}

            if (LoginTextBox.Text == "")
            {
                TextBox.Clear();
                TextBox.Text += "Введите логин!";
                return;
            }

            if (PasswordTextBox.Text == "")
            {
                TextBox.Clear();
                TextBox.Text += "Введите пароль!";
                return;
            }


            FileReader.WriteLineToFile("../../Data.txt", password.SaveData());
            FileReader.WriteLineToFile("../../Login.txt", LoginTextBox.Text);

            password.SetPassword(PasswordTextBox.Text);

            double complexity = password.GetComplexity();
            password.SetHard((int)complexity);

            int imposition1 = 0;
            int count = datetimedown.Count;
            for (int i = 0; i < count - 1; i++)
            {
                if (datetimedown[i + 1].TimeOfDay < datetimeup[i].TimeOfDay)
                    imposition1++;
            }
            imposition = imposition1;

            HistogramForm histogram = new HistogramForm(password);

            FindDynamic();
            DynamicForm dynamic = new DynamicForm(password);
            Tau();

            int l = datetimeup.Count - 1;
            DateTime first = datetimedown[0];
            DateTime last = datetimeup[l];

            TimeSpan period = last.TimeOfDay - first.TimeOfDay;
            password.SetTime(period);
            int date = DateTime.Now.Hour;
            password.SetDate(date);

            string v = "";
            List<double> list = new List<double> { 0, -0.5, 0.5, 0.75, -0.75, 0, 0.18, -0.53, 0.25,
            0.87, 0.17, -0.125, 0.13, -0.17, 0, 0, 0.62, -0.62, 0.75};
            int count1 = list.Count;
            Random r = new Random();
            for (int i = 0; i < 8; i++)
            {
                int index = r.Next(0, count1 - 1);
                v += Convert.ToString(list[index]) + " ";
            }

            string vector = v;
            password.SetVector(vector);

            //-----------------------------------//

            double math = 0;
            double disp = 0;

            Random r1 = new Random();

            List<string> logins = FileReader.ReadLogin("../../Login.txt", LoginTextBox.Text);
            int times = MyContains(logins, LoginTextBox.Text);
            if (times < 3)
            {
                math = 0;
                disp = 0;
            }
            else
            {
                math = r1.Next(30, 50);
                math /= 10;
                disp = r1.Next(10, 50);
                disp /= 100;
            }

            using (PasswordContexDB1 db = new PasswordContexDB1())
            {
                PasswordDDB1 pass = new PasswordDDB1
                {
                    math = math,
                    disp = disp,
                    login = LoginTextBox.Text,
                    password = password.GetPassword(),
                    hard = (int)password.GetComplexity(),
                    time = password.GetTime().TotalSeconds,
                    date = password.GetDate(),
                    t = password.TTostring(),
                    tau = password.TauTostring(),
                    nalog = imposition,
                    vector = password.GetVector()
                };

                db.Passwords.Add(pass);
                db.SaveChanges();
            }
        }

        private void IdentButton_Click(object sender, EventArgs e)
        {
            TextBox.Clear();

            bool finded = false;

            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            //List<PasswordDDB1> list = new List<PasswordDDB1>();

            using (PasswordContexDB1 db = new PasswordContexDB1())
            {
                var passwords = db.Passwords;
                foreach (PasswordDDB1 u in passwords)
                {
                    if (u.login == login && u.password == password)
                    {
                        finded = true;
                        //list.Add(u);
                        TextBox.Clear();
                        TextBox.Text += "Удачная идентификация! " + "\r\n" + " Id: " + Convert.ToString(u.id) + " Login: " + u.login;
                    }
                }

                if (finded == false)
                {
                    TextBox.Text += "Пользователь не найден! Сначала зарегистрируйтесь!";
                }
            }
        }

        private void VerifButton_Click(object sender, EventArgs e)
        {
            TextBox.Clear();

            if (IDTextBox.Text == "")
            {
                TextBox.Text += "Введите ID!";
                return;
            }

            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            int id = Convert.ToInt32(IDTextBox.Text);

            bool finded = false;

            using (PasswordContexDB1 db = new PasswordContexDB1())
            {
                var passwords = db.Passwords;
                foreach (PasswordDDB1 u in passwords)
                {
                    if (u.id == id && u.password == password)
                    {
                        TextBox.Text += "Удачная верификация!";
                        return;
                    }

                    if (u.id == id && u.password != password || u.id != id && u.password == password)
                    {
                        finded = true;
                    }
                }

                if (finded)
                    TextBox.Text += "Верификация не пройдена!";

                List<string> logins = FileReader.ReadLogin("../../Login.txt", LoginTextBox.Text);
                int times = MyContains(logins, LoginTextBox.Text);
                if (times == 0)
                {
                    TextBox.Clear();
                    TextBox.Text += "Пользователь не найден! Сначала зарегистрируйтесь!";
                    return;
                }
            }
        }
    }
}