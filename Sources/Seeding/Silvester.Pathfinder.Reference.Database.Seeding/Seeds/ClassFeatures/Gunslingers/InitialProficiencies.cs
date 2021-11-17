using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class InitialProficiencies : Template
    {
        public static readonly Guid ID = Guid.Parse("a9891147-f1cd-489e-a0a7-fda841384f4f");

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
            yield return new TextBlock { Id = Guid.Parse("064c03ca-1f7c-4ba2-bcf1-13256b8564a5"), Type = TextBlockType.Text, Text = "At 1st level, you gain a number of proficiencies that represent your basic training. These proficiencies are noted at the start of this class." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Key Ability
            builder.GainSpecificKeyAbilityOption(Guid.Parse("c21990ff-6219-4060-8812-dd1ba3e3d25f"), Stats.Instances.Dexterity.ID);

            //Perception
            builder.GainSpecificSkillProficiency(Guid.Parse("b8e13a04-b6af-41cd-be93-f5eca5cbebae"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);

            //Saving Throws
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("c10f387b-da2f-4b12-8de1-e7ced49c3af4"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("70bfd866-c1a3-4d5a-bca4-8857c8ee07ca"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("08252083-3700-44c1-8cc1-68bff7dbb904"), Proficiencies.Instances.Trained.ID, SavingThrowStats.Instances.Will.ID);

            //Skills
            //TODO: Add 3 plus intelligence modifier effect.

            //Attacks
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse("659d818c-2710-49ed-9a2c-dd4090c20a05"), Proficiencies.Instances.Expert.ID, WeaponGroups.Instances.Firearm.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse("917b2a82-47fd-451c-9882-0b1f48313a86"), Proficiencies.Instances.Expert.ID, WeaponGroups.Instances.Crossbow.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse("d85092cc-917f-4eee-99a8-cc61ea77275b"), Proficiencies.Instances.Expert.ID, WeaponGroups.Instances.Firearm.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse("baefd0a2-9437-4f85-b30f-27edb5e17842"), Proficiencies.Instances.Expert.ID, WeaponGroups.Instances.Firearm.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse("4e6ac602-e8c0-4311-935d-cbf678c7c051"), Proficiencies.Instances.Trained.ID, WeaponGroups.Instances.Firearm.ID, WeaponCategories.Instances.Advanced.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse("1266c54c-e768-4d1f-9c78-7bef3511982c"), Proficiencies.Instances.Trained.ID, WeaponGroups.Instances.Firearm.ID, WeaponCategories.Instances.Advanced.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("12449548-5f72-4c14-a0e8-6fc54fe3544e"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("7351c9d5-ade9-470e-bcb6-16c4acb3c05d"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("0141e45e-ff69-46da-b2b0-e1edb8d9cfd5"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Unarmed.ID);

            //Defenses
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("7c66fd51-1e7e-47b8-9b32-15ae42020843"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("c61dbd4c-1ce8-4cf0-912c-d5e074e5396c"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("5fc64c76-b39a-4c44-a451-82956d290941"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Unarmored.ID);

            //Class DC
            builder.GainSpecificClassDcProficiency(Guid.Parse("39ada395-9bd0-4778-bea3-1b79ac68e13e"), Proficiencies.Instances.Trained.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85982ff6-12fd-430f-a8d7-5092cba68996"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 106
            };
        }
    }
}
