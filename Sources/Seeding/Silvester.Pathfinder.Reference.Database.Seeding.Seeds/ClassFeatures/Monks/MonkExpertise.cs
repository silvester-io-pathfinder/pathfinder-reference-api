using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class MonkExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("c58b2fb6-4a71-457a-b60c-d338916af2c1");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 9,
                Name = "Monk Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("134dde30-5f2f-4641-8a6c-5ffa6a2fb678"), Type = TextBlockType.Text, Text = "Your proficiency rank for your monk class DC increases to expert. If you have ki spells, your proficiency rank for spell attacks and spell DCs with the tradition of magic you use for your ki spells increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificClassDcProficiency(Guid.Parse("ccc8f297-d9ad-4050-b0f2-fb490c957b9c"), Proficiencies.Instances.Expert.ID);
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("ab07dc67-23d3-4e34-92db-e0e80531828b"), Proficiencies.Instances.Expert.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("32232a51-3ffb-4a60-a8a5-77490c6dfd7d"), Proficiencies.Instances.Expert.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2e2faf40-b21e-4376-aa9e-8d45740405ae"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 157
            };
        }
    }
}
