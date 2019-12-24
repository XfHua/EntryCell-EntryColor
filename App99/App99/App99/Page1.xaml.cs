using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App99
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            TableView tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot
                {
                    new TableSection
                    {
                        new MyEntryCell
                        {
                            Label = "EntryCell:",
                            Placeholder = "Type Text Here",
                            LabelColor = Color.Red,
                           
                        }
                    }
                }
            };

            this.Content = new StackLayout
            {
                Children =
                {
                    tableView
                }
            };
        }
    }

    public class MyEntryCell : EntryCell { 
        
    }
}