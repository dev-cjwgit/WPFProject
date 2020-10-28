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
using WPFProject.BindingModel;
using WPFProject.WPFWindow.SubWindow;

namespace WPFProject.WPFWindow
{
    /// <summary>
    /// Type_Select_Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Type_Select_Window : UserControl
    {
        public Type_Select_Window()
        {
            InitializeComponent();
            var anim1 = new DoubleAnimation(0, 1, (Duration)TimeSpan.FromSeconds(0.3));
            this.BeginAnimation(UIElement.OpacityProperty, anim1);
        }

        private void Button1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var anim = new DoubleAnimation(1, 0, (Duration)TimeSpan.FromSeconds(0.3));

            anim.Completed += (s, _) =>
              {
                  ContentBindingModel.GetInstance().Page = new GameOneWindow();
              };
            this.BeginAnimation(UIElement.OpacityProperty, anim);

        }

        private void Button2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var anim = new DoubleAnimation(1, 0, (Duration)TimeSpan.FromSeconds(0.3));

            anim.Completed += (s, _) =>
            {
                ContentBindingModel.GetInstance().Page = new GameTwoWindow();
            };
            this.BeginAnimation(UIElement.OpacityProperty, anim);

        }

        private void Button3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var anim = new DoubleAnimation(1, 0, (Duration)TimeSpan.FromSeconds(0.3));

            anim.Completed += (s, _) =>
            {
                ContentBindingModel.GetInstance().Page = new GameThreeWindow();
            };
            this.BeginAnimation(UIElement.OpacityProperty, anim);

        }

    }
}
