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

namespace Task_3
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

        private void TextBox_Focus(object sender, RoutedEventArgs e)
        {
            // сделать все текстовые поля в панелях маленькими.
            foreach (var child in LeftPanel.Children)
                if (child is TextBox tb) tb.Style = (Style)Resources["SmallTextStyle"];

            foreach (var child in RightPanel.Children)
                if (child is TextBox tb) tb.Style = (Style)Resources["SmallTextStyle"];

            // большой стиль к элементу на который нажали
            (sender as FrameworkElement).Style = (Style)Resources["LargeTextStyle"];
        }
    }
}
