using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StarWeb
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new StarWeb.StarDev();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
