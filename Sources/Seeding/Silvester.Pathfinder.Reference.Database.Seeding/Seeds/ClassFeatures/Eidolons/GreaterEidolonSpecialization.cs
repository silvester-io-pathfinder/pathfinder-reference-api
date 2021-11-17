using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Eidolons
{
    public class GreaterEidolonSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("fa770da6-459c-4579-87fc-cfd7b605b3dc");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Greater Eidolon Specialization", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("23c9633a-8fa5-4e87-84a8-2a2fe9fef7ce"), Type = TextBlockType.Text, Text = "Your eidolon's damage from weapon specialization increases to 4 with unarmed attacks in which it's an expert, 6 if it's a master, and 8 if it's legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("66f70f0e-bac7-41f8-8dae-d71c7ba117f7"), ModifierType.Add, modifier: 2)
               .AddPrerequisites(Guid.Parse("4f6e4a2c-a4ec-4b24-9945-dd37cd452125"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("c5ef8100-41ad-470a-9a47-9f9e4c9696b5"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
               });

            builder.ModifyWeaponDamage(Guid.Parse("184f63b9-f1d2-4935-b60a-eb22eabf3185"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("8fbb98f8-3ceb-4836-a2af-8da656fe6c01"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("367d5881-f807-43e1-a3ad-e63bc9a64ced"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("d91b5691-248b-42de-89bb-cf2a625dd9de"), ModifierType.Add, modifier: 4)
                .AddPrerequisites(Guid.Parse("103fbf78-7dd8-4b4a-9a6c-e685e5ae3fac"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("3eba0816-09a6-4c6f-b185-5256259931ef"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
                });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("942f55c6-cc53-4ba9-9260-7b08192b277b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 57
            };
        }
    }
}
