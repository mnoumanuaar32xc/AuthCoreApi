using Microsoft.EntityFrameworkCore;
using TraningWebApi.Data;
using TraningWebApi.Model.Domain;
using TraningWebApi.Repositories.Interfaces;

namespace TraningWebApi.Repositories.Implementations
{
    public class TrainingRepository : ITrainingRepository
    {
        private readonly ApplicationDbContext dbContext;

        public TrainingRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Training> CreateAsync(Training training)
        {
            await dbContext.Training.AddAsync(training);
            await dbContext.SaveChangesAsync();
            return training;
        }

        public async Task<Training> DeleteAsync(Guid id)
        {
            var existinTraining = await dbContext.Training.FirstOrDefaultAsync(x => x.ID == id);
            if (existinTraining != null)
            {
                dbContext.Training.Remove(existinTraining);
                await dbContext.SaveChangesAsync();
                return existinTraining;

            }
            return null;

        }

        public async Task<IEnumerable<Training>> GetAsync()
        {
            return await dbContext.Training.ToListAsync();
        }

        public async Task<Training?> GetTrainingById(Guid id)
        {
            return await dbContext.Training.FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<Training> UpdateAsync(Training training)
        {
            var existingTraining = await dbContext.Training.FirstOrDefaultAsync(x => x.ID == training.ID);
            if (existingTraining is not null)
            {
                dbContext.Entry(existingTraining).CurrentValues.SetValues(training);
                await dbContext.SaveChangesAsync();
                return training;
            }
            return null;
        }
    }
}
