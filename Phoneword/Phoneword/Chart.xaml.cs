﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Phoneword
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Chart : ContentPage
	{
		public Chart ()
		{
			InitializeComponent ();
		}

        async void OnCallBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}