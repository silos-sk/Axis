using Axis;
namespace Axis.Views;

public partial class EditRegime: ContentPage
{
	public EditRegime()
	{
		InitializeComponent();
	}

	private void btnBackHomeClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync($"//{nameof(MainPage)}");
	}
}

