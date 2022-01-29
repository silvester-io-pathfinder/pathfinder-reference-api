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
    public class WeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("98144992-5093-494d-891d-ea3f1a2cf97b");

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
            yield return new TextBlock { Id = Guid.Parse("5fd9db04-0d84-42ee-997f-901b8cb92067"), Type = TextBlockType.Text, Text = "you've dedicated yourself to learning the intricacies of your weapons. Your proficiency ranks for simple weapons, martial weapons, and unarmed attacks increase to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("1e2f0f7a-3569-47e6-9afc-e6c93cc6ed8f"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("e5d9b7f4-9612-4273-bd00-cd1727b3c131"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("0de56341-f580-4081-bff9-8892f635214f"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7970d2b8-26a2-4e24-8455-42413cac4aed"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 108
            };
        }
    }
}
