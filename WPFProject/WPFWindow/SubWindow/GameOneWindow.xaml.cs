using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFProject.WPFWindow.SubWindow
{
    /// <summary>
    /// GameOneWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class GameOneWindow : UserControl
    {
        public GameOneWindow()
        {
            InitializeComponent();
            var anim1 = new DoubleAnimation(0, 1, (Duration)TimeSpan.FromSeconds(0.3));
            this.BeginAnimation(OpacityProperty, anim1);
        }

    }
}
