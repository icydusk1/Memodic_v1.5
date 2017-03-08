using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSLibrary {
	public class NetworkItem : INotifyPropertyChanged {
		public event PropertyChangedEventHandler PropertyChanged;

		public NetworkItem(string name) {
			Name = name;
		}

		public ObservableCollection<NetworkItem> Children { get; } = new ObservableCollection<NetworkItem>();
		public ObservableCollection<NetworkItem> Parents { get; } = new ObservableCollection<NetworkItem>();

		public string Name { get; set; }
		private bool? isChecked = false;
		public bool? IsChecked {
			get {
				return isChecked;
			}
			set {
				isChecked = value;
				SetRecursiveCheckDown(value);
			}
		}

		// 상위항목의 체크상태에 따라 하위항목의 체크상태 변경, 이렇게 최하위항목까지 CheckDown 후 CheckUp 시작
		private void SetRecursiveCheckDown(bool? isChecked) {
			foreach (var item in Children) {
				item.isChecked = isChecked;
				item.SetRecursiveCheckDown(isChecked);
			}
			if (Children.Count == 0) SetRecursiveCheckUp();
		}

		// 하위항목의 체크상태에 따라 상위항목의 체크상태 변경, 이렇게 CheckUp 하면서 View 업데이트
		private void SetRecursiveCheckUp() {
			foreach (var item in Parents) {
				item.UpdateCheck();
				item.SetRecursiveCheckUp();
			}
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsChecked"));
		}
		
		// 하위항목들이 전부 체크/언체크 되어있으면 상위항목에 체크/언체크, 그렇지 않으면 상위항목에 부분체크
		private void UpdateCheck() {
			int checks_cnt = 0, unchecks_cnt = 0;
			foreach (var item in Children) {
				if (item.isChecked == true) checks_cnt += 1;
				else if (item.isChecked == false) unchecks_cnt += 1;
			}

			if (checks_cnt == Children.Count) isChecked = true;
			else if (unchecks_cnt == Children.Count) isChecked = false;
			else isChecked = null;
		}

		// 하위항목을 추가할 때는 해당 하위항목의 상위항목에 자기자신을 추가
		public void AddChild(NetworkItem item) {
			Children.Add(item);
			item.Parents.Add(this);
		}
	}
}
