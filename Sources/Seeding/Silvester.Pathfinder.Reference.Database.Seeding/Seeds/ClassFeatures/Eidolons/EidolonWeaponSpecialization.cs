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
    public class EidolonWeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("ceba7acb-0d11-46ee-8846-f2a6f71a3244");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7,
                Name = "Eidolon Weapon Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c2d3d7ca-b18b-4663-92c4-d4443838fff8"), Type = TextBlockType.Text, Text = "Your eidolon has learned how to inflict greater injuries with its unarmed attacks. It deals 2 additional damage with unarmed attacks in which it's an expert. This damage increases to 3 if it's a master, and 4 if it's legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("7dff750e-2504-4144-81f5-ed80c7072508"), ModifierType.Add, modifier: 2)
                .AddPrerequisites(Guid.Parse("f79e239b-2304-43ea-aa3f-14aa742762e6"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("cb5e5568-72ef-4cb7-aeba-18f3df012110"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("112d339b-09fe-467a-ba95-e28067bfbeb6"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("51e5fa89-e479-4cd0-986f-db1a79892fa0"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("f572fd1c-55eb-41fb-9509-8a856f98c87a"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("4370b0ec-ef67-4bd9-a48f-206e32d4d7b2"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("f8ed001f-a492-48de-8e9c-7848f0bf24f2"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("fd30d48e-c36b-44cd-8b02-bd33859d2e74"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed879d78-e7b4-45ab-9a8b-14be7404cd25"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 56
            };
        }
    }
}
