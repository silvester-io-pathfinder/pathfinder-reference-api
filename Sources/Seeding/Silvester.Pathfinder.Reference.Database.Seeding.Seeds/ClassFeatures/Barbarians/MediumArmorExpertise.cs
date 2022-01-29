using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Barbarians
{
    public class MediumArmorExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("1298ccc7-aee1-41bb-9da3-b09c90fe0f10");

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
            yield return new TextBlock { Id = Guid.Parse("147b0a99-bb40-4672-8ee3-26a1611fa717"), Type = TextBlockType.Text, Text = "you've learned to defend yourself better against attacks. Your proficiency ranks for light armor, medium armor, and unarmored defense increase to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("5cc36594-e16f-45d0-826c-35daaa95fda9"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("fd2ac98c-6397-48d5-a5ca-e7e4b8e433be"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("a387ed82-efed-4c57-b652-12eaa6d422de"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.Unarmored.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a146fae9-23d8-4bd3-8f74-81e8b9488a16"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 85
            };
        }
    }
}
