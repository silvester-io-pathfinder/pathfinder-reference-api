using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rogues
{
    public class GreaterWeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("35e726ad-0643-4e50-a07a-2096f1805b05");

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
            yield return new TextBlock { Id = Guid.Parse("7fac7281-37c0-4504-ad2b-c849fcda503d"), Type = TextBlockType.Text, Text = "Your damage from weapon specialization increases to 4 with weapons and unarmed attacks in which you're an expert, 6 if you're a master, and 8 if you're legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("32399f7c-31cc-4ecb-83ec-2ad69d5005f4"), ModifierType.Add, modifier: 2)
                .AddPrerequisites(Guid.Parse("ad1cc5f6-a4c9-4ef3-bc21-e4fbe0fc4de4"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("dfaab246-6080-4456-b8ae-817f07fd150a"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("e3904ef9-c915-46d6-a04d-f5fcdd7c4ecb"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("5466d7d6-eb2d-48e5-8aea-b943e5a4cef7"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("c38b243f-d295-48a3-835c-9e7912eebcb2"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("9194a691-2b03-4356-a8e6-e5e71640ee86"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("d837d407-cf1a-423e-8319-4dbeebd8bd3d"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("99f375d3-dcd2-40a1-86e0-fa0a17db0b4c"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d907c12c-c66f-4b7a-bd59-8c5a017ddf04"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 182
            };
        }
    }
}
