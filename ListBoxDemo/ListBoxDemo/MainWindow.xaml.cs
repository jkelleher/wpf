using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ListBoxDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TestData = new ObservableCollection<Data>();
            TestData.Add(new Data() { Name = "John Brown", Notes = "These are the notes for John Brown.", When = DateTime.Today.AddDays(2) });
            TestData.Add(new Data() { Name = "Sally Brown", Notes = "These are the notes for John Brown.", When = DateTime.Today.AddDays(2) });
            TestData.Add(new Data() { Name = "John Smith", Notes = "These are the notes for John Brown.", When = DateTime.Today.AddDays(2) });
            TestData.Add(new Data() { Name = "John Doe", Notes = "These are the notes for John Brown.", When = DateTime.Today.AddDays(2) });

            this.DataContext = this;
        }

        public ObservableCollection<Data> TestData { get; set; }
    }

    public class Data
    {
        public string Name { get; set; }
        public string Notes { get; set; }
        public DateTime When { get; set; }
    }
}
