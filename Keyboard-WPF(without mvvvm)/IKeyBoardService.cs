using System;
using System.Windows;
using System.Windows.Input;

namespace WpfApp2
{
    interface IKeyBoardService
    {
        void AddWords();
        void MainWindow_KeyDown(object sender, KeyEventArgs e);
        void StopButton_Click(object sender, RoutedEventArgs e);
        void StartButton_Click(object sender, RoutedEventArgs e);
        void MainWindow_Loaded(object sender, RoutedEventArgs e);
        void dispatcherTimer_Tick(object? sender, EventArgs e);
    }
}
