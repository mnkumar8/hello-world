using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;

namespace HelloWorld
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new HelloWorld.MainPage();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            AppCenter.Start("uwp=6adde237-562c-4834-b2eb-a59d3c4ede95;" +
                   "android={Your Android App secret here}" +
                   "ios={Your iOS App secret here}",
                   typeof(Analytics));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
