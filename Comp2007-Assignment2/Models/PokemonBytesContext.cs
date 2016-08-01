namespace Comp2007_Assignment2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PokemonBytesContext : DbContext
    {
        public PokemonBytesContext()
            : base("name=PokemonBytesConnection")
        {
        }

        public virtual DbSet<Dish> Dish { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Pokemon> Pokemons { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
    }
}
