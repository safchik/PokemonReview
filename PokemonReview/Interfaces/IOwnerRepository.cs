using PokemonReview.Models;

namespace PokemonReview.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();

        Owner GetOwner(int ownerId);
        ICollection<Owner> GetOwnerOfAPokemon(int pokeId);
        IObservable<Pokemon> GetPokemonByOwner(int ownerId);
        bool OwnerExists(int ownerId);
    }
}
