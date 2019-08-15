using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntecPrac1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            picLog.Source = ImageSource.FromResource("IntecPrac1.logoIntec.jpg");
        }

        public async void OnValidate(object sender, EventArgs e)
        {
            bool isEmail = !string.IsNullOrEmpty(txtEmail.Text) && Regex.IsMatch(txtEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            bool isPassword = !string.IsNullOrEmpty(txtPassword.Text);


            if (isEmail && isPassword)
                await DisplayAlert("Alert", $"Hola {txtEmail.Text.Substring(0, txtEmail.Text.IndexOf('@'))}", "Ok");
            else if (!isEmail)
                await DisplayAlert("Alert", $"Campo email invalido", "Ok");
            else if (!isPassword)
                await DisplayAlert("Alert", $"Password no puede estar vacio", "Ok");



        }
    }
}