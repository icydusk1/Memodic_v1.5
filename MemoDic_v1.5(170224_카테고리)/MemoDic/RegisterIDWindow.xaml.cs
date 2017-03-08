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
	/// Interaction logic for RegisterIDWindow.xaml
	/// </summary>
	public partial class RegisterIDWindow : Window {
		public RegisterIDWindow() {
			InitializeComponent();
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
			string NewID = TB_NewID.Text;
			string NewPW = PB_NewPW.Password;
			string PWH = TB_HintForPW.Text;
			string[] find = MainWindow.userInfo.Find(delegate (string[] x) {
				return (x[0] == NewID);
			});

			// 계정 등록
			if (NewID.Length < 4) MessageBox.Show("ID must have at least 4 characters.");
			else if (find != null) MessageBox.Show("The ID already exists. Try other one.");
			else if (NewPW.Length < 4) MessageBox.Show("PW must have at least 4 digits.");
			else if (NewPW != PB_ConfirmNewPW.Password) MessageBox.Show("New PW for confirmation is incorrect.");
			else {
				MainWindow.userInfo.Add(new string[3] { NewID, NewPW, PWH });
				MainWindow.SaveFile("user.dat", MainWindow.userInfo, -5);
				MessageBox.Show("Registering ID Finished.");
				Close();
			}
		}

		private void BTT_Cancel_Click(object sender, RoutedEventArgs e) {
			Close();
		}
	}
}
