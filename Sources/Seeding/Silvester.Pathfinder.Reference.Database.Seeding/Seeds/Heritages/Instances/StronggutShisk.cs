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
    public class StronggutShisk : Template
    {
        public static readonly Guid ID = Guid.Parse("1ec3f0fb-4545-4618-ab33-23d588fd661a");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Stronggut Shisk"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2fc8eefe-5917-4420-9071-06e55102d157"), Type = TextBlockType.Text, Text = "Your metabolism is slow, allowing you to go for days without food and process maladies at a slower rate. You can go for 1 week without food before you begin to starve. Additionally, the onset times and lengths of stages for all diseases and poisons that affect you are increased by 50%. If the onset time or stage is instant or lasts only 1 round, this ability has no effect." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("3e813ea6-cdc5-4ee7-bb34-b3504d27a6c1"), "You can go for 1 week without food before you begin to starve.");
            builder.Manual(Guid.Parse("897294a9-935c-4dc1-8967-44494be0ea97"), "Additionally, the onset times and lengths of stages for all diseases and poisons that affect you are increased by 50%. If the onset time or stage is instant or lasts only 1 round, this ability has no effect.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("75eacd65-ebf3-489a-ab7a-d28d2b285691"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 123
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Shisk.ID;
        }
    }
}
