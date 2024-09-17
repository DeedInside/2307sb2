using _2307sb2.Model;
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

namespace _2307sb2
{
    public partial class MainWindow : Window
    {
        List<User> users;
        public MainWindow()
        {
            InitializeComponent();
            users = new List<User>()
            {
                new User("Name 1","Email","Pass", DateTime.Now),
                new User("Name 2","Email","Pass", DateTime.Now),
                new User("Name 3","Email","Pass", DateTime.Now)
            };
            ListBoxUser.ItemsSource = users;

            ComboBoxUser.ItemsSource = UserNames(users);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{check1.IsChecked.ToString()} - {check2.IsChecked.ToString()} - {check3.IsChecked.ToString()}");

        }

        private void check1_Checked(object sender, RoutedEventArgs e)
        {
            Stack_obr.Visibility = Visibility.Visible;
        }

        private void check1_Unchecked(object sender, RoutedEventArgs e)
        {
            Stack_obr.Visibility = Visibility.Collapsed;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            MessageBox.Show($"{rb.IsChecked.ToString()} - {rb.Content}");
        }

        private void ListBoxUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ListBox ListUser = (ListBox)sender;

                if (ListUser != null)
                {
                    if (ListUser.SelectedItem != null)
                    {
                        MessageBox.Show(ListUser.SelectedItem.ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error:" + ex);
            }
        }

        private void add_user_to_list(object sender, RoutedEventArgs e)
        {
            users.Add(new User("new Name", "new Emal", "new Pass", DateTime.Now));
            ListBoxUser.Items.Refresh();
        }
        List<string> UserNames(List<User> users)
        {
            List<string> result = new List<string>();

            foreach (User user in users)
            {
                result.Add(user.Name);
            }
            return result;
        }
    }
}