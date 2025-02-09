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

	private void btnCancelClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync($"//{nameof(MainPage)}");
	}

	private void btnSaveClicked(object sender, EventArgs e)
	{
		// Shell.Current.GoToAsync($"//{nameof(MainPage)}");
	}

	public string RegimeId
	{
		set
		{
			Regime = RegimeRepository.GetRegimebyId(int.Parse(value));
			if (Regime !=null)
			{
				EntryTime.Time = Regime.Time;
				EntryDose.Text = Regime.Dose;
				EntryPeriod.Text = Regime.Period;
			}
			
			// lblTime.Text = Regime.Time.ToString();
			// lblDose.Text = Regime.Dose;
			// lblPeriod.Text = Regime.Period;
		}
	}
}

