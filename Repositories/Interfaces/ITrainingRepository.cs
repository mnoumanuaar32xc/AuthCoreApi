using TraningWebApi.Model.Domain;

namespace TraningWebApi.Repositories.Interfaces
{
    public interface ITrainingRepository
    {
        Task<Training> CreateAsync(Training training);
        Task<IEnumerable<Training>> GetAsync();

        Task<Training> GetTrainingById(Guid id);
        Task<Training> UpdateAsync(Training training);
        Task<Training> DeleteAsync(Guid id);
    }
}
