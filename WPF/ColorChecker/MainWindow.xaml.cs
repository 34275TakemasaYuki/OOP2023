using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
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

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            Color color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            SolidColorBrush brush = new SolidColorBrush(color);
            colorArea.Background = brush;
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selectColor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = selectColor.Color;
            var name = selectColor.Name;
            colorArea.Background = new SolidColorBrush(color);
            rSlider.Value = (double)color.R;
            gSlider.Value = (double)color.G;
            bSlider.Value = (double)color.B;
        }

        private void stockButton_Click_1(object sender, RoutedEventArgs e) {
            //colorBox.SelectedIndex = -1;
            string colorList = string.Format("R= {0} G= {1} B= {2}", rSlider.Value, gSlider.Value, bSlider.Value);
            stockList.Items.Add(colorList);
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            string[] splitList = stockList.SelectedItem.ToString().Split(' ');
            rValue.Text = splitList[1];
            gValue.Text = splitList[3];
            bValue.Text = splitList[5];
        }
    }

    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
