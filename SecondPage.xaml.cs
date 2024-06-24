namespace HideSoftInputIssue;

public partial class SecondPage : ContentPage
{
    public SecondPage()
    {
        InitializeComponent();
    }

    private async void NavigateBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ThirdPage(), false);
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new ThirdPage(), false);
    }
}
