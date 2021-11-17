using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Fighters
{
    public class BattlefieldSurveyor : Template
    {
        public static readonly Guid ID = Guid.Parse("45c2f0ce-e78e-4d1b-bfec-696712ca2c91");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7,
                Name = "Battlefield Surveyor", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("bf630f9f-010a-4db3-97e8-6016d8e62780"), Type = TextBlockType.Text, Text = "Whether taking stock of an enemy army or simply standing guard, you excel at observing your foes. Your proficiency rank for Perception increases to master. In addition, you gain a +2 circumstance bonus to Perception checks for initiative, making you faster to react during combat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("caa64759-be08-415e-8a28-7f6c1fa23a1a"), Proficiencies.Instances.Master.ID, Skills.Instances.Perception.ID);
            builder.GainSpecificSkillCircumstanceBonus(Guid.Parse("7944d61b-8b18-4e13-b946-9322a38c416a"), Skills.Instances.Perception.ID, bonus: 2);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d0f8f28e-0709-40bb-853a-8d2c6fa26ec7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 143
            };
        }
    }
}
