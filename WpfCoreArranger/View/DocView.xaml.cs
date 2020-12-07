﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfCoreArranger.ViewModel;

namespace WpfCoreArranger.View
{
    /// <summary>
    /// Interaction logic for DocView.xaml
    /// </summary>
    public partial class DocView : UserControl
    {
        public DocView()
        {
            InitializeComponent();
            DataContext = new DocumentsViewModel();
        }
    }
}
