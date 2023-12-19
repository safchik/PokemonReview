﻿namespace PokemonReview.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Power { get; set; }
        public DateTime BirthDate { get; set; }


        public ICollection<Review> Reviews { get; set; }
    }
}
