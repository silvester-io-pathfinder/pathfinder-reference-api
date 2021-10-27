using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Swashbucklers
{
    public class WeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11, 
                Name = "Weapon Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You've dedicated yourself to learning the intricacies of your weapons. Your proficiency ranks for simple weapons, martial weapons, and unarmed attacks increase to expert. You gain access to the critical specialization effects of all weapons for which you have expert proficiency." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);

            builder
                .GainCurrentWeaponSpecialization(Guid.Parse(""))
                .AddPrerequisites(Guid.Parse(""), prerequisites => 
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, Proficiencies.Instances.Expert.ID);
                });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 86
            };
        }
    }
}
