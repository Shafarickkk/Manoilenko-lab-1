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

namespace Lab01
{
    public partial class Lab01 : Form
    {
        string login, password;

        public Lab01()
        {
            login = "admin";
            password = "12345";
            InitializeComponent();
        }


        private void button_start_Click(object sender, EventArgs e)
        {
            // для кращого результату треба все хешувати
            // хеш пароля зроблений з солями, для підвищення захисту взлому

            if (textBox_login.Text == login && textBox_password.Text  == password)
            {
                status_color.BackColor = Color.Green;
                MessageBox.Show("авторизовано");
            }
            else
            {
                status_color.BackColor = Color.Red;
                MessageBox.Show("помилка");
            }
        }

        
    }
}
