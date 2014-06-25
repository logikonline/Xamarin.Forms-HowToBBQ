using HowToBBQSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HowToBBQSample.Views
{
    public class DetailsPage : ContentPage
    {
        public DetailsPage(BBQRecipe recipe)
        {
            this.Title = recipe.Name;
            Label title = null;
            if (Device.OS == TargetPlatform.WinPhone)
            {
                title = new Label
                {
                    Text = recipe.Name,
                    XAlign = TextAlignment.Center,
                    Font = Font.SystemFontOfSize(32)
                };
            }

            var prepTime = new Label
            {
                Text = string.Concat("PrepTime: ", recipe.PrepTime)
            };

            var totalTime = new Label
            {
                Text = string.Concat("TotalTime: ", recipe.TotalTime)
            };

            var serves = new Label
            {
                Text = string.Concat("Serves: ", recipe.TotalTime)
            };

            var ingredients = new Label
            {
                Text = recipe.Ingredients
            };

            var directions = new Label
            {
                Text = recipe.Directions
            };

            var image = new Image
            {
                Source = recipe.Image,
                Aspect = Aspect.AspectFit,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            Content = new ScrollView
            {
                Padding = 20,
                Content = new StackLayout
                {
                    Spacing = 10,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    Children = {image, prepTime, totalTime, serves, ingredients, directions}
                }
            };
        }
    }
}
