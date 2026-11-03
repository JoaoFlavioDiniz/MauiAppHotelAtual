namespace MauiAppHotelAtualizado.Views;

public partial class HospedagemContratada : ContentPage
{
    public HospedagemContratada()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async Task Button_Clicked_1(object sender, EventArgs e)
    {
        
    }
}