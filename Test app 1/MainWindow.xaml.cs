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

		private void createStudent_Click (object sender, RoutedEventArgs e)
		{
			CreateStudentProfile form = new CreateStudentProfile();
			form.Show();
		}

		private void StudentLastName_TB_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			studentLastName_TB.Clear();
		}

		private void StudentFirstName_TB_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			studentFirstName_TB.Clear();
		}

		private void StudentMiddleName_TB_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			studentMiddleName_TB.Clear();
		}

		private void StudentID_TB_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			studentID_TB.Clear();
		}

		private void GraduationYear_TB_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			graduationYear_TB.Clear();
		}
	}
}
