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
    public class WeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("62fc362a-a927-4cc2-b4e7-b054238b5716");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5, 
                Name = "Weapon Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9cef6cbe-e680-44ef-97b5-ffe04b875ce4"), Type = TextBlockType.Text, Text = "you've dedicated yourself to learning the intricacies of your weapons. Your proficiency ranks for simple weapons, martial weapons, and unarmed attacks increase to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("421f2fc1-0127-4c39-a442-458897b24675"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("120b26e4-23ab-48bf-a612-877a7eb319ee"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("d44a28b9-8635-4e29-a5fe-e44efbebb5a4"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6dd16ac7-b8eb-43cc-8fe6-ea8a951a54df"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 40
            };
        }
    }
}
