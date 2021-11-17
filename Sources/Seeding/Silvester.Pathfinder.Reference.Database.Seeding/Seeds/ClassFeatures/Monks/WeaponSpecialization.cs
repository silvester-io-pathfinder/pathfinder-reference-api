using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class WeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("afcf0aad-1396-455e-99b1-8ce312906447");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7,
                Name = "Weapon Specialization", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6c190adc-5a5c-4b5b-847a-10f6fd18451d"), Type = TextBlockType.Text, Text = "You can inflict greater injuries with your favored weapons. You deal 2 additional damage with weapons and unarmed attacks in which you're an expert. This damage increases to 3 if you're a master, and 4 if you're legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("450b6f50-936a-4498-b3d0-b455e26304cf"), ModifierType.Add, modifier: 2)
                .AddPrerequisites(Guid.Parse("637f16c1-12a7-4d88-b91b-c27ab71810f1"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("a205c76f-e6b6-4bea-b860-0d2fe50ef2ba"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("b2aeb518-8c8f-4241-a19c-060197fb1746"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("7170a270-88f2-4f62-bbb5-ebd73343c28f"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("21876ea6-ff6e-4976-9ff0-5b7c88ec85a1"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("bb94e2ac-73ba-4370-8f26-5629dae752b8"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("35840352-d30e-421d-bc71-cf736b234132"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("55160271-9c98-4025-9fad-7f37540c8e51"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3749f05f-5752-4c23-a0e2-90077901df1c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 41
            };
        }
    }
}
