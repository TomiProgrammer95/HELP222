using System.Collections.ObjectModel;

namespace zhmásodik.HELP;

public partial class Tapped : ContentPage
{
    public ObservableCollection<string> Items { get; set; }

    public Tapped()
    {
        Items = new ObservableCollection<string>()
        {
            "kocka.png",
            "kocka.png",
            "kocka.png"
        };
        BindingContext = this;
        InitializeComponent();
    }

    private void TappedMethod(object sender, ItemTappedEventArgs e)
    {
        if (e.ItemIndex == 0)
        {
            ScrollViewName.BackgroundColor = Colors.Red;
        }
        else
        {
            ScrollViewName.BackgroundColor = Colors.Green;
        }
    }
}