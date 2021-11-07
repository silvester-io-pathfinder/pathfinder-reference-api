using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class LotusLeshy : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Lotus Leshy"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You effortlessly float on the surface of water. You can walk on the surface of still water and other non-damaging liquids, moving at half your normal Speed. You can attempt to walk along the surface of flowing water as well, still moving at half Speed, but doing so requires a successful Acrobatics check to Balance using the DC of a Swim check to move through the water; on a failure, you fall into the water. This Acrobatics check doesn't use an action." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse(""), "You effortlessly float on the surface of water.");
            builder.Manual(Guid.Parse(""), "You can walk on the surface of still water and other non-damaging liquids, moving at half your normal Speed. You can attempt to walk along the surface of flowing water as well, still moving at half Speed, but doing so requires a successful Acrobatics check to Balance using the DC of a Swim check to move through the water; on a failure, you fall into the water. This Acrobatics check doesn't use an action.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 42
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Leshy.ID;
        }
    }
}
