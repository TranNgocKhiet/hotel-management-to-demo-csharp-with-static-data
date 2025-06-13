using Repositories;
using Services;
using System.Windows;
using System.Windows.Controls;
using BusinessObjects;

namespace TranNgocKhietWPF
{
    public partial class CustomerListPage : Page
    {
        private readonly ICustomerService iCustomerService;

        public CustomerListPage()
        {
            InitializeComponent();

            var customerRepository = new CustomerRepository();
            var customerService = new CustomerService(customerRepository);
            iCustomerService = customerService;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCustomerList();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string keyword = SearchTextBox.Text.ToLower().Trim();

            try
            {
                var allCustomers = iCustomerService.GetCustomers();
                var filtered = allCustomers
                    .Where(c => !string.IsNullOrEmpty(c.CustomerFullName) && c.CustomerFullName.ToLower().Contains(keyword))
                    .ToList();

                CustomerDataGrid.ItemsSource = null;
                CustomerDataGrid.ItemsSource = filtered;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed.\n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void LoadCustomerList()
        {
            try
            {
                var customers = iCustomerService.GetCustomers();
                CustomerDataGrid.ItemsSource = null;
                CustomerDataGrid.ItemsSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of customers");
            }
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new CustomerDialog();
            if (dialog.ShowDialog() == true)
            {
                Customer newCustomer = dialog.Customer;

                var customers = iCustomerService.GetCustomers();

                int autoIncreaseID = 1;

                var usedIDs = new HashSet<int>(customers.Select(c => c.CustomerID));

                while (usedIDs.Contains(autoIncreaseID))
                {
                    autoIncreaseID++;
                }

                newCustomer.CustomerID = autoIncreaseID;
                iCustomerService.AddCustomer(newCustomer);
                LoadCustomerList();
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (CustomerDataGrid.SelectedItem is Customer selectedCustomer)
            {
                var dialog = new CustomerDialog(selectedCustomer);
                if (dialog.ShowDialog() == true)
                {
                    iCustomerService.UpdateCustomer(dialog.Customer);
                    LoadCustomerList();
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to update!");
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedCustomer = CustomerDataGrid.SelectedItem as Customer;

            if (selectedCustomer == null)
            {
                MessageBox.Show("Please select a customer to delete.", "No Selection", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBoxResult result = MessageBox.Show(
                $"Are you sure you want to delete customer '{selectedCustomer.CustomerFullName}' (ID: {selectedCustomer.CustomerID})?",
                "Confirm Delete",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
            );

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    iCustomerService.RemoveCustomer(selectedCustomer);
                    MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                    LoadCustomerList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete customer.\n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
