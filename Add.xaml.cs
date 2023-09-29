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
using System.Windows.Shapes;

namespace Todo_App
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public List<ToDoElement> toDos = new List<ToDoElement>();

        public Add()
        {
            InitializeComponent();
        }

        private void TxtInputName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnAddConfirm_Click(object sender, RoutedEventArgs e)
        {
            ToDoElement task1 = new ToDoElement();
            addToList(task1, TxtInputName.Text, TxtInputDesc.Text);

            TxtTempOutput.Text = "";
            foreach (ToDoElement task in toDos)
            {
                TxtTempOutput.Text += (task1.name + " " +task1.description);
            }

        }

        public void addToList(ToDoElement ElementName, string Name, string Description)
        {
            ElementName.name = Name;
            ElementName.description = Description;
            toDos.Add(ElementName);
        }
    }

    public class ToDoElement
    {
        public int id = 0;
        public string name = string.Empty;
        public string description = string.Empty;

    }
}
