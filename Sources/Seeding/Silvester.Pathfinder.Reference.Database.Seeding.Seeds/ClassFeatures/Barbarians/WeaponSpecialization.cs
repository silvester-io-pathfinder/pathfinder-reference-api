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
    public class WeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("023d3e09-c8b6-4273-95c2-aa996c296242");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7,
                Name = "Weapon Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a082d654-d0b7-4a46-8010-aa1481805d6b"), Type = TextBlockType.Text, Text = "Your rage helps you hit harder. You deal an additional 2 damage with weapons and unarmed attacks in which you have expert proficiency. This damage increases to 3 if you're a master, and 4 if you're legendary. You gain your instinct's specialization ability." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("015b3845-b680-445a-9421-0865e02e2347"), ModifierType.Add, modifier: 2)
                .AddPrerequisites(Guid.Parse("26cd1dd0-0d27-4a9b-ba20-b0d87c093d0a"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("23cf098c-e8c4-4988-b4cd-28a1940e7a8d"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("f1870b79-712a-4df5-937d-56ed2615c1b3"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("a30ba2b7-5b79-48e1-9266-e6abae032a61"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("16da22ab-1415-489e-9a44-93526862a492"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("1f0717a5-33d2-4325-be65-c7df72cf0c4a"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("2bdcedfd-c784-4d4e-a62b-819a39feaa76"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("6298e0ae-c3ab-4b0f-9272-737f2dcf2c96"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });

            //TODO: Add instinct ability effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c7e3ad6-213d-4ccb-a5e9-2d44d1730a12"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 85
            };
        }
    }
}
