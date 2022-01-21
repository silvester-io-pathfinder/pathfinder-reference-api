using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class InitialProficiencies : Template
    {
        public static readonly Guid ID = Guid.Parse("cac385c9-2f9c-48b9-9816-d40fc6009128");

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
            yield return new TextBlock { Id = Guid.Parse("63a15da0-4de0-4b7b-82ae-f4f69f2acaa4"), Type = TextBlockType.Text, Text = "At 1st level, you gain a number of proficiencies that represent your basic training. These proficiencies are noted at the start of this class." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Key Ability
            builder.GainSpecificKeyAbilityOption(Guid.Parse("0790f4dd-50e7-4880-b114-6cb5eba3929e"), Stats.Instances.Intelligence.ID);

            //Perception
            builder.GainSpecificSkillProficiency(Guid.Parse("76927142-df16-4b1e-a78c-bb3705a5f6b1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Perception.ID);

            //Saving Throws
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("f9d8cdbe-8beb-4f18-af7a-7bc123244ce3"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("5b5e0a74-607f-450f-bf4a-8cedf0dd9e39"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("978c9725-91dd-4c3b-9c14-f6e19fa9a7f5"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Will.ID);

            //Skills
            builder.GainSpecificSkillProficiency(Guid.Parse("4117beac-84cf-42ab-9441-72c6649c9abc"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
            //TODO: Add 3 plus intelligence modifier effect.

            //Attacks
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("d19cbe24-a32f-46dc-8acd-016c8fc7f6a6"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("c97c50cc-fbf4-47fd-9b68-4a8fd64ca2e4"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("c71877b5-841b-4968-bde5-db87e8fad7ff"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Unarmed.ID);

            //Defenses
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("7a3f4892-655c-4093-b24a-716b56eee756"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("23edb9b0-c4f0-4843-8972-03d180a1e4f3"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("98e248ba-b590-4d80-b495-19b4194be42d"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Unarmored.ID);

            //Class DC
            builder.GainSpecificClassDcProficiency(Guid.Parse("66af755c-b082-4b69-b5a9-05a5224bb7cf"), Proficiencies.Instances.Trained.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("42805cb7-9ab2-45a0-840d-de052aea271b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 16
            };
        }
    }
}
