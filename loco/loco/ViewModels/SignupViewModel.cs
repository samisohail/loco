using loco.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using loco.Validators;
using loco.Views;
using Xamarin.Forms;

namespace loco.ViewModels
{
    public class SignupViewModel
    {
        public SignupModel SignupModel { get; set; } = new SignupModel();

        public ICommand SignupCommand { get; }

        private Page _page;

        public INavigation Navigation { get; set; }

        public SignupViewModel(Page page)
        {
            _page = page;
            SignupCommand = new Command(async () => await SignupAsync());
        }

        private async Task SignupAsync()
        {
            //if (!ValidationHelper.IsFormValid(SignupModel, _page)) { return; }
            // await _page.DisplayAlert("Success", "Validation Success!", "OK");
            await Navigation.PushAsync(new MainPage());
        }
    }
}
