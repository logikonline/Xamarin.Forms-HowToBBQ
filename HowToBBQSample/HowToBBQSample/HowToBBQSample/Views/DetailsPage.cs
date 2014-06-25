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
                    XAlign = TextAlignment.Start,
                    Font = Font.SystemFontOfSize(32)
                };
            }

            var stackPanel = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { title }
            };

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


            var listview = new ScrollView
            {
                Padding = 20,
                Content = new StackLayout
                {
                    Spacing = 10,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    Children = {prepTime, totalTime, serves, ingredients, directions}
                }
            };

            stackPanel.Children.Insert(2, listview);

            stackPanel.Children.Insert(1, image);

            if (Device.OS == TargetPlatform.WinPhone)
            {
                stackPanel.Children.Insert(0, title);
            }

            stackPanel.Padding =  new Thickness(20, 0, 0, 0);

            Content = stackPanel;
        }
    }
}
