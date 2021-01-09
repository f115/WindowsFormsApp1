using MysecondFormsApp1.project;
using MysecondFormsApp1;
using System;
using System.Windows.Forms;
using WindowsFormsApp1.useful_another;

namespace WindowsFormsApp1
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation.Validate(txbx_logemail.Text, txbx_logpassword.Text))
                {
                    validlogin = true;
                    MessageBox.Show("Finally you did it ALL.");
                }

                if (validlogin)
                {
                    string
                        email = txbx_logemail.Text,
                        password = txbx_logpassword.Text;

                    if (Users.HasUser(password, email))
                    {
                        Hide();
                        Session.User = Users.GetUser(email, password);
                        Session.MainForm1 = this;

                        if (user.UserRole = UserRole.)
                        {
                            Adminpanel adminpanel = Session.AdminPanel == null ? new Adminpanel() : Session.AdminPanel;

                        }
                        else (user.UserRole = UserRole.User);
                        {
                            Dashboard dashboard = Session.Dashboard == null ? new Dashboard() : Session.Dashboard;
                            dashboard.ShowDialog();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Finally you didn't do it.");

                    }
                }
                 catch (Exception)
                 {

                throw;
                }

  
                    txbx_logemail.Text = string.Empty;
                    txbx_logpassword.Text = string.Empty;

                


            }
        

        private void btn_register_Click(object sender, EventArgs e)
        {

            try
            {
                string
                      name = txbx_name.Text,
                      surname = txbx_surname.Text,
                     email = txbx_email.Text,
                      password = txbx_password.Text;
                         age = txbx_age.Text;



                Validation.Validate(name, surname, age, email, password);
                sbyte convertAge = Validation.IsAgeValueValid(age, 0);
                if (!Users.HasUser(email, password))
                {
                    User user = new User(name, surname, age, email, password);
                   user.UserRole = UserRole.User;

                    AccountManager.SendMail(email);
                    Session.User = user;
                    Session.Code = AccountManager.confirmationCode;
                    Confform confform = new Confform();
                    confform.ShowDialog();

                }
                        if (user.IsEmailConfirmed)
                        {
                          Users.AddUser(user);
                          MessageBox.Show( "ok now you a succesfuly user");
                        }
                        else
                        {

                               MessageBox.Show("Finally you didn't do it.");
                        }

            }
            catch(ArgumentNullException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (FormatException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (InvalidAgeValueException exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                txbx_name.Text = string.Empty;
                txbx_surname.Text = string.Empty;
                txbx_email.Text = string.Empty;
                txbx_password.Text = string.Empty;
                txbx_age.Text = string.Empty;
            }

        }
    } 
}

