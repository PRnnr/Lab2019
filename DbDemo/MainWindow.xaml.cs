using DbDemo.Controller;
using DbDemoLib.Entities;
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

namespace DbDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DbDemoController _controller;
        public MainWindow()
        {
            InitializeComponent();
            this._controller = new DbDemoController();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await _controller.AddStudentAsync(new Student { MatrNr = 1312, Name = "Anna" });
        }
    }
}
