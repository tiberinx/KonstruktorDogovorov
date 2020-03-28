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

namespace KonstruktorDogovorov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public string DogovorNumber  //Забиндиное поле к textbox
        {
            get { return textbox1.Text; }
            set { textbox1.Text = value; }
        }
        public string CustomerName  //Забиндиное поле к textbox
        {
            get { return CustomerTextBox.Text; }
            set { CustomerTextBox.Text = value; }
        }
        public string vyvozTBO
        {
            get { if (chkboxTBO.IsChecked == true) { return TBOvalue.Text; } else { return null; } }
        }
        public string vyvozKGM
        {
            get { if (chkboxKGM.IsChecked == true) { return KGMvalue.Text; } else { return null; } }
        }

        public string DogovorDate
        {
            get { return DatePicker1.Text; }
        }

        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = perems;

        }
        private string _orgFullText = "";
        public string OrgType
        {            
            get
            {
                
                switch (orgList.SelectedIndex)
                {
                    case 0:
                        _orgFullText = "Общество с ограниченной ответственностью";
                        return _orgFullText;
                    case 1:
                        _orgFullText = "Индивидуальный предприниматель";
                        return _orgFullText;
                       
                    case 2:
                        _orgFullText = "Акционерное общество";
                        return _orgFullText;
                        
                    case 3:
                        _orgFullText = "Закрытое акционерное общество";
                        return _orgFullText;
                        
                    case 4:
                        _orgFullText = "Публичное акционерное общество";
                        return _orgFullText;
                        
                    case 5:
                        _orgFullText = "";
                        return _orgFullText;
                        
                    default:
                        return _orgFullText;
                        
                }
            }
            set { _orgFullText = value; }
        }
        private Visibility _vLitseVis = Visibility.Hidden;
       public Visibility vLitseVisibility
        {
            get
            {
                switch (orgList.SelectedIndex)
                {
                    case 1:
                        return _vLitseVis = Visibility.Hidden;
                    default:
                        return _vLitseVis = Visibility.Visible;
                }
            }
            set { _vLitseVis = value; }
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
            new GeneratedClass().CreatePackage(@"D:\Output.docx");            
        }

 
    }

}