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
using Word = Microsoft.Office.Interop.Word;

namespace KonstruktorDogovorov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string CustomValue = "такие дела";
            Word.Application app = new Word.Application();
            Word.Document doc = app.Documents.Add(filepath);
            doc.Variables["var_name"].Value = CustomValue;
            doc.Fields.Update();
            doc.Save();
            doc.Close();
            app.Quit();
        }
    }
}
