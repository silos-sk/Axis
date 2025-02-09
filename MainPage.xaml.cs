using System.Security.Authentication;
using ObjCRuntime;
using Axis.Views;
using Axis.Models;

using Regime = Axis.Models.SteroidRegime;

namespace Axis;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();

		// TimeSpan selectedTime = TimePicker.Time;

		List<SteroidRegime> Regimes = RegimeRepository.GetRegimes();
		listRegimes.ItemsSource = Regimes;
	}

	private void OnProtocolClicked(object sender, EventArgs e)
	{

		Shell.Current.GoToAsync(nameof(Protocols));
	}

	public class Patient
    {
        public string? Name { get; set; }
        public int? MRN { get; set; }
        public string? Medication { get; set; }
    }

	public async void ListRegimes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		if (listRegimes.SelectedItem != null)
		{
		await Shell.Current.GoToAsync($"{nameof(EditRegime)}?Id={((Regime)listRegimes.SelectedItem).RegimeId}");
		}
		
	}

    private void ListRegimes_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		listRegimes.SelectedItem = null;
    }

}

