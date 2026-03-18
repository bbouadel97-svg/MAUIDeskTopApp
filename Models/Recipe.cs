namespace MauiDesktopApp.Models;

public class Recipe
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int PreparationDuration { get; set; }
        public required Ingredients Ingredients { get; set; }
        public required string Instructions { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }

    }

public class Ingredients
{
    public List<string> Items { get; set; } = new();

    public override string ToString()
    {
        return Items.Count > 0 ? string.Join(", ", Items) : "No ingredients";
    }
}