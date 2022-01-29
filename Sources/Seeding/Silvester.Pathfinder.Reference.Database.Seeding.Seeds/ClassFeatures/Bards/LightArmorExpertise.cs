using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class LightArmorExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("b6b917b6-2aa6-41a2-b9f1-29571c8e18fb");

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
            yield return new TextBlock { Id = Guid.Parse("98fd14a5-2cd4-4c26-a334-e503dfb3d429"), Type = TextBlockType.Text, Text = "you've learned how to dodge while wearing light or no armor. Your proficiency ranks for light armor and unarmored defense increase to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("a157282e-858e-42fa-84a7-04f8ebee69f2"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("6f87bfbd-a399-4d8b-98a0-ef12df93cf81"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.Unarmored.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9f022e91-5027-4ef7-8c9f-ce95bef6e0c7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 99
            };
        }
    }
}
