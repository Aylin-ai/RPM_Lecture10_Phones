using System.Windows;
using Microsoft.Xaml.Behaviors;

namespace Phones
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new ApplicationViewModel
                (
                new DefaultDialogService(), 
                new JsonFileService()
                );
        }
    }
}
