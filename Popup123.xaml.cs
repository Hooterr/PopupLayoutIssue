using Microsoft.Maui.Controls.Internals;

namespace PopupLayoutIssue;

public partial class Popup123
{
    public Popup123(bool immediately)
    {
        InitializeComponent();

        if (immediately)
        {
            testlabel4.Text = testlabel2.Text =
    "This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines.";
            testlabel1.Text = testlabel3.Text = "Test123";
        }
        else
        {
            Dispatcher.DispatchDelayed(TimeSpan.FromSeconds(0.5), () =>
            {
                testlabel4.Text = testlabel2.Text =
                    "This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines.";
                testlabel1.Text = testlabel3.Text = "Test123";
            });
        }
    }
}