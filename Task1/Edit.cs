using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Edit : Form
    {
        int index;
        Password password;
        int id;

        public Edit(Password pass, int id)
        {
            InitializeComponent();
            GetPassword(pass);
            GetId(id);
        }

        public void GetPassword(Password password)
        {
            this.password = password;
        }

        public void GetId(int id)
        {
            this.id = id;
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            index = 1;
            EditTextBox.Clear();
            using (PasswordContexDB1 db = new PasswordContexDB1())
            {
                var passwords = db.Passwords;
                foreach (PasswordDDB1 u in passwords)
                {
                    if (u.id == id)
                    {
                        EditTextBox.Text += Convert.ToString(u.login);
                    }
                }
            }
        }

        private void SaveEditButton_Click(object sender, EventArgs e)
        {
            string text = EditTextBox.Text;
            using (PasswordContexDB1 db = new PasswordContexDB1())
            {
                var passwords = db.Passwords;
                foreach (PasswordDDB1 u in passwords)
                {
                    if (u.id == id)
                    {
                        db.Passwords.Remove(u);
                        PasswordDDB1 pass = Save(u);
                        db.Passwords.Add(pass);
                    }
                }
                db.SaveChanges();
            }
        }


        private void PassBTN_Click(object sender, EventArgs e)
        {
            index = 2;
            EditTextBox.Clear();
            using (PasswordContexDB1 db = new PasswordContexDB1())
            {
                var passwords = db.Passwords;
                foreach (PasswordDDB1 u in passwords)
                {
                    if (u.id == id)
                    {
                        EditTextBox.Text += Convert.ToString(u.password);
                    }
                }
            }
        }

        private void TimeBTN_Click(object sender, EventArgs e)
        {
            index = 3;
            EditTextBox.Clear();
            using (PasswordContexDB1 db = new PasswordContexDB1())
            {
                var passwords = db.Passwords;
                foreach (PasswordDDB1 u in passwords)
                {
                    if (u.id == id)
                    {
                        EditTextBox.Text += Convert.ToString(u.time);
                    }
                }
            }
        }

        private void DateBTN_Click(object sender, EventArgs e)
        {
            index = 4;
            EditTextBox.Clear();
            using (PasswordContexDB1 db = new PasswordContexDB1())
            {
                var passwords = db.Passwords;
                foreach (PasswordDDB1 u in passwords)
                {
                    if (u.id == id)
                    {
                        EditTextBox.Text += Convert.ToString(u.date);
                    }
                }
            }
        }

        private void TBTN_Click(object sender, EventArgs e)
        {
            index = 5;
            EditTextBox.Clear();
            using (PasswordContexDB1 db = new PasswordContexDB1())
            {
                var passwords = db.Passwords;
                foreach (PasswordDDB1 u in passwords)
                {
                    if (u.id == id)
                    {
                        EditTextBox.Text += Convert.ToString(u.t);
                    }
                }
            }
        }

        private void TauBTN_Click(object sender, EventArgs e)
        {
            index = 6;
            EditTextBox.Clear();
            using (PasswordContexDB1 db = new PasswordContexDB1())
            {
                var passwords = db.Passwords;
                foreach (PasswordDDB1 u in passwords)
                {
                    if (u.id == id)
                    {
                        EditTextBox.Text += Convert.ToString(u.tau);
                    }
                }
            }
        }

        private void NalogBTN_Click(object sender, EventArgs e)
        {
            index = 7;
            EditTextBox.Clear();
            using (PasswordContexDB1 db = new PasswordContexDB1())
            {
                var passwords = db.Passwords;
                foreach (PasswordDDB1 u in passwords)
                {
                    if (u.id == id)
                    {
                        EditTextBox.Text += Convert.ToString(u.nalog);
                    }
                }
            }
        }

        private void VectorBTN_Click(object sender, EventArgs e)
        {
            index = 8;
            EditTextBox.Clear();
            using (PasswordContexDB1 db = new PasswordContexDB1())
            {
                var passwords = db.Passwords;
                foreach (PasswordDDB1 u in passwords)
                {
                    if (u.id == id)
                    {
                        EditTextBox.Text += Convert.ToString(u.vector);
                    }
                }
            }
        }

        private void ComplButton_Click(object sender, EventArgs e)
        {
            index = 9;
            EditTextBox.Clear();
            using (PasswordContexDB1 db = new PasswordContexDB1())
            {
                var passwords = db.Passwords;
                foreach (PasswordDDB1 u in passwords)
                {
                    if (u.id == id)
                    {
                        EditTextBox.Text += Convert.ToString(u.hard);
                    }
                }
            }
        }

        private void MathButton_Click(object sender, EventArgs e)
        {
            index = 10;
            EditTextBox.Clear();
            using (PasswordContexDB1 db = new PasswordContexDB1())
            {
                var passwords = db.Passwords;
                foreach (PasswordDDB1 u in passwords)
                {
                    if (u.id == id)
                    {
                        EditTextBox.Text += Convert.ToString(u.math);
                    }
                }
            }
        }

        private void DispButton_Click(object sender, EventArgs e)
        {
            index = 11;
            EditTextBox.Clear();
            using (PasswordContexDB1 db = new PasswordContexDB1())
            {
                var passwords = db.Passwords;
                foreach (PasswordDDB1 u in passwords)
                {
                    if (u.id == id)
                    {
                        EditTextBox.Text += Convert.ToString(u.disp);
                    }
                }
            }
        }
    }
}
