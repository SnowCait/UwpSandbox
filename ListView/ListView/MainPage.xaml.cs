using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 を参照してください

namespace ListView
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            CoreWindow.GetForCurrentThread().KeyUp += MainPage_KeyUp;
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            base.OnNavigatingFrom(e);

            CoreWindow.GetForCurrentThread().KeyUp -= MainPage_KeyUp;
        }

        private void MainPage_KeyUp(CoreWindow sender, KeyEventArgs args)
        {
            Debug.WriteLine(args.VirtualKey);
            switch (args.VirtualKey)
            {
                case VirtualKey.J:
                    if (ListView1.SelectedIndex < ListView1.Items.Count - 1)
                        ListView1.SelectedIndex++;
                    break;
                case VirtualKey.K:
                    if (ListView1.SelectedIndex > 0)
                        ListView1.SelectedIndex--;
                    break;

                case VirtualKey.T:
                    var item = ListView1.SelectedItem as TextBlock;
                    Debug.WriteLine(item.Text);
                    break;

                case VirtualKey.Up:
                case VirtualKey.Down:
                    Debug.WriteLine(ListView1.CharacterSpacing);
                    break;
            }
        }

        private void ListView1_ChoosingGroupHeaderContainer(ListViewBase sender, ChoosingGroupHeaderContainerEventArgs args)
        {

        }

        private void ListView1_ChoosingItemContainer(ListViewBase sender, ChoosingItemContainerEventArgs args)
        {

        }

        private void ListView1_ContainerContentChanging(ListViewBase sender, ContainerContentChangingEventArgs args)
        {

        }

        private void ListView1_DataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args)
        {

        }

        private void ListView1_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {

        }

        private void ListView1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void ListView1_DragItemsCompleted(ListViewBase sender, DragItemsCompletedEventArgs args)
        {

        }

        private void ListView1_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {

        }

        private void ListView1_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void ListView1_DragOver(object sender, DragEventArgs e)
        {

        }

        private void ListView1_DragStarting(UIElement sender, DragStartingEventArgs args)
        {

        }

        private void ListView1_Drop(object sender, DragEventArgs e)
        {

        }

        private void ListView1_DropCompleted(UIElement sender, DropCompletedEventArgs args)
        {

        }

        private void ListView1_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void ListView1_Holding(object sender, HoldingRoutedEventArgs e)
        {

        }

        private void ListView1_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void ListView1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void ListView1_KeyDown(object sender, KeyRoutedEventArgs e)
        {

        }

        private void ListView1_KeyUp(object sender, KeyRoutedEventArgs e)
        {

        }

        private void ListView1_LayoutUpdated(object sender, object e)
        {

        }

        private void ListView1_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ListView1_Loading(FrameworkElement sender, object args)
        {

        }

        private void ListView1_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void ListView1_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {

        }

        private void ListView1_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {

        }

        private void ListView1_ManipulationInertiaStarting(object sender, ManipulationInertiaStartingRoutedEventArgs e)
        {

        }

        private void ListView1_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e)
        {

        }

        private void ListView1_ManipulationStarting(object sender, ManipulationStartingRoutedEventArgs e)
        {

        }

        private void ListView1_PointerCanceled(object sender, PointerRoutedEventArgs e)
        {

        }

        private void ListView1_PointerCaptureLost(object sender, PointerRoutedEventArgs e)
        {

        }

        private void ListView1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {

        }

        private void ListView1_PointerExited(object sender, PointerRoutedEventArgs e)
        {

        }

        private void ListView1_PointerMoved(object sender, PointerRoutedEventArgs e)
        {

        }

        private void ListView1_PointerPressed(object sender, PointerRoutedEventArgs e)
        {

        }

        private void ListView1_PointerReleased(object sender, PointerRoutedEventArgs e)
        {

        }

        private void ListView1_PointerWheelChanged(object sender, PointerRoutedEventArgs e)
        {

        }

        private void ListView1_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {

        }

        private void ListView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Debug.WriteLine(ListView1.SelectedIndex);
        }

        private void ListView1_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void ListView1_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ListView1_Unloaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
