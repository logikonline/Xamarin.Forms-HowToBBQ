using Xamarin.Forms;

namespace HowToBBQXAMLSample.Views
{
    public class AspectImageCell : ViewCell
    {

        public static readonly BindableProperty NameProperty =
            BindableProperty.Create<AspectImageCell, string>(
                p => p.Name, string.Empty);


        public static readonly BindableProperty ImageSourceProperty =
        BindableProperty.Create<AspectImageCell, string>(
        p => p.ImageSource, string.Empty);

        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set
            {
                SetValue(NameProperty, value);

            }
        }

        public string ImageSource
        {
            get { return (string)GetValue(ImageSourceProperty); }
            set
            {
                SetValue(ImageSourceProperty, value);

            }
        }

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

            foodImage.SetBinding(Image.SourceProperty, "ImageSource");


            var layout = new StackLayout
            {
                Padding = new Thickness(0, 0, 10, 0),
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Children = { foodImage, label }
            };

            View = layout;
        }
    }

}
