using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Druids
{
    public class LightningReflexes : Template
    {
        public static readonly Guid ID = Guid.Parse("84181b19-ce7a-4f07-9dd7-85b232bb1487");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Lightning Reflexes", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("186f0877-d306-4531-84e0-4ff9cdfbc219"), Type = TextBlockType.Text, Text = "Your reflexes are lightning fast. Your proficiency rank for Reflex saves increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("58889436-ad39-45ff-8eaa-a12de92822e2"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Reflex.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("15acd603-666f-473b-bf7b-bca08e89918a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 133
            };
        }
    }
}
