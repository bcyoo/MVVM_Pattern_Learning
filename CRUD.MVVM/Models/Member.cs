using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.MVVM.Models
{
    /*
     ObservableObject : 데이터 바인딩을 지원하는 기능을 제공
    데이터 바인딩은 UI요소와 데이터를 연결하여 데이터 변경이 자동으로 UI에 반영되도록 하는 기능.
    이를 통해 UI와 데이터 모델이 동기화되어 유저 인터페이스에 쉽게 업데이트할 수 있다.

    IColoneable : Clone을 지원하기 위한 인터페이스
    clone() 메서드로 객체의 얕은 복사를 제공
    객체 자체를 복사하지 않고 참조만 복사하는 방식

    Member class 는 멤버 정보를 저장하기위한 속성을 가지고있음
    property 정의 : id name phone regdate isuse 속성들은
    get과 set 접근자를 가짐, 이러한 속성들을 통해 클래스 내부의 데이터를 안전하게 읽고 쓸수있음
    setProperty 메서드를 사용하여 값을 설정한다,
    setproperty 메서드를 통해 속성 값이 변경되면 데이터 바인딩 기능에 의해 ui도 자동으로 업데이트된다

    ref : reference로 전달할때 사용
    
    1.
    메서드 안에서 parameter 값을 변경하여 해당 변경이 호출한 쪽에 영향을 미치도록 하고싶은 경우 사용
    ref 키워드를 사용하여 매개변수를 전달하면 참조에 의한 호출 방식으로 동작하게됨
    >> 이렇게하면 매서드 내에서 매개변수의 값이 변경되면 호출한 쪽의변수 값도 함께 변경됨

    2.
    observableobject 클래에서 사용되는 setproperty 메서드 때문에 사용함
    setproperty 메서드는 데이터 바인딩을 지원하기 위해 사용되며, 속성 값이 변경될때 자동으로 ui를 업데이트함
    하지만 이렇게 동작하려면 속성 값을 참조로 전달해야한다



     */
    public class Member : ObservableObject, ICloneable // ObservableObject는 데이터 바인딩 기능 제공 클래스, ICloneable은 복제를 지원하기위한 인터페이스
    {
        public int Id { get; set; } // { get; set; }을 통해 값을 가져오고 설정할 수있음

        private string _name;
        public string Name
        {
            get { return _name; } 
            set { SetProperty(ref _name, value); }
        }
        

        /*
         
        ref를 사용하면 _phone 변수의 값을 참조로 전달,
        setproperty 메서드는 새로운 값인 vlaue를 _phone에 대입하고
        값이 변경되었는지 확인하여 필요한 ui를 업데이트함
         
         */
        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { SetProperty(ref _phone, value); }
        }

        public DateTime RegDate { get; set; }
        private bool _isUse;
        public bool IsUse
        {
            get { return _isUse; }
            set { SetProperty(ref _isUse, value); }
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

    }
}
