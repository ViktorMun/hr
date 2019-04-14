using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HrSystem
{


    public partial class MainWindow
    {
        private Modal _FillList;
        ///2.	Для списка сотрудников и списка департаментов предусмотреть визуализацию (отображение). 
        private void ShowDepartments_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            RefreshEmployees();
            ShowEmployees.SelectedIndex = 0;
        }

        private void RefreshEmployees()
        {
            ShowEmployees.ItemsSource = _FillList.GetEmployeesByDep(ShowDepartments.SelectedItem as Department);
        }
        /// Создаем сотрудника
        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            var empl = _FillList.CreateEmployee(InputFam.Text, InputName.Text, dep.SelectedItem as Department);
            RefreshEmployees();
            ShowEmployees.SelectedIndex = ShowEmployees.Items.Count - 1;
        }
        /// Создаем департамент
        private void BtnCreateDep_Click(object sender, RoutedEventArgs e)
        {
            var dep = _FillList.CreateDepartment(depNew.Text);
            ShowDepartments.SelectedIndex = ShowDepartments.Items.Count - 1;
        }
    }
}
