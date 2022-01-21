using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class MediumArmorMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("8764c63c-ac7b-4187-a567-d5dfa7d54f87");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17,
                Name = "Medium Armor Mastery", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c775d30b-1b63-468d-ba81-6d643b97e1a6"), Type = TextBlockType.Text, Text = "Your skill with light and medium armor improves, increasing your ability to avoid blows. Your proficiency ranks for light and medium armor, as well as for unarmed defense, increase to master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("9443be72-829a-43a3-a360-084035c89569"), Proficiencies.Instances.Master.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("881fb679-6f69-4037-bd23-a10b417e7baa"), Proficiencies.Instances.Master.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("325014eb-f47b-4210-9dc5-b33151585634"), Proficiencies.Instances.Master.ID, ArmorCategories.Instances.Unarmored.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("15eed1ca-993c-46c7-a366-1a9a881dfab0"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 42
            };
        }
    }
}
