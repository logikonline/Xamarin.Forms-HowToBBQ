using HowToBBQXAMLSample.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace HowToBBQXAMLSample
{
    public class App
    {
        public static Page GetMainPage()
        {
             var recipes = new BBQRecipesPage();
             return new NavigationPage(recipes);

        }
    }
}
