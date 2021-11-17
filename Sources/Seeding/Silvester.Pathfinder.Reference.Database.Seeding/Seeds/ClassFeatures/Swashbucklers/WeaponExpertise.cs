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
        public static readonly Guid ID = Guid.Parse("055f3a9c-1836-4d48-8de9-7eb9051dba84");

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
            yield return new TextBlock { Id = Guid.Parse("ee461e59-9837-4cca-b860-99c7ca7bdd66"), Type = TextBlockType.Text, Text = "You've dedicated yourself to learning the intricacies of your weapons. Your proficiency ranks for simple weapons, martial weapons, and unarmed attacks increase to expert. You gain access to the critical specialization effects of all weapons for which you have expert proficiency." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("b09930e8-710b-4072-af85-2e52d4093221"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("8d3edec3-44b7-46e8-ad31-e74c3541b974"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("73fae518-328c-47ed-8403-e5fe198c763e"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);

            builder
                .GainCurrentWeaponSpecialization(Guid.Parse("e0471131-02f4-43c5-ade4-b11387e65df3"))
                .AddPrerequisites(Guid.Parse("545782bd-9ac9-48b9-8e3d-ea47eb9e5f83"), prerequisites => 
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("3ec7d09a-3451-4fd0-a455-b006844c031c"), Comparator.GreaterThanOrEqualTo, Proficiencies.Instances.Expert.ID);
                });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4094f9c2-1043-4450-82e4-84c980efdc78"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 86
            };
        }
    }
}
