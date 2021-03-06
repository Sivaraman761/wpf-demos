#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.SampleLayout;
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

namespace FastBarChart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : SampleLayoutWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class Model
    {
        public DateTime Date { get; set; }

        public double Price { get; set; }
    }

    public class ViewModel
    {
        DateTime date = new DateTime(1999, 1, 1);

        public ViewModel()
        {
            List = new ObservableCollection<Model>();
            Random random = new Random();

            for (int i = 0; i < 80; i++)
            {
                List.Add(new Model() { Date = date.AddDays(i), Price = random.Next(1, 20) });
            }            
        }

        public ObservableCollection<Model> List { get; set; }
    }
}
