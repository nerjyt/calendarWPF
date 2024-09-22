using System;
using System.Collections.Generic;
using System.Globalization;
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
	/// Логика взаимодействия для first_page.xaml
	/// </summary>
	public partial class first_page : Page
	{
		public first_page()
		{
			InitializeComponent();
			for_data.Text = DateTime.Now.ToString("MMMM yyyy");
		}

		private void for_click_right_Click(object sender, RoutedEventArgs e)
		{
			if (DateTime.TryParse(for_data.Text, out DateTime currentDate))
			{
				DateTime newDate = currentDate.AddMonths(1);
				for_data.Text = newDate.ToString("MMMM yyyy", CultureInfo.GetCultureInfo("ru-RU"));
			}
		}

		private void for_click_lefr_Click(object sender, RoutedEventArgs e)
		{
			if (DateTime.TryParse(for_data.Text, out DateTime currentDate))
			{
				DateTime newDate = currentDate.AddMonths(-1);
				for_data.Text = newDate.ToString("MMMM yyyy", CultureInfo.GetCultureInfo("ru-RU"));
			}
		}


	}
}
