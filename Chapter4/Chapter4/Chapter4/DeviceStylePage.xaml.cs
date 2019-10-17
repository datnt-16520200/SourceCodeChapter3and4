using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter4
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DeviceStylePage : ContentPage
	{
		public DeviceStylePage ()
		{
			InitializeComponent ();
		}
	}
}