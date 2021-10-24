using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rangers
{
    public class MasterfulHunter : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17,
                Name = "Masterful Hunter", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have honed your abilities as a hunter to incredible levels. Your proficiency rank for your ranger class DC increases to master. When using a ranged weapon that you have master proficiency in, you can ignore the penalty if attacking your hunted prey within the weapon’s second and third range increments." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you have master proficiency in Perception, you gain a +4 circumstance bonus to Perception checks when you Seek your prey, and if you have master proficiency in Survival, you gain a +4 circumstance bonus to Survival checks when you Track your prey. You also gain an additional benefit depending on your hunter’s edge." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificClassDcProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID);

            builder.AddAnd(Guid.Parse(""), and =>
            {
                and.AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveAnyRangedWeapon(Guid.Parse(""));
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, Proficiencies.Instances.Master.ID);
                });
                and.DisableRangedWeaponRangePenalty(Guid.Parse(""), RangeTier.Second);
                and.DisableRangedWeaponRangePenalty(Guid.Parse(""), RangeTier.Third);
            });

            //TODO: Add second paragraph's effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 170
            };
        }
    }
}
