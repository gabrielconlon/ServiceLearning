using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test_app_1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			
		}

		private void menuCreateStudent_Click (object sender, RoutedEventArgs e)
		{
			StudentProfile Studentform = new StudentProfile();
			Studentform.Show();
		}

        private void menuCreateAgency_Click(object sender, RoutedEventArgs e)
        {
            AgencyProfile Agencyform = new AgencyProfile();
            Agencyform.Show();
        }

        private void newStudentProfile_BTN_Click(object sender, RoutedEventArgs e)
        {
            StudentProfile form = new StudentProfile();
            form.Show();
        }

        private void studentSearch_BTN_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Present a way for the prototype to populate some basic data which can be clicked to show what a student profile window will look like
        }

        private void menuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

	}
}
