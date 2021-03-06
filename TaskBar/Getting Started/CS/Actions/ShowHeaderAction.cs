#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.Windows.Interactivity;
using Syncfusion.Windows.Tools.Controls;
using System.Windows.Controls;
using System.Windows;

namespace TaskBarDemo
{
    /// <summary>
    /// Class represents the show header logic for task bar.
    /// </summary>
    public class ShowHeaderAction : TargetedTriggerAction<CheckBox>
    {
#if Framework3_5
        public FrameworkElement TargetObject
        {
            get { return (FrameworkElement)GetValue(TargetObjectProperty); }
            set { SetValue(TargetObjectProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Target.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TargetObjectProperty =
            DependencyProperty.Register("TargetObject", typeof(FrameworkElement), typeof(ShowHeaderAction), new UIPropertyMetadata(null));
#endif

        /// <summary>
        /// Method used to show header for the task bar.
        /// </summary>
        /// <param name="parameter">Specifies the parameter to invoke the object.</param>
        protected override void Invoke(object parameter)
        {            
            foreach (object obj in ((TaskBar)TargetObject).Items)
            {
                TaskBarItem item = obj as TaskBarItem;
                if (item != null)
                {
                    RoutedEventArgs routedEvent = parameter as RoutedEventArgs;
                    if ((routedEvent.OriginalSource as CheckBox).IsChecked == true)
                        item.ShowHeader();
                    else
                        item.HideHeader();
                }
            }
        }
    }
}
