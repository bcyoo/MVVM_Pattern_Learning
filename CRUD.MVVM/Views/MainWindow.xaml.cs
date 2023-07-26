using CRUD.MVVM.ViewModels;
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

namespace CRUD.MVVM
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // 코드 비하인드에 비즈니스 로직에 관련된 코딩은 하지 않음
            // ViewModel을 View에 연결 시키기 위해 작성
            // 등록된 Type을 인스턴스 시켜서 사용할수있음
            DataContext = App.Current.Services.GetService(typeof(MainViewModel));
        }
    }
}
