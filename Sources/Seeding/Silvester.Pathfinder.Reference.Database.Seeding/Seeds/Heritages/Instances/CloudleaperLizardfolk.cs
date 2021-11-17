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
    public class CloudleaperLizardfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("93026980-5965-48f2-9ff3-e862aa32a90c");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Cloudleaper Lizardfolk"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f27079b7-734d-4627-90d8-101af0149efd"), Type = TextBlockType.Text, Text = "Your body is light with flaps of skin along your limbs that catch the air that passes beneath you. As long as you can act and have enough room, you can open the flaps to slow any fall just enough to avoid taking damage (whether you have the room to do so depends on the GM's discretion)." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("8ccf05e9-9093-4b59-b4ad-59f896e141ca"), "As long as you can act and have enough room, you can open the flaps to slow any fall just enough to avoid taking damage (whether you have the room to do so depends on the GM's discretion).");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38128178-8f1f-438a-b2fd-2df4928b15dc"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 45
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Lizardfolk.ID;
        }
    }
}
