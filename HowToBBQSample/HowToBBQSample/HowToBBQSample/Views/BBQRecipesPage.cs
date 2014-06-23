using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using HowToBBQSample.Models;
using HowToBBQSample.ViewModels;


namespace HowToBBQSample.Views
{
    public class BBQRecipesPage : ContentPage
    {
        public BBQRecipesPage()
        {
            Title = "BBQ Recipes";

            var list = new ListView();
            var viewModel = new BBQRecipesViewModel();
            list.ItemsSource = viewModel.Recipes;

            var cell = new DataTemplate(typeof(AspectImageCell));

            cell.SetBinding(TextCell.TextProperty, "Name");
            cell.SetBinding(TextCell.DetailProperty, "ShortDesc");
            cell.SetBinding(ImageCell.ImageSourceProperty, "Image");

            list.ItemTemplate = cell;

            list.ItemTapped += (sender, args) =>
            {
                var recipe = args.Item as BBQRecipe;
                if (recipe == null)
                    return;

                Navigation.PushAsync(new DetailsPage(recipe));
                // Reset the selected item
                list.SelectedItem = null;
            };

            Content = list;
        }
    }

    public class AspectImageCell : ImageCell
    {
    }
}
