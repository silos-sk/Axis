namespace Axis;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	// private void OnCounterClicked(object sender, EventArgs e)
	// {
	// 	count++;

	// 	if (count == 1)
	// 		CounterBtn.Text = $"Clicked {count} time";
	// 	else
	// 		CounterBtn.Text = $"Clicked {count} times";

	// 	SemanticScreenReader.Announce(CounterBtn.Text);
	// }
	private void OnProtocolClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			ThreePt.Text = $"Clicked {count} time";
		else
			ThreePt.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(ThreePt.Text);
	}
}

