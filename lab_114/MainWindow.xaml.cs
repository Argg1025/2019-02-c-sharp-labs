using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;


namespace lab_114
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers = new List<Customer>();
        List<string> customerList = new List<string>();
        Customer customer;
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
                People.ItemsSource = customers;
                People.DisplayMemberPath = "ContactName"; ;
            }
        }

        public void PeopleSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customer = (Customer)People.SelectedItem;
            Selected.Text = $"{customer.ContactName}\n {customer.City}\n {customer.Country}";
            string name = customer.ContactName;

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new NorthwindEntities())
            {
                var customerToUpdate =
                        db.Customers.Where(c => c.ContactName == customer.ContactName).FirstOrDefault();
                if (!UpdateName.Text.Equals("")) customerToUpdate.ContactName = UpdateName.Text;
                db.SaveChanges();
            }
        }
    }
}
