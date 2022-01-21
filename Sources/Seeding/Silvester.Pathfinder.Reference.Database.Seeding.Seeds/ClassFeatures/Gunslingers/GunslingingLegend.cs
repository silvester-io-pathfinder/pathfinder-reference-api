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
    public class GunslingingLegend : Template
    {
        public static readonly Guid ID = Guid.Parse("9b8a0b4d-3e06-48d6-9406-c708c1c48b61");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 13,
                Name = "Gunslinging Legend", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("32b56a5d-8927-4ffa-ab6a-5d9629e52a27"), Type = TextBlockType.Text, Text = "You've learned unique techniques for wielding firearms and crossbows that give you unmatched skill in their use. Your proficiency rank increases to legendary with simple and martial firearms and crossbows and to master with advanced firearms and crossbows. Your proficiency rank for simple weapons, martial weapons, and unarmed attacks increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse("70c9cb83-ea5d-4cac-ba4d-c23b82511f76"), Proficiencies.Instances.Legendary.ID, WeaponGroups.Instances.Firearm.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse("dd41eb2c-d2ce-44b3-9300-12cdedd49396"), Proficiencies.Instances.Legendary.ID, WeaponGroups.Instances.Firearm.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse("6a8d7684-6c24-442f-8375-d68500de767f"), Proficiencies.Instances.Legendary.ID, WeaponGroups.Instances.Crossbow.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse("b19ceea6-b29a-438b-b823-6b0525d24b55"), Proficiencies.Instances.Legendary.ID, WeaponGroups.Instances.Crossbow.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse("90fde5d8-bcf5-4b4e-9a8a-dd5a1aca3339"), Proficiencies.Instances.Master.ID, WeaponGroups.Instances.Crossbow.ID, WeaponCategories.Instances.Advanced.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse("5c94fae4-867c-4c22-9f1b-b67ccf7ffadd"), Proficiencies.Instances.Master.ID, WeaponGroups.Instances.Firearm.ID, WeaponCategories.Instances.Advanced.ID);

            builder.GainAnyWeaponGroupProficiency(Guid.Parse("b1c43228-9380-4a90-89d2-8513d1c125f9"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainAnyWeaponGroupProficiency(Guid.Parse("69338179-9a0a-47ee-9030-aef49cc1d065"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainAnyWeaponGroupProficiency(Guid.Parse("6ad4b362-97ed-4150-9e19-36c26a39adce"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);

            builder.GainSpecificWeaponGroupSpecialization(Guid.Parse("b89b48b4-615b-4ae5-8c4a-f13e4d8007d4"), WeaponGroups.Instances.Crossbow.ID);
            builder.GainSpecificWeaponGroupSpecialization(Guid.Parse("b39d1053-5e89-4079-9954-aef188c88c97"), WeaponGroups.Instances.Firearm.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56a12027-691b-4c9a-93f0-4120fde9c1ad"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 107
            };
        }
    }
}
