﻿using AULA1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AULA1.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}