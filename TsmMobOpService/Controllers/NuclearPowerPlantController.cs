namespace TsmMobOpService.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    using TsmMobOpService.Models;

    /// <summary>
    /// Class NuclearPowerPlantController.
    /// </summary>
    public class NuclearPowerPlantController : ApiController
    {
        /// <summary>
        /// Demo data for the PointOfInterestController
        /// </summary>
        private readonly NuclearPowerPlant[] powerPlants = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NuclearPowerPlantController"/> class.
        /// </summary>
        public NuclearPowerPlantController()
        {
            // Nuclear Power Plants Coordinates
           this.powerPlants = new[]
                              {
                                  new NuclearPowerPlant(1, "Kernkraftwerk Beznau", string.Empty, 47.552222f, 8.227778f),
                                  new NuclearPowerPlant(2, "Kernkraftwerk Gösgen", string.Empty, 47.365833f, 7.968889f),
                                  new NuclearPowerPlant(3, "Kernkraftwerk Leibstadt", string.Empty, 47.60135f, 8.18375f),
                                  new NuclearPowerPlant(4, "Kernkraftwerk Mühleberg", string.Empty, 46.970833f, 7.270278f)
                              };
        }

        /// <summary>
        /// Gets all nuclear power plants.
        /// </summary>
        /// <returns>a list of nuclear power plants.</returns>
        [HttpGet]
        public IEnumerable<NuclearPowerPlant> GetAllNuclearPowerPlants()
        {
            return this.powerPlants;
        }

        /// <summary>
        /// Gets a single nuclear power plant by id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpGet]
        public IHttpActionResult GetNuclearPowerPlant(int id)
        {
            var powerPlant = this.powerPlants.FirstOrDefault(p => p.Id == id);
            if (powerPlant == null)
            {
                return this.NotFound();
            }

            return this.Ok(powerPlant);
        }

        /// <summary>
        /// Counts this instance.
        /// </summary>
        /// <returns>IHttpActionResult.</returns>
        [HttpGet]
        [Route("api/nuclearpowerplant/count")]
        public IHttpActionResult Count()
        {
            var numberOfRecords = this.powerPlants.Count();

            return this.Ok(numberOfRecords);
        }
    }
}
