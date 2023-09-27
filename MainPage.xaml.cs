using CommunityToolkit.Maui.Views;

namespace PopupLayoutIssue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		this.ShowPopup(new Popup123(ImmediateData.IsChecked));
	}

	private void Button_OnClicked(object sender, EventArgs e)
	{
		this.ShowPopup(new Popup2());
	}
}

