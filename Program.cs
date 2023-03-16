using System;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace ef_issue;
class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        using var db = new DataContext();

        var geometryFactory = GeometryFactory.Default.WithSRID(4326);
        var latitude = 0.0;
        var longitude = 0.0;
        
        var centerPoint = geometryFactory.CreatePoint(new Coordinate(longitude, latitude));

        
        // nearest neighbor query
        var campaigns = await db.Campaigns
            .AsNoTracking()
            .OrderBy(x => EF.Functions.DistanceKnn(x.Location, centerPoint))
            .ToListAsync();
    }
}
