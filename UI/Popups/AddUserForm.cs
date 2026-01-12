using System;
using System.Windows.Forms;
using RentalApp.Data.Repositories;
using RentalApp.Models.Users;

namespace RentalApp.UI.Popups
{
    public partial class AddUserForm : Form
    {
        private UserRepository _userRepository;

        public AddUserForm()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
            InitializeRoles();
        }

        private void InitializeRoles()
        {
            roleComboBox.Items.Add("RentalAgent");
            roleComboBox.Items.Add("Manager");
            roleComboBox.Items.Add("Admin");
            roleComboBox.SelectedIndex = 0; // Default to RentalAgent
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text) ||
                roleComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Check if username exists
            if (_userRepository.UsernameExists(usernameTextBox.Text))
            {
                MessageBox.Show("Username already exists. Please choose another.");
                return;
            }

            try
            {
                // Create user object
                User newUser = null;
                string role = roleComboBox.SelectedItem.ToString();
                
                // Using 0 as ID since it will be auto-incremented
                if (role == "Admin")
                    newUser = new Admin(0, firstNameTextBox.Text, lastNameTextBox.Text, usernameTextBox.Text);
                else if (role == "Manager")
                    newUser = new Manager(0, firstNameTextBox.Text, lastNameTextBox.Text, usernameTextBox.Text);
                else
                    newUser = new RentalAgent(0, firstNameTextBox.Text, lastNameTextBox.Text, usernameTextBox.Text);

                newUser.SetPassword(passwordTextBox.Text);

                // Add to database
                _userRepository.Add(newUser);

                MessageBox.Show("User added successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
