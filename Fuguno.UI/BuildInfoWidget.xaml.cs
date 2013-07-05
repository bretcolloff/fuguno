﻿using Fuguno.Tfs;
using System;
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

namespace Fuguno.UI
{
    /// <summary>
    /// Interaction logic for BuildInfoWidget.xaml
    /// </summary>
    public partial class BuildInfoWidget : UserControl
    {
        public static DependencyProperty StatusProperty = DependencyProperty.Register("Status", typeof(string), typeof(BuildInfoWidget));
        public string Status
        {
            get { return (string)GetValue(StatusProperty); }
            set { SetValue(StatusProperty, value); }
        }

        public static DependencyProperty BuildNumberProperty = DependencyProperty.Register("BuildNumber", typeof(string), typeof(BuildInfoWidget));
        public string BuildNumber
        {
            get { return (string)GetValue(BuildNumberProperty); }
            set { SetValue(BuildNumberProperty, value); }
        }

        public static DependencyProperty RequestedForProperty = DependencyProperty.Register("RequestedFor", typeof(string), typeof(BuildInfoWidget));
        public string RequestedFor
        {
            get { return (string)GetValue(RequestedForProperty); }
            set { SetValue(RequestedForProperty, value); }
        }

        public BuildInfoWidget()
        {
            InitializeComponent();
        }

        private void UpdateControls()
        {
            //Brush backgroundBrush = null;
            //switch (_buildInfo.Status)
            //{
            //    case "None":
            //    case "NotStarted":
            //        backgroundBrush = new SolidColorBrush(Colors.DarkGray);
            //        break;
            //    case "InProgress":
            //        backgroundBrush = new SolidColorBrush(Colors.LightGray);
            //        break;
            //    case "Succeeded":
            //        backgroundBrush = new SolidColorBrush(Colors.Green);
            //        break;
            //    case "PartiallySucceeded":
            //        backgroundBrush = new SolidColorBrush(Colors.Orange);
            //        break;
            //    case "Failed":
            //        backgroundBrush = new SolidColorBrush(Colors.Red);
            //        break;
            //    case "Stopped":
            //        backgroundBrush = new SolidColorBrush(Colors.Yellow);
            //        break;
            //}

            //Background = backgroundBrush;

            //BuildNumberLabel.Content = _buildInfo.BuildNumber;
            //RequestedForLabel.Content = _buildInfo.RequestedFor;
        }
    }
}