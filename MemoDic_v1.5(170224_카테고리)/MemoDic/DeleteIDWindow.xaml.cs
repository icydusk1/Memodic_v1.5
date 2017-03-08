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

namespace MemoDic {
	/// <summary>
	/// Interaction logic for DeleteIDWindow.xaml
	/// </summary>
	public partial class DeleteIDWindow : Window {
		MainWindow mainWindow;

		public DeleteIDWindow(MainWindow mainWindowRef) {
			InitializeComponent();
			mainWindow = mainWindowRef;
		}

		private void PB_ConfirmPW_PasswordChanged(object sender, RoutedEventArgs e) {
			if (PB_ConfirmPW.Password == "") TBL_ConfirmPW.Visibility = Visibility.Visible;
			else TBL_ConfirmPW.Visibility = Visibility.Collapsed;
		}

		private void BTT_OK_Click(object sender, RoutedEventArgs e) {
			if(PB_ConfirmPW.Password != MainWindow.PW) MessageBox.Show("New PW for confirmation is incorrect.");
			else {
				MainWindow.userInfo.RemoveAt(MainWindow.loginIndex);
				MessageBox.Show("Deleting ID Finished.");
				Close();
				mainWindow.BTT_Login_Click(sender, e);
			}
		}

		private void BTT_Cancel_Click(object sender, RoutedEventArgs e) {
			Close();
		}
	}
}
