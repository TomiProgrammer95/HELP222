namespace zhmásodik.HELP;

public partial class CheckBox : ContentPage
{
    public bool Check { get; set; }

    public CheckBox()
    {

        InitializeComponent();
        BindingContext = this;
    }

    private void CheckBoxMethod(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value == true) // if(Check == true) ez is jó lenne
        {
            Label.Text = "Igaz";
        }
    }
}