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
    public class ArmorExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("e9f3cf3b-427b-469a-8913-134dfc34efdb");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11, 
                Name = "Armor Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("690c3151-81b3-4b2c-85a1-3aeb75401582"), Type = TextBlockType.Text, Text = "You have spent so much time in armor that you know how to make the most of its protection. Your proficiency ranks for light, medium, and heavy armor, as well as for unarmored defense, increase to expert. You gain the armor specialization effects of medium and heavy armor." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("de2c1bd5-ef74-4863-a286-7a1362aa7533"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("e4d7797f-212e-4c4d-9935-ab941ef9db83"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("52f5f7c3-1eec-4d12-aa15-6dba742f2911"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.HeavyArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("8a19c4d8-0c3e-46ce-a99c-eb01182765ad"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.Unarmored.ID);

            builder.GainSpecificArmorCategorySpecialization(Guid.Parse("8e4c4b2a-abe4-41a2-ae5d-8d6a515e85bd"), ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategorySpecialization(Guid.Parse("b10831b6-8248-4d10-b86e-baba77c553f0"), ArmorCategories.Instances.HeavyArmor.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("04f425db-bcc5-49e2-9a55-5a8f2b2fe768"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 143
            };
        }
    }
}
