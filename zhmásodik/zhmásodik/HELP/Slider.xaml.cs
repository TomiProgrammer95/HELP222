namespace zhmásodik.HELP;

public partial class Slider : ContentPage
{
    public int Value { get; set; }

    public Slider()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private void SliderMethod(object sender, ValueChangedEventArgs e)
    {
        // "e" - vel érem a a kapm meg slider értékét 
        if (e.NewValue > 50)
        {
            EntryColor.BackgroundColor = Colors.Red;
        }
        else
        {
            EntryColor.BackgroundColor = Colors.Green;
        }
        OnPropertyChanged(nameof(Value));
    }
}