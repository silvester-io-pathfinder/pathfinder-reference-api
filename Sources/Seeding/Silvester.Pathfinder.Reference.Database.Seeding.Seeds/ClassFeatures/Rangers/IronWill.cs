using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rangers
{
    public class IronWill : Template
    {
        public static readonly Guid ID = Guid.Parse("0b07d35d-8e4b-4942-8554-19e672ee2a81");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Iron Will", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("aa07868b-d6f2-410e-8823-e1a46a019558"), Type = TextBlockType.Text, Text = "Your training has hardened your resolve. Your proficiency rank for Will saves increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("68393b1f-2df9-40ce-a7ab-417f01094dab"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Will.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f64ef63-4938-48a1-aaf3-cde060c915dc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 168
            };
        }
    }
}
