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
        public static readonly Guid ID = Guid.Parse("2229fa5c-1f5e-4d6c-8d85-9d7cdcd2b707");

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
            yield return new TextBlock { Id = Guid.Parse("18f69784-9d6f-43fe-96ae-bcd6f8d54880"), Type = TextBlockType.Text, Text = "You effortlessly float on the surface of water. You can walk on the surface of still water and other non-damaging liquids, moving at half your normal Speed. You can attempt to walk along the surface of flowing water as well, still moving at half Speed, but doing so requires a successful Acrobatics check to Balance using the DC of a Swim check to move through the water; on a failure, you fall into the water. This Acrobatics check doesn't use an action." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("da174376-1839-4e41-a94e-0fa78355297e"), "You effortlessly float on the surface of water.");
            builder.Manual(Guid.Parse("7ad1cd9d-7391-4e62-a3ce-1fa50305da0e"), "You can walk on the surface of still water and other non-damaging liquids, moving at half your normal Speed. You can attempt to walk along the surface of flowing water as well, still moving at half Speed, but doing so requires a successful Acrobatics check to Balance using the DC of a Swim check to move through the water; on a failure, you fall into the water. This Acrobatics check doesn't use an action.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("943f55db-6b5d-4d56-8aac-d6df3f6621cd"),
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
