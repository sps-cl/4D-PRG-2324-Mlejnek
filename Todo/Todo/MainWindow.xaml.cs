using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ToDoListApp
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> ToDoItems { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ToDoItems = new ObservableCollection<string>();
            lstToDo.ItemsSource = ToDoItems;
            txtTitle.KeyDown += TxtTitle_KeyDown;
            txtDescription.KeyDown += TxtDescription_KeyDown;
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            AddToDoItem();
        }

        private void RemoveAll_Click(object sender, RoutedEventArgs e)
        {
            ToDoItems.Clear();
        }
        private void TxtTitle_GotFocus(object sender, RoutedEventArgs e)
        {
            txtTitle.Text = "";
            txtTitle.Foreground = System.Windows.Media.Brushes.Black;
        }

        private void TxtTitle_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                txtTitle.Text = "Název";
                txtTitle.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void TxtDescription_GotFocus(object sender, RoutedEventArgs e)
        {
            txtDescription.Text = "";
            txtDescription.Foreground = System.Windows.Media.Brushes.Black;
        }

        private void TxtDescription_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                txtDescription.Text = "Popis";
                txtDescription.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void TxtTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                AddToDoItem();
            }
        }

        private void TxtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                AddToDoItem();
            }
        }

        private void AddToDoItem()
        {
            string title = txtTitle.Text;
            string description = txtDescription.Text;

            if (!string.IsNullOrWhiteSpace(title) && title != "Název")
            {
                if (description != "Popis")
                {
                    string newItem = $"{title}: {description}";
                    ToDoItems.Add(newItem);
                    txtTitle.Text = "Název";
                    txtDescription.Text = "Popis";
                    txtTitle.Foreground = System.Windows.Media.Brushes.Gray;
                    txtDescription.Foreground = System.Windows.Media.Brushes.Gray;
                }
                else
                {
                    string newItem = $"{title}";
                    ToDoItems.Add(newItem);
                    txtTitle.Text = "Název";
                    txtDescription.Text = "Popis";
                    txtTitle.Foreground = System.Windows.Media.Brushes.Gray;
                    txtDescription.Foreground = System.Windows.Media.Brushes.Gray;
                }
            }
            else
            {
                MessageBox.Show("Zadejte prosím název položky.");
            }
        }
    }
}
