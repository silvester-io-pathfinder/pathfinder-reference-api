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
    public class TechnologicalFleshwarp : Template
    {
        public static readonly Guid ID = Guid.Parse("f91b3983-66a8-43b8-80d1-919b130abd3e");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Technological Fleshwarp"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d15b8441-0efc-4d18-af63-cfa714cb60e7"), Type = TextBlockType.Text, Text = "Your transformation is due to manipulation by advanced technology, like that found in Numeria. Your emotions are dulled and hard to influence. When you roll a success on a saving throw against an emotion effect, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ImproveSpecificTraitAnySavingThrow(Guid.Parse("2317dff8-1255-4a6d-bcc0-a37c3be579da"), Traits.Instances.Emotion.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fddc6abf-19dd-4c67-8ea2-aeb425e643cf"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 91
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Fleshwarp.ID;
        }
    }
}
