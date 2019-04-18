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
using Database;
using Microsoft.EntityFrameworkCore;
using Mosiac.Services;
using Mosiac.ViewModels;
using MahApps.Metro.Controls;

namespace Mosiac
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly MainViewModel _vm;
        private readonly IPartDetailViewModel _partModel;

        public MainWindow(MainViewModel vm, IPartDetailViewModel partModel)
        {
            InitializeComponent();
            _vm = vm;
            _partModel = partModel;
            DataContext = _vm; 
            Loaded += MainWindow_Loaded;
           
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await _vm.LoadAsync();
            await _partModel.LoadManusList();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.TextBoxName.Text.ToString().Length > 0)
            {
                _vm.Search(TextBoxName.Text.ToString());
            }
           
           
        }

        public IPartDetailViewModel PartDetailViewModel { get;  }
    }
}
