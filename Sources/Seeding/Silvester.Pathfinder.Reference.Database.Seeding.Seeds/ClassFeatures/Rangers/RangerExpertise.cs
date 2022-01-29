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
    public class RangerExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("a01e1a7c-2a30-4984-afa1-a8dddc786854");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 9,
                Name = "Ranger Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("01d514a7-1629-4fbb-ba98-1df23a57f1d1"), Type = TextBlockType.Text, Text = "you've practiced your techniques to make them harder to resist. Your proficiency rank for your ranger class DC increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificClassDcProficiency(Guid.Parse("9bc99231-8330-45de-a537-35a8c588628a"), Proficiencies.Instances.Expert.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c15e6d4-703d-4fff-a33f-c875d720f67b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 169
            };
        }
    }
}
