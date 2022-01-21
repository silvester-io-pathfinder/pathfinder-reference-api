using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class WeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("277f62b5-2242-42b0-8603-5f80f9fa7e98");

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
            yield return new TextBlock { Id = Guid.Parse("08f5d290-b858-44c3-a0d7-297c599e78ee"), Type = TextBlockType.Text, Text = "You've learned how to inflict greater injuries with the weapons you know best. You deal 2 additional damage with weapons and unarmed attacks in which you are an expert. This damage increases to 3 if you're a master, and 4 if you're legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("fe274cc2-58dc-4c0a-afd6-e14b2adb26ab"), ModifierType.Add, modifier: 2)
               .AddPrerequisites(Guid.Parse("bf0c63d6-3b7a-4829-bb55-6c41403d5adb"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("2c203498-d422-4497-b7eb-c4a5e053cd57"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
               });

            builder.ModifyWeaponDamage(Guid.Parse("2833e8f7-515e-486a-b62b-5886faf1beec"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("13388860-d72b-4bb7-bbee-0323792ed467"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("a721c65f-c965-49c7-af82-ccb3970d3d88"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("d93a0479-b428-4707-a3c3-f5ba91a0e843"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("39d67497-fcb4-484f-8d5a-bd1c395962e7"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("20170878-44a7-4034-b439-ede606075c31"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f582dc2-7f82-4248-a56b-55cd02e3c937"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 107
            };
        }
    }
}
