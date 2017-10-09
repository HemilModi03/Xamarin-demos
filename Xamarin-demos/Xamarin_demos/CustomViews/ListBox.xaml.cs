using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Xamarin_demos.CustomViews
{
    public partial class ListBox : ContentView
    {
        public ListBox()
        {
            InitializeComponent();
        }

        public Image _Imgtitle
		{
            get { return this.ImgTitle; }
			set { _Imgtitle = value; }
		}

        public Label _lblListTitle
		{
            get { return this.lblListTitle; }
			set { _lblListTitle = value; }
		}

		public Label _lblListSubTitle
		{
            get { return this.lblListSubTitle; }
			set { lblListSubTitle = value; }
		}

	}
}
