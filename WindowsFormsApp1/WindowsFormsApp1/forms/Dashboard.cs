using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MysecondFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FiLeManager.WriteLogs(path, _user.Email,);

            Session.Form1.Show();
            Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            _user = Session.User;
            lbl_name.Text += "" + _user.Email;
            lbl_name.Text += "" + _user.Name;
            lbl_surname.Text += "" + _user.Surname;
            lbl_Age.Text += "" + _user.Age;

            string path = "C:/Users/Faiq/source/repos/MysecondFormsApp1/MysecondFormsApp1/Logs/logs.txt";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            var results = FileDialog.ShowDialog();
            string fileName = string.Empty;
            if (results == DialogResult.OK)
            {
                fileName = FileDialog.FileName;
                Random random = new Random();
                int number = random.Next();
                string newFilename = $"userPicture{number}.png";
                File.Copy(fileName, FileManager.GetPath("Pics", newFilename));
                ShowMyImage(fileName, 300, 300);
            }
        }
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.MainForm.Close();
        }
        User _user = Session.User;
        string path = GetPath("Logs", "logs.txt");


    }
}
