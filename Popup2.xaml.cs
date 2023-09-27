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
    private readonly bool _clearParent;
    public Popup2(bool clearParent)
    {
        _clearParent = clearParent;
        InitializeComponent();
        Content.BindingContext = new ViewModel();
    }

    protected override Task OnClosed(object result, bool wasDismissedByTappingOutsideOfPopup)
    {
        if (_clearParent)
        {
            Content.Parent = null;
        }

        return base.OnClosed(result, wasDismissedByTappingOutsideOfPopup);
    }
}