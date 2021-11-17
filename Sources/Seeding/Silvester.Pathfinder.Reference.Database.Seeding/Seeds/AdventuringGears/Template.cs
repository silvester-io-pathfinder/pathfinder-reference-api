using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears
{
    public abstract class Template : EntityTemplate<AdventuringGear>
    {
        protected override AdventuringGear GetEntity(ISeedBuilder builder)
        {
            AdventuringGear gear = GetAdventuringGear();

            foreach(AdventuringGearVariant variant in GetVariants())
            {
                variant.AdventuringGearId = gear.Id;
                builder.AddData(variant);
            }

            builder.AddSourcePage(gear, GetSourcePage(), e => e.SourcePageId);
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
