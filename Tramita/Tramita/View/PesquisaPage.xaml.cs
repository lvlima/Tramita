﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tramita.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tramita.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PesquisaPage : ContentPage
	{
		public PesquisaPage ()
		{
			InitializeComponent();
            BindingContext = new PesquisaViewModel();

		}
	}
}