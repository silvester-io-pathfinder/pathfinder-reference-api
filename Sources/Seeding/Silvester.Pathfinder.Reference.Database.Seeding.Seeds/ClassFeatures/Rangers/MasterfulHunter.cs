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
        public static readonly Guid ID = Guid.Parse("2963c5c0-b16d-42d9-ab38-d80a4bc2fd6b");

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
            yield return new TextBlock { Id = Guid.Parse("f37819cd-a1e9-40d4-9267-b55953ddc143"), Type = TextBlockType.Text, Text = "You have honed your abilities as a hunter to incredible levels. Your proficiency rank for your ranger class DC increases to master. When using a ranged weapon that you have master proficiency in, you can ignore the penalty if attacking your hunted prey within the weapon�s second and third range increments." };
            yield return new TextBlock { Id = Guid.Parse("77805f5c-b442-4486-854b-8a2938142337"), Type = TextBlockType.Text, Text = "If you have master proficiency in Perception, you gain a +4 circumstance bonus to Perception checks when you Seek your prey, and if you have master proficiency in Survival, you gain a +4 circumstance bonus to Survival checks when you Track your prey. You also gain an additional benefit depending on your hunter�s edge." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificClassDcProficiency(Guid.Parse("7e5c44a1-4a46-425b-adc9-bc4ef4b31c18"), Proficiencies.Instances.Master.ID);

            builder.AddAnd(Guid.Parse("c6f5f697-dabb-4718-972a-117a13e699cf"), and =>
            {
                and.AddPrerequisites(Guid.Parse("78be75b3-843d-4754-8d4a-ee93c02fb27d"), prerequisites =>
                {
                    prerequisites.HaveAnyRangedWeapon(Guid.Parse("ec95c88d-a4a8-4d14-b9de-fb4015b8363b"));
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("8cb6b950-937a-410a-b9e8-924472450fc3"), Comparator.GreaterThanOrEqualTo, Proficiencies.Instances.Master.ID);
                });
                and.DisableRangedWeaponRangePenalty(Guid.Parse("1387a86d-6ebf-49a7-93a3-3bed32c39a59"), RangeTier.Second);
                and.DisableRangedWeaponRangePenalty(Guid.Parse("762a9542-a3b5-43a6-ae8d-8885c5ab2813"), RangeTier.Third);
            });

            //TODO: Add second paragraph's effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db40135e-ae97-4e8e-8c74-d0aadb2c8983"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 170
            };
        }
    }
}
