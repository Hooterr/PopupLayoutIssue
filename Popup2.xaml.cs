using CommunityToolkit.Mvvm.ComponentModel;

namespace PopupLayoutIssue;

public partial class ViewModel : ObservableObject
{
    [ObservableProperty]
    private int _selected;

    public ViewModel()
    {
        Selected = 1;
    }
}

public partial class Popup2
{
    public Popup2()
    {
        InitializeComponent();
        Content.BindingContext = new ViewModel();
    }

    protected override Task OnClosed(object result, bool wasDismissedByTappingOutsideOfPopup)
    {
        Content.Parent = null;
        return base.OnClosed(result, wasDismissedByTappingOutsideOfPopup);
    }
}