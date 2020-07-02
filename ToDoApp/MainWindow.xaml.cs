using System.ComponentModel;
using System.Windows;
using ToDoApp.Models;

namespace ToDoApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<TodoModel> _todoData;

        public MainWindow()
        {
            InitializeComponent();
        }

        void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _todoData = new BindingList<TodoModel>()
            {
                new TodoModel() {Text = "test"},
                new TodoModel() {Text = "dfsdfsd"}
            };

            dgTodoList.ItemsSource = _todoData;
        }
    }
}
