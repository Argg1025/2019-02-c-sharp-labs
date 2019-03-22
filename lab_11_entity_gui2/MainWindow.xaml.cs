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
//using System.Windows.Data;


namespace lab_11_entity_gui2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers = new List<Customer>();
        List<string> customerList = new List<string>();
        Customer customer;
        List<string> cities = new List<string>();

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

                foreach (var c in customers)
                {
                    customerList.Add($"{c.ContactName} has ID {c.CustomerID} company name: {c.CompanyName}  contact title: {c.ContactTitle} address: {c.Address} city: {c.City}  country: {c.Country}  region: {c.Region} postcode: {c.PostalCode} phone: {c.Phone} fax: {c.Fax}.");
                }

                ListBox01.ItemsSource = customerList;
                
            }

            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
                ListBox02.ItemsSource = customers;

            }

            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
                ListBox03.ItemsSource = customers;
                ListBox03.DisplayMemberPath = "ContactName";

            }

            // populate static combo
            ComboBoxStaticCity.Items.Add("New York");
            ComboBoxStaticCity.Items.Add("Florence");
            ComboBoxStaticCity.Items.Add("London");
            using (var db = new NorthwindEntities())
            {
                cities =
                    (from cust in db.Customers
                     select cust.City).Distinct().OrderByDescending(city=>city).ToList<string>();
                ComboBoxBoundToCity.ItemsSource = cities;
            }
        }

        private void ListBox03_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customer = (Customer)ListBox03.SelectedItem;
            TextBoxName.Text = customer.ContactName;
        }

        private void ComboBoxStaticCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show($"You chose {ComboBoxStaticCity.SelectedItem}");
        }

        private void ComboBoxBoundToCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
