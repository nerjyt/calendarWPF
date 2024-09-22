using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace calendarWPF
{
	/// <summary>
	/// Логика взаимодействия для page_for_days.xaml
	/// </summary>
	public partial class page_for_days : Page
	{
		public page_for_days()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			window_for_activity newWindow = new window_for_activity();  
			newWindow.Show();                           
		}
	}
}
