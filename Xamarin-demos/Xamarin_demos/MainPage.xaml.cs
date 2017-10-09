using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_demos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            var TempListobj = new ObservableCollection<OrderType>();

            TempListobj.Add(new OrderType(){ImgTitle="dry_clean",ListTitle="Dry Clean", ListSubTitle="Starting 12$ per item"});
			TempListobj.Add(new OrderType() { ImgTitle = "shirt", ListTitle = "Wash and Fold", ListSubTitle = "Starting 3$ per lb" });

            foreach(var Item in TempListobj)
            {
                var listFrame = new CustomViews.ListBox();

                listFrame._Imgtitle.Source = Item.ImgTitle;
                listFrame._lblListTitle.Text = Item.ListTitle;
                listFrame._lblListSubTitle.Text = Item.ListSubTitle;

                ListStack.Children.Add(listFrame);
            }

		}
    }


    public class OrderType
    {
		public string ImgTitle { get; set; }
		public string ListTitle { get; set; }
		public string ListSubTitle { get; set; }
    }
}
