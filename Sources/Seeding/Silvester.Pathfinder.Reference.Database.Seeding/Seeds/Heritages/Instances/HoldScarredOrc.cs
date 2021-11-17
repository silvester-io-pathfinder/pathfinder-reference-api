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
    public class HoldScarredOrc : Template
    {
        public static readonly Guid ID = Guid.Parse("aabb3152-aa04-4a6f-8fbd-e01723217a5f");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Hold-Scarred Orc"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("710bc88a-a29a-46e0-b274-be7975e9d810"), Type = TextBlockType.Text, Text = "You are part of an orc community that participates in ritual scarification or tattooing. The marks on your skin show your exceptional hardiness and vitality. You gain 12 Hit Points from your ancestry instead of 10. You also gain the Diehard feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyAncestryHitpoints(Guid.Parse("51c945fe-d11d-4771-a5f1-0afa2aa90218"), ModifierType.Add, modifier: 2);
            builder.GainSpecificFeat(Guid.Parse("7f3a0ecc-8e7c-4f96-93f5-66fae832b7f7"), Feats.Instances.Diehard.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a34a4a55-a570-4c15-a3df-440f34bc6f06"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 18
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Orc.ID;
        }
    }
}
