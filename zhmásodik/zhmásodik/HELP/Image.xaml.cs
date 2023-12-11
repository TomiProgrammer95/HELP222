using System.Windows.Input;

namespace zhmásodik.HELP;

public partial class Image : ContentPage
{
    public ICommand MyCommand1 { get; set; }

    public Image()
    {
        MyCommand1 = new Command(() => { StackLayoutColor.BackgroundColor = Colors.Red; });
        InitializeComponent();
        BindingContext = this;
    }
}