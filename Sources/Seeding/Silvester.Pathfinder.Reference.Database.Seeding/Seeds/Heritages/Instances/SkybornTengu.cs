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
    public class SkybornTengu : Template
    {
        public static readonly Guid ID = Guid.Parse("aeb89419-b060-483a-a8ee-3dec1a429cec");

        protected override Heritage GetHeritage()
        {
           return new Heritage 
           {
               Id = ID, 
               RarityId = Rarities.Instances.Common.ID, 
               Name = "Skyborn Tengu"
           };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("06fd7a61-8a90-4aed-8ab8-3573def7cb2e"), Type = TextBlockType.Text, Text = "Your bones may be especially light, you may be a rare tengu with wings, or your connection to the spirits of wind and sky might be stronger than most, slowing your descent through the air. You take no damage from falling, regardless of the distance you fall." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyFallDistance(Guid.Parse("880a73a9-09c5-4203-b26e-d808d8498ec8"), ModifierType.Multiply, modifier: 0);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e4f6cbea-fb65-4ff7-8509-a2cbd7c6ce2d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 26
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Tengu.ID;
        }
    }
}
