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
        private int toDoCount = 0;
        public ToDoElement[] findToDo = new ToDoElement[150];

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

            //MessageBox.Show(FindToDo(int.Parse(txtFind.Text)).name);

        }

        private void addElement()
        {
            findToDo[toDoCount] = new ToDoElement();
            findToDo[toDoCount].id = toDoCount;
            findToDo[toDoCount].name = TxtInputName.Text;
            findToDo[toDoCount].description = TxtInputDesc.Text;
        }

        private ToDoElement FindToDo(int ID)
        {
            var chosen = findToDo.First(x => x.id == ID);
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
    