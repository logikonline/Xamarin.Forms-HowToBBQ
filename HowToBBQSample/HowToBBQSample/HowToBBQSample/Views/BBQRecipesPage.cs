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
            Label title = null;
            if (Device.OS == TargetPlatform.WinPhone)
            {
                title = new Label
                {
                    Text = "BBQ Recipes",
                    Font = Font.SystemFontOfSize(42)
                };
            }

            var list = new ListView();
            var viewModel = new BBQRecipesViewModel();
            list.ItemsSource = viewModel.Recipes;

            var cell = new DataTemplate(typeof(AspectImageCell));

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

            var stackPanel = new StackLayout();

            stackPanel.Padding = new Thickness(20, 0, 0, 0);

            stackPanel.Children.Insert(1, list);

            stackPanel.Children.Insert(0, title);
                        
            Content = stackPanel;

            
        }
    }

    public class AspectImageCell : ViewCell
    {
        public AspectImageCell()
        {
            var label = new Label
            {
                YAlign = TextAlignment.Center,
                Font = Font.SystemFontOfSize(15)
            };

            label.SetBinding(Label.TextProperty, "Name");

            var foodImage = new Image
            {
                WidthRequest = 40,
                HeightRequest = 60
            };
            foodImage.SetBinding(Image.SourceProperty, "Image");
 
            var layout = new StackLayout
            {
                Padding = new Thickness(0,0,10,0),
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Children = { foodImage, label }
            };

            View = layout;
        }

        protected override void OnBindingContextChanged()
        {
            // Fixme : this is happening because the View.Parent is getting 
            // set after the Cell gets the binding context set on it. Then it is inheriting
            // the parents binding context.
            View.BindingContext = BindingContext;
            base.OnBindingContextChanged();
        }
    }
}
