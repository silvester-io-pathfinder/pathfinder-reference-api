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
    public class RangerWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("5dd0b05f-f90f-4811-a073-cdda4c861f50");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5, 
                Name = "Ranger Weapon Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6b055076-4a3d-4634-b340-2c3b7f94a91c"), Type = TextBlockType.Text, Text = "you've dedicated yourself to learning the intricacies of your weapons. Your proficiency ranks for simple and martial weapons and unarmed attacks increases to expert. You gain access to the critical specialization effects of all simple and martial weapons and unarmed attacks when attacking your hunted prey." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("7fd64481-e4e1-4e63-b512-442b8aa4267e"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("a16be055-8e23-47a1-8f0b-ac78a59b864a"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("3edf576d-233f-48bf-9c47-340ce76c2c26"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);

            //TODO: Add the Hunter Prey condition.
            builder.GainSpecificWeaponCategorySpecialization(Guid.Parse("fe86fd0d-d12e-4015-a446-0c2ff694ff51"), WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategorySpecialization(Guid.Parse("a4c48781-7e60-40dc-80b9-d9657b87f73d"), WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponCategorySpecialization(Guid.Parse("6499d253-96cf-42a5-a668-85437c6f3efb"), WeaponCategories.Instances.Unarmed.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b88635ca-d264-45d9-a554-3a26b6ba91ce"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 169
            };
        }
    }
}
