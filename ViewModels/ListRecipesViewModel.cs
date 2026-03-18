using System.Collections.Immutable;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using MauiDesktopApp.Models;

namespace MauiDesktopApp.ViewModels;

public partial class ListRecipesViewModel : ObservableObject
{
    public ObservableCollection<Recipe> Recipes { get; set; }

    public ListRecipesViewModel()
    {
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
    }
}