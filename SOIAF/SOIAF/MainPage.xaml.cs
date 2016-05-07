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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SOIAF
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //ViewFrame.Navigate(typeof(View.HomeView));
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void HamMenuActivator_Click(object sender, RoutedEventArgs e)
        {
            SplitView.IsPaneOpen = !SplitView.IsPaneOpen;
        }

        private void StackPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void StackPanel_Tapped_1(object sender, TappedRoutedEventArgs e)
        {

        }

        private void homePanel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ViewFrame.Navigate(typeof(View.HomeView));
        }

        private void charactersPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ViewFrame.Navigate(typeof(View.CharactersView));
        }

        private void booksPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ViewFrame.Navigate(typeof(View.BooksView));
        }

        private void kingdomsPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ViewFrame.Navigate(typeof(View.KingdomsView));
        }
    }
}
