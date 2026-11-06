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

namespace KinoWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EmployeesButton_Click(object sender, RoutedEventArgs e)
        {
            EmployesWindow employesWindow = new EmployesWindow();
            employesWindow.Show();
            this.Close();
        }

        private void ProjectsButton_Click(object sender, RoutedEventArgs e)
        {
            ProjectsWindow projectsWindow = new ProjectsWindow();
            projectsWindow.Show();
            this.Close();
        }

        private void LocationsButton_Click(object sender, RoutedEventArgs e)
        {
            AreaWindow areaWindow = new AreaWindow();
            areaWindow.Show();
            this.Close();
        }

        private void CrewButton_Click(object sender, RoutedEventArgs e)
        {
            FilmCrewWindow filmCrewWindow = new FilmCrewWindow();
            filmCrewWindow.Show();
            this.Close();
        }

        private void ScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            ScheduleWindow scheduleWindow = new ScheduleWindow();
            scheduleWindow.Show();
            this.Close();
        }

        private void CostsButton_Click(object sender, RoutedEventArgs e)
        {
            ExpensesWindow expensesWindow = new ExpensesWindow();
            expensesWindow.Show();
            this.Close();
        }

        private void RentalButton_Click(object sender, RoutedEventArgs e)
        {
            RentalWindow rentalWindow = new RentalWindow();
            rentalWindow.Show();
            this.Close();
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            AutorizationWindow autorizationWindow = new AutorizationWindow();
            autorizationWindow.Show();
            this.Close();
        }
    }
}
