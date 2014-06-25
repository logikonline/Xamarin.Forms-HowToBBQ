using Xamarin.Forms;

namespace HowToBBQXAMLSample.Views
{
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
                Padding = new Thickness(0, 0, 10, 0),
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
