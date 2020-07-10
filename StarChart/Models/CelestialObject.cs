using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StarChart.Models
{
    //TODO 02.01 : create CelestialOnject Model
    public class CelestialObject
    {
        //TODO 02.02 : add Properties
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public int? OrbitedObjectId { get; set; }

        [NotMapped]
        public List<CelestialObject> Satellites { get; set; }

        public TimeSpan OrbitalPeriod { get; set; }
    }
}
