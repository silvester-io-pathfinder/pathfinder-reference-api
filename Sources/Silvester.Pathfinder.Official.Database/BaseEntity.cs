using System;

namespace Silvester.Pathfinder.Official.Database
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
    }
    
    public interface IOwnedEntity
    {
        //Marker pattern.
    }
}
