using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Fighters
{
    public class ArmorMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("419741a6-d386-4067-974e-47b811d8e218");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17, 
                Name = "Armor Mastery", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8ba59307-8ce1-4622-9b44-854a37ddf85a"), Type = TextBlockType.Text, Text = "Your skill with armor improves, increasing your ability to prevent blows. Your proficiency ranks for light, medium, and heavy armor, as well as for unarmored defense, increase to master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("cf819828-9503-4489-96a3-54e8f3468709"), Proficiencies.Instances.Master.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("df0fa633-f95a-4d0d-91a7-ee8c50d8347b"), Proficiencies.Instances.Master.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("af86b91f-9e76-41ec-b972-b7d1e4faba2b"), Proficiencies.Instances.Master.ID, ArmorCategories.Instances.HeavyArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("efc454f4-8a83-4410-8852-918f77604eec"), Proficiencies.Instances.Master.ID, ArmorCategories.Instances.Unarmored.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ecd0f97a-711a-426c-a303-5cb4602f804d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 144
            };
        }
    }
}
