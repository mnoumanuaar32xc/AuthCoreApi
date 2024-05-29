using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TraningWebApi.Model.Domain;
using TraningWebApi.Model.DTO;
using TraningWebApi.Repositories.Interfaces;

namespace TraningWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingRepository trainingRepository;
        public TrainingController(ITrainingRepository trainingRepository)
        {
            this.trainingRepository = trainingRepository;

        }


        [HttpPost]
        public async Task<IActionResult> CreateTraining([FromBody] CreateTrainingRequestDto request)
        {
            // Map DTO to Domain Model
            var traning = new Training
            {

                Name = request.Name,
                Lavel = request.Lavel
            };


            await trainingRepository.CreateAsync(traning);
            // domain model to DTO 
            var respons = new TrainingDto
            {
                ID = traning.ID,
                Name = request.Name,
                Lavel = request.Lavel
            };

            return Ok(respons);
        }

        [HttpGet]
        [Authorize]
        public async Task<List<TrainingDto>> GettAllTrainings()
        {
            var trainingList = await trainingRepository.GetAsync();
            // map Domain Model with DTO

            var response = new List<TrainingDto>();

            foreach (var item in trainingList)
            {

                response.Add(new TrainingDto { ID = item.ID, Name = item.Name, Lavel = item.Lavel });
            }
            return response;
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<Training> GetTrainingById([FromRoute] Guid id)
        {
            var training = await trainingRepository.GetTrainingById(id);
            return training;
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> EditTraining([FromRoute] Guid id, [FromBody] CreateTrainingRequestDto request)
        {
            // Map DTO to Domain Model
            var traning = new Training
            {
                ID = id,
                Name = request.Name,
                Lavel = request.Lavel
            };


            await trainingRepository.UpdateAsync(traning);
            // domain model to DTO 
            var respons = new TrainingDto
            {
                ID = traning.ID,
                Name = request.Name,
                Lavel = request.Lavel
            };

            return Ok(respons);
        }

        [HttpDelete]
        [Route("id: Guid")]
        public async Task<IActionResult> DeleteTraining([FromRoute] Guid id)
        {
            var trainig = await trainingRepository.DeleteAsync(id);
            if (trainig is null)
            {
                return NotFound();
            }
            // convert Domain to DTO 
            var response = new Training
            {
                ID = trainig.ID,
                Name = trainig.Name,
                Lavel = trainig.Lavel
            };

            return Ok(response);
        }
    }
}
