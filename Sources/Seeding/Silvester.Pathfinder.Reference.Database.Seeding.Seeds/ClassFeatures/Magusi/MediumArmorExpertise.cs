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
    public class MediumArmorExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("158914d2-b981-49cf-9542-7f28332dc75d");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11,
                Name = "Medium Armor Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b8bc80a8-9806-418a-a797-223c4958b8f5"), Type = TextBlockType.Text, Text = "you've learned to defend yourself better against attacks. Your proficiency ranks for light armor, medium armor, and unarmored defense increase to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("079bf275-f470-4d1a-958c-58c1d1aeb613"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("0d67cbe2-8303-4abe-89b5-1eacaf0ab163"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("3828a463-a424-476d-a434-4fedd41b635b"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.Unarmored.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("127ffd25-e372-4dfa-8b0c-4010d601b84e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 42
            };
        }
    }
}
