using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pantry
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAddItem(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.AddItemPage());
        }

        private void OnRemoveItem(object sender, EventArgs e)
        {
            
        }

        private void OnScanItem(object sender, EventArgs e)
        {

        }
    }
}
