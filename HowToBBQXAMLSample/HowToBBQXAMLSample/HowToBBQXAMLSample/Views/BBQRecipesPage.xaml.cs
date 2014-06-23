using HowToBBQXAMLSample.Models;
using HowToBBQXAMLSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HowToBBQXAMLSample.Views
{
    public partial class BBQRecipesPage
    {
        public BBQRecipesPage()
        {
            InitializeComponent();

            this.BindingContext = new BBQRecipesViewModel();
        }

        public void OnItemSelected(object sender, ItemTappedEventArgs args)
        {
            var recipe = args.Item as BBQRecipe;
            if (recipe == null)
                return;

            Navigation.PushAsync(new DetailsPage(recipe));
            // Reset the selected item
            list.SelectedItem = null;
        }
    }
}
