using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CaptainsLog.Core;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace CaptainsLog
{

    /// Interaction logic for MainWindow.xaml

    public partial class MainWindow : Window
    {
        // Selects entry within Data Grid
        private logEntry SelectedLogEntry;

        //Public = so everyone can see it, the OC class (a smarter list) does something with the logEntry (????) class, naming the new class logEntries
        public static ObservableCollection<logEntry> logEntries;

        //public = so everyone can see it, static = which is a setting that makes it set, like a reference point?, no idea about the Routed class, Naming it DeletedCommand 
        //and having it be able to receive input
        public static RoutedUICommand DeleteCommand { get; }

        //public = so everyone can see it, MainWindow is the actual main window for the WPF and shows the user the app
        public MainWindow()
        {
            //This starts the app up - like a rooster that wakes up an entire farm at dawn
            InitializeComponent();

            //logEntires is now a variable defined as any new instance of the logEntry class ???
            logEntries = new ObservableCollection<logEntry>();

            //I don't know
            gridLogEntries.ItemsSource = logEntries;
        }

        //private = so only this class can be seen by this part of the app?? (I can't explain it in words) Seperation of Concerns
        private void newEntry_Click(object sender, RoutedEventArgs e)
        {
            newWindow entryWindow = new newWindow();
            entryWindow.Show();
            
        }

        private void saveEntry_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This will work soon.");            
        }

        private void deleteEntry_Click(object sender, RoutedEventArgs e)
        {
            // the if statement confirms that something is selected
            if (SelectedLogEntry != null)
            {
                // the reference to the selection within the grid is removed 
                logEntries.Remove(SelectedLogEntry);
                // the reference is nullified 
                SelectedLogEntry = null;
            }
        }
        
        // Event of selection (when grid item clicked it is selected)
        private void gridLogEntries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // row (selected item) within the data grid (gridLogEntries) cast within 
            // the LogEntry class (adds functionality)
            SelectedLogEntry = (logEntry)gridLogEntries.SelectedItem;
        }

    }
}













