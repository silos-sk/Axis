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

	private void btnUpdateClicked(object sender, EventArgs e)
	{
		Regime.Time = EntryTime.Time;
		Regime.Dose = EntryDose.Text;
		Regime.Period = EntryPeriod.Text;
		RegimeRepository.UpdateRegime(Regime.RegimeId, Regime);
		Shell.Current.GoToAsync("..");
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

