using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class LightArmorMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("ad282a8a-af5c-4e23-81ca-18d6c2e0e08b");

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
            yield return new TextBlock { Id = Guid.Parse("30556f3a-fa06-4b4c-9b02-594bb4be0c35"), Type = TextBlockType.Text, Text = "Your skill with light armor improves, increasing your ability to dodge blows. Your proficiency ranks for light armor and unarmored defense increase to master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("fa77c562-e8d0-43ff-af32-4099207a6561"), Proficiencies.Instances.Master.ID, ArmorCategories.Instances.LightArmor.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d8bbc34a-f288-446b-80ab-b64276fa8add"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 76 
            };
        }
    }
}
