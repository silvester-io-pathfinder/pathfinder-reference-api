using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rogues
{
    public class InitialProficiencies : Template
    {
        public static readonly Guid ID = Guid.Parse("f466f824-ba43-4443-b289-0a312590b74f");

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
            yield return new TextBlock { Id = Guid.Parse("a527a824-9c71-4b78-b857-1f770a063f8a"), Type = TextBlockType.Text, Text = "At 1st level, you gain a number of proficiencies that represent your basic training. These proficiencies are noted at the start of this class." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Ability Boost
            builder.GainSpecificKeyAbilityOption(Guid.Parse("629759e5-93e8-4f29-8b81-c6c84ff729f1"), Stats.Instances.Dexterity.ID);

            //Perception
            builder.GainSpecificSkillProficiency(Guid.Parse("27d32d8a-62ad-40e6-a26d-b13afc0d7434"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);

            //Saving Throws
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("bc928d91-9803-4bd5-9078-13695b8be0e7"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("2f2dd36a-020c-4526-8346-31b14ed181d3"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("0aba8866-834d-437e-9547-4ff1ec4a4279"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Will.ID);

            //Skills
            builder.GainSpecificSkillProficiency(Guid.Parse("a36e11fc-b5d4-405c-95f8-aa80fcce1edd"), Proficiencies.Instances.Trained.ID, Skills.Instances.Stealth.ID);
            //TODO: Add 7 plus intelligence modifier effect.

            //Attacks
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("f5d2d992-4497-43af-a95f-77c9dcd91413"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("6eab7472-b63a-448d-b87f-27069af39867"), Proficiencies.Instances.Trained.ID, Items.MeleeWeapons.Instances.Rapier.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("4e0fdeab-d986-49d7-bb46-d8fa35e698a8"), Proficiencies.Instances.Trained.ID, Items.MeleeWeapons.Instances.Sap.ID);
            builder.GainSpecificRangedWeaponProficiency(Guid.Parse("9ba3d888-f23e-41e7-afd0-a3d331a7cdb5"), Proficiencies.Instances.Trained.ID, Items.RangedWeapons.Instances.Shortbow.ID);
            builder.GainSpecificMeleeWeaponProficiency(Guid.Parse("855702ad-51a1-4f1c-bfec-3eac9c947371"), Proficiencies.Instances.Trained.ID, Items.MeleeWeapons.Instances.Shortsword.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("93dc280b-f12d-4048-893a-81252fdba5c6"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Unarmed.ID);

            //Defenses
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("53fedfeb-0f78-433b-abe6-4d3060f4ed10"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("4e4f3651-c4d2-49d2-a6e3-0d93baa95578"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Unarmored.ID);

            //Class DC
            builder.GainSpecificClassDcProficiency(Guid.Parse("4fc7fd6a-10f3-4080-b484-0b4dc91b83aa"), Proficiencies.Instances.Trained.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb46a225-0994-4c72-851d-0534cc060610"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 180
            };
        }
    }
}
