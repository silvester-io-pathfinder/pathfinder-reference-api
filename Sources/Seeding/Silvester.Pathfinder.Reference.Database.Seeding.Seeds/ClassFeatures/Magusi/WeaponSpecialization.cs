using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class WeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("e80e98f0-0f14-44b0-baeb-12796abb67b3");

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
            yield return new TextBlock { Id = Guid.Parse("9e325a09-9545-4b6a-bbb8-4c4bef74fbf9"), Type = TextBlockType.Text, Text = "You can inflict greater injuries with your favored weapons. You deal 2 additional damage with weapons and unarmed attacks in which you're an expert. This damage increases to 3 if you're a master, and 4 if you're legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("9a33a101-ad94-4b97-b601-b8e0b69832d6"), ModifierType.Add, modifier: 2)
               .AddPrerequisites(Guid.Parse("d7a0d219-c8de-4d8f-998b-8875dd7f45fa"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("476d3503-c29a-4c12-9dbe-0b76a7ff4fee"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
               });

            builder.ModifyWeaponDamage(Guid.Parse("cf0a2cff-76c7-4b94-8a54-2be8788cea04"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("62422c30-229f-46a6-9ce9-3760cdbaafbe"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("4a779056-de91-4a08-9d5d-03d0f1a236ad"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("644984ee-79fe-4648-ace3-6ce652fa544b"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("3be2a3d1-ec71-4698-9a74-87c41211a578"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("56705acf-303e-465c-b43d-48499e6f97c1"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("71d4313c-f629-4d23-b735-5078644cbb7b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 41
            };
        }
    }
}
