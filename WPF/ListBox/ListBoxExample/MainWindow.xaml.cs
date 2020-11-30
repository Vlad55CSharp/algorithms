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

namespace ListBoxExample
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

        private void SimpleList_MouseUp(object sender, MouseButtonEventArgs e)
        {
        
            if (simpleList.SelectedItem != null)
            {
                ListBoxItem li = (ListBoxItem)simpleList.Items[simpleList.SelectedIndex];//получаем доступ к элементу
                MessageBox.Show((string)li.Content);//получаем текст
            }
        }

      
        private void ExtendedList_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (!(sender is ListBox))
                return;
            ListBox list = (ListBox)sender; //получаем ListBox            
            ListBoxItem item = (ListBoxItem)list.Items[simpleList.SelectedIndex];//получаем доступ к выделенному элементу
            StackPanel panel = (StackPanel)item.Content; //получаем доступ к панели
            string result = ""; 
            foreach (UIElement element in panel.Children)
            {
                if (element is TextBlock block) //проверяем, является ли текущий элемент панели текстовым блоком
                {
                    result += block.Text;
                    result += ".";
                }
            }
            _ = MessageBox.Show(result);
        }
    }
}
