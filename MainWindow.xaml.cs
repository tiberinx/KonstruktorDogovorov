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

        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = perems;
            
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = (MainWindow)Application.Current.MainWindow;

            string message = mw.textbox1.Text;
            MessageBox.Show(message);  //Проверка значения забиндиного поля в этом классе

            GeneratedClass genclass = new GeneratedClass(); //экземпляр доп класса
            genclass.CreatePackage(@"D:\Output.docx"); //упаковка класса в документ
        }
    }

    public class Perems
    {
        
       
    }
}