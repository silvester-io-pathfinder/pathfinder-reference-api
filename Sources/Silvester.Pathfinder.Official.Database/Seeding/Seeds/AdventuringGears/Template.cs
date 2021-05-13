using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears
{
    public abstract class Template : EntityTemplate<AdventuringGear>
    {
        protected override AdventuringGear GetEntity(ModelBuilder builder)
        {
            AdventuringGear gear = GetAdventuringGear();

            SourcePage sourcePage = GetSourcePage();
            gear.SourcePageId = sourcePage.Id;
            builder.AddData(sourcePage);

            foreach(AdventuringGearVariant variant in GetVariants())
            {
                variant.AdventuringGearId = gear.Id;
                builder.AddData(variant);
            }

            builder.AddTextBlocks(gear, GetDetails(), e => e.Details);

            return gear;
        }

        protected abstract AdventuringGear GetAdventuringGear();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<TextBlock> GetDetails();

        ///<summary>Override in subclasses to specify other variants of the same type.</summary>
        protected virtual IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield break;
        }
    }
}
