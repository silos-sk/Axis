using Axis;
namespace Axis.Views;

public partial class Protocols : ContentPage
{
	public Protocols()
	{
		InitializeComponent();
	}

	private void btnBackHomeClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync($"//{nameof(MainPage)}");
	}
}

