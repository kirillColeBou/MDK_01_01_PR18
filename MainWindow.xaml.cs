using PrintManagementSystem_Тепляков.Classes;
using PrintManagementSystem_Тепляков.Pages;
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

namespace PrintManagementSystem_Тепляков
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow main;
        public static Record rec = new Record();

        public MainWindow()
        {
            InitializeComponent();
            OpenPages(pages.record);
            main = this;
        }

        public enum pages
        {
            record, magazine
        }

        public void OpenPages(pages _pages)
        {
            if (_pages == pages.record)
            {
                frame.Navigate(rec);
                mainWindow.Title = "Система управления печатью";
            }
            if (_pages == pages.magazine)
            {
                frame.Navigate(new Pages.Magazine(rec));
                mainWindow.Title = "Журнал";
            }
        }
    }
}
