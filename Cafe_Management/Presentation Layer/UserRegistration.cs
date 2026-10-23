using Cafe_Management.Data_Access_Layer;
using Cafe_Management.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management.Presentation_Layer
{
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void UserRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void surityCheckBox_Click(object sender, EventArgs e)
        {
            if (submitButton.Enabled == false)
            {
                submitButton.Enabled = true;
            }
            else
                submitButton.Enabled = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else if (confirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Confirm password cannot be empty");
            }
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("Email cannot be empty");
            }
            else if (dateOfBirthDateTimePicker.Text == "")
            {
                MessageBox.Show("Select a date");
            }
            else if (maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                MessageBox.Show("Select a gender");
            }
            else if (phoneNumberTextBox.Text=="")
            {
                MessageBox.Show("Give Phone Number");
            }
            else if (userTypeComboBox.Text=="")
            {
                MessageBox.Show("Select User Type");
            }
            else
            {
                if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and confirm password does not match");
                }
                else
                {
                    

                    User user = new User();
                    user.Name = nameTextBox.Text;
                    user.Username = usernameTextBox.Text;
                    user.Password = passwordTextBox.Text;
                    user.Email = emailTextBox.Text;
                    user.DateOfBirth = dateOfBirthDateTimePicker.Text;
                    user.PhoneNumber = phoneNumberTextBox.Text;
                    if (maleRadioButton.Checked)
                    {
                        user.Gender = "Male";
                    }
                    else
                    {
                        user.Gender = "Female";
                    }
                   // user.BloodGroup = bloodGroupComboBox.Text;
                    user.UserType = userTypeComboBox.Text;


                    UserDataAccess userDataAccess = new UserDataAccess();
                    if (userDataAccess.UserRegister(user))
                    {
                        MessageBox.Show("User added");
                        //Login login = new Login();
                        //login.Show();
                        //this.Hide();
                        ManageEmployee manageEmployee = new ManageEmployee();
                        manageEmployee.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error in adding");
                    }

                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmployee = new ManageEmployee();
            manageEmployee.Show();
            this.Hide();
        }
    }
}
