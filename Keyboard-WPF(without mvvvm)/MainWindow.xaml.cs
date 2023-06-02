using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace WpfApp2
{
    public partial class MainWindow : Window, IKeyBoardService
    {       
        List<string> words = new List<string>();

        List<string> spareWords = new List<string>();

        private bool flag = false;

        private DispatcherTimer dispatcherTimer;

        private int seconds = 60;

        int i = 0;

        int fails = 0;

        public MainWindow()
        {
            InitializeComponent();
            StartButton.Click += StartButton_Click;
            StopButton.Click += StopButton_Click;
            KeyDown += MainWindow_KeyDown;
            Loaded += MainWindow_Loaded;
        }

        public void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        public void dispatcherTimer_Tick(object? sender, EventArgs e)
        {
            if (flag)
            {
                if (seconds > 0)
                {
                    --seconds;
                    TimerLabel.Content = $"Time left: {seconds}";
                }
                else
                {
                    dispatcherTimer.Stop();

                    MessageBox.Show
                    (
                       $"Time is over! Your speed: {i} char/min, count of fails are: {fails}",
                       caption: "Information",
                       button: MessageBoxButton.OK,
                       icon: MessageBoxImage.Information
                    );

                    InputBox.Clear();
                    ShowBox.Clear();

                    var result = MessageBox.Show
                    (
                       $"Print again?",
                       caption: "Information",
                       button: MessageBoxButton.YesNo,
                       icon: MessageBoxImage.Information
                    );

                    if (result == MessageBoxResult.Yes)
                    {
                        var currentExecutablePath = Process.GetCurrentProcess().MainModule.FileName;
                        Process.Start(currentExecutablePath);
                        Application.Current.Shutdown();
                    }

                    else
                    {
                        Application.Current.Shutdown();
                    }
                }
            }             
        }

        public void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Z)
            {
                if (flag)
                {
                    InputBox.Text += "z";
                    i++;
                }
            }
            if (e.Key == Key.X)
            {
                if (flag)
                {
                    InputBox.Text += "x";
                    i++;
                }
            }
            if (e.Key == Key.C)
            {
                if (flag)
                {
                    InputBox.Text += "c";
                    i++;
                }
            }
            if (e.Key == Key.V)
            {
                if (flag)
                {
                    InputBox.Text += "v";
                    i++;
                }
            }
            if (e.Key == Key.B)
            {
                if (flag)
                {
                    InputBox.Text += "b";
                    i++;
                }
            }
            if (e.Key == Key.N)
            {
                if (flag)
                {
                    InputBox.Text += "n";
                    i++;
                }
            }
            if (e.Key == Key.M)
            {
                if (flag)
                {
                    InputBox.Text += "m";
                    i++;
                }
            }
            if (e.Key == Key.A)
            {
                if (flag)
                {
                    InputBox.Text += "a";
                    i++;
                }
            }
            if (e.Key == Key.S)
            {
                if (flag)
                {
                    InputBox.Text += "s";
                    i++;
                }
            }
            if (e.Key == Key.D)
            {
                if (flag)
                {
                    InputBox.Text += "d";
                    i++;
                }
            }
            if (e.Key == Key.F)
            {
                if (flag)
                {
                    InputBox.Text += "f";
                    i++;
                }
            }
            if (e.Key == Key.G)
            {
                if (flag)
                {
                    InputBox.Text += "g";
                    i++;
                }
            }
            if (e.Key == Key.H)
            {
                if (flag)
                {
                    InputBox.Text += "h";
                    i++;
                }
            }
            if (e.Key == Key.J)
            {
                if (flag)
                {
                    InputBox.Text += "j";
                    i++;
                }
            }
            if (e.Key == Key.K)
            {
                if (flag)
                {
                    InputBox.Text += "k";
                    i++;
                }
            }
            if (e.Key == Key.L)
            {
                if (flag)
                {
                    InputBox.Text += "l";
                    i++;
                }
            }
            if (e.Key == Key.Q)
            {
                if (flag)
                {
                    InputBox.Text += "q";
                    i++;
                }
            }
            if (e.Key == Key.W)
            {
                if (flag)
                {
                    InputBox.Text += "w";
                    i++;
                }
            }
            if (e.Key == Key.E)
            {
                if (flag)
                {
                    InputBox.Text += "e";
                    i++;
                }
            }
            if (e.Key == Key.R)
            {
                if (flag)
                {
                    InputBox.Text += "r";
                    i++;
                }
            }
            if (e.Key == Key.T)
            {
                if (flag)
                {
                    InputBox.Text += "t";
                    i++;
                }
            }
            if (e.Key == Key.Y)
            {
                if (flag)
                {
                    InputBox.Text += "y";
                    i++;
                }
            }
            if (e.Key == Key.U)
            {
                if (flag)
                {
                    InputBox.Text += "u";
                    i++;
                }
            }
            if (e.Key == Key.I)
            {
                if (flag)
                {
                    InputBox.Text += "i";
                    i++;
                }
            }
            if (e.Key == Key.O)
            {
                if (flag)
                {
                    InputBox.Text += "o";
                    i++;
                }
            }
            if (e.Key == Key.P)
            {
                if (flag)
                {
                    InputBox.Text += "p";
                    i++;
                }
            }
            if (e.Key == Key.Back)
            {
                if (flag && InputBox.Text.Length > 0)
                {
                    InputBox.Text = InputBox.Text.Remove(InputBox.Text.Length - 1);
                }
            }
            if (e.Key == Key.CapsLock)
            {
                if (flag)
                {
                    InputBox.CharacterCasing = CharacterCasing.Upper;                 
                }
            }
        }

        public void StopButton_Click(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                flag = false;
            }
        }

        public void StartButton_Click(object sender, RoutedEventArgs e)
        {
            AddWords();

            var rnd = new Random();

            if (flag == false)
            {
                flag = true;
            }

            for (int i = 0; i < words.Count; i++)
            {
                try
                {
                    //if (CaseSensitiveCheckBox.IsChecked == true)
                    {
                        if (ShowBox.Text.Length > 0 && InputBox.Text.Length > 0 && ShowBox.Text[i] != InputBox.Text[i])
                        {
                            fails++;
                        }
                    }
                    
                }
                catch (IndexOutOfRangeException)
                {
                    throw new IndexOutOfRangeException("Incorrect datas!");
                }
                

                var index = rnd.Next(0, words.Count);

                if (InputBox.Text.Length == ShowBox.Text.Length && !spareWords.Contains(words[index]))
                {
                    ShowBox.Text = words[index];
                    InputBox.Clear();
                    spareWords.Add(words[index]);
                }
            }
        }

        public void AddWords()
        {
            words.Add("Abandon");
            words.Add("Abnormal");
            words.Add("Bliss");
            words.Add("Able");
            words.Add("Cohesion");
            words.Add("Diverge");
            words.Add("Redundant");
            words.Add("Inch");
            words.Add("Flour");
            words.Add("Abide");
            words.Add("Lessen");
            words.Add("Dive");
            words.Add("Offspring");
            words.Add("Hill");
            words.Add("Showcase");
            words.Add("Smuggle");
            words.Add("Once");
            words.Add("Block");
            words.Add("Melon");
            words.Add("Abduct");
            words.Add("Flock");
            words.Add("Abate");
            words.Add("Float");
            words.Add("Bloat");
            words.Add("Insect");
            words.Add("Incredible");
            words.Add("Memoirs");
            words.Add("Hinder");
            words.Add("Outnumber");
            words.Add("Frustrating");
            words.Add("Inherit");
            words.Add("Outgoing");
            words.Add("Twilight");
            words.Add("Ultimate");
            words.Add("Landscape");
            words.Add("Weapon");
            words.Add("Incubment");
            words.Add("Waterfall");
            words.Add("Judicial");
            words.Add("Measure");
            words.Add("Dizzy");
            words.Add("Breakfast");
            words.Add("Obedience");
            words.Add("Normal");
            words.Add("Box");
            words.Add("Lung");
            words.Add("Youngster");
            words.Add("Vocabulary");
            words.Add("Objective");
            words.Add("Lunch");
        }
    }
}
