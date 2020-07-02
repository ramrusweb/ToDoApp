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
        private BindingList<TodoModel> _todoDataList;

        public MainWindow()
        {
            InitializeComponent();
        }

        void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _todoDataList = new BindingList<TodoModel>()
            {
                new TodoModel() {Text = "test"},
                new TodoModel() {Text = "dfsdfsd"}
            };

            dgTodoList.ItemsSource = _todoDataList;
            _todoDataList.ListChanged += _todoDataList_ListChanged;
        }

        void _todoDataList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {

            }
        }
    }
}
