namespace zhmásodik.HELP;

public partial class Entry : ContentPage
{
	public Entry()
	{
		InitializeComponent();
	}

    private void EntryMethod(object sender, TextChangedEventArgs e)
    {
        if (e.NewTextValue == "Hello")
        {
            EntryColor.BackgroundColor = Colors.Red;
        }
    }
}