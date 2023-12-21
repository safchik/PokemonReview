using AutoMapper;
using PokemonReview.Data;
using PokemonReview.Interfaces;
using PokemonReview.Models;

namespace PokemonReview.Repository
{
    public class ReviewRepository : IreviewRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ReviewRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        Review IreviewRepository.GetReview(int reviewId)
        {
            return _context.Reviews.Where(r => r.Id == reviewId).FirstOrDefault();
        }

        ICollection<Review> IreviewRepository.GetReviews()
        {
            return _context.Reviews.ToList();
        }

        ICollection<Review> IreviewRepository.GetReviewsOfAPokemon(int pokeId)
        {
            return _context.Reviews.Where(r => r.Pokemon.Id == pokeId).ToList();
        }

        bool IreviewRepository.ReviewExists(int reviewId)
        {
            return _context.Reviews.Any(r  => r.Id == reviewId);
        }
    }
}
