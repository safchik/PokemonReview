using PokemonReview.Models;

namespace PokemonReview.Interfaces
{
    public interface IreviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);

        ICollection<Review> GetReviewsOfAPokemon(int pokeId);
        bool ReviewExists(int reviewId);
    }
}
