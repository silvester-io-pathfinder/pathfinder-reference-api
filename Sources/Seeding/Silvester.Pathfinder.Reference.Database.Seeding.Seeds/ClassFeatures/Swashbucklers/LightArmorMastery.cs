using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Swashbucklers
{
    public class LightArmorMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("fbcc5f1b-4a59-4a82-a7ef-64d009beb798");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Light Armor Mastery", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1f7ce310-2946-420e-9be2-ea1b41b12697"), Type = TextBlockType.Text, Text = "Your skill with light armor improves, increasing your ability to dodge blows. Your proficiency ranks for light armor and unarmored defense increase to master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("9954b572-4ca4-4d60-8737-9e57e958b405"), Proficiencies.Instances.Master.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("58a91e04-eca8-4983-88ab-a74d4b7e1628"), Proficiencies.Instances.Master.ID, ArmorCategories.Instances.Unarmored.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fdd8855b-e9b1-47e3-9532-b59faa93710b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 87
            };
        }
    }
}
