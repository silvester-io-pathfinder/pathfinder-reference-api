using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Planes
{
    public abstract class Template : EntityTemplate<Plane>
    {
        protected override Plane GetEntity(ModelBuilder builder)
        {
            Plane plane = GetPlane();

            foreach(Guid traitId in GetTraits())
            {
                builder.HasJoinData<Trait, Plane>((traitId, plane.Id));
            }

            builder.AddTextBlocks(plane, GetDetails(), (e) => e.Details);

            return plane;
        }

        protected abstract Plane GetPlane();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<TextBlock> GetDetails();
    }  
}
