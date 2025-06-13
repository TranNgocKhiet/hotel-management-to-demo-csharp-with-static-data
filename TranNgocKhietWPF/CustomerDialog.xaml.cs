using BusinessObjects;
using Services;
using System;
using System.Text.RegularExpressions;
using System.Windows;

namespace TranNgocKhietWPF
{
    public partial class CustomerDialog : Window
    {
        public Customer Customer { get; private set; }

        public CustomerDialog(Customer existingCustomer = null)
        {
            InitializeComponent();
            if (existingCustomer != null)
            {
                txtFullName.Text = existingCustomer.CustomerFullName;
                txtTelephone.Text = existingCustomer.Telephone;
                txtEmail.Text = existingCustomer.EmailAddress;
                txtStatus.Text = existingCustomer.CustomerStatus.ToString();
                txtPassword.Text = existingCustomer.Password;

                txtBirthday.Text = existingCustomer.CustomerBirthday.HasValue
                    ? existingCustomer.CustomerBirthday.Value.ToString("yyyy-MM-dd")
                    : "";

                Customer = existingCustomer;
            }
            else
            {
                Customer = new Customer();
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show("Full name is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                string telephone = txtTelephone.Text.Trim();
                if (string.IsNullOrWhiteSpace(telephone))
                {
                    MessageBox.Show("Telephone is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                if (!Regex.IsMatch(telephone, @"^\d{10}$"))
                {
                    MessageBox.Show("Telephone must contain only digits (10 numbers).", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Password is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (!DateOnly.TryParse(txtBirthday.Text, out DateOnly birthday))
                {
                    MessageBox.Show("Invalid birthday format. Use yyyy-MM-dd.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (!byte.TryParse(txtStatus.Text, out byte status))
                {
                    MessageBox.Show("Status must be a number (1 = Active, 2 = Inactive).", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (status != 1 && status != 2)
                {
                    MessageBox.Show("Status must be 1 (Active) or 2 (Inactive).", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                Customer.CustomerFullName = txtFullName.Text.Trim();
                Customer.Telephone = txtTelephone.Text.Trim();
                Customer.EmailAddress = txtEmail.Text.Trim();
                Customer.Password = txtPassword.Text;
                Customer.CustomerBirthday = birthday;
                Customer.CustomerStatus = status;

                DialogResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
