using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

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
            AppCenter.Start("uwp=ba4e80a0-cf3c-4791-b16b-a6c23399f6c7;" +
                   "android=8b4a54ff-9951-4e97-99ed-3ab95b729c58" +
                   "ios=f86885a7-2e89-46cb-bc33-2c77f94c7ead",
                   typeof(Analytics), typeof(Crashes));
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
