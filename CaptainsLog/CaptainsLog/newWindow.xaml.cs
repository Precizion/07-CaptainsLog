using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Windows.Navigation;
using CaptainsLog.Core;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace CaptainsLog
{
    /// <summary>
    /// Interaction logic for newWindow.xaml
    /// </summary>
    public partial class newWindow : Window
    {
        public newWindow()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            logEntry log = new logEntry();

            log.Id = MainWindow.logEntries.Count + 1;
            log.Title = titleBox.Text;
            log.Text = entryBox.Text;
            log.EntryDate = DateTime.Now;

            MainWindow.logEntries.Add(log);
        }
    }
}
