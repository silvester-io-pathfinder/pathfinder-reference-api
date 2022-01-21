using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class WeaponMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("ddb5c4cf-a0ae-4b3e-825a-f374a210b2ec");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 13,
                Name = "Weapon Mastery", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5c955f81-4624-4734-b43e-ec89029c96d2"), Type = TextBlockType.Text, Text = "You fully understand your weapons. Your proficiency ranks for simple weapons, martial weapons, and unarmed attacks increase to master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("7da8e9b9-e528-4eec-a84b-046aa42c4686"), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("68a250af-a628-4630-bf75-5b59199b376d"), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("3bca62d0-9c4e-4e85-a4bf-0b5f56545639"), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Unarmed.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5d320325-dd5e-4dce-a0b9-fde5d93fe9a7"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 42
            };
        }
    }
}
