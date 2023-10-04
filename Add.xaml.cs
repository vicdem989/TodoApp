using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Input.Manipulations;
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
        //private int toDoCount = 0;
        public static List<ToDoElement> amountOfToDos = new List<ToDoElement>();

        public Add()
        {
            InitializeComponent();
        }

        private void TxtInputName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        
        private void BtnAddConfirm_Click(object sender, RoutedEventArgs e)
        {
            addElement();

        }

        private void addElement()
        {
            amountOfToDos.Add(new ToDoElement() {
                id = GlobalVariables.toDoCount++,
                name = TxtInputName.Text,
                description = TxtInputDesc.Text
            });

        }

        private ToDoElement FindToDo(int ID)
        {
            var chosen = amountOfToDos.First(x => x.id == ID);
            return chosen;

        }

        private void txtFind_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

    public class ToDoElement
    {
        public int id { get; set; } = 0;
        public string name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;

    }
}
    