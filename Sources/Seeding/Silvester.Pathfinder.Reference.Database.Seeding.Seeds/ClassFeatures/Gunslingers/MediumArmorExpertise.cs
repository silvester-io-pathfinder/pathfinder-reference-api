using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class MediumArmorExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("8a3fc50f-3436-424a-910d-68aee02da80b");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 13,
                Name = "Medium Armor Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ed384a9a-8ccc-46d9-9ac5-fbe46a1e65a5"), Type = TextBlockType.Text, Text = "you've learned to defend yourself better against attacks. Your proficiency ranks for light armor, medium armor, and unarmored defense increase to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("89a41c56-c73b-4953-b6c7-1eed70e9da06"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("389846aa-ddf6-486f-8a82-a2e240a3bd8a"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("09314ff7-39bb-4ad2-b8f4-6998afd2086c"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.Unarmored.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a7a56a62-d2e3-4ba4-9670-97cf45b8edc4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 107
            };
        }
    }
}
