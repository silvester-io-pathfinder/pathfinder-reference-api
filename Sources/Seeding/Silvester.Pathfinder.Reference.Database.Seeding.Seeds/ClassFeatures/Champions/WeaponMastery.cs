using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class WeaponMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("8a25cd0c-4854-4152-96ff-172cc8f213f4");

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
            yield return new TextBlock { Id = Guid.Parse("59a0046a-de58-486f-bf48-3f4b28a89121"), Type = TextBlockType.Text, Text = "You fully understand your weapons. Your proficiency ranks for simple weapons, martial weapons, and unarmed attacks increase to master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("cfe331ba-a0d5-47bf-a39c-286407389f80"), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("82bca21b-8380-4e6b-bd5d-0c6e70bc5539"), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("2c270617-4631-4e2d-ba4d-95e540760f14"), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Unarmed.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2660d40-297a-426b-9855-784b02d7a42e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 109
            };
        }
    }
}
