using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class InitialProficiencies : Template
    {
        public static readonly Guid ID = Guid.Parse("9cce21a5-996d-4d51-a925-bcca24ee5a41");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Initial Proficiencies", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d6b55f98-3f24-499f-9c44-d903001f6ce0"), Type = TextBlockType.Text, Text = "At 1st level, you gain a number of proficiencies that represent your basic training. These proficiencies are noted at the start of this class." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Key Ability
            builder.GainSpecificKeyAbilityOption(Guid.Parse("a2e83f21-e723-4576-86ff-0da623ef29ee"), Stats.Instances.Strength.ID);
            builder.GainSpecificKeyAbilityOption(Guid.Parse("3608534b-cac4-4802-ad2d-bc19f9bd8d4c"), Stats.Instances.Dexterity.ID);

            //Perception
            builder.GainSpecificSkillProficiency(Guid.Parse("4f9b2c39-7930-4cc7-9c2d-b191d357a030"), Proficiencies.Instances.Trained.ID, Skills.Instances.Perception.ID);

            //Saving Throws
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("9c79a567-2b6c-450b-9569-ebeae22e37f9"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("3e46a836-f114-4d77-839e-1a42ab2f553a"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("f1de88d9-2a30-4887-8d70-a54743cb9c5b"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Will.ID);

            //Skills
            builder.GainSpecificSkillProficiency(Guid.Parse("64148c8e-83f6-4509-98e1-8c00dae4ab8a"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            //TODO: Add 2 plus intelligence modifier effect.

            //Attacks
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("3fcdfe78-c51b-418a-8193-b98563214688"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("1ede183f-5f8c-4546-94f6-6ebb1eb0f0ce"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("08356cd5-8fbe-4c24-9c99-22bbe18ba359"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Unarmed.ID);

            //Defenses
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("2d9373fe-ec5d-4b53-a830-19dc0b8539aa"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("43203d31-e665-4f31-a07b-053e1a20c151"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("3c9f9ecc-57e5-4f9d-8afe-d387503619fa"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.HeavyArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("c53a91c7-379a-43ed-b561-46523a3c780b"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Unarmored.ID);

            //Class DC
            builder.GainSpecificClassDcProficiency(Guid.Parse("55f774cc-d418-4b9d-bd5c-f2feb2c528ae"), Proficiencies.Instances.Trained.ID);

            //Spells
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("85853927-9f94-4538-a437-6c846434733f"), Proficiencies.Instances.Trained.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("2f238b7f-9fc9-430b-a59e-8b1bff846a2b"), Proficiencies.Instances.Trained.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68ca8fad-5119-4a83-8050-2143933968ee"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 106
            };
        }
    }
}
