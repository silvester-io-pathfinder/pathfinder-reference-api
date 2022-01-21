using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class FlexibleCatfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("86645939-97ac-4e12-86a2-190c5db49916");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Flexible Catfolk"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3efb603c-da53-4f6f-bf07-69ac7c8ecdc2"), Type = TextBlockType.Text, Text = "You've inherited flexibility beyond that of most humanoids. You don't treat tight spaces that don't require you to Squeeze as difficult terrain. In addition, you get a +1 circumstance bonus to checks when you attempt to Escape." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("cf8f914b-a30d-478c-aa4b-53c0c4125516"), "You don't treat tight spaces that don't require you to Squeeze as difficult terrain.");
            builder.GainSpecificActionCircumstanceBonus(Guid.Parse("17e322b2-fafb-477b-98f0-fcde49e16525"), Actions.Instances.Escape.ID, bonus: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8257626d-6636-4002-a7fe-a847d0889708"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 17
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Catfolk.ID;
        }
    }
}
