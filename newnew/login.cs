using System;

using Xamarin.Forms;

namespace newnew
{
    public class login : ContentPage
    {
        public login()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

