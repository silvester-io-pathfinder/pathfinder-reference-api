using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class InventorWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("13ae14cd-1016-4d12-8b72-6e5c89e4834f");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5, 
                Name = "Inventor Weapon Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b79476c8-c87f-4f78-9d27-a6cebc99af1c"), Type = TextBlockType.Text, Text = "You develop tricks for using your weapons more effectively. Your proficiency ranks for simple and martial weapons and unarmed attacks increase to expert. If you have a weapon innovation, you gain access to the critical specialization effect with your innovation." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("1a5950cf-7797-4005-871c-2eab870cd261"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("525ba887-c941-4961-a5b9-8801a8147dc7"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("3a72fb89-0622-4480-b409-9648f0240f2a"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);

            builder.GainInnovationWeaponSpecialization(Guid.Parse("ddd9514c-1b15-4025-9bd2-28101047fbc5"))
                .AddPrerequisites(Guid.Parse("bf44523c-5732-4dc0-9016-fa004fea4ee9"), prerequisites => 
                {
                    prerequisites.HaveSpecificInnovation(Guid.Parse("9aa3c261-2033-423b-a8ad-38635edf156f"), Innovations.Instances.Weapon.ID);
                });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("533b98aa-15a1-44ac-8924-479a7b4b3e51"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 20
            };
        }
    }
}
