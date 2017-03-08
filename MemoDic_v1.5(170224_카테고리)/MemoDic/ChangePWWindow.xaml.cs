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
	/// Interaction logic for ChangePWWindow.xaml
	/// </summary>
	public partial class ChangePWWindow : Window {
		public ChangePWWindow() {
			InitializeComponent();
		}

		private void PB_PW_PasswordChanged(object sender, RoutedEventArgs e) {
			if (PB_PW.Password == "") TBL_PW.Visibility = Visibility.Visible;
			else TBL_PW.Visibility = Visibility.Collapsed;
		}

		private void PB_NewPW_PasswordChanged(object sender, RoutedEventArgs e) {
			if (PB_NewPW.Password == "") TBL_NewPW.Visibility = Visibility.Visible;
			else TBL_NewPW.Visibility = Visibility.Collapsed;
		}

		private void PB_ConfirmNewPW_PasswordChanged(object sender, RoutedEventArgs e) {
			if (PB_ConfirmNewPW.Password == "") TBL_ConfirmNewPW.Visibility = Visibility.Visible;
			else TBL_ConfirmNewPW.Visibility = Visibility.Collapsed;
		}

		private void BTT_OK_Click(object sender, RoutedEventArgs e) {
			// ID 및 PW 매칭 검사
			string PW = PB_PW.Password;
			string NewPW = PB_NewPW.Password;
			string ConfirmNewPW = PB_ConfirmNewPW.Password;
			string NewPWH = TB_HintForPW.Text;
			if (PW != MainWindow.PW) MessageBox.Show("PW is incorrect.");
			else if (NewPW.Length < 4) MessageBox.Show("PW must have at least 4 digits.");
			else if (ConfirmNewPW != NewPW) MessageBox.Show("New PW for confirmation is incorrect.");
			else {
				MainWindow.userInfo[MainWindow.loginIndex] = new string[] { MainWindow.ID, NewPW, NewPWH };
				MainWindow.SaveFile("user.dat", MainWindow.userInfo, -5);
				MessageBox.Show("Changing PW Finished.");
				Close();
			}
		}

		private void BTT_Cancel_Click(object sender, RoutedEventArgs e) {
			Close();
		}
	}
}
