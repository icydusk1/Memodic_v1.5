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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Media.Effects;
using System.Windows.Media.Animation;
using SSLibrary;

namespace MemoDic {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public static string ID, PW = "";
		public static int loginIndex;
		public static bool loginFlag = false;
		public static List<string[]> configInfo = new List<string[]>();
		public static List<string[]> logInfo = new List<string[]>();
		public static List<string[]> userInfo = new List<string[]>();

		public MainWindow() {
			InitializeComponent();
			try {
				// 프로그램 시작 시 정보 로딩
				configInfo = LoadFile("config.dat", 0);
				userInfo = LoadFile("user.dat", 5);
				logInfo = LoadFile("log.dat", 10);
				if (configInfo[0][1] == "True" || configInfo[0][1] == "true") {
					CHB_Remember_me.IsChecked = true;
					try {
						TB_ID.Text = logInfo[0][0];
						PB_PW.Password = logInfo[0][1];
					}
					catch { };
				}
			}
			catch (Exception exc) {
				MessageBox.Show(exc.ToString());
			};

			// 임시 카테고리
			CHBTRVVM CHBViewModel = new CHBTRVVM();
			NetworkItem NImyStuff = new NetworkItem("myStuff");

			NetworkItem NIcar = new NetworkItem("car");
			NetworkItem NIsmall = new NetworkItem("small");
			NetworkItem NImartiz = new NetworkItem("martiz");
			NetworkItem NImorning = new NetworkItem("morning");
			NetworkItem NImedium = new NetworkItem("medium");
			NetworkItem NIbenz = new NetworkItem("benz");
			NetworkItem NIgift = new NetworkItem("gift");
			NetworkItem NIwallet = new NetworkItem("wallet");
			NImyStuff.AddChild(NIcar);
			NIcar.AddChild(NIsmall);
			NIsmall.AddChild(NImartiz);
			NIsmall.AddChild(NImorning);
			NIcar.AddChild(NImedium);
			NImedium.AddChild(NIbenz);
			NImyStuff.AddChild(NIgift);
			NIgift.AddChild(NIbenz);
			NIgift.AddChild(NIwallet);

			CHBViewModel.NetworkItems.Add(NImyStuff);
			CHBTRV_CHBTreeView.DataContext = CHBViewModel;
		}
		
		protected override void OnClosed(EventArgs e) {
			// 프로그램 종료 시 정보 저장
			SaveFile("config.dat", configInfo, 0);
			SaveFile("user.dat", userInfo, -5);
			SaveFile("log.dat", logInfo, -10);
		}

		private void TB_ID_KeyDown(object sender, KeyEventArgs e) {
			if (e.Key == Key.Enter) BTT_Login_Click(sender, e);
		}

		private void PB_PW_KeyDown(object sender, KeyEventArgs e) {
			if (e.Key == Key.Enter) BTT_Login_Click(sender, e);
		}

		private void PB_PW_PasswordChanged(object sender, RoutedEventArgs e) {
			if (PB_PW.Password == "") TBL_PW.Visibility = Visibility.Visible;
			else TBL_PW.Visibility = Visibility.Collapsed;
		}

		public void BTT_Login_Click(object sender, RoutedEventArgs e) {
			// 로그아웃
			if (loginFlag) {
				// 로그인 가능 상태로 초기화
				TB_ID.IsEnabled = true;
				TB_ID.Text = "";
				PB_PW.IsEnabled = true;
				PB_PW.Password = "";
				BTT_Login.Content = "Login";
				loginFlag = false;
				CHB_Remember_me.IsEnabled = true;
				CHB_Remember_me.IsChecked = false;
				configInfo[0][1] = "False";
				TB_RegisterID.Text = "Register ID";
				TB_FindPW.Text = "Find PW";
				SaveFile("user.dat", userInfo, -5);
				MessageBox.Show("Successfully logged out.");
			}
			else {
				// 로그인
				ID = TB_ID.Text;
				PW = PB_PW.Password;
				loginIndex = userInfo.FindIndex(delegate (string[] x) {
					return (x[0] == ID);
				});
				if (loginIndex == -1) MessageBox.Show("No matching ID found.");
				else if (userInfo[loginIndex][1] != PW) MessageBox.Show("PW is incorrect.");
				else {
					// 계정 정보 기억
					if (CHB_Remember_me.IsChecked == true) {
						configInfo[0][1] = "True";
						if (logInfo.Count == 0) logInfo.Add(new string[] { ID, PW });
						else {
							logInfo[0][0] = ID;
							logInfo[0][1] = PW;
						}
					}
					else configInfo[0][1] = "False";

					// 로그인 상태로 전환
					TB_ID.IsEnabled = false;
					PB_PW.IsEnabled = false;
					BTT_Login.Content = "Logout";
					loginFlag = true;
					CHB_Remember_me.IsEnabled = false;
					TB_RegisterID.Text = "Delete ID";
					TB_FindPW.Text = "Change PW";
					MessageBox.Show("Successfully logged in.");
				}
			}
		}

		private void TB_RegisterID_MouseEnter(object sender, MouseEventArgs e) {
			TB_RegisterID.TextDecorations = TextDecorations.Underline;
		}

		private void TB_RegisterID_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
			if(loginFlag) {
				DeleteIDWindow deleteIDWindow = new DeleteIDWindow(this);
				deleteIDWindow.ShowDialog();
			}
			else {
				RegisterIDWindow registerIDWindow = new RegisterIDWindow();
				registerIDWindow.ShowDialog();
			}
		}

		private void TB_RegisterID_MouseLeave(object sender, MouseEventArgs e) {
			TB_RegisterID.TextDecorations = null;
		}

		private void TB_FindPW_MouseEnter(object sender, MouseEventArgs e) {
			TB_FindPW.TextDecorations = TextDecorations.Underline;
		}

		private void TB_FindPW_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
			if (loginFlag) {
				// PW 변경
				ChangePWWindow changePWWindow = new ChangePWWindow();
				changePWWindow.ShowDialog();
			}
			else {
				// PW 찾기
				FindPWWindow findPWWindow = new FindPWWindow();
				findPWWindow.ShowDialog();
			}
		}

		private void TB_FindPW_MouseLeave(object sender, MouseEventArgs e) {
			TB_FindPW.TextDecorations = null;
		}

		// 파일 읽기
		public static List<string[]> LoadFile(string fileName, int codingPar) {
			List<string[]> sTempList = new List<string[]>();
			if (File.Exists(fileName)) {
				using (StreamReader sr = new StreamReader(fileName, Encoding.GetEncoding(932))) {
					for (int i=0; sr.Peek() >= 0; i++) {
						string[] sTemp = sr.ReadLine().Split('\t');
						if (sTemp.Length == 1) sTemp = new string[] { sTemp[0], "" }; // 배열길이는 null이 아니면 최소 2여야 함.
						for(int j=0; j<sTemp.Length; j++) {
							sTemp[j] = code(sTemp[j], codingPar);
						}
						sTempList.Add(sTemp);
					}
					sr.Close();
					sr.Dispose();
				}
			}
			return sTempList;
		}

		// 파일 쓰기
		public static void SaveFile(string fileName, List<string[]> Info, int codingPar) {
			using (FileStream fi = new FileStream(fileName, FileMode.Create))
			using (StreamWriter sw = new StreamWriter(fi, Encoding.GetEncoding(932))) {
				StringBuilder sb = new StringBuilder();
				for(int i=0; i<Info.Count; i++) {
					for(int j=0; j<Info[i].Length; j++) {
						sb.Append(code(Info[i][j], codingPar) + "\t");
					}
					sb.Remove(sb.Length -1, 1);
					sb.Append("\n");
				}
				sb.Remove(sb.Length - 1, 1);
				sw.Write(sb);
				sw.Close();
				sw.Dispose();
				fi.Close();
				fi.Dispose();
			}
		}

		private void BTT_Add_Click(object sender, RoutedEventArgs e) {
			//MessageBox.Show(CHBTRV_CHBTreeView);
		}

		private void BTT_Delete_Click(object sender, RoutedEventArgs e) {

		}

		// 암호화 및 복호화
		private static string code(string input, int codingPar) {
			StringBuilder output = new StringBuilder();
			for(int i=0; i<input.Length; i++) {
				output.Append((char) ((int) input[i] + codingPar));
			}
			return output.ToString();
		}
	}
}
