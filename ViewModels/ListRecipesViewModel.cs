using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiDesktopApp.Models;
using MauiDesktopApp.Services;

namespace MauiDesktopApp.ViewModels;

public partial class ListRecipesViewModel : ObservableObject
{
    public ObservableCollection<Recipe> Recipes { get; set; }
    private readonly RecipeStore _recipeStore;

    public ListRecipesViewModel(RecipeStore recipeStore)
    {
        _recipeStore = recipeStore;
        Recipes = _recipeStore.Recipes;

        if (Recipes.Count > 0)
        {
            return;
        }

        Recipes = new ObservableCollection<Recipe>
        {
            new Recipe
            {
                Id = 1,
                Name = "Spaghetti Bolognese",
                PreparationDuration = 30,
                Ingredients = new Ingredients { Items = new List<string> { "Spaghetti", "Ground Beef", "Tomato Sauce", "Onion", "Garlic" } },
                Instructions = "Cook spaghetti. Brown ground beef with onion and garlic. Add tomato sauce and simmer. Serve over spaghetti.",
                CreationDate = DateTime.Now.AddDays(-10),
                ModificationDate = DateTime.Now.AddDays(-5)
            },
            new Recipe
            {
                Id = 2,
                Name = "Chicken Curry",
                PreparationDuration = 45,
                Ingredients = new Ingredients { Items = new List<string> { "Chicken", "Curry Powder", "Coconut Milk", "Onion", "Garlic" } },
                Instructions = "Sauté chicken with onion and garlic. Add curry powder and coconut milk. Simmer until chicken is cooked through.",
                CreationDate = DateTime.Now.AddDays(-8),
                ModificationDate = DateTime.Now.AddDays(-3)
            }
        };

        foreach (var recipe in Recipes)
        {
            _recipeStore.Recipes.Add(recipe);
        }

        Recipes = _recipeStore.Recipes;
    }

    [RelayCommand]
    private async Task AddNewRecipe()
    {
        await Shell.Current.GoToAsync(nameof(Views.AddRecipePage));
    }
}