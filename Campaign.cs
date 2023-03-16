using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace ef_issue
{
    public class Campaign 
    {
        // private const int _SRID = 4326;
        // private static readonly PrecisionModel _precisionModel = new PrecisionModel(PrecisionModels.Floating);
        // private static readonly GeometryFactory _geometryFactory = new GeometryFactory(_precisionModel, _SRID);
        
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName = "geometry (point)")]
        public Point Location { get; set; }
    }
}
