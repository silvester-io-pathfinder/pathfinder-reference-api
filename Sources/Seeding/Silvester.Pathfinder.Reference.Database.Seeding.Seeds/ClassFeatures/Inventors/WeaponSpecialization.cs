using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class WeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("088b8480-6cba-4c22-a28a-7c96e94b91fe");

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
            yield return new TextBlock { Id = Guid.Parse("d0b6500c-0336-423e-8a86-9dcc5f2c2e31"), Type = TextBlockType.Text, Text = "you've learned how to inflict greater injuries with the weapons you know best. You deal 2 additional damage with weapons and unarmed attacks in which you are an expert. This damage increases to 3 damage if you're a master, and 4 damage if you're legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("1e0f3730-b769-437f-9b97-35f5e78b0103"), ModifierType.Add, modifier: 2)
               .AddPrerequisites(Guid.Parse("bc3189b8-119d-4552-949b-ceee5a1bcb24"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("79348fcd-240a-4a45-a60a-66ad255f6352"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
               });

            builder.ModifyWeaponDamage(Guid.Parse("4dc70a01-4538-49a5-84c7-eea50bf5236d"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("31316ed6-eb4d-45e3-a673-b1cd0cd093df"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("0f455643-fcf9-4dff-9381-5814cd64aee9"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("399dd176-68f0-4a4f-81c5-c8f50e675697"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("c63b0ec2-0b57-44c2-ace3-7e7c1f0413a7"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("96ab8002-253a-41b3-9d0e-8afab2b44d4c"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bec64c23-3ef3-400e-b4a8-52eab131f1fb"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 22
            };
        }
    }
}
