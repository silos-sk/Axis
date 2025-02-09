using System.Security.Authentication;
using ObjCRuntime;
using Axis.Views;
using Axis;

namespace Axis;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();

		List<SteroidRegime> Regimes=
        [
            new SteroidRegime { Time="8:00", Dose="20" },
			new SteroidRegime { Time="12:00", Dose="10" },
			new SteroidRegime { Time="17:00", Dose="10" },
		];

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

    public class SteroidRegime
    {
        public string? Time { get; set; }
        public string? Dose { get; set; }
    }

}

