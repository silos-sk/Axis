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
	}

	private void OnProtocolClicked(object sender, EventArgs e)
	{

		Shell.Current.GoToAsync(nameof(Protocols));
	}

	

}

