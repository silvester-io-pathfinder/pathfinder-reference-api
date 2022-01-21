using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class LightArmorExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("e61c9abe-7d5d-4e7b-9953-8fa97ce0dc16");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 13,
                Name = "Light Armor Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2cf1df77-0aec-4e20-b793-76c2e85a92e5"), Type = TextBlockType.Text, Text = "You've learned how to dodge while wearing light or no armor. Your proficiency rank for light armor and unarmored defense increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("61fcbe4f-cfef-4c9e-8861-04a2556a7586"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("d03e6310-782a-42b4-a595-1f8fa2ef6954"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.Unarmored.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e0a77198-c36c-4814-8bef-70d37554edd5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 72
            };
        }
    }
}
