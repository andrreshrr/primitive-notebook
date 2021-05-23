using System;
using System.IO;
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
using Microsoft.Win32;
using System.Reflection;
using System.Diagnostics;
namespace NotePad
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string path;


        public MainWindow()
        {
            InitializeComponent();
            mainWindow.Title = "unnamed.txt";
            text.AcceptsTab = true;
        }
     

        private void createButton_Click(object sender, RoutedEventArgs e) //создание нового файла
        {
            text.Text = "";

            if (MessageBoxResult.Yes == MessageBox.Show("Сохранить изменения в файле?", "Вопрос, сэр", MessageBoxButton.YesNo, MessageBoxImage.Question))
            {
                save_Click(sender, e);
                path = null;
            }

            mainWindow.Title = "unnamed.txt";
        }

        private void saveAs_Click(object sender, RoutedEventArgs e)// сохранить как
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Text file (*.txt)|*.txt";
            dialog.FileName = "unnamed.txt";
            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, text.Text);
                mainWindow.Title = dialog.FileName;
                string[] paths = dialog.FileName.Split('\\');
                mainWindow.Title = paths[paths.Length - 1]; ;
                path = dialog.FileName;

            }
        }

        private void save_Click(object sender, RoutedEventArgs e)//сохранить
        {
            if ((mainWindow.Title == "unnamed")||(path==null))
                saveAs_Click(sender, e);
            else           
                File.WriteAllText(path, text.Text);
             
        }

        private void open_Click(object sender, RoutedEventArgs e)//открыть
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Text file (*.txt)|*.txt";

            if (MessageBoxResult.Yes == MessageBox.Show("Сохранить изменения в файле?", "Вопрос, сэр", MessageBoxButton.YesNo, MessageBoxImage.Question))
            {
                save_Click(sender, e);
                path = null;
            }

            if (dialog.ShowDialog() == true)
            {
                text.Text = File.ReadAllText(dialog.FileName);
                string[] paths = dialog.FileName.Split('\\');
                mainWindow.Title = paths[paths.Length - 1];
                path = dialog.FileName;
            }
        }

        private void text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                PrintSymbol("\n");
            } else if (e.Key == Key.Tab)
            {
                PrintSymbol("\t");
            }
        }

        private void menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                // do nothing
            }
        }

        private void newWindow_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(Assembly.GetExecutingAssembly().Location.ToString());
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBoxResult.Yes == MessageBox.Show("Сохранить изменения в файле?", "Вопрос, сэр", MessageBoxButton.YesNo, MessageBoxImage.Question))
            {
                save_Click(sender, e);
                path = null;
            }

            this.Close();
        }

        private void PrintSymbol(string s)
        {
            var caret = text.CaretIndex;
            string firstText = text.Text.Substring(0, text.CaretIndex);
            string secondText = text.Text.Substring(text.CaretIndex, text.Text.Length - text.CaretIndex);

            firstText += s;
            text.Text = firstText + secondText;
            text.CaretIndex = caret + 1;

        }

        private void printDate_Click(object sender, RoutedEventArgs e)
        {
            PrintSymbol(DateTime.Now.Date.ToString().Substring(0,10));
        }

        private void printTime(object sender, RoutedEventArgs e)
        {
            PrintSymbol(DateTime.Now.TimeOfDay.ToString());

        }

        private void smilePrint(object sender, RoutedEventArgs e)
        {
            PrintSymbol(":-)");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            PrintSymbol("+7 (996) 431-22-77");
        }
    }
}
