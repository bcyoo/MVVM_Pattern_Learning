using System;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using MVVM_Pattern.Models;

namespace MVVM_Pattern.ViewModels
{
    public class MainViewModel : ObservableObject // ObservableObject 클래스를 상속 받아서 MainViewModel 속서 ㅇ변경 알림 기능을 가지도록 함
    {
        private IList<Person> _persons = new ObservableCollection<Person> // Person 객체들을 담는 _persons 라는 필드 선언,
                                                                          // ObservableCollection<Person>형태로 초기화
                                                                          // ObservableCollection은 데이터가 변경되면 자동으로 UI에 반영되는 동적인 컬렉션
        {
            new Person{ Name = "cc0104", Sex = true, Age = 11, Address = "Seoul_1"},
            new Person{ Name = "cc0103", Sex= false, Age= 12, Address = "Seoul_2"}
        };
        public IList<Person> Persons { get { return _persons; } } // _persons라는 필드를 읽기 전용으로,
                                                                  // 외부 코드에서 Persons 속성을 통해 _persons 컬렉션을 읽을 수 있지만,
                                                                  // 컬렉션을 직접 수정할 수는 없다.

        // 네개의 private 속성,
        // SelectedListItem, SelectedListItem2, SelectedComboItem, SelectedComboItem2는
        // 이들은 각각 Person 타입 객체를 나타내며 선택된 항목의 정보를 저장
        private Person _selectedListItem;
        public Person SelectedListItem
        {
            get { return _selectedListItem; }
            set { SetProperty(ref _selectedListItem, value); }
        }

        private Person _selectedListItem2;
        public Person SelectedListItem2
        {
            get { return _selectedListItem2; }
            set { SetProperty(ref _selectedListItem2, value); }
        }

        private Person _selectedComboItem;
        public Person SelectedComboitem
        {
            get { return _selectedComboItem; }
            set { SetProperty(ref _selectedComboItem, value);}  
        }
        private Person _selectedComboItem2;
        public Person SeletedComboitem2
        {
            get { return _selectedComboItem2; }
            set { SetProperty(ref _selectedComboItem2, value); }
        }
        public IRelayCommand DeleteListItemCommand { get; set; } // DeleteListItemCommand public 속성을 선언,
                                                                 // IRelayCommand 인터페이스를 구현한 커스텀 명령 클래스를 가라킴,
                                                                 // 명령 클래스는 특정 동작을 수행할 수 있는 명령을 나타냄
        public IRelayCommand DeleteComboItemCommand { get; set; } // DeleteComboItemCommand public 속성을 선언,
                                                                  // IRelayCommand 인터페이스를 구현한 커스텀 명령 클래스를 가라킴,
                                                                  // 명령 클래스는 특정 동작을 수행할 수 있는 명령을 나타냄

        public MainViewModel()
        {
            init(); // 초기화 작업 수행 메서드,
                    // SelectedListItem, SelectedComboItem에 _persons 컬렉션의 첫번째 항목을 할당
        }

        private void init()
        {
            SelectedListItem = Persons.FirstOrDefault();
            SelectedComboitem = Persons.FirstOrDefault();

            DeleteListItemCommand = new RelayCommand(OnDeleteListItem,
                () => SelectedListItem2 != null && SelectedListItem2.Age % 2 == 0);
            DeleteComboItemCommand = new RelayCommand(OnDeleteComboItem,
                () => SeletedComboitem2 != null && SeletedComboitem2.Age % 2 == 1);
        }

        private void OnDeleteComboItem()
        {
            Persons.Remove(SeletedComboitem2); // DeleteListItemCommand에서 호출되는 메서드,
                                               // SelectedComboItem2가 가리키는 항목을 _persons 컬렉션에서 삭제
        }
        private void OnDeleteListItem()
        {
            Persons.Remove(SelectedListItem2); // DeleteListItemCommand에서 호출되는 메서드,
                                               // SelectedListItem2가 가리키는 항목을 _persons 컬렉션에서 삭제
        }

        /*
         이 코드는GUI app 사용되는 ViewModel
        데이터를 관리하고 선택된 항목 삭제 등의 동작을 처리.
        또한 커스텀 명령클래스를 통해 gui와 상호작용을 가능하게 하고 있음
        --> 이러한 viewmodel을 사용하면 app 로직과 데이터를 UI=로 부터 분리하여 유지보수, 테스트 용이
         */
    }
}
