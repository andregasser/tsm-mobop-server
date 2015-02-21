using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TsmMobOpService.Controllers
{
    using TsmMobOpService.Models;

    public class PointOfInterestController : ApiController
    {
        /// <summary>
        /// Demo data for the PointOfInterestController
        /// </summary>
        private readonly PointOfInterest[] pointsOfInterest = new PointOfInterest[]
                                                         {
                                                             new PointOfInterest(
                                                                 1,
                                                                 "Kernkraftwerk Mühleberg",
                                                                 "Achtung, is gefährlich",
                                                                 5),
                                                             new PointOfInterest(
                                                                 2,
                                                                 "Tobi's Home",
                                                                 "Where Tobi lives",
                                                                 17),
                                                             new PointOfInterest(
                                                                 3,
                                                                 "Attila's Home",
                                                                 "Where Attila lives",
                                                                 28),
                                                             new PointOfInterest(
                                                                 4,
                                                                 "André's Home",
                                                                 "Nothing to see here",
                                                                 31),
                                                             new PointOfInterest(
                                                                 5,
                                                                 "Flughafen Zürich",
                                                                 "Sehr laut hier",
                                                                 32)
                                                         };

        [HttpGet]
        public IEnumerable<PointOfInterest> GetAllPointsOfInterest()
        {
            return pointsOfInterest;
        }

        [HttpGet]
        public IHttpActionResult GetPointOfInterest(int id)
        {
            var pointOfInterest = this.pointsOfInterest.FirstOrDefault(p => p.Id == id);
            if (pointOfInterest == null)
            {
                return this.NotFound();
            }
            
            return this.Ok(pointOfInterest);
        }
    }
}
