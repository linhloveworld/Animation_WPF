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

namespace BTL_N5_Animation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            TransformGroup transformGroup = new TransformGroup();


            // Scale
            ScaleTransform scaleTransform = new ScaleTransform();
            DoubleAnimation scaleXAnimation = new DoubleAnimation();

            scaleXAnimation.From = 0;
            scaleXAnimation.To = 1;
            scaleXAnimation.Duration = TimeSpan.FromSeconds(0.8);
            //scaleXAnimation.RepeatBehavior = RepeatBehavior.Forever;
            scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, scaleXAnimation);

            // Rotate
            RotateTransform rotateTransform = new RotateTransform();
            DoubleAnimation rotateAnimation = new DoubleAnimation();
            rotateAnimation.Duration = TimeSpan.FromSeconds(0.8);

            // Chỉnh vị trí gốc quay
            // Thêm khung giá trị
            rotateTransform.CenterX = 0.5;
            rotateTransform.CenterY = 0.5;
            rotateAnimation.From = 90;
            rotateAnimation.To = 0;

            // Thiết lập giá trị của RotateTransform.AngleProperty
            rotateTransform.BeginAnimation(RotateTransform.AngleProperty, rotateAnimation);

            // Opacity 
            DoubleAnimation opacityAnimation = new DoubleAnimation();
            opacityAnimation.From = 0;
            opacityAnimation.To = 1;
            opacityAnimation.Duration = TimeSpan.FromSeconds(0.8);
            rectangle1.BeginAnimation(Rectangle.OpacityProperty, opacityAnimation);

            transformGroup.Children.Add(scaleTransform);

            transformGroup.Children.Add(rotateTransform);
            
            rectangle1.RenderTransform = transformGroup;
        }

        private void wheel( object sender, RoutedEventArgs e)
        {
            TransformGroup transformGroup = new TransformGroup();

            // Scale
            ScaleTransform scaleTransform = new ScaleTransform();
            DoubleAnimation scaleXAnimation = new DoubleAnimation();
            scaleXAnimation.From = 0;
            scaleXAnimation.To = 1;
            scaleXAnimation.Duration = TimeSpan.FromSeconds(2);
            scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, scaleXAnimation);

            // Rotate
            RotateTransform rotateTransform = new RotateTransform();
            DoubleAnimation rotateAnimation = new DoubleAnimation();
            rotateAnimation.Duration = TimeSpan.FromSeconds(2);
            rotateTransform.CenterX = 0.5;
            rotateTransform.CenterY = -20;
            rotateAnimation.From = 0;
            rotateAnimation.To = -720;
            rotateTransform.BeginAnimation(RotateTransform.AngleProperty, rotateAnimation);

            // Opacity 
            DoubleAnimation opacityAnimation = new DoubleAnimation();
            opacityAnimation.From = 0;
            opacityAnimation.To = 1;
            opacityAnimation.Duration = TimeSpan.FromSeconds(2);
            rectangle1.BeginAnimation(Rectangle.OpacityProperty, opacityAnimation);

            // Add transforms to group
            transformGroup.Children.Add(scaleTransform);
            transformGroup.Children.Add(rotateTransform);

            // Set the RenderTransform to the group
            rectangle1.RenderTransform = transformGroup;

        }

        private void swivel(object sender, RoutedEventArgs e)
        {
            TransformGroup transformGroup = new TransformGroup();
            // Scale
            ScaleTransform scaleTransform = new ScaleTransform();
            DoubleAnimationUsingKeyFrames scaleXAnimation = new DoubleAnimationUsingKeyFrames();
            // Thêm các LinearDoubleKeyFrame tương ứng với các giá trị tại các điểm khung hình
            scaleXAnimation.KeyFrames.Add(new LinearDoubleKeyFrame(1, TimeSpan.FromSeconds(0)));
            scaleXAnimation.KeyFrames.Add(new LinearDoubleKeyFrame(-1, TimeSpan.FromSeconds(1)));
            scaleXAnimation.KeyFrames.Add(new LinearDoubleKeyFrame(1, TimeSpan.FromSeconds(2)));
            scaleXAnimation.Duration = TimeSpan.FromSeconds(2);
            scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, scaleXAnimation);

            // Rotate
            RotateTransform rotateTransform = new RotateTransform();
            DoubleAnimation rotateAnimation = new DoubleAnimation();
            rotateAnimation.Duration = TimeSpan.FromSeconds(2);
            rotateTransform.CenterX = 0.5;
            rotateTransform.CenterY = 1;
            rotateAnimation.From = 0;
            rotateAnimation.To = 0;
            rotateTransform.BeginAnimation(RotateTransform.AngleProperty, rotateAnimation);

            // Opacity 
            DoubleAnimation opacityAnimation = new DoubleAnimation();
            opacityAnimation.From = 0.2;
            opacityAnimation.To = 1;
            opacityAnimation.Duration = TimeSpan.FromSeconds(2);
            rectangle1.BeginAnimation(Rectangle.OpacityProperty, opacityAnimation);

            // Add transforms to group
            transformGroup.Children.Add(scaleTransform);
            transformGroup.Children.Add(rotateTransform);

            // Set the RenderTransform to the group
            rectangle1.LayoutTransform = transformGroup;

        }

        // Hòa- teeter
        private void teeter(object sender, RoutedEventArgs e)
        {
            TransformGroup transformGroup = new TransformGroup();

            // Scale
            

            // Rotate
            RotateTransform rotateTransform = new RotateTransform();
            DoubleAnimationUsingKeyFrames rotateAnimation = new DoubleAnimationUsingKeyFrames();
            // Thêm các LinearDoubleKeyFrame tương ứng với các giá trị tại các điểm khung hình
            rotateAnimation.KeyFrames.Add(new LinearDoubleKeyFrame(4, TimeSpan.FromSeconds(0.2)));
            rotateAnimation.KeyFrames.Add(new LinearDoubleKeyFrame(-4, TimeSpan.FromSeconds(0.4)));
            rotateAnimation.KeyFrames.Add(new LinearDoubleKeyFrame(4, TimeSpan.FromSeconds(0.6)));
            rotateAnimation.KeyFrames.Add(new LinearDoubleKeyFrame(-4, TimeSpan.FromSeconds(0.8)));
            rotateAnimation.KeyFrames.Add(new LinearDoubleKeyFrame(0, TimeSpan.FromSeconds(1)));
            rotateAnimation.Duration = TimeSpan.FromSeconds(1);
            rotateTransform.BeginAnimation(RotateTransform.AngleProperty, rotateAnimation);

            transformGroup.Children.Add(rotateTransform);


            // Set the RenderTransform to the group
            rectangle1.RenderTransform = transformGroup;

        }

        // Pulse
        private void btn_Pulse(object sender, RoutedEventArgs e)
        {
            TransformGroup transformGroup = new TransformGroup();
            ScaleTransform scaleTransform = new ScaleTransform();

            DoubleAnimation scaleXAnimation = new DoubleAnimation();
            scaleXAnimation.From = 1;
            scaleXAnimation.To = 1.2;
            scaleXAnimation.Duration = TimeSpan.FromSeconds(1);
            scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, scaleXAnimation);
            scaleTransform.ScaleX = 1;
            scaleTransform.ScaleY = 1;

            DoubleAnimation opacityAnimation = new DoubleAnimation();
            opacityAnimation.From = 0;
            opacityAnimation.To = 1;
            opacityAnimation.Duration = TimeSpan.FromSeconds(1);
            rectangle1.BeginAnimation(Rectangle.OpacityProperty, opacityAnimation);
            transformGroup.Children.Add(scaleTransform);
            rectangle1.RenderTransform = transformGroup;
        }

        // Hùng 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TransformGroup transformGroup = new TransformGroup();
            ScaleTransform scaleTransform = new ScaleTransform();
            DoubleAnimation scaleXAnimation = new DoubleAnimation();
            scaleXAnimation.From = 1;
            scaleXAnimation.To = 0;
            scaleXAnimation.Duration = TimeSpan.FromSeconds(1);
            scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, scaleXAnimation);
            RotateTransform rotateTransform = new RotateTransform();
            DoubleAnimation rotateAnimation = new DoubleAnimation();
            rotateAnimation.Duration = TimeSpan.FromSeconds(.9);
            rotateTransform.CenterX = 0.5;
            rotateTransform.CenterY = 0.5;
            rotateAnimation.From = 90;
            rotateAnimation.To = 0;
            rotateTransform.BeginAnimation(RotateTransform.AngleProperty, rotateAnimation);
            DoubleAnimation opacityAnimation = new DoubleAnimation();
            opacityAnimation.From = 1;
            opacityAnimation.To = 0;
            opacityAnimation.Duration = TimeSpan.FromSeconds(0.8);
            rectangle1.BeginAnimation(Rectangle.OpacityProperty, opacityAnimation);
            transformGroup.Children.Add(scaleTransform);
            transformGroup.Children.Add(rotateTransform);
            rectangle1.RenderTransform = transformGroup;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TransformGroup transformGroup = new TransformGroup();
            ScaleTransform scaleTransform = new ScaleTransform();
            DoubleAnimation scaleXAnimation = new DoubleAnimation();
            scaleXAnimation.From = 0;
            scaleXAnimation.To = 1;
            scaleXAnimation.Duration = TimeSpan.FromSeconds(1);
            scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, scaleXAnimation);

            DoubleAnimation opacityAnimation = new DoubleAnimation();
            opacityAnimation.From = 0;
            opacityAnimation.To = 1;
            opacityAnimation.Duration = TimeSpan.FromSeconds(1);
            rectangle1.BeginAnimation(Rectangle.OpacityProperty, opacityAnimation);
            transformGroup.Children.Add(scaleTransform);
            rectangle1.RenderTransform = transformGroup;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TransformGroup transformGroup = new TransformGroup();
            ScaleTransform scaleTransform = new ScaleTransform();
            DoubleAnimation scaleXAnimation = new DoubleAnimation();
            scaleXAnimation.From = 1;
            scaleXAnimation.To = 0;
            scaleXAnimation.Duration = TimeSpan.FromSeconds(.8);
            scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, scaleXAnimation);

            DoubleAnimation opacityAnimation = new DoubleAnimation();
            opacityAnimation.From = 1;
            opacityAnimation.To = 0;
            opacityAnimation.Duration = TimeSpan.FromSeconds(0.8);
            rectangle1.BeginAnimation(Rectangle.OpacityProperty, opacityAnimation);
            transformGroup.Children.Add(scaleTransform);
            rectangle1.RenderTransform = transformGroup;
        } // End Hùng

        // 
        private void appear(object sender, RoutedEventArgs e)
        {
            DoubleAnimation opacityAnimation = new DoubleAnimation();
            opacityAnimation.From = 0;
            opacityAnimation.To = 1;
            opacityAnimation.Duration = TimeSpan.FromSeconds(1);
            rectangle1.BeginAnimation(Rectangle.OpacityProperty, opacityAnimation);

            ScaleTransform scaleTransform = new ScaleTransform();
            DoubleAnimation scaleXAnimation = new DoubleAnimation();
            scaleXAnimation.From = 0.5;
            scaleXAnimation.To = 1;
            scaleXAnimation.Duration = TimeSpan.FromSeconds(1);
            rectangle1.RenderTransformOrigin = new Point(0.5, 0.5);
            scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, scaleXAnimation);

            DoubleAnimation scaleYAnimation = new DoubleAnimation();
            scaleYAnimation.From = 0.5;
            scaleYAnimation.To = 1;
            scaleYAnimation.Duration = TimeSpan.FromSeconds(1);
            scaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, scaleYAnimation);

            TransformGroup transformGroup = new TransformGroup();
            transformGroup.Children.Add(scaleTransform);
            rectangle1.RenderTransform = transformGroup;

        }

        private void zoom(object sender, RoutedEventArgs e)
        {
            TransformGroup transformGroup = new TransformGroup();

            ScaleTransform scaleTransform = new ScaleTransform();
            transformGroup.Children.Add(scaleTransform);

            DoubleAnimation scaleAnimation = new DoubleAnimation();
            scaleAnimation.From = 1.0;
            scaleAnimation.To = 1.5;
            scaleAnimation.Duration = TimeSpan.FromSeconds(1);
            scaleAnimation.AutoReverse = true;
            scaleAnimation.RepeatBehavior = RepeatBehavior.Forever;
            scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
            scaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, scaleAnimation);

            rectangle1.RenderTransform = transformGroup;



        }

        private void flyin(object sender, RoutedEventArgs e)
        {
            // Create a TransformGroup to hold the animations
            TransformGroup transformGroup = new TransformGroup();

            // Create a ScaleTransform to scale the rectangle
            ScaleTransform scaleTransform = new ScaleTransform();
            DoubleAnimation scaleAnimation = new DoubleAnimation();
            scaleAnimation.From = 0.8; // start with 80% size
            scaleAnimation.To = 1; // end with 100% size
            scaleAnimation.Duration = TimeSpan.FromSeconds(1);
            scaleAnimation.EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseInOut };
            scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
            scaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, scaleAnimation);

            // Create a TranslateTransform to move the rectangle into view
            TranslateTransform translateTransform = new TranslateTransform();
            DoubleAnimation translateAnimation = new DoubleAnimation();
            translateAnimation.From = -100; // move from left of screen
            translateAnimation.To = 0; // move to center of screen
            translateAnimation.Duration = TimeSpan.FromSeconds(1);
            translateAnimation.EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseInOut };
            translateTransform.BeginAnimation(TranslateTransform.XProperty, translateAnimation);

            // Add the transforms to the TransformGroup
            transformGroup.Children.Add(scaleTransform);
            transformGroup.Children.Add(translateTransform);

            // Set the RenderTransform to the TransformGroup
            rectangle1.RenderTransform = transformGroup;


        }

        private void rise_up(object sender, RoutedEventArgs e)
        {
            TranslateTransform translateTransform = new TranslateTransform();
            DoubleAnimation translateYAnimation = new DoubleAnimation();
            translateYAnimation.From = 0;
            translateYAnimation.To = -50;
            translateYAnimation.Duration = TimeSpan.FromSeconds(1);
            translateYAnimation.AutoReverse = true;
            translateYAnimation.RepeatBehavior = RepeatBehavior.Forever;
            translateTransform.BeginAnimation(TranslateTransform.YProperty, translateYAnimation);
            rectangle1.RenderTransform = translateTransform;



        }
    }
}
