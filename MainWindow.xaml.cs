using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace Payroll_Appplication
{
    public class EmployeeRecord
    {
        public string Employee { get; set; }
        public int EmployeeNo { get; set; }
        public double WorkHours { get; set; }
        public double OvertimeHours { get; set; }
        public double GrossPay { get; set; }
        public double StatutoryPay { get; set; }
        public double Deductions { get; set; }
        public double NetSalary { get; set; }
        public string Status { get; set; }
    }

    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private bool _isRetracted;
        public bool IsRetracted
        {
            get { return _isRetracted; }
            set
            {
                _isRetracted = value;
                OnPropertyChanged();
            }
        }

        public int clickCount = 1;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand OpenLoginCommand { get; }
        public ICommand OpenEmployeesCommand { get; }
        public ICommand OpenEditCommand { get; }
        public ICommand OpenRegisterCommand { get; }
        public ICommand OpenStatisticsCommand { get; }
        public ICommand OpenProfileCommand { get; }
        public ICommand OpenDashboardCommand { get; }
        public ICommand OpenPayrollHandlingCommand { get; }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            OpenLoginCommand = new RelayCommand(OpenLoginWindow);
            OpenEmployeesCommand = new RelayCommand(OpenEmployeesWindow);
            OpenEditCommand = new RelayCommand(OpenEmployeeEditWindow);
            OpenRegisterCommand = new RelayCommand(OpenRegisterEditWindow);
            OpenStatisticsCommand = new RelayCommand(OpenStatisticsWindow);
            OpenProfileCommand = new RelayCommand(OpenProfileWindow);
            OpenDashboardCommand = new RelayCommand(OpenDashboardWindow);
            OpenPayrollHandlingCommand = new RelayCommand(OpenPayrollHandlingWindow);

            // Sample data
            var employeeRecords = new List<EmployeeRecord>
            {
                new EmployeeRecord { Employee = "John Doe", EmployeeNo = 101, WorkHours = 40, OvertimeHours = 5, GrossPay = 5000, StatutoryPay = 200, Deductions = 500, NetSalary = 4700, Status = "Paid" },
                new EmployeeRecord { Employee = "Jane Smith", EmployeeNo = 102, WorkHours = 38, OvertimeHours = 4, GrossPay = 4800, StatutoryPay = 190, Deductions = 480, NetSalary = 4530, Status = "Paid" },
                new EmployeeRecord { Employee = "Alice Johnson", EmployeeNo = 103, WorkHours = 42, OvertimeHours = 6, GrossPay = 5200, StatutoryPay = 210, Deductions = 520, NetSalary = 4890, Status = "Unpaid" },
                new EmployeeRecord { Employee = "Bob Williams", EmployeeNo = 104, WorkHours = 37, OvertimeHours = 3, GrossPay = 4600, StatutoryPay = 185, Deductions = 460, NetSalary = 4325, Status = "Paid" },
                new EmployeeRecord { Employee = "Emily Brown", EmployeeNo = 105, WorkHours = 39, OvertimeHours = 5, GrossPay = 4900, StatutoryPay = 195, Deductions = 490, NetSalary = 4625, Status = "Unpaid" }
            };

            EmployeeListView.ItemsSource = employeeRecords;
        }

        private void RetractButton_Click(object sender, RoutedEventArgs e)
        {
            clickCount++;
            IsRetracted = !IsRetracted;
            if (clickCount % 2 == 0)
            {
                var retractStoryboard = (Storyboard)FindResource("RetractNavigationStoryboard");
                retractStoryboard.Begin();
            }
            else
            {
                var restoreStoryboard = (Storyboard)FindResource("RestoreNavigationStoryboard");
                restoreStoryboard.Begin();
            }

        }

        private void OpenLoginWindow()
        {
            Login loginWindow = new Login();
            loginWindow.Show();
            this.Hide();   
        }

        private void OpenEmployeesWindow()
        {
            Employees employeeWindow = new Employees();
            employeeWindow.Show();
            this.Hide();
        }

        private void OpenEmployeeEditWindow()
        {
            EmployeeEdit employeeEdit = new EmployeeEdit();
            employeeEdit.Show();
            this.Hide();
        }

        private void OpenDashboardWindow()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void OpenPayrollHandlingWindow()
        {
            PayrollHandling payrollWindow = new PayrollHandling();
            payrollWindow.Show();
            this.Hide();
        }

        private void OpenStatisticsWindow()
        {
            Statistics statisticsWindow = new Statistics();
            statisticsWindow.Show();
            this.Hide();
        }

        private void OpenRegisterEditWindow()
        {
            RegisterPage registerWindow = new RegisterPage();
            registerWindow.Show();
            this.Hide();
        }

        private void OpenProfileWindow()
        {
            Profile profileWindow = new Profile();
            profileWindow.Show();
            this.Hide();
        }
    }
}
