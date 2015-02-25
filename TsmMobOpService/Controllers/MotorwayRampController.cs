namespace TsmMobOpService.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    using TsmMobOpService.Models;

    /// <summary>
    /// Class MotorwayController.
    /// </summary>
    public class MotorwayRampController : ApiController
    {
        /// <summary>
        /// Demo data for the MotorwayRampController
        /// </summary>
        private readonly MotorwayRamp[] motorwayRamps = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MotorwayRampController"/> class.
        /// </summary>
        public MotorwayRampController()
        {
            // Motorway Ramps Coordinates
            this.motorwayRamps = new[]
            {
                new MotorwayRamp(1, "Oftringen", "A1", 47.306524f, 7.929096f),
                new MotorwayRamp(2, "Aarau-Ost", "A1", 47.391583f, 8.131814f),
                new MotorwayRamp(3, "Ramp 4", "A53", 47.380942f, 8.685205f),
                new MotorwayRamp(4, "Ramp 5", "A53", 47.368896f, 8.712038f),
                new MotorwayRamp(5, "Kleinandelfingen", "A4", 47.602679f, 8.690625f),
                new MotorwayRamp(6, "Hergiswil", "A2", 46.999111f, 8.311361f),
                new MotorwayRamp(7, "Luzern-Horw", "A2", 47.018377f, 8.296849f),
                new MotorwayRamp(8, "Luzern-Kriens", "A2", 47.036418f, 8.295487f),
            };
        }

        /// <summary>
        /// Gets all motorway ramps.
        /// </summary>
        /// <returns>a list of motorway ramps.</returns>
        [HttpGet]
        public IEnumerable<MotorwayRamp> GetAllMotorwayRamps()
        {
            return this.motorwayRamps;
        }

        /// <summary>
        /// Gets a single motorway ramp by id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpGet]
        public IHttpActionResult GetMotorwayRamp(int id)
        {
            var powerPlant = this.motorwayRamps.FirstOrDefault(p => p.Id == id);
            if (powerPlant == null)
            {
                return this.NotFound();
            }

            return this.Ok(powerPlant);
        }
    }
}
