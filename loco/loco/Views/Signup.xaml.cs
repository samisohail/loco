using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using loco.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace loco.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Signup : ContentPage
	{
		public Signup ()
		{
			InitializeComponent ();
		    var viewModel = new SignupViewModel(this) {Navigation = Navigation};
		    this.BindingContext = viewModel;
		}	    
	}
}