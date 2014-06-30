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
            Label title = new Label();
            var stackPanel = new StackLayout();
            stackPanel.VerticalOptions = LayoutOptions.FillAndExpand;

            if (Device.OS == TargetPlatform.WinPhone)
            {

                title.Text = recipe.Name;
                title.XAlign = TextAlignment.Start;
                title.Font = Font.SystemFontOfSize(32);

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
                Source = recipe.Image
            };


            var listview = new ScrollView
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    Children = { prepTime, totalTime, serves, ingredients, directions }
                }
            };

            if (Device.OS == TargetPlatform.WinPhone)
            {
                listview.Padding = 20;
            }

            stackPanel.Children.Insert(0, title);
            stackPanel.Children.Insert(1, image);
            stackPanel.Children.Insert(2, listview);

            stackPanel.Padding = new Thickness(20, 0, 0, 0);

            Content = stackPanel;
        }
    }
}
