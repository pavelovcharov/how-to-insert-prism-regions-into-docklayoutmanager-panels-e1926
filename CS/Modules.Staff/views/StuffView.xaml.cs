﻿using System;
using System.Collections.Generic;
using System.Linq;
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
using Modules.Infrastructure;

namespace Modules.Staff {
    public partial class StaffView : UserControl {

        public static TeamController Controller { get { return TeamController.Controller; } }
        public StaffView() {
            InitializeComponent();
        }
    }
}
