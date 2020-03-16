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
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;

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

        public static DocumentVariable GetVariableByName(string name, WordprocessingDocument document)
        {
            
            DocumentSettingsPart documentSettings = document.MainDocumentPart.DocumentSettingsPart;
         
            Settings settings = documentSettings.Settings;
         
            DocumentVariables variables = settings.Elements<DocumentVariables>().FirstOrDefault();
         
            if (variables != null)
            {
                return variables.Elements<DocumentVariable>().Where(v => v.Name == name)
                    .FirstOrDefault();
            }
            return null;
        }

     
        public static void SetDocumentVariableValue(DocumentVariable variable, string value)
        {
            variable.Val = value;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = @"C:\test\input\input.docx";

            using (WordprocessingDocument document = WordprocessingDocument.Open(path, true))
            {
                DocumentVariable variable = GetVariableByName("DogovorNumber", document);
                if (variable != null)
                    SetDocumentVariableValue(variable, "New Value");
            
                variable.Val = "New Value"; //если вывести так,без проверки, при отладке выдает что 
                document.SaveAs(@"D:/out.docx");

            }
        }
    }
}
