namespace BlazingPizza
{
    /// <summary>
    /// Represents a pre-configured template for a pizza a user can order
    /// </summary>
    public class PizzaSpecial
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal BasePrice { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

// This is a helper method to format the base price as a string with a dollar sign and commas
        public string GetFormattedBasePrice() => BasePrice.ToString("$#,##0", System.Globalization.CultureInfo.InvariantCulture);
    }
}
