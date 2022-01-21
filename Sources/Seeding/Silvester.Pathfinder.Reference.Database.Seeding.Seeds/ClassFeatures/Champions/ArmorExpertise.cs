using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class ArmorExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("a4b2e12e-dae4-4d24-9e4e-b162910109a4");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7, 
                Name = "Armor Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8f06c9d6-a845-4686-b426-92044b25fdd5"), Type = TextBlockType.Text, Text = "You have spent so much time in armor that you know how to make the most of its protection. Your proficiency ranks for light, medium, and heavy armor, as well as for unarmored defense, increase to expert. You gain the armor specialization effects of medium and heavy armor." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("eba1bdab-2a94-4a5e-9381-40da656e2843"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("8d99c267-1fd6-4177-b7a1-e564118283b9"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("79dd59f1-9be4-46db-9c79-01000eea1aa1"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.HeavyArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("1bc2922f-bb05-4a47-9c4a-fb9a033c5bec"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.Unarmored.ID);
            builder.GainSpecificArmorCategorySpecialization(Guid.Parse("36c5fe8c-3c1b-4746-8a8a-59f2ea5660e6"), ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategorySpecialization(Guid.Parse("c228ca5f-2903-43cd-9097-efb7a327d80d"), ArmorCategories.Instances.HeavyArmor.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f40fb60-e4c2-4524-a94e-7dab68ae4bca"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 108
            };
        }
    }
}
