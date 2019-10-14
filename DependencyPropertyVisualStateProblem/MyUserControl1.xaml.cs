namespace DependencyPropertyVisualStateProblem
{
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    public sealed partial class MyUserControl1 : UserControl
    {
        public MyUserControl1()
        {
            this.InitializeComponent();
        }

        public static readonly DependencyProperty IsButtonCheckedProperty =
            DependencyProperty.Register(nameof(IsButtonChecked), typeof(bool),
                typeof(MyUserControl1), new PropertyMetadata(null));

        public bool IsButtonChecked
        {
            get => (bool)GetValue(IsButtonCheckedProperty);
            set => SetValue(IsButtonCheckedProperty, value);
        }
    }
}
