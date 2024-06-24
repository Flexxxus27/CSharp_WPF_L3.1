using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSharp_WPF_L3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    /// DataTemplate
    /// ItemTemplate 
    ///     <Listbox> 
    ///         <Listbox.ItemTemplate>
    ///             <DataTemplate>
    ///         
    ///             </DataTemplate>
    ///         </Listbox.ItemTemplate>
    ///     </Listbox>
    ///  Привязка данных.
    ///  
    ///  Binding - привязка данных к шаблону
    ///  Привязка - это взаимодействие двух объектов, источника и приемника. Приемник создает привязку к определенному св-ву источника и в случае модификации источника, приемник будет 
    ///  так же модифицирован.
    ///  Основные св-ва класса Binding:
    ///     1. ElementName - это имя элемента к которому создается привязка.
    ///     2. Mode - режим привязки. Может принимать значения OneWay -  св-ва приемника изменяется после модификации св-ва источника., OneTime - св-ва приемника устанавливается только один раз.,
    ///         TwoWay - и приемник и источник может изменять привязанные св-ва.
    ///     3. Path - ссылка на св-во объекта к которому идет привязка.
    ///     4. Source - указывает на источник если он не является элементом управления, или данные не передаются из кода.
    ///     
    ///     События - позволяют отлавливать некоторое взаимодействие с элементом управления, и выполняют указаный в теле события код. События необходимо добавлять ка св-ва.
    ///         
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
    }
}