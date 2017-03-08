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
	/// Interaction logic for FindPWWindow.xaml
	/// </summary>
	public partial class FindPWWindow : Window {
		public FindPWWindow() {
			InitializeComponent();
		}

		private void BTT_OK_Click(object sender, RoutedEventArgs e) {
			// ID 및 PW 매칭 검사
			string ID = TB_ID.Text;
			string[] find = MainWindow.userInfo.Find(delegate (string[] x) {
				return (x[0] == ID);
			});
			if(find == null) MessageBox.Show("No matching ID found.");
			else {
				if(find.Length < 3) MessageBox.Show("Hint for PW: No hint");
				else MessageBox.Show("Hint for PW: " + find[2]);
				Close();
			}
		}

		private void BTT_Cancel_Click(object sender, RoutedEventArgs e) {
			Close();
		}
	}
}
