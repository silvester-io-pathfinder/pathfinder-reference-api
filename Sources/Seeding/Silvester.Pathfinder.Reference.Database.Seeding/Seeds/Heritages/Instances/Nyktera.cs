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
    public class Nyktera : Template
    {
        public static readonly Guid ID = Guid.Parse("380fd677-cdbe-4f77-bf30-30993ecb6c81");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Nyktera"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ee9dd802-abc2-495e-811d-f84dbeb67299"), Type = TextBlockType.Text, Text = "You have batlike features, an affinity for batkind, and hearing that is second to none. As long as you can hear normally, you can use the Seek action to sense undetected creatures in a 60-foot cone instead of a 30-foot cone. You also gain a +2 circumstance bonus to locate undetected creatures that you could hear within 30 feet with a Seek action." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("77697d6d-c377-4a11-a7ea-1023e189e0d5"), "As long as you can hear normally, you can use the Seek action to sense undetected creatures in a 60-foot cone instead of a 30-foot cone.");
            builder.GainSpecificActionCircumstanceBonus(Guid.Parse("eccf105c-61ce-4e5a-96a3-34b2e8b86527"), Actions.Instances.Seek.ID, bonus: 2, addendum: "Only applies to creatures that you could potentially hear.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d1bc16d-b2ff-40a5-90f7-088b9fe203a5"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 129
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Sprite.ID;
        }
    }
}
