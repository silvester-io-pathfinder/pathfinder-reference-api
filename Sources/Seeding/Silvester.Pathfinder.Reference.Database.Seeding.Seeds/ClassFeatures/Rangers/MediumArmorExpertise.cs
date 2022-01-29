using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rangers
{
    public class MediumArmorExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("73c42f7a-66d5-46f9-91cd-8706f6a4fff5");

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
            yield return new TextBlock { Id = Guid.Parse("a622f98a-32e4-48a4-8040-57bab5814da3"), Type = TextBlockType.Text, Text = "you've learned to defend yourself better against attacks. Your proficiency ranks for light armor, medium armor, and unarmored defense increase to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("4dbfe79d-9e52-45ba-a3e6-541428ca0a14"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("8431c5e0-fec5-4d4d-8597-b54d8e798dd1"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("391cc2a9-7cee-4d00-80ba-430b935e30c6"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.Unarmored.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("277d6fa9-643c-4315-8050-d35798b5ba13"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 169
            };
        }
    }
}
