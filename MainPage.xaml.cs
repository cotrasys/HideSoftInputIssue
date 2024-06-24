namespace HideSoftInputIssue;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void NavigateBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SecondPage());
    }
}
