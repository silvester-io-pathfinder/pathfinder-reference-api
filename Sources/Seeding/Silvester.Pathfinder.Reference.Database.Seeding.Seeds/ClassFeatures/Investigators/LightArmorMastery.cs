using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Investigators
{
    public class LightArmorMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("95a2d27e-61b9-4f33-bfe9-6ef9c9b75948");

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
            yield return new TextBlock { Id = Guid.Parse("177915a1-679e-48ff-856e-ffa42da6e8ce"), Type = TextBlockType.Text, Text = "Your skill with light armor improves, increasing your ability to dodge blows. Your proficiency ranks for light armor and unarmored defense increase to master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("37f5b80b-19b7-405f-9295-873ac988d57b"), Proficiencies.Instances.Master.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("3b6509e6-9f2f-433e-afaa-fcb5480b480a"), Proficiencies.Instances.Master.ID, ArmorCategories.Instances.Unarmored.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5d787fa6-c5fa-4847-bdd3-3aefa36ea9f5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 59
            };
        }
    }
}
