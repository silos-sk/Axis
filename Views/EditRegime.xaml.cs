using Axis;
using Axis.Models;
namespace Axis.Views;

using Regime = Axis.Models.SteroidRegime;

[QueryProperty(nameof(RegimeId),"Id")]
public partial class EditRegime: ContentPage
{
	private Regime Regime;

	public EditRegime()
	{
		InitializeComponent();
	}

	private void btnBackHomeClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync($"//{nameof(MainPage)}");
	}

	public string RegimeId
	{
		set
		{
			Regime = RegimeRepository.GetRegimebyId(int.Parse(value));
			lblTime.Text = Regime.Time.ToString();
		}
	}
}

