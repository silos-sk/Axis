using Axis.Views;

namespace Axis;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(Protocols), typeof(Protocols));
		Routing.RegisterRoute(nameof(EditRegime), typeof(EditRegime));
	}
}
