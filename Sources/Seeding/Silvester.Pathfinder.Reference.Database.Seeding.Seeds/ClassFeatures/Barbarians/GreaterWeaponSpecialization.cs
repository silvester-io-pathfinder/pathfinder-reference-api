using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Barbarians
{
    public class GreaterWeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("abbc5d66-457f-4116-ba27-caf559073870");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Greater Weapon Specialization", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("cba2cc9c-e76d-46f9-a741-a2f7705a6c29"), Type = TextBlockType.Text, Text = "The weapons you've mastered become truly fearsome in your hands. Your damage from weapon specialization increases to 4 with weapons and unarmed attacks in which you're an expert, 6 if you're a master, and 8 if you're legendary. You gain a greater benefit from your instinct's specialization ability." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("29b3b812-9b9a-4bd3-a1aa-dc902b69d932"), ModifierType.Add, modifier: 2)
                .AddPrerequisites(Guid.Parse("ead0484b-056f-447c-84a2-8ba85d1d40c7"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("2e5e675c-938a-4236-bdbb-e28f36ce16dd"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("ba98ed8a-e2d3-4ad6-8895-42a77523148f"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("cfabce1f-70c4-49fe-898e-85f64234a3ae"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("3dc7fd3c-6f22-437e-9c2e-6683b8a6b079"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("6eed7174-c011-4656-913c-51f636ca86f1"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("ee3cf087-f299-404b-9e48-35d33d54c5c4"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("f30efa9b-0445-42ad-8799-613335ea16f6"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });

            //TODO: Add greater instinct effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4b11d2e4-3e34-4519-9bf0-094d85f01221"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 86
            };
        }
    }
}
