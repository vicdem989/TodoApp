using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Todo_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            displayToDo.ItemsSource = Add.amountOfToDos;
        }

        private void BtnAdd_Click_1(object sender, RoutedEventArgs e)
        {
            Add OpenAddWindow = new Add();
            OpenAddWindow.Show();
            


        }

        public void UpdateList()
        {
            txtOutput.Text = "";
            if (Add.amountOfToDos.Count > 0)
            {
                for (int i = 0; i < Add.amountOfToDos.Count; i++)
                {
                    txtOutput.Text += Add.amountOfToDos[i].id.ToString() + " - " + Add.amountOfToDos[i].name + " - " + Add.amountOfToDos[i].description + "\n";
                }
            }
            displayToDo.ItemsSource = Add.amountOfToDos;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            UpdateList();
        }
    }
}
