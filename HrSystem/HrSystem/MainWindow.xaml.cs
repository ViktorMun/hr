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
using System.Collections.ObjectModel;

namespace HrSystem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {/// <summary>
     /// 1.	Создать сущности Employee и Department и заполнить списки сущностей начальными данными.
     /// </summary>
     /// создание сущностей Employees department

        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        ObservableCollection<Department> departments = new ObservableCollection<Department>();

        Department it = new Department(nameof(it));
        Department hr = new Department(nameof(hr));
        Department support = new Department(nameof(support));
        public MainWindow()
        {
            InitializeComponent();
            FillList();
        }

        private void FillList()
        {//добавление департаментов
            departments.Add(it);
            departments.Add(hr);
            departments.Add(support);
            //добавление сотрудников
            employees.Add(new Employee("Иван", "Иванов",  it));
            employees.Add(new Employee("Сергей", "Сергеев", it));
            employees.Add(new Employee("Дмитрий", "Дмитриев", it));
            employees.Add(new Employee("Олеся", "Олесеевна", support));
            employees.Add(new Employee("Джон", "Джоннов", support));
            employees.Add(new Employee("Макл", "Майклов",  it));
            employees.Add(new Employee("Руслан", "Русланов",  hr));
            ShowEmployees.ItemsSource = employees;
            ShowDepartments.ItemsSource = departments;
        }
        ///2.	Для списка сотрудников и списка департаментов предусмотреть визуализацию (отображение). 
        private void ShowEmployees_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void ShowDepartments_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
