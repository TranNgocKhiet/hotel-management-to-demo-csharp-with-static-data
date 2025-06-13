namespace BusinessObjects
{
    public partial class Customer
    {
        public int CustomerID { get; set; }
        public string? CustomerFullName { get; set; }
        public string? Telephone { get; set; }
        public string EmailAddress { get; set; }
        public DateOnly? CustomerBirthday { get; set; }
        public Byte? CustomerStatus { get; set; }
        public string Password { get; set; }

        public Customer() { }

        public Customer(int customerID, string? customerFullName, string? telephone, 
            string emailAddress, DateOnly? customerBirthday, Byte? customerStatus, string password)
        {
            CustomerID = customerID;
            CustomerFullName = customerFullName;
            Telephone = telephone;
            EmailAddress = emailAddress;
            CustomerBirthday = customerBirthday;
            CustomerStatus = customerStatus;
            this.Password = password;
        }
    }
}
