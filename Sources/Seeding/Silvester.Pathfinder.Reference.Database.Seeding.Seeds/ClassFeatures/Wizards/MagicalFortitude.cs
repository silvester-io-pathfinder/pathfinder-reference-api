using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Wizards
{
    public class MagicalFortitude : Template
    {
        public static readonly Guid ID = Guid.Parse("375be07b-2d1a-4dd1-974a-fa9ce7b142ab");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 9,
                Name = "Magical Fortitude", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("25cd391d-bd4f-446f-be22-49107cda9f34"), Type = TextBlockType.Text, Text = "Magical power has improved your body's resiliency. Your proficiency rank for Fortitude saves increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("9602d5bb-ba14-4a1c-84bc-876da43680c1"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Fortitude.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c1be03f7-bf09-4033-8b6b-bd4a17f444c5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 207
            };
        }
    }
}
