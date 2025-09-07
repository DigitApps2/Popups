using Controls.UserDialogs.Maui;

namespace Sample;

public partial class PopupTestPage
{
    public PopupTestPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearingAnimationEnd()
    {
        base.OnAppearingAnimationEnd();


        UserDialogs.Instance.ShowLoading("Loading");
        await Task.Delay(500);
        UserDialogs.Instance.HideHud();
    }
}