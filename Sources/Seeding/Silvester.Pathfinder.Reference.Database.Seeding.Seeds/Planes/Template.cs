using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Planes
{
    public abstract class Template : EntityTemplate<Plane>
    {
        protected override Plane GetEntity(ISeedBuilder builder)
        {
            Plane plane = GetPlane();

            builder.AddTraits(plane, GetTraits());
            builder.AddTextBlocks(plane, GetDetails(), (e) => e.Details);

            return plane;
        }

        protected abstract Plane GetPlane();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<TextBlock> GetDetails();
    }  
}
