using BusinessObjects;
using Repositories;
using Services;
using System.Text.Json;
using System.Windows;
using System.Text.Json;
using System.IO;

namespace TranNgocKhietWPF
{
    public partial class LoginWindow : Window   
    {
        private readonly ICustomerService iCustomerService;

        public LoginWindow()
        {
            InitializeComponent();
            var customerRepository = CustomerRepository.Instance;
            var customerService = new CustomerService(customerRepository);
            iCustomerService = customerService;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string jsonString = File.ReadAllText("appsetting.json");
            Customer admin = JsonSerializer.Deserialize<Customer>(jsonString);

            Customer customer = iCustomerService.Login(txtEmail.Text, txtPass.Password);
            if (admin != null 
                && admin.EmailAddress.Equals(txtEmail.Text) 
                && admin.Password.Equals(txtPass.Password))
            {
                this.Hide();
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();
            }
            else if (customer != null)
            {
                this.Hide();
                UserWindow userWindow = new UserWindow(customer);
                userWindow.Show();
            }
            else
            {
                MessageBox.Show("You are not permission!");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
