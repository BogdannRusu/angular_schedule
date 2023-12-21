using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Athena.DataModule;
using MaterialSkin.Controls;
using MaterialSkin;
//using Athena.DataModule;


namespace Athena
{
    public partial class SignUpFormView : Form
    {
        public SignUpFormView()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var login = new LogInFormView();
            login.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertUsers();
        }

        public void InsertUsers()
        {
            var username = textBoxUsername.Text;
            var password = textBoxPass.Text;
            var email = textBoxEmail.Text;

            using (var context = new AthenaDbContext())
            {
                var newUser = new users
                {
                   name = username,
                   password = EncryptPassword(password),
                   email = email,
                   is_active = 1

                };

                context.users.Add(newUser);
                context.SaveChanges();
                if (checkBoxTerms.Checked)
                {
                    MessageBox.Show("Sa inserat userul cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                 else { MessageBox.Show("A aparut o eroare la inserare!!! Mai incercati din nou", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                

            }
        }

        public static string EncryptPassword(string pass)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pass));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private void textBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] sensitiveChars = { '*', '$', '#' };

            if (sensitiveChars.Contains(e.KeyChar))
            {
                e.KeyChar = '*';
            }
        }

        private void textBoxRePass_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] sensitiveChars = { '*', '$', '#' };

            if (sensitiveChars.Contains(e.KeyChar))
            {
                e.KeyChar = '*';
            }
        }
    }
}
