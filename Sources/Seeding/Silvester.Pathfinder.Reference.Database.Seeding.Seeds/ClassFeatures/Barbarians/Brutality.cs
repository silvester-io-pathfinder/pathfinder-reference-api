using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Barbarians
{
    public class Brutality : Template
    {
        public static readonly Guid ID = Guid.Parse("cd394de5-d5c2-425b-b959-fce33c6bbd34");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Brutality", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a993c1bd-6cfb-47e0-aced-656ccd1f528e"), Type = TextBlockType.Text, Text = "Your fury makes your weapons lethal. Your proficiency ranks for simple weapons, martial weapons, and unarmed attacks increase to expert. While raging, you gain access to the critical specialization effects for melee weapons and unarmed attacks." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("22fedfb7-b1cf-4efe-9dea-82ad4158c488"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("e73e527a-c28e-4448-bb6f-968face900bb"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("b8b3fa23-dd85-4842-b17e-7bf94afa621c"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);

            //TODO: Add raging effect..
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b4433b01-ce8e-4799-a871-39a628653e9f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 86
            };
        }
    }
}
