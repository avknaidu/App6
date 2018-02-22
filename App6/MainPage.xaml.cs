using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App6
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.SetValue(Microsoft.Toolkit.Uwp.UI.Extensions.TextBoxRegex.RegexProperty, @"^(\([0-9]{3}\) |[0-9]{3}-)[0-9]{3}-[0-9]{4}|(\([0-9]{3}\)|[0-9]{3})[0-9]{3}[0-9]{4}$");

            TextBlock textBlock = new TextBlock();
            textBlock.Text = textBox.GetValue(Microsoft.Toolkit.Uwp.UI.Extensions.TextBoxRegex.IsValidProperty).ToString();

            StackPanel stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.Children.Add(textBox);
            stackPanel.Children.Add(textBlock);

            MyGrid.Children.Add(stackPanel);
        }
    }
}
