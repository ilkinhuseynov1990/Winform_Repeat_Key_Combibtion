using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string login = "admin";
            string password = "admin";
            bool ok = checkInputFields(loginTxt.Text.Trim(), paswordTxt.Text.Trim()) ;
            if (ok)
            {
                MessageBox.Show("Login or pasword is not empty");
                return;
            }

            if (loginTxt.Text.Trim() == login && password == "admin")
            {
                Dashboard dashboard = new Dashboard(this);
                dashboard.Show();
                this.Hide();
            } else if (loginTxt.Text.Trim() != login || paswordTxt.Text.Trim()!=password)
            {
                MessageBox.Show("Login or password is not correct","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }


        public bool checkInputFields(string login, string password)
        {
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
