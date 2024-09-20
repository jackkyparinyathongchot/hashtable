using System.Collections;
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

namespace HashmapApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void addbt_Click(object sender, RoutedEventArgs e)
        {
            //add
            hashtable.Add(txtKey.Text, txtValue);
            MessageBox.Show("add "+txtKey.Text+" "+txtValue.Text+" success");
        }

        private void removebt_Click(object sender, RoutedEventArgs e)
        {
            //remove
            hashtable.Remove(txtKey.Text);
            MessageBox.Show("remove " + txtKey.Text + " " + txtValue.Text + " success");
        }

        private void showbt_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;
            //show
            foreach (string key in icollection)
            {
                MessageBox.Show(hashtable[key].ToString());
            }
        }
    }
}