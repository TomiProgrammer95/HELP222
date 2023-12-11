using System.Collections.ObjectModel;

namespace zhmásodik.HELP;

public partial class Picker : ContentPage
{
    public ObservableCollection<string> Elemek { get; set; }

    public object Index { get; set; }

    public Picker()
    {
        Elemek = new ObservableCollection<string>()
            {
                "House", "Car", "Holiday"
            };
        InitializeComponent();
        BindingContext = this;
    }

    private void PickerMethod(object sender, EventArgs e)
    {
        OnPropertyChanged(nameof(Index));
        // Index-el tudsz hivatkozni a kiválasztott elemre
        // pl: if(Index.toString() == "1")
    }
    
}