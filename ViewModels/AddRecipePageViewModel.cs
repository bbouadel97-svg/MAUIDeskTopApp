using System;
using CommunityToolkit.Mvvm.ComponentModel;
using MauiDesktopApp.Models;
namespace MauiDesktopApp.ViewModels;
public class AddRecipePageViewModel: ObservableObject
    {
        public Recipe? NewRecipe { get; set; } = null;   
    }