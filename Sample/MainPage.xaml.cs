using Controls.UserDialogs.Maui;
using MPowerKit.Popups.Interfaces;

namespace Sample;

public partial class MainPage
{
    int count;

    public IPopupService PopupService { get; }

    public MainPage()
    {
        InitializeComponent();

        PopupService = MPowerKit.Popups.PopupService.Current;
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        for (int i = 0; i < 10; i++)
        {
            await PopupService.ShowPopupAsync(new PopupTestPage());
            UserDialogs.Instance.ShowLoading("Loading");
            await Task.Delay(500);
            UserDialogs.Instance.HideHud();
            await PopupService.HidePopupAsync();
        }
    }
}