using System;
using System.Windows;
using System.Diagnostics;

namespace Dinner.Async
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnMakeDinner_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //[1] 밥만들기
            Restaurant.Restaurant.Rice rice = await (new Restaurant.Restaurant()).MakeRiceAsync();
            IblDisplay.Content = $"밥 준비완료 -{rice.GetHashCode()}";

            //[2] 국만들기
            Restaurant.Restaurant.Soup soup = await (new Restaurant.Restaurant()).MakeSoupAsync();
            IblDisplay.Content = $"국 준비완료 -{soup.GetHashCode()}";

            stopwatch.Stop();
            IblDisplay.Content = $"\n 시간 : {stopwatch.ElapsedMilliseconds}밀리초";

            IblDisplay.Content = ("비동기 방식으로 식사준비 완료");

        }

        private void btnWatchingTV_Click(object sender, RoutedEventArgs e)
        {
            IblDisplay.Content = 
                "TV 보는중..." + DateTime.Now.Millisecond.ToString();
        }


    }


}
