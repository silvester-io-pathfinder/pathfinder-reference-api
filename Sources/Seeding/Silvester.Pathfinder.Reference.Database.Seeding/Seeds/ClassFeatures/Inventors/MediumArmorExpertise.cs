using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class MediumArmorExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("8e329284-b25a-4b56-9ec0-4dee093bd6dc");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11,
                Name = "Medium Armor Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1d997a98-e9bc-45c2-a458-53f78b97169b"), Type = TextBlockType.Text, Text = "You've learned to better defend yourself against attacks. Your proficiency ranks for light armor, medium armor, and unarmored defense increase to expert." };
            yield return new TextBlock { Id = Guid.Parse("088f4855-931c-4d4d-beb3-41f1db0030df"), Type = TextBlockType.Text, Text = "If you have a medium or heavy armor innovation, you gain access to the critical specialization effect with your armor innovation." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("b1cb51c5-7631-44a4-b7a6-5554a4c2a666"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("27169ca3-026c-41ec-8cfb-16690ed05bba"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("1791fe3f-5003-4d76-aafe-a04b202ea0d7"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.Unarmored.ID);

            builder.GainInnovationArmorSpecialization(Guid.Parse("809b66b7-1256-4e14-b930-cbde022cb596"))
                .AddPrerequisites(Guid.Parse("8dbfc6bc-a0f8-4cbd-8e30-7da73fafec19"), prerequisites => 
                {
                    prerequisites.HaveSpecificInnovation(Guid.Parse("4f9ab1e2-a25b-4c74-b846-27ad3920c32a"), Innovations.Instances.Armor.ID);
                });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b29564e8-efa1-43ef-a5fb-1f1ac9a53261"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 22
            };
        }
    }
}
