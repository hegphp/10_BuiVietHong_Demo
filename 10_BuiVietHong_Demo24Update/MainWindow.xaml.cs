using _10_BuiVietHong_Demo24Update.Models;
using _10_BuiVietHong_Demo24Update.Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _10_BuiVietHong_Demo24Update
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ManageContact manageContact = new ManageContact();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                manageContact.LoadContacts();
                ContactListView.ItemsSource = manageContact.GetContacts();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message, "Load contacts");
            }
        }

        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //check if one of the textboxes is empty
                if (ContactIdTextBox.Text == "" || ContactNameTextBox.Text == "" || PhoneTextBox.Text == "" || CompanyNameTextBox.Text == "")
                {
                    throw new Exception("Please fill all the textboxes");
                }
                //Confirm to insert the contact
                MessageBoxResult result = MessageBox.Show("Do you want to insert this contact?", "Insert contact", MessageBoxButton.YesNo);
                var contact = new Contact
                {
                    ContactID = ContactIdTextBox.Text,
                    ContactName = ContactNameTextBox.Text,
                    Phone = PhoneTextBox.Text,
                    CompanyName = CompanyNameTextBox.Text
                };
                manageContact.AddNewContact(contact);
                LoadButton_Click(sender, e);
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message, "Insert contact");
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            try {
                var contact = new Contact
                {
                    CompanyName = CompanyNameTextBox.Text,
                    ContactID = ContactIdTextBox.Text,
                    ContactName = ContactNameTextBox.Text,
                    Phone = PhoneTextBox.Text,
                };
                manageContact.UpdateContact(contact);
                LoadButton_Click(sender, e);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Update contact");
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //deleteContact by selected contact id
                var selectedContact = (Contact)ContactListView.SelectedItem;
                manageContact.DeleteContact(selectedContact.ContactID);
                LoadButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete contact");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            //Exit the program
            Application.Current.Shutdown();
        }
    }
}