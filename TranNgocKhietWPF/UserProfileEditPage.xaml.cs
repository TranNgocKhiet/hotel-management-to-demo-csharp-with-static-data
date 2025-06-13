using BusinessObjects;
using Repositories;
using Services;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace TranNgocKhietWPF
{
    public partial class UserProfileEditPage : Page
    {
        private readonly ICustomerService iCustomerService;
        private Customer currentUser;

        public UserProfileEditPage(Customer user)
        {
            InitializeComponent();

            var customerRepository = CustomerRepository.Instance;
            var customerService = new CustomerService(customerRepository);
            iCustomerService = customerService;

            currentUser = user;

            txtFullName.Text = currentUser.CustomerFullName;
            txtTelephone.Text = currentUser.Telephone;
            txtEmailAddress.Text = currentUser.EmailAddress;
            txtCustomerBirthday.Text = currentUser.CustomerBirthday.HasValue
                ? currentUser.CustomerBirthday.Value.ToString("dd/MM/yyyy") : "";
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string phone = txtTelephone.Text.Trim();
            string email = txtEmailAddress.Text.Trim();
            string birthdayText = txtCustomerBirthday.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Full name is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!Regex.IsMatch(phone, @"^\d{10}$"))
            {
                MessageBox.Show("Telephone must be 10 digits.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!DateOnly.TryParse(birthdayText, out var birthday))
            {
                MessageBox.Show("Invalid birthday format. Use yyyy-MM-dd or a valid date.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            currentUser.CustomerFullName = fullName;
            currentUser.Telephone = phone;
            currentUser.EmailAddress = email;
            currentUser.CustomerBirthday = birthday;

            iCustomerService.UpdateCustomer(currentUser);

            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
