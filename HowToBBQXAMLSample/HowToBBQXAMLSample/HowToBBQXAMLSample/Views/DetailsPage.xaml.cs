using HowToBBQXAMLSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToBBQXAMLSample.Views
{
    public partial class DetailsPage
    {
        public DetailsPage(BBQRecipe recipe)
        {
            InitializeComponent();
            this.BindingContext = recipe;
        }
    }
}
