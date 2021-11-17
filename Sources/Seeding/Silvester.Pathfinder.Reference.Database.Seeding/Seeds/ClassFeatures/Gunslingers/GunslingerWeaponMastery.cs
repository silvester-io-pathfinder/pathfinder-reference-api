using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class GunslingerWeaponMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("593cc17d-b637-4ee2-835d-1b2bf95b7b63");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Gunslinger Weapon Mastery", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3efa7f5d-838e-4267-bacc-3ecdb7edc214"), Type = TextBlockType.Text, Text = "You fully understand the best way to utilize your unique weapons. Your proficiency rank increases to master with simple and martial firearms and crossbows. Your proficiency rank for advanced firearms and crossbows, simple weapons, martial weapons, and unarmed attacks increases to expert. You gain access to the critical specialization effects for firearms and crossbows." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse("9eb9db33-5400-492f-a8b9-d553b7d9e557"), Proficiencies.Instances.Master.ID, WeaponGroups.Instances.Firearm.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse("e795732c-ed56-41c8-8f5d-e6069daf7604"), Proficiencies.Instances.Master.ID, WeaponGroups.Instances.Firearm.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse("d4290821-da16-4519-8d03-4c8f4b379c58"), Proficiencies.Instances.Master.ID, WeaponGroups.Instances.Crossbow.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse("54e6beff-efd4-4be2-ab44-b6e7ef2ccce7"), Proficiencies.Instances.Master.ID, WeaponGroups.Instances.Crossbow.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse("d09c89d3-ba8e-4e13-a35d-ccccc6e5b479"), Proficiencies.Instances.Expert.ID, WeaponGroups.Instances.Crossbow.ID, WeaponCategories.Instances.Advanced.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse("056bad06-a9b1-4d0a-94d9-1b73f6036f77"), Proficiencies.Instances.Expert.ID, WeaponGroups.Instances.Firearm.ID, WeaponCategories.Instances.Advanced.ID);

            builder.GainAnyWeaponGroupProficiency(Guid.Parse("5d73b20c-84c2-4ce7-bab7-d7c912aa5df9"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainAnyWeaponGroupProficiency(Guid.Parse("b4c8ad5d-4dd9-4c81-a423-4f7f0713b0e4"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainAnyWeaponGroupProficiency(Guid.Parse("eb75d4d7-80f2-48f1-b287-6075070a0fb6"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);

            builder.GainSpecificWeaponGroupSpecialization(Guid.Parse("4324e44b-f654-40a2-96c9-9b41d0942ef1"), WeaponGroups.Instances.Crossbow.ID);
            builder.GainSpecificWeaponGroupSpecialization(Guid.Parse("062a8d8f-94d4-4476-9c24-2085389d0d5b"), WeaponGroups.Instances.Firearm.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("736b5fcb-22df-40c8-bfe0-1b0cc8fe6fdb"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 107
            };
        }
    }
}
