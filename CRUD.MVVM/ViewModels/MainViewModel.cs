using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CRUD.MVVM.Models;

namespace CRUD.MVVM.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        /*
         
         MVVM 핵심 PropertChanged 이벤트를 이용해야 하기때문에 Members property가 계속 변경된다면
        아래와 같은 형태를 사용
         */
        private IList<Member> _member;
        public IList<Member> Members
        {
            get { return _member; }
            set { SetProperty(ref _member, value); }
        }

        private void Init()
        {
            Members = new ObservableCollection<Member>
            {
                new Member
                {
                    Id = 1,
                    Name = "Foo",
                    Phone = "010-1111-2222",
                    RegDate = DateTime.Now,
                    IsUse = true
                }
            };

            NewCommand = new RelayCommand(() => IsEditing = true);

            CancelCommand = new RelayCommand(() => IsEditing = false);

        }

        public MainViewModel()
        {
            Init();
        }


        // New button 처리
        // NewCommand를 추가함 NewButton과 연결해서 버튼 click을 command로 본경하는데 사용
        // NewCommand를 실행 시켰을 때 해야할 일이 간단하면 아래와같이 짧게 만들어서 사용함
        // IsEditing property를 추가, 이 property는 _isEditing 처럼 수정 상태인지 여부를 판단하기위해 사용

        public IRelayCommand NewCommand { get; set; }
        public IRelayCommand CancelCommand { get; set; }

        private bool _isEditing;
        public bool IsEditing
        {
            get { return _isEditing; }
            set { SetProperty(ref _isEditing, value); }
        }
    }
}
