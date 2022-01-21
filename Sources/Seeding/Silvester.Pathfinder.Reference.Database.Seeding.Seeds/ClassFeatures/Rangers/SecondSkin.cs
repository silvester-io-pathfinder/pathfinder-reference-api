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
    public class SecondSkin : Template
    {
        public static readonly Guid ID = Guid.Parse("0d422135-059d-40c4-9977-c02b63cd72df");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Second Skin", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8b466cae-9190-41b8-b171-dc70e1269ca5"), Type = TextBlockType.Text, Text = "Your armor has become akin to a second skin for you. Your proficiency ranks for light armor, medium armor, and unarmored defense increase to master. When wearing light or medium armor, you can rest normally, rather than receiving poor rest that leaves you fatigued." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("d1b9547c-0a1c-4c0d-b9c2-3863ac430d93"), Proficiencies.Instances.Master.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("2a7c549c-4041-4c56-88f6-eea06917c0c9"), Proficiencies.Instances.Master.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("51d4e4ac-c023-41d1-a8f3-4a5807246b59"), Proficiencies.Instances.Master.ID, ArmorCategories.Instances.Unarmored.ID);
            
            //TODO: Add the "remove fatigued when resting in armor" effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7582eaa0-15da-4ac2-8157-62566f522917"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 170
            };
        }
    }
}
