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
using WPFIntroduction.Model;

namespace WPFIntroduction
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<User> _User = new List<User>();

        public MainWindow()
        {
            InitializeComponent();

            _User.Add(new User() { Id = Guid.NewGuid(), Email = "Test1@seznam.cz", Name = "Pepa" });
            _User.Add(new User() { Id = Guid.NewGuid(), Email = "Test2@seznam.cz", Name = "Josef" });
            _User.Add(new User() { Id = Guid.NewGuid(), Email = "Test3@seznam.cz", Name = "Pepík" });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello world!");

            foreach (var Item in _User)
            {
                TreeViewItem treeItem = new TreeViewItem();
                treeItem.Header = Item.Name;

                StackPanel stack = new StackPanel();
                stack.Orientation = Orientation.Horizontal;

                Label label0 = new Label();
                label0.Content = Item.Email;
                stack.Children.Add(label0);

                Label label1 = new Label();
                label1.Content = Item.Id;
                stack.Children.Add(label1);

                treeItem.Items.Add(stack);

                MyTree.Items.Add(treeItem);
            }
        }
    }
}
